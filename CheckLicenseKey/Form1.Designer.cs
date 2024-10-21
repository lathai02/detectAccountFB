namespace CheckLicenseKey
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
            txtBoxLicenseKey = new TextBox();
            txtBoxBios = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxProcessorId = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtBoxLicenseKey
            // 
            txtBoxLicenseKey.Location = new Point(249, 45);
            txtBoxLicenseKey.Name = "txtBoxLicenseKey";
            txtBoxLicenseKey.Size = new Size(282, 23);
            txtBoxLicenseKey.TabIndex = 0;
            // 
            // txtBoxBios
            // 
            txtBoxBios.Location = new Point(249, 116);
            txtBoxBios.Name = "txtBoxBios";
            txtBoxBios.Size = new Size(282, 23);
            txtBoxBios.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 27);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "License Key:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 98);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Bios";
            // 
            // txtBoxProcessorId
            // 
            txtBoxProcessorId.Location = new Point(249, 186);
            txtBoxProcessorId.Name = "txtBoxProcessorId";
            txtBoxProcessorId.Size = new Size(282, 23);
            txtBoxProcessorId.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 168);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "ProcessorId";
            // 
            // button1
            // 
            button1.Location = new Point(347, 261);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtBoxProcessorId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxBios);
            Controls.Add(txtBoxLicenseKey);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxLicenseKey;
        private TextBox txtBoxBios;
        private Label label1;
        private Label label2;
        private TextBox txtBoxProcessorId;
        private Label label3;
        private Button button1;
    }
}
