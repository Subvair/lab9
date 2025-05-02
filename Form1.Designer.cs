namespace DirectorySyncMVP
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDir1;
        private System.Windows.Forms.TextBox textBoxDir2;
        private System.Windows.Forms.Button buttonBrowse1;
        private System.Windows.Forms.Button buttonBrowse2;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.RadioButton radioXml;
        private System.Windows.Forms.RadioButton radioJson;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxDir1 = new System.Windows.Forms.TextBox();
            this.textBoxDir2 = new System.Windows.Forms.TextBox();
            this.buttonBrowse1 = new System.Windows.Forms.Button();
            this.buttonBrowse2 = new System.Windows.Forms.Button();
            this.buttonSync = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.radioXml = new System.Windows.Forms.RadioButton();
            this.radioJson = new System.Windows.Forms.RadioButton();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();

            this.groupBoxFormat.SuspendLayout();
            this.SuspendLayout();

            // textBoxDir1
            this.textBoxDir1.Location = new System.Drawing.Point(20, 20);
            this.textBoxDir1.Size = new System.Drawing.Size(400, 23);

            // buttonBrowse1
            this.buttonBrowse1.Location = new System.Drawing.Point(430, 20);
            this.buttonBrowse1.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse1.Text = "Обзор...";
            this.buttonBrowse1.Click += new System.EventHandler(this.buttonBrowse1_Click);

            // textBoxDir2
            this.textBoxDir2.Location = new System.Drawing.Point(20, 60);
            this.textBoxDir2.Size = new System.Drawing.Size(400, 23);

            // buttonBrowse2
            this.buttonBrowse2.Location = new System.Drawing.Point(430, 60);
            this.buttonBrowse2.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse2.Text = "Обзор...";
            this.buttonBrowse2.Click += new System.EventHandler(this.buttonBrowse2_Click);

            // groupBoxFormat
            this.groupBoxFormat.Controls.Add(this.radioXml);
            this.groupBoxFormat.Controls.Add(this.radioJson);
            this.groupBoxFormat.Location = new System.Drawing.Point(20, 100);
            this.groupBoxFormat.Size = new System.Drawing.Size(200, 50);
            this.groupBoxFormat.Text = "Формат логов";

            // radioXml
            this.radioXml.AutoSize = true;
            this.radioXml.Location = new System.Drawing.Point(10, 20);
            this.radioXml.Text = "XML";
            this.radioXml.Checked = true;

            // radioJson
            this.radioJson.AutoSize = true;
            this.radioJson.Location = new System.Drawing.Point(70, 20);
            this.radioJson.Text = "JSON";

            // buttonSync
            this.buttonSync.Location = new System.Drawing.Point(20, 170);
            this.buttonSync.Size = new System.Drawing.Size(485, 30);
            this.buttonSync.Text = "Синхронизировать";
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);

            // listBoxLog
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 15;
            this.listBoxLog.Location = new System.Drawing.Point(20, 220);
            this.listBoxLog.Size = new System.Drawing.Size(485, 184);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 421);
            this.Controls.Add(this.textBoxDir1);
            this.Controls.Add(this.buttonBrowse1);
            this.Controls.Add(this.textBoxDir2);
            this.Controls.Add(this.buttonBrowse2);
            this.Controls.Add(this.groupBoxFormat);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.listBoxLog);
            this.Text = "Синхронизация директорий";

            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}