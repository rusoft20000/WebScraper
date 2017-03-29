namespace WebScraper
{
    partial class StartDialog
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
            this.projectURL = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pathDB = new System.Windows.Forms.TextBox();
            this.SelectDBfile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.StartScraping = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedDriver = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // projectURL
            // 
            this.projectURL.FormattingEnabled = true;
            this.projectURL.Location = new System.Drawing.Point(12, 35);
            this.projectURL.Name = "projectURL";
            this.projectURL.ScrollAlwaysVisible = true;
            this.projectURL.Size = new System.Drawing.Size(587, 121);
            this.projectURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROJECT:";
            // 
            // pathDB
            // 
            this.pathDB.Location = new System.Drawing.Point(96, 9);
            this.pathDB.Name = "pathDB";
            this.pathDB.Size = new System.Drawing.Size(422, 20);
            this.pathDB.TabIndex = 2;
            // 
            // SelectDBfile
            // 
            this.SelectDBfile.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectDBfile.Location = new System.Drawing.Point(524, 6);
            this.SelectDBfile.Name = "SelectDBfile";
            this.SelectDBfile.Size = new System.Drawing.Size(75, 23);
            this.SelectDBfile.TabIndex = 3;
            this.SelectDBfile.Text = "DB File";
            this.SelectDBfile.UseVisualStyleBackColor = true;
            this.SelectDBfile.Click += new System.EventHandler(this.SelectDBfile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // StartScraping
            // 
            this.StartScraping.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartScraping.Location = new System.Drawing.Point(12, 251);
            this.StartScraping.Name = "StartScraping";
            this.StartScraping.Size = new System.Drawing.Size(587, 39);
            this.StartScraping.TabIndex = 4;
            this.StartScraping.Text = "Start Scraping";
            this.StartScraping.UseVisualStyleBackColor = true;
            this.StartScraping.Click += new System.EventHandler(this.StartScraping_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Using driver:";
            // 
            // SelectedDriver
            // 
            this.SelectedDriver.FormattingEnabled = true;
            this.SelectedDriver.Items.AddRange(new object[] {
            "Chrome Driver",
            "PhantomJS Driver"});
            this.SelectedDriver.Location = new System.Drawing.Point(127, 162);
            this.SelectedDriver.Name = "SelectedDriver";
            this.SelectedDriver.Size = new System.Drawing.Size(472, 21);
            this.SelectedDriver.TabIndex = 5;
            // 
            // StartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedDriver);
            this.Controls.Add(this.StartScraping);
            this.Controls.Add(this.SelectDBfile);
            this.Controls.Add(this.pathDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectURL);
            this.Name = "StartDialog";
            this.Text = "Start Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox projectURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathDB;
        private System.Windows.Forms.Button SelectDBfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button StartScraping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectedDriver;
       
    }
}