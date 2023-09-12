using HtmlAgilityPack;
using MCare.ShareTKQC.Dtos;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xNet;

namespace MCare.ShareTKQC.Helpers
{
    public class RequestHelpers
    {
        public ApiClient _apiClient;

        private FacebookDto fbDto;

        public RequestHelpers(FacebookDto fbDto)
        {
            this.fbDto = fbDto;
        }

        public async Task<string> LoginFacebook()
        {
            _apiClient = new ApiClient(null, null, 0);

            var sourceTemp = await _apiClient.GetStringAsync("https://mbasic.facebook.com/");
            var cookieTemp = _apiClient.GetCookie();
            var sourceMain = await _apiClient.GetStringAsync("https://www.facebook.com/");

            var document = new HtmlDocument();
            document.LoadHtml(sourceMain);

            var urlDocument = document.DocumentNode.SelectSingleNode("//form[@data-testid='royal_login_form']");
            if (urlDocument == null) return "Failed";

            var urlAction = urlDocument.Attributes["action"].Value;

            var lsd = Regex.Match(sourceMain, "(?<=lsd\" value=\").*?(?=\")").ToString();
            var jazoest = Regex.Match(sourceMain, "(?<=jazoest\" value=\").*?(?=\")").ToString();

            var payload = new Dictionary<string, string>
                {
                    { "jazoest", jazoest },
                    { "lsd", lsd },
                    { "email", fbDto.Uid },
                    { "login_source", "comet_headerless_login" },
                    { "next", "" },
                    { "encpass", fbDto.Password }
                };

            var content = new FormUrlEncodedContent(payload);

            var login = await _apiClient.PostDataAsync($"https://www.facebook.com{urlAction}", content);

            var otp = Common.Common.GetCode(fbDto.Key2Fa);

            string fb_dtsg = Regex.Match(login, "(?<=fb_dtsg\" value=\").*?(?=\")").ToString().Replace("=", "=");
            string nh = Regex.Match(login, "(?<=nh\" value=\").*?(?=\")").ToString();
            jazoest = Regex.Match(login, "(?<=jazoest\" value=\").*?(?=\")").ToString();
            string payloadSubmitCode = $"fb_dtsg={fb_dtsg}&jazoest={jazoest}&checkpoint_data=&no_fido=true&approvals_code={otp}&submit[Continue]=Continue&nh={nh}";
            string submitCode = await _apiClient.PostDataAsync("https://m.facebook.com/checkpoint/", payloadSubmitCode, "application/x-www-form-urlencoded");

            fb_dtsg = Regex.Match(submitCode, "(?<=fb_dtsg\" value=\").*?(?=\")").ToString().Replace("=", "=");
            nh = Regex.Match(submitCode, "(?<=nh\" value=\").*?(?=\")").ToString();
            jazoest = Regex.Match(submitCode, "(?<=jazoest\" value=\").*?(?=\")").ToString();
            string payloadSaveDevice = $"fb_dtsg={fb_dtsg}&jazoest={jazoest}&checkpoint_data=&name_action_selected=save_device&submit[Continue]=Continue&nh={nh}&fb_dtsg={fb_dtsg}&jazoest={jazoest}";
            string saveDevice = await _apiClient.PostDataAsync("https://mbasic.facebook.com/login/checkpoint/?ref=dbl", payloadSaveDevice, "application/x-www-form-urlencoded");


            fb_dtsg = Regex.Match(saveDevice, "(?<=fb_dtsg\" value=\").*?(?=\")").Groups[0].Value.ToString();
            jazoest = Regex.Match(saveDevice, "(?<=jazoest\" value=\").*?(?=\")").ToString();
            nh = Regex.Match(saveDevice, "(?<=nh\" value=\").*?(?=\")").ToString();
            string payloadSaveLoca = $"fb_dtsg={fb_dtsg}&jazoest={jazoest}&checkpoint_data=&submit[Continue]=Tiếp+tục&nh={nh}&fb_dtsg={fb_dtsg}&jazoest={jazoest}";
            string saveLoca = await _apiClient.PostDataAsync("https://mbasic.facebook.com/login/checkpoint/", payloadSaveLoca, "application/x-www-form-urlencoded");
            fb_dtsg = Regex.Match(saveLoca, "(?<=fb_dtsg\" value=\").*?(?=\")").Groups[0].Value.ToString();
            jazoest = Regex.Match(saveLoca, "(?<=jazoest\" value=\").*?(?=\")").ToString();
            nh = Regex.Match(saveLoca, "(?<=nh\" value=\").*?(?=\")").ToString();
            string dataThiswasme = $"fb_dtsg={fb_dtsg}&jazoest={jazoest}&checkpoint_data=&submit[This+was+me]=Đây+là+tôi&nh={nh}&fb_dtsg={fb_dtsg}&jazoest={jazoest}";
            string postThiswasme = await _apiClient.PostDataAsync("https://mbasic.facebook.com/login/checkpoint/", dataThiswasme, "application/x-www-form-urlencoded");
            fb_dtsg = Regex.Match(saveLoca, "(?<=fb_dtsg\" value=\").*?(?=\")").Groups[0].Value.ToString();
            jazoest = Regex.Match(saveLoca, "(?<=jazoest\" value=\").*?(?=\")").ToString();
            nh = Regex.Match(saveLoca, "(?<=nh\" value=\").*?(?=\")").ToString();
            string payloadLoginLoca = $"fb_dtsg={fb_dtsg}&jazoest={jazoest}&checkpoint_data=&name_action_selected=dont_save&submit[Continue]=Tiếp+tục&nh={nh}&fb_dtsg={fb_dtsg}&jazoest={jazoest}";
            string loginLoca = await _apiClient.PostDataAsync("https://mbasic.facebook.com/login/checkpoint/", payloadLoginLoca, "application/x-www-form-urlencoded");

            return _apiClient.GetCookie();
        }

