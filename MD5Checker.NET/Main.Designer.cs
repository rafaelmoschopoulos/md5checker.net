namespace MD5Checker.NET
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.BrowseFile = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.UsersHash = new System.Windows.Forms.TextBox();
            this.Hash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Calculate);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.ProgressBar1);
            this.GroupBox1.Controls.Add(this.BrowseFile);
            this.GroupBox1.Controls.Add(this.FilePath);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(406, 86);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Find the MD5 hash";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(306, 45);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(89, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Progress:";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(63, 45);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(237, 23);
            this.ProgressBar1.TabIndex = 4;
            // 
            // BrowseFile
            // 
            this.BrowseFile.Location = new System.Drawing.Point(306, 17);
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.Size = new System.Drawing.Size(89, 23);
            this.BrowseFile.TabIndex = 3;
            this.BrowseFile.Text = "Browse";
            this.BrowseFile.UseVisualStyleBackColor = true;
            this.BrowseFile.Click += new System.EventHandler(this.BrowseFile_Click);
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(63, 19);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(237, 20);
            this.FilePath.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Input file:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Exit);
            this.GroupBox2.Controls.Add(this.Check);
            this.GroupBox2.Controls.Add(this.UsersHash);
            this.GroupBox2.Controls.Add(this.Hash);
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Controls.Add(this.label3);
            this.GroupBox2.Location = new System.Drawing.Point(12, 104);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(406, 109);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Integrity Verification";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(9, 71);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(294, 71);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(101, 23);
            this.Check.TabIndex = 4;
            this.Check.Text = "Compare hashes";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // UsersHash
            // 
            this.UsersHash.Location = new System.Drawing.Point(147, 45);
            this.UsersHash.Name = "UsersHash";
            this.UsersHash.Size = new System.Drawing.Size(248, 20);
            this.UsersHash.TabIndex = 3;
            // 
            // Hash
            // 
            this.Hash.Location = new System.Drawing.Point(147, 19);
            this.Hash.Name = "Hash";
            this.Hash.ReadOnly = true;
            this.Hash.Size = new System.Drawing.Size(248, 20);
            this.Hash.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hash for comparison:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input file\'s calculated hash:";
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.WorkerReportsProgress = true;
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.BackgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 224);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "MD5Checker.NET";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Button BrowseFile;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox UsersHash;
        private System.Windows.Forms.TextBox Hash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker BackgroundWorker1;
    }
}

