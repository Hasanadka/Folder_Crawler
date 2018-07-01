namespace Folder_Crwaler
{
    partial class FolderCrawler
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnSongs = new System.Windows.Forms.Button();
            this.Btn_SngFolders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.lblMB = new System.Windows.Forms.Label();
            this.Btn_MediaFldr = new System.Windows.Forms.Button();
            this.chkSong = new System.Windows.Forms.CheckBox();
            this.ChkVid = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = global::Folder_Crwaler.Properties.Resources.dcgfb;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.Font = new System.Drawing.Font("Old English Text MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Silver;
            this.btnBrowse.Location = new System.Drawing.Point(294, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(77, 27);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.BackColor = System.Drawing.Color.Silver;
            this.FolderPath.Location = new System.Drawing.Point(27, 62);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(240, 20);
            this.FolderPath.TabIndex = 1;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackgroundImage = global::Folder_Crwaler.Properties.Resources.dcgfb;
            this.BtnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGenerate.Font = new System.Drawing.Font("Old English Text MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.ForeColor = System.Drawing.Color.Silver;
            this.BtnGenerate.Location = new System.Drawing.Point(27, 147);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(105, 33);
            this.BtnGenerate.TabIndex = 2;
            this.BtnGenerate.Text = "Media";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnSongs
            // 
            this.BtnSongs.BackgroundImage = global::Folder_Crwaler.Properties.Resources.dcgfb;
            this.BtnSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSongs.Font = new System.Drawing.Font("Old English Text MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSongs.ForeColor = System.Drawing.Color.Silver;
            this.BtnSongs.Location = new System.Drawing.Point(147, 147);
            this.BtnSongs.Name = "BtnSongs";
            this.BtnSongs.Size = new System.Drawing.Size(105, 33);
            this.BtnSongs.TabIndex = 3;
            this.BtnSongs.Text = "Songs";
            this.BtnSongs.UseVisualStyleBackColor = true;
            this.BtnSongs.Visible = false;
            this.BtnSongs.Click += new System.EventHandler(this.BtnSongs_Click);
            // 
            // Btn_SngFolders
            // 
            this.Btn_SngFolders.BackgroundImage = global::Folder_Crwaler.Properties.Resources.dcgfb;
            this.Btn_SngFolders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_SngFolders.Font = new System.Drawing.Font("Old English Text MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SngFolders.ForeColor = System.Drawing.Color.Silver;
            this.Btn_SngFolders.Location = new System.Drawing.Point(147, 186);
            this.Btn_SngFolders.Name = "Btn_SngFolders";
            this.Btn_SngFolders.Size = new System.Drawing.Size(105, 33);
            this.Btn_SngFolders.TabIndex = 4;
            this.Btn_SngFolders.Text = "Songs Folder";
            this.Btn_SngFolders.UseVisualStyleBackColor = true;
            this.Btn_SngFolders.Visible = false;
            this.Btn_SngFolders.Click += new System.EventHandler(this.Btn_SngFolders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(266, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "© Sagar Hasanadka";
            // 
            // txtMB
            // 
            this.txtMB.BackColor = System.Drawing.Color.Silver;
            this.txtMB.Location = new System.Drawing.Point(27, 121);
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(72, 20);
            this.txtMB.TabIndex = 6;
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(105, 125);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(23, 13);
            this.lblMB.TabIndex = 7;
            this.lblMB.Text = "MB";
            // 
            // Btn_MediaFldr
            // 
            this.Btn_MediaFldr.BackgroundImage = global::Folder_Crwaler.Properties.Resources.dcgfb;
            this.Btn_MediaFldr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_MediaFldr.Font = new System.Drawing.Font("Old English Text MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MediaFldr.ForeColor = System.Drawing.Color.Silver;
            this.Btn_MediaFldr.Location = new System.Drawing.Point(27, 186);
            this.Btn_MediaFldr.Name = "Btn_MediaFldr";
            this.Btn_MediaFldr.Size = new System.Drawing.Size(105, 33);
            this.Btn_MediaFldr.TabIndex = 8;
            this.Btn_MediaFldr.Text = "Media Folder";
            this.Btn_MediaFldr.UseVisualStyleBackColor = true;
            this.Btn_MediaFldr.Click += new System.EventHandler(this.Btn_MediaFldr_Click);
            // 
            // chkSong
            // 
            this.chkSong.AutoSize = true;
            this.chkSong.BackColor = System.Drawing.Color.Silver;
            this.chkSong.Location = new System.Drawing.Point(269, 147);
            this.chkSong.Name = "chkSong";
            this.chkSong.Size = new System.Drawing.Size(56, 17);
            this.chkSong.TabIndex = 9;
            this.chkSong.Text = "Songs";
            this.chkSong.UseVisualStyleBackColor = false;
            // 
            // ChkVid
            // 
            this.ChkVid.AutoSize = true;
            this.ChkVid.BackColor = System.Drawing.Color.Silver;
            this.ChkVid.Location = new System.Drawing.Point(269, 170);
            this.ChkVid.Name = "ChkVid";
            this.ChkVid.Size = new System.Drawing.Size(58, 17);
            this.ChkVid.TabIndex = 10;
            this.ChkVid.Text = "Videos";
            this.ChkVid.UseVisualStyleBackColor = false;
            // 
            // FolderCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Folder_Crwaler.Properties.Resources.xdfv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 222);
            this.Controls.Add(this.ChkVid);
            this.Controls.Add(this.chkSong);
            this.Controls.Add(this.Btn_MediaFldr);
            this.Controls.Add(this.lblMB);
            this.Controls.Add(this.txtMB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_SngFolders);
            this.Controls.Add(this.BtnSongs);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "FolderCrawler";
            this.Text = "Folder Crawler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnSongs;
        private System.Windows.Forms.Button Btn_SngFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMB;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Button Btn_MediaFldr;
        private System.Windows.Forms.CheckBox chkSong;
        private System.Windows.Forms.CheckBox ChkVid;
    }
}