        public async Task<string> GetTokenEAAb()
        {
            var sourceTest = await _apiClient.GetStringAsync("https://www.facebook.com/dialog/oauth?client_id=124024574287414&redirect_uri=fbconnect://success&scope=email,publish_actions,publish_pages,user_about_me,user_actions.books,user_actions.music,user_actions.news,user_actions.video,user_activities,user_birthday,user_education_history,user_events,user_games_activity,user_groups,user_hometown,user_interests,user_likes,user_location,user_notes,user_photos,user_questions,user_relationship_details,user_relationships,user_religion_politics,user_status,user_subscriptions,user_videos,user_website,user_work_history,friends_about_me,friends_actions.books,friends_actions.music,friends_actions.news,friends_actions.video,friends_activities,friends_birthday,friends_education_history,friends_events,friends_games_activity,friends_groups,friends_hometown,friends_interests,friends_likes,friends_location,friends_notes,friends_photos,friends_questions,friends_relationship_details,friends_relationships,friends_religion_politics,friends_status,friends_subscriptions,friends_videos,friends_website,friends_work_history,ads_management,create_event,create_note,export_stream,friends_online_presence,manage_friendlists,manage_notifications,manage_pages,photo_upload,publish_stream,read_friendlists,read_insights,read_mailbox,read_page_mailboxes,read_requests,read_stream,rsvp_event,share_item,sms,status_update,user_online_presence,video_upload,xmpp_login&response_type=token");
            sourceTest = sourceTest.Replace("\\", "");
            string encrypt = Regex.Match(sourceTest, "encrypted_post_body\" value=\"(.*?)\"").Groups[1].Value.ToString();
            string scope = Regex.Match(sourceTest, "scope\" value=\"(.*?)\"").Groups[1].Value.ToString();
            string fb_dtsg = await GetFb_dtsg(fbDto.Cookie);
            string jazoest = fb_dtsg.Split('|')[1];
            fb_dtsg = fb_dtsg.Split('|')[0];
            string data = $"jazoest={jazoest}&fb_dtsg={fb_dtsg}&from_post=1&__CONFIRM__=1&scope=" +
                $"{scope}&display=page&sdk=&sdk_version=&domain=&sso_device=&state=&user_code=&nonce=&logger_id=7feb7096-aea0-417b-9892-8a7bc42731ef&auth_type=&auth_nonce=&code_challenge=&code_challenge_method=&encrypted_post_body=" +
                $"{encrypt}&return_format%5B%5D=access_token";
            var sourceToken = await _apiClient.PostDataAsync("https://www.facebook.com/v1.0/dialog/oauth/skip/submit/", data, "application/x-www-form-urlencoded");
            return Regex.Match(sourceToken, "EAAB(.*?)&").Value.ToString();
        }

        public async Task<string> GetFb_dtsg(string cookie, string user_agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36")
        {
            ApiClient apiClient = new ApiClient(cookie, "", 0, user_agent);
            string getdata = await apiClient.GetStringAsync("https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed");
            string fb_dtsg = Regex.Match(getdata, "(?<=fb_dtsg).*?(?=autocomplete)").ToString().Replace("value=", "").Replace(" ", "").Replace("\"", "").Replace(@"\", "");
            string jazoest = Regex.Match(getdata, "(?<=jazoest).*?(?=autocomplete=)").ToString().Replace(@"\", "").Replace("\"", "").Replace(" ", "").Replace("value=", "");
            return $"{fb_dtsg}|{jazoest}";
        }
    }
}
