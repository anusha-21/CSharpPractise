
namespace SchoolFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textTwitter = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.btnPushToText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SchoolName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Twitter";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(256, 53);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(150, 31);
            this.textName.TabIndex = 7;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(256, 200);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(150, 31);
            this.textState.TabIndex = 8;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(256, 248);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(150, 31);
            this.textZip.TabIndex = 9;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(256, 286);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(150, 31);
            this.textPhone.TabIndex = 10;
            // 
            // textTwitter
            // 
            this.textTwitter.Location = new System.Drawing.Point(256, 332);
            this.textTwitter.Name = "textTwitter";
            this.textTwitter.Size = new System.Drawing.Size(150, 31);
            this.textTwitter.TabIndex = 11;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(256, 154);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(150, 31);
            this.textCity.TabIndex = 12;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(256, 105);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(150, 31);
            this.textAddress.TabIndex = 13;
            // 
            // btnPushToText
            // 
            this.btnPushToText.Location = new System.Drawing.Point(265, 394);
            this.btnPushToText.Name = "btnPushToText";
            this.btnPushToText.Size = new System.Drawing.Size(132, 34);
            this.btnPushToText.TabIndex = 14;
            this.btnPushToText.Text = "Push To Text";
            this.btnPushToText.UseVisualStyleBackColor = true;
            this.btnPushToText.Click += new System.EventHandler(this.btnPushToText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 516);
            this.Controls.Add(this.btnPushToText);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textTwitter);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textTwitter;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button btnPushToText;
    }
}

