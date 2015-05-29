namespace Update
{
    partial class Form_Update
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Update));
            this.label_State = new System.Windows.Forms.Label();
            this.pictureBox_UpdateLogo = new System.Windows.Forms.PictureBox();
            this.progressBar_Process = new System.Windows.Forms.ProgressBar();
            this.label_NowVersion = new System.Windows.Forms.Label();
            this.panel_Update = new System.Windows.Forms.Panel();
            this.label_NewVersion = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.label_Note = new System.Windows.Forms.Label();
            this.button_Email = new System.Windows.Forms.Button();
            this.button_Download = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UpdateLogo)).BeginInit();
            this.panel_Update.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_State.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_State.Location = new System.Drawing.Point(50, 21);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(153, 28);
            this.label_State.TabIndex = 0;
            this.label_State.Text = "正在检测更新...";
            // 
            // pictureBox_UpdateLogo
            // 
            this.pictureBox_UpdateLogo.Image = global::Update.Properties.Resources.update_2;
            this.pictureBox_UpdateLogo.Location = new System.Drawing.Point(12, 17);
            this.pictureBox_UpdateLogo.Name = "pictureBox_UpdateLogo";
            this.pictureBox_UpdateLogo.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_UpdateLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_UpdateLogo.TabIndex = 1;
            this.pictureBox_UpdateLogo.TabStop = false;
            // 
            // progressBar_Process
            // 
            this.progressBar_Process.Location = new System.Drawing.Point(12, 55);
            this.progressBar_Process.Name = "progressBar_Process";
            this.progressBar_Process.Size = new System.Drawing.Size(191, 15);
            this.progressBar_Process.Step = 50;
            this.progressBar_Process.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar_Process.TabIndex = 2;
            // 
            // label_NowVersion
            // 
            this.label_NowVersion.AutoSize = true;
            this.label_NowVersion.Location = new System.Drawing.Point(3, 6);
            this.label_NowVersion.Name = "label_NowVersion";
            this.label_NowVersion.Size = new System.Drawing.Size(59, 12);
            this.label_NowVersion.TabIndex = 3;
            this.label_NowVersion.Text = "当前版本:";
            // 
            // panel_Update
            // 
            this.panel_Update.Controls.Add(this.button_Download);
            this.panel_Update.Controls.Add(this.button_Email);
            this.panel_Update.Controls.Add(this.label_Note);
            this.panel_Update.Controls.Add(this.label_Level);
            this.panel_Update.Controls.Add(this.label_NewVersion);
            this.panel_Update.Controls.Add(this.label_NowVersion);
            this.panel_Update.Location = new System.Drawing.Point(12, 55);
            this.panel_Update.Name = "panel_Update";
            this.panel_Update.Size = new System.Drawing.Size(191, 319);
            this.panel_Update.TabIndex = 5;
            this.panel_Update.Visible = false;
            // 
            // label_NewVersion
            // 
            this.label_NewVersion.AutoSize = true;
            this.label_NewVersion.Location = new System.Drawing.Point(3, 33);
            this.label_NewVersion.Name = "label_NewVersion";
            this.label_NewVersion.Size = new System.Drawing.Size(59, 12);
            this.label_NewVersion.TabIndex = 6;
            this.label_NewVersion.Text = "最新版本:";
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Location = new System.Drawing.Point(3, 60);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(59, 12);
            this.label_Level.TabIndex = 7;
            this.label_Level.Text = "推 荐 度:";
            // 
            // label_Note
            // 
            this.label_Note.Location = new System.Drawing.Point(3, 87);
            this.label_Note.Name = "label_Note";
            this.label_Note.Size = new System.Drawing.Size(185, 193);
            this.label_Note.TabIndex = 8;
            this.label_Note.Text = "更新内容:";
            // 
            // button_Email
            // 
            this.button_Email.Location = new System.Drawing.Point(98, 293);
            this.button_Email.Name = "button_Email";
            this.button_Email.Size = new System.Drawing.Size(75, 23);
            this.button_Email.TabIndex = 9;
            this.button_Email.Text = "邮件推送";
            this.button_Email.UseVisualStyleBackColor = true;
            this.button_Email.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(17, 293);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(75, 23);
            this.button_Download.TabIndex = 10;
            this.button_Download.Text = "下载更新";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // Form_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 386);
            this.Controls.Add(this.panel_Update);
            this.Controls.Add(this.progressBar_Process);
            this.Controls.Add(this.pictureBox_UpdateLogo);
            this.Controls.Add(this.label_State);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新中心";
            this.Load += new System.EventHandler(this.Form_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UpdateLogo)).EndInit();
            this.panel_Update.ResumeLayout(false);
            this.panel_Update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.PictureBox pictureBox_UpdateLogo;
        private System.Windows.Forms.ProgressBar progressBar_Process;
        private System.Windows.Forms.Label label_NowVersion;
        private System.Windows.Forms.Panel panel_Update;
        private System.Windows.Forms.Label label_NewVersion;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.Label label_Note;
        private System.Windows.Forms.Button button_Email;
        private System.Windows.Forms.Button button_Download;
    }
}

