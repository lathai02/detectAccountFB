namespace DetectAccountFB
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
            TxtBoxLicensekey = new TextBox();
            BtnGenerateKey = new Button();
            btnSend = new Button();
            txtDesktopName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TxtBoxLicensekey
            // 
            TxtBoxLicensekey.Location = new Point(182, 131);
            TxtBoxLicensekey.Name = "TxtBoxLicensekey";
            TxtBoxLicensekey.ReadOnly = true;
            TxtBoxLicensekey.Size = new Size(281, 23);
            TxtBoxLicensekey.TabIndex = 0;
            // 
            // BtnGenerateKey
            // 
            BtnGenerateKey.Location = new Point(182, 248);
            BtnGenerateKey.Name = "BtnGenerateKey";
            BtnGenerateKey.Size = new Size(159, 23);
            BtnGenerateKey.TabIndex = 1;
            BtnGenerateKey.Text = "Generate licence key";
            BtnGenerateKey.UseVisualStyleBackColor = true;
            BtnGenerateKey.Click += BtnGenerateKey_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(378, 248);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtDesktopName
            // 
            txtDesktopName.Location = new Point(182, 64);
            txtDesktopName.Name = "txtDesktopName";
            txtDesktopName.ReadOnly = true;
            txtDesktopName.Size = new Size(281, 23);
            txtDesktopName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "User name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 113);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "Lisence Key";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 356);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDesktopName);
            Controls.Add(btnSend);
            Controls.Add(BtnGenerateKey);
            Controls.Add(TxtBoxLicensekey);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBoxLicensekey;
        private Button BtnGenerateKey;
        private Button btnSend;
        private TextBox txtDesktopName;
        private Label label1;
        private Label label2;
    }
}
