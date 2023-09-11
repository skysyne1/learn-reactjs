using MCare.ShareTKQC.Contants;
using System;
using System.Linq;
using System.Threading.Tasks;
using xNet;

namespace MCare.ShareTKQC.Helpers
{
    public interface IApiClient
    {
        Task<string> GetStringAsync(string url);

        Task<string> PostDataAsync(string url, string payload, string contentType);

        Task<string> PostDataAsync(string url, HttpContent content);
    }

    public class ApiClient
    {
        private HttpRequest _httpRequest { get; set; }

        public ApiClient(string cookie, string proxy, int typeProxy, string user_agent = RequestFields.UserAgent)
        {
            if (!string.IsNullOrEmpty(cookie) && !string.IsNullOrEmpty(proxy))
                InitData(cookie, proxy, typeProxy, user_agent);
        }

        public async Task<string> GetStringAsync(string url)
        {
            return await Task<string>.Run(() =>
            {
                return _httpRequest.Get(url).ToString();
            });
        }

        public async Task<string> PostDataAsync(string url, string payload, string contentType)
        {
            return await Task<string>.Run(() =>
            {
                return _httpRequest.Post(url, payload, contentType).ToString();
            });
        }

        public async Task<string> PostDataAsync(string url, HttpContent content)
        {
            return await Task<string>.Run(() =>
            {
                return _httpRequest.Post(url, content).ToString();
            });
        }

        private void InitData(string cookie, string proxy, int typeProxy, string user_agent)
        {
            _httpRequest = new HttpRequest
            {
                KeepAlive = true,
                AllowAutoRedirect = true,
                Cookies = new CookieDictionary(false),
                UserAgent = user_agent,
            };

            SetHeader();

            if (!string.IsNullOrEmpty(cookie) )
                AddCookie(cookie);

            if (!string.IsNullOrEmpty(proxy))
                AddProxy(proxy, typeProxy);
        }

        private void AddProxy(string proxy, int typeProxy)
        {
            switch (proxy.Split(':').Count())
            {
                case 1:
                    if (typeProxy == 0)
                    {
                        _httpRequest.Proxy = HttpProxyClient.Parse($"127.0.0.1:{proxy}");
                    }
                    else
                    {
                        _httpRequest.Proxy = Socks5ProxyClient.Parse($"127.0.0.1:{proxy}");
                    }
                    break;
                case 2:
                    if (typeProxy == 0)
                    {
                        _httpRequest.Proxy = HttpProxyClient.Parse(proxy);
                    }
                    else
                    {
                        _httpRequest.Proxy = Socks5ProxyClient.Parse(proxy);
                    }
                    break;
                case 4:
                    if (typeProxy == 0)
                    {
                        _httpRequest.Proxy = new HttpProxyClient(proxy.Split(':')[0], Convert.ToInt32(proxy.Split(':')[1]), proxy.Split(':')[2], proxy.Split(':')[3]);
                    }
                    else
                    {
                        _httpRequest.Proxy = new Socks5ProxyClient(proxy.Split(':')[0], Convert.ToInt32(proxy.Split(':')[1]), proxy.Split(':')[2], proxy.Split(':')[3]);
                    }
                    break;
                case 3:
                    break;
            }
        }

        private void AddCookie(string cookie)
        {
            string[] array = cookie.Split(';');
            foreach (string text in array)
            {
                string[] array2 = text.Split('=');
                if (array2.Count() > 1)
                {
                    try
                    {
                        _httpRequest.Cookies.Add(array2[0], array2[1]);
                    }
                    catch { }
                }
            }
        }

        public string GetCookie()
        {
            return _httpRequest.Cookies.ToString();
        }

        private void AddHeader(string key, string value)
        {
            _httpRequest.AddHeader(key, value);
        }

        private void SetHeader()
        {
            AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
            AddHeader("Accept-Language", "en-US,en;q=0.9");
            AddHeader("Upgrade-Insecure-Requests", "1");
        }
    }
}
