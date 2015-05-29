namespace CAUService
{
    partial class Form_EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditUser));
            this.label_Number = new System.Windows.Forms.Label();
            this.label_Pass_URP = new System.Windows.Forms.Label();
            this.label_Pass_NetGate = new System.Windows.Forms.Label();
            this.label_Pass_StdMgr = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.textBox_Pass_URP = new System.Windows.Forms.TextBox();
            this.textBox_Pass_NetGate = new System.Windows.Forms.TextBox();
            this.textBox_Pass_StdMgr = new System.Windows.Forms.TextBox();
            this.groupBox_Password = new System.Windows.Forms.GroupBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.checkBox_SetToDefault = new System.Windows.Forms.CheckBox();
            this.groupBox_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Location = new System.Drawing.Point(12, 15);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(35, 12);
            this.label_Number.TabIndex = 0;
            this.label_Number.Text = "学号:";
            // 
            // label_Pass_URP
            // 
            this.label_Pass_URP.AutoSize = true;
            this.label_Pass_URP.Location = new System.Drawing.Point(6, 24);
            this.label_Pass_URP.Name = "label_Pass_URP";
            this.label_Pass_URP.Size = new System.Drawing.Size(77, 12);
            this.label_Pass_URP.TabIndex = 1;
            this.label_Pass_URP.Text = "URP教务系统:";
            // 
            // label_Pass_NetGate
            // 
            this.label_Pass_NetGate.AutoSize = true;
            this.label_Pass_NetGate.Location = new System.Drawing.Point(6, 50);
            this.label_Pass_NetGate.Name = "label_Pass_NetGate";
            this.label_Pass_NetGate.Size = new System.Drawing.Size(35, 12);
            this.label_Pass_NetGate.TabIndex = 2;
            this.label_Pass_NetGate.Text = "网关:";
            // 
            // label_Pass_StdMgr
            // 
            this.label_Pass_StdMgr.AutoSize = true;
            this.label_Pass_StdMgr.Location = new System.Drawing.Point(6, 77);
            this.label_Pass_StdMgr.Name = "label_Pass_StdMgr";
            this.label_Pass_StdMgr.Size = new System.Drawing.Size(83, 12);
            this.label_Pass_StdMgr.TabIndex = 3;
            this.label_Pass_StdMgr.Text = "网络教学平台:";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(53, 12);
            this.textBox_Number.MaxLength = 10;
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(226, 21);
            this.textBox_Number.TabIndex = 0;
            // 
            // textBox_Pass_URP
            // 
            this.textBox_Pass_URP.Location = new System.Drawing.Point(95, 20);
            this.textBox_Pass_URP.MaxLength = 16;
            this.textBox_Pass_URP.Name = "textBox_Pass_URP";
            this.textBox_Pass_URP.Size = new System.Drawing.Size(166, 21);
            this.textBox_Pass_URP.TabIndex = 3;
            this.textBox_Pass_URP.UseSystemPasswordChar = true;
            // 
            // textBox_Pass_NetGate
            // 
            this.textBox_Pass_NetGate.Location = new System.Drawing.Point(95, 47);
            this.textBox_Pass_NetGate.MaxLength = 16;
            this.textBox_Pass_NetGate.Name = "textBox_Pass_NetGate";
            this.textBox_Pass_NetGate.Size = new System.Drawing.Size(166, 21);
            this.textBox_Pass_NetGate.TabIndex = 4;
            this.textBox_Pass_NetGate.UseSystemPasswordChar = true;
            // 
            // textBox_Pass_StdMgr
            // 
            this.textBox_Pass_StdMgr.Location = new System.Drawing.Point(95, 74);
            this.textBox_Pass_StdMgr.MaxLength = 16;
            this.textBox_Pass_StdMgr.Name = "textBox_Pass_StdMgr";
            this.textBox_Pass_StdMgr.Size = new System.Drawing.Size(166, 21);
            this.textBox_Pass_StdMgr.TabIndex = 5;
            this.textBox_Pass_StdMgr.UseSystemPasswordChar = true;
            // 
            // groupBox_Password
            // 
            this.groupBox_Password.Controls.Add(this.label_Pass_URP);
            this.groupBox_Password.Controls.Add(this.textBox_Pass_StdMgr);
            this.groupBox_Password.Controls.Add(this.label_Pass_NetGate);
            this.groupBox_Password.Controls.Add(this.textBox_Pass_NetGate);
            this.groupBox_Password.Controls.Add(this.label_Pass_StdMgr);
            this.groupBox_Password.Controls.Add(this.textBox_Pass_URP);
            this.groupBox_Password.Location = new System.Drawing.Point(12, 66);
            this.groupBox_Password.Name = "groupBox_Password";
            this.groupBox_Password.Size = new System.Drawing.Size(267, 109);
            this.groupBox_Password.TabIndex = 2;
            this.groupBox_Password.TabStop = false;
            this.groupBox_Password.Text = "密码";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(204, 203);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 7;
            this.button_OK.Text = "确认";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(12, 203);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 42);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 12);
            this.label_Name.TabIndex = 11;
            this.label_Name.Text = "姓名:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_Name.Location = new System.Drawing.Point(53, 39);
            this.textBox_Name.MaxLength = 5;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(226, 21);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // checkBox_SetToDefault
            // 
            this.checkBox_SetToDefault.AutoSize = true;
            this.checkBox_SetToDefault.Checked = true;
            this.checkBox_SetToDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SetToDefault.Location = new System.Drawing.Point(183, 181);
            this.checkBox_SetToDefault.Name = "checkBox_SetToDefault";
            this.checkBox_SetToDefault.Size = new System.Drawing.Size(96, 16);
            this.checkBox_SetToDefault.TabIndex = 6;
            this.checkBox_SetToDefault.Text = "设为启用用户";
            this.checkBox_SetToDefault.UseVisualStyleBackColor = true;
            // 
            // Form_EditUser
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(291, 237);
            this.Controls.Add(this.checkBox_SetToDefault);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox_Password);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.label_Number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EditUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_EditUser_FormClosing);
            this.Load += new System.EventHandler(this.Form_EditUser_Load);
            this.Shown += new System.EventHandler(this.Form_EditUser_Shown);
            this.groupBox_Password.ResumeLayout(false);
            this.groupBox_Password.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Label label_Pass_URP;
        private System.Windows.Forms.Label label_Pass_NetGate;
        private System.Windows.Forms.Label label_Pass_StdMgr;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.TextBox textBox_Pass_URP;
        private System.Windows.Forms.TextBox textBox_Pass_NetGate;
        private System.Windows.Forms.TextBox textBox_Pass_StdMgr;
        private System.Windows.Forms.GroupBox groupBox_Password;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.CheckBox checkBox_SetToDefault;
    }
}