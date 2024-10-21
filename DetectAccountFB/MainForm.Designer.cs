namespace DetectAccountFB
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            buttonImportFile = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtBoxProxy = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNumberOfThreads = new TextBox();
            dataGridViewListAccount = new DataGridView();
            btnCheck = new Button();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListAccount).BeginInit();
            SuspendLayout();
            // 
            // buttonImportFile
            // 
            buttonImportFile.Location = new Point(482, 19);
            buttonImportFile.Name = "buttonImportFile";
            buttonImportFile.Size = new Size(138, 41);
            buttonImportFile.TabIndex = 1;
            buttonImportFile.Text = "Import File";
            buttonImportFile.UseVisualStyleBackColor = true;
            buttonImportFile.Click += buttonImportFile_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 26);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(185, 22);
            copyToolStripMenuItem.Text = "Copy userName|Pass";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Proxy";
            // 
            // txtBoxProxy
            // 
            txtBoxProxy.Location = new Point(26, 37);
            txtBoxProxy.Name = "txtBoxProxy";
            txtBoxProxy.Size = new Size(310, 23);
            txtBoxProxy.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 73);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 5;
            label2.Text = "Re-check time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 73);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Threads";
            // 
            // txtNumberOfThreads
            // 
            txtNumberOfThreads.Location = new Point(184, 91);
            txtNumberOfThreads.Name = "txtNumberOfThreads";
            txtNumberOfThreads.Size = new Size(152, 23);
            txtNumberOfThreads.TabIndex = 7;
            // 
            // dataGridViewListAccount
            // 
            dataGridViewListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListAccount.Location = new Point(0, 120);
            dataGridViewListAccount.Name = "dataGridViewListAccount";
            dataGridViewListAccount.RowTemplate.Height = 25;
            dataGridViewListAccount.Size = new Size(1077, 503);
            dataGridViewListAccount.TabIndex = 0;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(482, 74);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(138, 40);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 624);
            Controls.Add(btnCheck);
            Controls.Add(dataGridViewListAccount);
            Controls.Add(txtNumberOfThreads);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(txtBoxProxy);
            Controls.Add(label1);
            Controls.Add(buttonImportFile);
            Name = "MainForm";
            Text = "MainForm";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonImportFile;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private Label label1;
        private TextBox txtBoxProxy;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox txtNumberOfThreads;
        private DataGridView dataGridViewListAccount;
        private Button btnCheck;
    }
}