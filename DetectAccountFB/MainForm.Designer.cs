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
            dataGridViewListAccount = new DataGridView();
            buttonImportFile = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListAccount).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewListAccount
            // 
            dataGridViewListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListAccount.Location = new Point(1, 159);
            dataGridViewListAccount.Name = "dataGridViewListAccount";
            dataGridViewListAccount.RowTemplate.Height = 25;
            dataGridViewListAccount.Size = new Size(1076, 462);
            dataGridViewListAccount.TabIndex = 0;
            // 
            // buttonImportFile
            // 
            buttonImportFile.Location = new Point(30, 81);
            buttonImportFile.Name = "buttonImportFile";
            buttonImportFile.Size = new Size(75, 23);
            buttonImportFile.TabIndex = 1;
            buttonImportFile.Text = "Import File";
            buttonImportFile.UseVisualStyleBackColor = true;
            buttonImportFile.Click += buttonImportFile_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 48);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(185, 22);
            copyToolStripMenuItem.Text = "Copy userName|Pass";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 624);
            Controls.Add(buttonImportFile);
            Controls.Add(dataGridViewListAccount);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewListAccount).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewListAccount;
        private Button buttonImportFile;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
    }
}