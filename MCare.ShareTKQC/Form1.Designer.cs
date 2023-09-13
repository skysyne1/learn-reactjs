namespace MCare.ShareTKQC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvViaReceive = new System.Windows.Forms.DataGridView();
            this.cChoseReceive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cSttReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUidReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPasswordReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKey2FaReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCookieReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTokenReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatusReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bôiĐenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bỏChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bôiĐenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tấtCảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvViaShare = new System.Windows.Forms.DataGridView();
            this.cChoseShare = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cSttShare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUidShare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPasswordShare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKey2Fa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTokenShare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatusShare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.dtgvAdAccounts = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTimezone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAccountStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViaReceive)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViaShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAdAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 565);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Btn_Start);
            this.tabPage1.Controls.Add(this.dtgvAdAccounts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hiển thị";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvViaReceive);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1164, 179);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Via Nhận";
            // 
            // dtgvViaReceive
            // 
            this.dtgvViaReceive.AllowUserToAddRows = false;
            this.dtgvViaReceive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvViaReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvViaReceive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChoseReceive,
            this.cSttReceive,
            this.cUidReceive,
            this.cPasswordReceive,
            this.cKey2FaReceive,
            this.cCookieReceive,
            this.cTokenReceive,
            this.cStatusReceive});
            this.dtgvViaReceive.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgvViaReceive.Location = new System.Drawing.Point(3, 16);
            this.dtgvViaReceive.Name = "dtgvViaReceive";
            this.dtgvViaReceive.RowHeadersVisible = false;
            this.dtgvViaReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvViaReceive.Size = new System.Drawing.Size(1158, 157);
            this.dtgvViaReceive.TabIndex = 6;
            // 
            // cChoseReceive
            // 
            this.cChoseReceive.FillWeight = 30F;
            this.cChoseReceive.HeaderText = "Chose";
            this.cChoseReceive.Name = "cChoseReceive";
            // 
            // cSttReceive
            // 
            this.cSttReceive.FillWeight = 30F;
            this.cSttReceive.HeaderText = "#";
            this.cSttReceive.Name = "cSttReceive";
            // 
            // cUidReceive
            // 
            this.cUidReceive.HeaderText = "Uid";
            this.cUidReceive.Name = "cUidReceive";
            // 
            // cPasswordReceive
            // 
            this.cPasswordReceive.HeaderText = "Password";
            this.cPasswordReceive.Name = "cPasswordReceive";
            // 
            // cKey2FaReceive
            // 
            this.cKey2FaReceive.HeaderText = "Key 2Fa";
            this.cKey2FaReceive.Name = "cKey2FaReceive";
            // 
            // cCookieReceive
            // 
            this.cCookieReceive.HeaderText = "Cookie";
            this.cCookieReceive.Name = "cCookieReceive";
            // 
            // cTokenReceive
            // 
            this.cTokenReceive.HeaderText = "Token EAAb";
            this.cTokenReceive.Name = "cTokenReceive";
            // 
            // cStatusReceive
            // 
            this.cStatusReceive.HeaderText = "Status";
            this.cStatusReceive.Name = "cStatusReceive";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnToolStripMenuItem,
            this.bỏChọnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // chọnToolStripMenuItem
            // 
            this.chọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bôiĐenToolStripMenuItem,
            this.tấtCảToolStripMenuItem});
            this.chọnToolStripMenuItem.Name = "chọnToolStripMenuItem";
            this.chọnToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.chọnToolStripMenuItem.Text = "Chọn";
            // 
            // bôiĐenToolStripMenuItem
            // 
            this.bôiĐenToolStripMenuItem.Name = "bôiĐenToolStripMenuItem";
            this.bôiĐenToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.bôiĐenToolStripMenuItem.Text = "Bôi đen";
            // 
            // tấtCảToolStripMenuItem
            // 
            this.tấtCảToolStripMenuItem.Name = "tấtCảToolStripMenuItem";
            this.tấtCảToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.tấtCảToolStripMenuItem.Text = "Tất cả";
            // 
            // bỏChọnToolStripMenuItem
            // 
            this.bỏChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bôiĐenToolStripMenuItem1,
            this.tấtCảToolStripMenuItem1});
            this.bỏChọnToolStripMenuItem.Name = "bỏChọnToolStripMenuItem";
            this.bỏChọnToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.bỏChọnToolStripMenuItem.Text = "Bỏ chọn";
            // 
            // bôiĐenToolStripMenuItem1
            // 
            this.bôiĐenToolStripMenuItem1.Name = "bôiĐenToolStripMenuItem1";
            this.bôiĐenToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.bôiĐenToolStripMenuItem1.Text = "Bôi đen";
            // 
            // tấtCảToolStripMenuItem1
            // 
            this.tấtCảToolStripMenuItem1.Name = "tấtCảToolStripMenuItem1";
            this.tấtCảToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.tấtCảToolStripMenuItem1.Text = "Tất cả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvViaShare);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1164, 189);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Via Share";
            // 
            // dtgvViaShare
            // 
            this.dtgvViaShare.AllowUserToAddRows = false;
            this.dtgvViaShare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvViaShare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvViaShare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChoseShare,
            this.cSttShare,
            this.cUidShare,
            this.cPasswordShare,
            this.cKey2Fa,
            this.cCookie,
            this.cTokenShare,
            this.cStatusShare});
            this.dtgvViaShare.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgvViaShare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvViaShare.Location = new System.Drawing.Point(3, 16);
            this.dtgvViaShare.Name = "dtgvViaShare";
            this.dtgvViaShare.RowHeadersVisible = false;
            this.dtgvViaShare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvViaShare.Size = new System.Drawing.Size(1158, 170);
            this.dtgvViaShare.TabIndex = 1;
            // 
            // cChoseShare
            // 
            this.cChoseShare.FillWeight = 30F;
            this.cChoseShare.HeaderText = "Chose";
            this.cChoseShare.Name = "cChoseShare";
            // 
            // cSttShare
            // 
            this.cSttShare.FillWeight = 30F;
            this.cSttShare.HeaderText = "#";
            this.cSttShare.Name = "cSttShare";
            // 
            // cUidShare
            // 
            this.cUidShare.HeaderText = "Uid";
            this.cUidShare.Name = "cUidShare";
            // 
            // cPasswordShare
            // 
            this.cPasswordShare.HeaderText = "Password";
            this.cPasswordShare.Name = "cPasswordShare";
            // 
            // cKey2Fa
            // 
            this.cKey2Fa.HeaderText = "Key 2Fa";
            this.cKey2Fa.Name = "cKey2Fa";
            // 
            // cCookie
            // 
            this.cCookie.HeaderText = "Cookie";
            this.cCookie.Name = "cCookie";
            // 
            // cTokenShare
            // 
            this.cTokenShare.HeaderText = "Token EAAb";
            this.cTokenShare.Name = "cTokenShare";
            // 
            // cStatusShare
            // 
            this.cStatusShare.HeaderText = "Status";
            this.cStatusShare.Name = "cStatusShare";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(1059, 496);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(103, 37);
            this.Btn_Start.TabIndex = 5;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            // 
            // dtgvAdAccounts
            // 
            this.dtgvAdAccounts.AllowUserToAddRows = false;
            this.dtgvAdAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAdAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChose,
            this.cStt,
            this.cUid,
            this.cName,
            this.cCurrency,
            this.cTimezone,
            this.cAccountStatus,
            this.cStatus});
            this.dtgvAdAccounts.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgvAdAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvAdAccounts.Location = new System.Drawing.Point(3, 3);
            this.dtgvAdAccounts.Name = "dtgvAdAccounts";
            this.dtgvAdAccounts.RowHeadersVisible = false;
            this.dtgvAdAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAdAccounts.Size = new System.Drawing.Size(1164, 112);
            this.dtgvAdAccounts.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1170, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cấu hình";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cChose
            // 
            this.cChose.FillWeight = 30F;
            this.cChose.HeaderText = "Chose";
            this.cChose.Name = "cChose";
            // 
            // cStt
            // 
            this.cStt.FillWeight = 30F;
            this.cStt.HeaderText = "#";
            this.cStt.Name = "cStt";
            // 
            // cUid
            // 
            this.cUid.HeaderText = "Uid";
            this.cUid.Name = "cUid";
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            // 
            // cCurrency
            // 
            this.cCurrency.HeaderText = "Currency";
            this.cCurrency.Name = "cCurrency";
            // 
            // cTimezone
            // 
            this.cTimezone.HeaderText = "Timezone";
            this.cTimezone.Name = "cTimezone";
            // 
            // cAccountStatus
            // 
            this.cAccountStatus.HeaderText = "Account Status";
            this.cAccountStatus.Name = "cAccountStatus";
            // 
            // cStatus
            // 
            this.cStatus.HeaderText = "Status";
            this.cStatus.Name = "cStatus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 565);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViaReceive)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViaShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAdAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgvViaShare;
        private System.Windows.Forms.DataGridView dtgvAdAccounts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bôiĐenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bỏChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bôiĐenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChoseShare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSttShare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUidShare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPasswordShare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKey2Fa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCookie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTokenShare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatusShare;
        private System.Windows.Forms.DataGridView dtgvViaReceive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChoseReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSttReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUidReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPasswordReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKey2FaReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCookieReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTokenReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatusReceive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChose;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTimezone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAccountStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
    }
}

