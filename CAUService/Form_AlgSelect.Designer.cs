namespace CAUService
{
    partial class Form_AlgSelect
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
            this.listView_Algs = new System.Windows.Forms.ListView();
            this.Alg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.pictureBox_AlgImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Algs
            // 
            this.listView_Algs.CheckBoxes = true;
            this.listView_Algs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Alg});
            this.listView_Algs.Location = new System.Drawing.Point(12, 12);
            this.listView_Algs.MultiSelect = false;
            this.listView_Algs.Name = "listView_Algs";
            this.listView_Algs.Size = new System.Drawing.Size(145, 249);
            this.listView_Algs.TabIndex = 0;
            this.listView_Algs.UseCompatibleStateImageBehavior = false;
            this.listView_Algs.View = System.Windows.Forms.View.Details;
            this.listView_Algs.SelectedIndexChanged += new System.EventHandler(this.listView_Algs_SelectedIndexChanged);
            // 
            // Alg
            // 
            this.Alg.Text = "算法名称";
            this.Alg.Width = 116;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(308, 238);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "确认";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(163, 238);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox_AlgImage
            // 
            this.pictureBox_AlgImage.BackColor = System.Drawing.Color.White;
            this.pictureBox_AlgImage.Location = new System.Drawing.Point(163, 12);
            this.pictureBox_AlgImage.Name = "pictureBox_AlgImage";
            this.pictureBox_AlgImage.Size = new System.Drawing.Size(220, 220);
            this.pictureBox_AlgImage.TabIndex = 3;
            this.pictureBox_AlgImage.TabStop = false;
            // 
            // Form_AlgSelect
            // 
            this.AcceptButton = this.button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(393, 271);
            this.Controls.Add(this.pictureBox_AlgImage);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.listView_Algs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AlgSelect";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "算法选择";
            this.Load += new System.EventHandler(this.Form_AlgSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Algs;
        private System.Windows.Forms.ColumnHeader Alg;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.PictureBox pictureBox_AlgImage;
    }
}