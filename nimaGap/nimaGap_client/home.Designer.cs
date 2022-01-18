namespace nimaGap_client
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
            this.connect_btn = new System.Windows.Forms.Button();
            this.connect_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gap_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.message_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contact_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(0, 4);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(111, 27);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "اتصال به سرور";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // connect_txt
            // 
            this.connect_txt.Location = new System.Drawing.Point(117, 6);
            this.connect_txt.Name = "connect_txt";
            this.connect_txt.Size = new System.Drawing.Size(138, 22);
            this.connect_txt.TabIndex = 1;
            this.connect_txt.Text = "127.0.0.1:9000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "آدرس سرور";
            // 
            // gap_txt
            // 
            this.gap_txt.Enabled = false;
            this.gap_txt.Location = new System.Drawing.Point(0, 34);
            this.gap_txt.Multiline = true;
            this.gap_txt.Name = "gap_txt";
            this.gap_txt.Size = new System.Drawing.Size(648, 359);
            this.gap_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(734, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "گپ";
            // 
            // send_btn
            // 
            this.send_btn.Enabled = false;
            this.send_btn.Location = new System.Drawing.Point(0, 466);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(111, 27);
            this.send_btn.TabIndex = 5;
            this.send_btn.Text = "ارسال";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // message_txt
            // 
            this.message_txt.Enabled = false;
            this.message_txt.Location = new System.Drawing.Point(117, 471);
            this.message_txt.Name = "message_txt";
            this.message_txt.Size = new System.Drawing.Size(531, 22);
            this.message_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(706, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "پیام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "نام کاربری";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(366, 6);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(365, 22);
            this.username_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(706, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "مخاطب";
            // 
            // contact_txt
            // 
            this.contact_txt.Enabled = false;
            this.contact_txt.Location = new System.Drawing.Point(117, 433);
            this.contact_txt.Name = "contact_txt";
            this.contact_txt.Size = new System.Drawing.Size(531, 22);
            this.contact_txt.TabIndex = 10;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contact_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message_txt);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gap_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect_txt);
            this.Controls.Add(this.connect_btn);
            this.Name = "home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox connect_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gap_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox message_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contact_txt;
    }
}

