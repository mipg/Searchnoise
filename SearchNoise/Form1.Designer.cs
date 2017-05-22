namespace SearchNoise
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SearchTerms = new System.Windows.Forms.Label();
            this.txt_NextSearch = new System.Windows.Forms.TextBox();
            this.btn_NextSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Searched = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TimeLeft = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Result1 = new System.Windows.Forms.Label();
            this.lbl_Result2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Result4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Result3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Result5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MinSleepTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_MaxSleepTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.outputDirTextbox = new System.Windows.Forms.TextBox();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.outputDirFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Terms:";
            // 
            // lbl_SearchTerms
            // 
            this.lbl_SearchTerms.AutoSize = true;
            this.lbl_SearchTerms.Location = new System.Drawing.Point(109, 95);
            this.lbl_SearchTerms.Name = "lbl_SearchTerms";
            this.lbl_SearchTerms.Size = new System.Drawing.Size(33, 13);
            this.lbl_SearchTerms.TabIndex = 1;
            this.lbl_SearchTerms.Text = "None";
            // 
            // txt_NextSearch
            // 
            this.txt_NextSearch.Location = new System.Drawing.Point(30, 36);
            this.txt_NextSearch.Name = "txt_NextSearch";
            this.txt_NextSearch.Size = new System.Drawing.Size(292, 20);
            this.txt_NextSearch.TabIndex = 2;
            // 
            // btn_NextSearch
            // 
            this.btn_NextSearch.Location = new System.Drawing.Point(342, 36);
            this.btn_NextSearch.Name = "btn_NextSearch";
            this.btn_NextSearch.Size = new System.Drawing.Size(127, 20);
            this.btn_NextSearch.TabIndex = 3;
            this.btn_NextSearch.Text = "Set Next Search";
            this.btn_NextSearch.UseVisualStyleBackColor = true;
            this.btn_NextSearch.Click += new System.EventHandler(this.btn_NextSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Searched:";
            // 
            // lbl_Searched
            // 
            this.lbl_Searched.AutoSize = true;
            this.lbl_Searched.Location = new System.Drawing.Point(108, 121);
            this.lbl_Searched.Name = "lbl_Searched";
            this.lbl_Searched.Size = new System.Drawing.Size(33, 13);
            this.lbl_Searched.TabIndex = 5;
            this.lbl_Searched.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time:";
            // 
            // lbl_TimeLeft
            // 
            this.lbl_TimeLeft.AutoSize = true;
            this.lbl_TimeLeft.Location = new System.Drawing.Point(387, 77);
            this.lbl_TimeLeft.Name = "lbl_TimeLeft";
            this.lbl_TimeLeft.Size = new System.Drawing.Size(13, 13);
            this.lbl_TimeLeft.TabIndex = 7;
            this.lbl_TimeLeft.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result1:";
            // 
            // lbl_Result1
            // 
            this.lbl_Result1.AutoSize = true;
            this.lbl_Result1.Location = new System.Drawing.Point(105, 159);
            this.lbl_Result1.Name = "lbl_Result1";
            this.lbl_Result1.Size = new System.Drawing.Size(16, 13);
            this.lbl_Result1.TabIndex = 9;
            this.lbl_Result1.Text = "...";
            // 
            // lbl_Result2
            // 
            this.lbl_Result2.AutoSize = true;
            this.lbl_Result2.Location = new System.Drawing.Point(105, 172);
            this.lbl_Result2.Name = "lbl_Result2";
            this.lbl_Result2.Size = new System.Drawing.Size(16, 13);
            this.lbl_Result2.TabIndex = 11;
            this.lbl_Result2.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Result2:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Result4
            // 
            this.lbl_Result4.AutoSize = true;
            this.lbl_Result4.Location = new System.Drawing.Point(105, 198);
            this.lbl_Result4.Name = "lbl_Result4";
            this.lbl_Result4.Size = new System.Drawing.Size(16, 13);
            this.lbl_Result4.TabIndex = 15;
            this.lbl_Result4.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Result4:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Result3
            // 
            this.lbl_Result3.AutoSize = true;
            this.lbl_Result3.Location = new System.Drawing.Point(105, 185);
            this.lbl_Result3.Name = "lbl_Result3";
            this.lbl_Result3.Size = new System.Drawing.Size(16, 13);
            this.lbl_Result3.TabIndex = 13;
            this.lbl_Result3.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Result3:";
            // 
            // lbl_Result5
            // 
            this.lbl_Result5.AutoSize = true;
            this.lbl_Result5.Location = new System.Drawing.Point(105, 211);
            this.lbl_Result5.Name = "lbl_Result5";
            this.lbl_Result5.Size = new System.Drawing.Size(16, 13);
            this.lbl_Result5.TabIndex = 17;
            this.lbl_Result5.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Result5:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Min Sleep Time (s)";
            // 
            // txt_MinSleepTime
            // 
            this.txt_MinSleepTime.Location = new System.Drawing.Point(390, 93);
            this.txt_MinSleepTime.Name = "txt_MinSleepTime";
            this.txt_MinSleepTime.Size = new System.Drawing.Size(72, 20);
            this.txt_MinSleepTime.TabIndex = 19;
            this.txt_MinSleepTime.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Max Sleep Time (s)";
            // 
            // txt_MaxSleepTime
            // 
            this.txt_MaxSleepTime.Location = new System.Drawing.Point(390, 119);
            this.txt_MaxSleepTime.Name = "txt_MaxSleepTime";
            this.txt_MaxSleepTime.Size = new System.Drawing.Size(72, 20);
            this.txt_MaxSleepTime.TabIndex = 21;
            this.txt_MaxSleepTime.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Output Directory:";
            // 
            // outputDirTextbox
            // 
            this.outputDirTextbox.Location = new System.Drawing.Point(123, 243);
            this.outputDirTextbox.Name = "outputDirTextbox";
            this.outputDirTextbox.Size = new System.Drawing.Size(199, 20);
            this.outputDirTextbox.TabIndex = 23;
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Location = new System.Drawing.Point(356, 241);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(25, 23);
            this.folderBrowserButton.TabIndex = 24;
            this.folderBrowserButton.Text = "...";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.folderBrowserButton_Click);
            // 
            // outputDirFolderBrowserDialog
            // 
            this.outputDirFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // openFolderButton
            // 
            this.openFolderButton.Image = global::SearchNoise.Properties.Resources.open_file_icon;
            this.openFolderButton.Location = new System.Drawing.Point(328, 241);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(25, 23);
            this.openFolderButton.TabIndex = 25;
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_NextSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.folderBrowserButton);
            this.Controls.Add(this.outputDirTextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_MaxSleepTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_MinSleepTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Result5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Result4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Result3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_Result2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Result1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_TimeLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Searched);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_NextSearch);
            this.Controls.Add(this.txt_NextSearch);
            this.Controls.Add(this.lbl_SearchTerms);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Searchnoise";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SearchTerms;
        private System.Windows.Forms.TextBox txt_NextSearch;
        private System.Windows.Forms.Button btn_NextSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Searched;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_TimeLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Result1;
        private System.Windows.Forms.Label lbl_Result2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Result4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Result3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Result5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MinSleepTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_MaxSleepTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox outputDirTextbox;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.FolderBrowserDialog outputDirFolderBrowserDialog;
        private System.Windows.Forms.Button openFolderButton;
    }
}

