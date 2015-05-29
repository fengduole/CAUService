namespace CAUService
{
    partial class Form_UserManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UserManage));
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_SetNowUser = new System.Windows.Forms.Button();
            this.listView_UserList = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_NowUserInfo = new System.Windows.Forms.Label();
            this.label_NowUser = new System.Windows.Forms.Label();
            this.panel_DivideLine = new System.Windows.Forms.Panel();
            this.label_CreatTime = new System.Windows.Forms.Label();
            this.label_LastTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Edit
            // 
            this.button_Edit.Enabled = false;
            this.button_Edit.Location = new System.Drawing.Point(287, 205);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(62, 45);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "编辑";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(219, 205);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(62, 45);
            this.button_New.TabIndex = 2;
            this.button_New.Text = "新增";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_SetNowUser
            // 
            this.button_SetNowUser.Enabled = false;
            this.button_SetNowUser.Location = new System.Drawing.Point(219, 256);
            this.button_SetNowUser.Name = "button_SetNowUser";
            this.button_SetNowUser.Size = new System.Drawing.Size(198, 45);
            this.button_SetNowUser.TabIndex = 1;
            this.button_SetNowUser.Text = "设为启用用户";
            this.button_SetNowUser.UseVisualStyleBackColor = true;
            this.button_SetNowUser.Click += new System.EventHandler(this.button_SetDefault_Click);
            // 
            // listView_UserList
            // 
            this.listView_UserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.UserName});
            this.listView_UserList.FullRowSelect = true;
            this.listView_UserList.Location = new System.Drawing.Point(12, 12);
            this.listView_UserList.MultiSelect = false;
            this.listView_UserList.Name = "listView_UserList";
            this.listView_UserList.Size = new System.Drawing.Size(201, 289);
            this.listView_UserList.TabIndex = 0;
            this.listView_UserList.UseCompatibleStateImageBehavior = false;
            this.listView_UserList.View = System.Windows.Forms.View.Details;
            this.listView_UserList.SelectedIndexChanged += new System.EventHandler(this.listView_UserList_SelectedIndexChanged);
            // 
            // Number
            // 
            this.Number.Text = "学号";
            this.Number.Width = 100;
            // 
            // UserName
            // 
            this.UserName.Text = "用户名";
            this.UserName.Width = 70;
            // 
            // button_Delete
            // 
            this.button_Delete.Enabled = false;
            this.button_Delete.Location = new System.Drawing.Point(355, 205);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(62, 45);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "删除";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_NowUserInfo
            // 
            this.label_NowUserInfo.AutoSize = true;
            this.label_NowUserInfo.Location = new System.Drawing.Point(219, 12);
            this.label_NowUserInfo.Name = "label_NowUserInfo";
            this.label_NowUserInfo.Size = new System.Drawing.Size(83, 12);
            this.label_NowUserInfo.TabIndex = 5;
            this.label_NowUserInfo.Text = "当前启用帐户:";
            // 
            // label_NowUser
            // 
            this.label_NowUser.AutoSize = true;
            this.label_NowUser.Location = new System.Drawing.Point(240, 34);
            this.label_NowUser.Name = "label_NowUser";
            this.label_NowUser.Size = new System.Drawing.Size(101, 12);
            this.label_NowUser.TabIndex = 6;
            this.label_NowUser.Text = "当前启用帐户信息";
            // 
            // panel_DivideLine
            // 
            this.panel_DivideLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_DivideLine.Location = new System.Drawing.Point(221, 56);
            this.panel_DivideLine.Name = "panel_DivideLine";
            this.panel_DivideLine.Size = new System.Drawing.Size(196, 1);
            this.panel_DivideLine.TabIndex = 7;
            // 
            // label_CreatTime
            // 
            this.label_CreatTime.AutoSize = true;
            this.label_CreatTime.Location = new System.Drawing.Point(225, 69);
            this.label_CreatTime.Name = "label_CreatTime";
            this.label_CreatTime.Size = new System.Drawing.Size(77, 12);
            this.label_CreatTime.TabIndex = 8;
            this.label_CreatTime.Text = "用户创建时间";
            // 
            // label_LastTime
            // 
            this.label_LastTime.AutoSize = true;
            this.label_LastTime.Location = new System.Drawing.Point(225, 91);
            this.label_LastTime.Name = "label_LastTime";
            this.label_LastTime.Size = new System.Drawing.Size(77, 12);
            this.label_LastTime.TabIndex = 9;
            this.label_LastTime.Text = "上次使用时间";
            // 
            // Form_UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 313);
            this.Controls.Add(this.label_LastTime);
            this.Controls.Add(this.label_CreatTime);
            this.Controls.Add(this.panel_DivideLine);
            this.Controls.Add(this.label_NowUser);
            this.Controls.Add(this.label_NowUserInfo);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.listView_UserList);
            this.Controls.Add(this.button_SetNowUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_UserManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_UserManage_FormClosed);
            this.Load += new System.EventHandler(this.Form_UserManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SetNowUser;
        private System.Windows.Forms.ListView listView_UserList;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label_NowUserInfo;
        private System.Windows.Forms.Label label_NowUser;
        private System.Windows.Forms.Panel panel_DivideLine;
        private System.Windows.Forms.Label label_CreatTime;
        private System.Windows.Forms.Label label_LastTime;
    }
}