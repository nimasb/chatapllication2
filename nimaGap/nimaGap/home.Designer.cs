namespace nimaGap
{
    partial class home
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
            this.status_txt = new System.Windows.Forms.TextBox();
            this.data_txt = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.userlist_lst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ip_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // status_txt
            // 
            this.status_txt.Enabled = false;
            this.status_txt.Location = new System.Drawing.Point(123, 31);
            this.status_txt.Multiline = true;
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(665, 247);
            this.status_txt.TabIndex = 0;
            // 
            // data_txt
            // 
            this.data_txt.Enabled = false;
            this.data_txt.Location = new System.Drawing.Point(123, 284);
            this.data_txt.Name = "data_txt";
            this.data_txt.Size = new System.Drawing.Size(665, 22);
            this.data_txt.TabIndex = 1;
            // 
            // send_btn
            // 
            this.send_btn.Enabled = false;
            this.send_btn.Location = new System.Drawing.Point(123, 312);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(665, 23);
            this.send_btn.TabIndex = 2;
            this.send_btn.Text = "ارسال";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Enabled = false;
            this.start_btn.Location = new System.Drawing.Point(123, 2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(171, 23);
            this.start_btn.TabIndex = 3;
            this.start_btn.Text = "شروع";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // userlist_lst
            // 
            this.userlist_lst.FormattingEnabled = true;
            this.userlist_lst.ItemHeight = 16;
            this.userlist_lst.Location = new System.Drawing.Point(-3, 2);
            this.userlist_lst.Name = "userlist_lst";
            this.userlist_lst.Size = new System.Drawing.Size(120, 452);
            this.userlist_lst.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "آی پی سرور";
            // 
            // ip_txt
            // 
            this.ip_txt.Location = new System.Drawing.Point(300, 2);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(423, 22);
            this.ip_txt.TabIndex = 6;
            this.ip_txt.Text = "127.0.0.1:9000";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ip_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userlist_lst);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.data_txt);
            this.Controls.Add(this.status_txt);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox status_txt;
        private System.Windows.Forms.TextBox data_txt;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.ListBox userlist_lst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ip_txt;
    }
}