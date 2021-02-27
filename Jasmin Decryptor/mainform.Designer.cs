namespace Jasmin_Decryptor
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.uppertext = new System.Windows.Forms.Label();
            this.verifyingkey = new System.Windows.Forms.Label();
            this.verifiedlabel = new System.Windows.Forms.Label();
            this.invalidkeylabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.finalreport = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.closebutton = new System.Windows.Forms.PictureBox();
            this.decryptbutton = new System.Windows.Forms.PictureBox();
            this.selecticon = new System.Windows.Forms.PictureBox();
            this.floraicon = new System.Windows.Forms.PictureBox();
            this.footer = new System.Windows.Forms.PictureBox();
            this.scanningicon = new System.Windows.Forms.PictureBox();
            this.invalidkey = new System.Windows.Forms.PictureBox();
            this.verifiedkey = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.notfound = new System.Windows.Forms.PictureBox();
            this.totalfileslabel = new System.Windows.Forms.Label();
            this.decryptedfileslabel = new System.Windows.Forms.Label();
            this.remainingfileslabel = new System.Windows.Forms.Label();
            this.loadingman = new System.Windows.Forms.PictureBox();
            this.loadingman2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.finalreport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selecticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floraicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanningicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verifiedkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notfound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingman2)).BeginInit();
            this.SuspendLayout();
            // 
            // uppertext
            // 
            this.uppertext.AutoSize = true;
            this.uppertext.Font = new System.Drawing.Font("Microsoft Tai Le", 10.25F);
            this.uppertext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uppertext.Location = new System.Drawing.Point(81, 190);
            this.uppertext.Name = "uppertext";
            this.uppertext.Size = new System.Drawing.Size(359, 18);
            this.uppertext.TabIndex = 5;
            this.uppertext.Text = "Please select the password file to start decryption process";
            // 
            // verifyingkey
            // 
            this.verifyingkey.AutoSize = true;
            this.verifyingkey.BackColor = System.Drawing.Color.Transparent;
            this.verifyingkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.verifyingkey.Location = new System.Drawing.Point(227, 355);
            this.verifyingkey.Name = "verifyingkey";
            this.verifyingkey.Size = new System.Drawing.Size(79, 13);
            this.verifyingkey.TabIndex = 11;
            this.verifyingkey.Text = "Verifying key....";
            this.verifyingkey.Visible = false;
            // 
            // verifiedlabel
            // 
            this.verifiedlabel.AutoSize = true;
            this.verifiedlabel.BackColor = System.Drawing.Color.Transparent;
            this.verifiedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.verifiedlabel.Location = new System.Drawing.Point(184, 355);
            this.verifiedlabel.Name = "verifiedlabel";
            this.verifiedlabel.Size = new System.Drawing.Size(138, 16);
            this.verifiedlabel.TabIndex = 15;
            this.verifiedlabel.Text = "Click to decrypt button";
            this.verifiedlabel.Visible = false;
            // 
            // invalidkeylabel
            // 
            this.invalidkeylabel.AutoSize = true;
            this.invalidkeylabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidkeylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.invalidkeylabel.Location = new System.Drawing.Point(175, 356);
            this.invalidkeylabel.Name = "invalidkeylabel";
            this.invalidkeylabel.Size = new System.Drawing.Size(168, 16);
            this.invalidkeylabel.TabIndex = 17;
            this.invalidkeylabel.Text = "Please select the vaild key";
            this.invalidkeylabel.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 346);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(411, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // finalreport
            // 
            this.finalreport.Image = global::Jasmin_Decryptor.Properties.Resources.report;
            this.finalreport.Location = new System.Drawing.Point(24, 150);
            this.finalreport.Name = "finalreport";
            this.finalreport.Size = new System.Drawing.Size(458, 221);
            this.finalreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finalreport.TabIndex = 21;
            this.finalreport.TabStop = false;
            this.finalreport.Visible = false;
            // 
            // header
            // 
            this.header.Image = global::Jasmin_Decryptor.Properties.Resources.header3;
            this.header.Location = new System.Drawing.Point(0, -1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(512, 174);
            this.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.header.TabIndex = 0;
            this.header.TabStop = false;
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // minimize
            // 
            this.minimize.Image = global::Jasmin_Decryptor.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(462, 7);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(20, 16);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimize.TabIndex = 13;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // closebutton
            // 
            this.closebutton.Image = global::Jasmin_Decryptor.Properties.Resources.close_button;
            this.closebutton.Location = new System.Drawing.Point(483, 3);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(21, 21);
            this.closebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closebutton.TabIndex = 12;
            this.closebutton.TabStop = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // decryptbutton
            // 
            this.decryptbutton.Image = global::Jasmin_Decryptor.Properties.Resources.buttuon3;
            this.decryptbutton.Location = new System.Drawing.Point(181, 391);
            this.decryptbutton.Name = "decryptbutton";
            this.decryptbutton.Size = new System.Drawing.Size(150, 42);
            this.decryptbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.decryptbutton.TabIndex = 7;
            this.decryptbutton.TabStop = false;
            this.decryptbutton.Click += new System.EventHandler(this.decryptbutton_Click);
            // 
            // selecticon
            // 
            this.selecticon.Image = global::Jasmin_Decryptor.Properties.Resources.buttuon4;
            this.selecticon.Location = new System.Drawing.Point(230, 325);
            this.selecticon.Name = "selecticon";
            this.selecticon.Size = new System.Drawing.Size(62, 26);
            this.selecticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selecticon.TabIndex = 9;
            this.selecticon.TabStop = false;
            this.selecticon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // floraicon
            // 
            this.floraicon.Image = global::Jasmin_Decryptor.Properties.Resources.flora_BLACK;
            this.floraicon.Location = new System.Drawing.Point(207, 219);
            this.floraicon.Name = "floraicon";
            this.floraicon.Size = new System.Drawing.Size(113, 97);
            this.floraicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.floraicon.TabIndex = 8;
            this.floraicon.TabStop = false;
            // 
            // footer
            // 
            this.footer.Image = global::Jasmin_Decryptor.Properties.Resources.fotter;
            this.footer.Location = new System.Drawing.Point(-3, 449);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(563, 168);
            this.footer.TabIndex = 1;
            this.footer.TabStop = false;
            // 
            // scanningicon
            // 
            this.scanningicon.Image = global::Jasmin_Decryptor.Properties.Resources.icon;
            this.scanningicon.Location = new System.Drawing.Point(60, 119);
            this.scanningicon.Name = "scanningicon";
            this.scanningicon.Size = new System.Drawing.Size(382, 237);
            this.scanningicon.TabIndex = 10;
            this.scanningicon.TabStop = false;
            this.scanningicon.Visible = false;
            // 
            // invalidkey
            // 
            this.invalidkey.Image = global::Jasmin_Decryptor.Properties.Resources.invaild_key;
            this.invalidkey.Location = new System.Drawing.Point(200, 194);
            this.invalidkey.Name = "invalidkey";
            this.invalidkey.Size = new System.Drawing.Size(132, 160);
            this.invalidkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.invalidkey.TabIndex = 16;
            this.invalidkey.TabStop = false;
            this.invalidkey.Visible = false;
            // 
            // verifiedkey
            // 
            this.verifiedkey.Image = global::Jasmin_Decryptor.Properties.Resources.verified;
            this.verifiedkey.Location = new System.Drawing.Point(200, 192);
            this.verifiedkey.Name = "verifiedkey";
            this.verifiedkey.Size = new System.Drawing.Size(132, 160);
            this.verifiedkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verifiedkey.TabIndex = 14;
            this.verifiedkey.TabStop = false;
            this.verifiedkey.Visible = false;
            // 
            // line
            // 
            this.line.Image = global::Jasmin_Decryptor.Properties.Resources.line;
            this.line.Location = new System.Drawing.Point(-34, 334);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(644, 91);
            this.line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.line.TabIndex = 6;
            this.line.TabStop = false;
            // 
            // notfound
            // 
            this.notfound.Image = global::Jasmin_Decryptor.Properties.Resources.not_found;
            this.notfound.Location = new System.Drawing.Point(87, 170);
            this.notfound.Name = "notfound";
            this.notfound.Size = new System.Drawing.Size(358, 202);
            this.notfound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notfound.TabIndex = 18;
            this.notfound.TabStop = false;
            this.notfound.Visible = false;
            // 
            // totalfileslabel
            // 
            this.totalfileslabel.AutoSize = true;
            this.totalfileslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalfileslabel.Location = new System.Drawing.Point(64, 263);
            this.totalfileslabel.Name = "totalfileslabel";
            this.totalfileslabel.Size = new System.Drawing.Size(97, 39);
            this.totalfileslabel.TabIndex = 22;
            this.totalfileslabel.Text = "1500";
            this.totalfileslabel.Visible = false;
            // 
            // decryptedfileslabel
            // 
            this.decryptedfileslabel.AutoSize = true;
            this.decryptedfileslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedfileslabel.Location = new System.Drawing.Point(362, 265);
            this.decryptedfileslabel.Name = "decryptedfileslabel";
            this.decryptedfileslabel.Size = new System.Drawing.Size(97, 39);
            this.decryptedfileslabel.TabIndex = 23;
            this.decryptedfileslabel.Text = "1500";
            this.decryptedfileslabel.Visible = false;
            // 
            // remainingfileslabel
            // 
            this.remainingfileslabel.AutoSize = true;
            this.remainingfileslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.remainingfileslabel.ForeColor = System.Drawing.Color.Red;
            this.remainingfileslabel.Location = new System.Drawing.Point(258, 329);
            this.remainingfileslabel.Name = "remainingfileslabel";
            this.remainingfileslabel.Size = new System.Drawing.Size(35, 13);
            this.remainingfileslabel.TabIndex = 24;
            this.remainingfileslabel.Text = "1500";
            this.remainingfileslabel.Visible = false;
            // 
            // loadingman
            // 
            this.loadingman.Image = global::Jasmin_Decryptor.Properties.Resources.loading;
            this.loadingman.Location = new System.Drawing.Point(152, 165);
            this.loadingman.Name = "loadingman";
            this.loadingman.Size = new System.Drawing.Size(191, 192);
            this.loadingman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingman.TabIndex = 20;
            this.loadingman.TabStop = false;
            this.loadingman.Visible = false;
            // 
            // loadingman2
            // 
            this.loadingman2.Image = global::Jasmin_Decryptor.Properties.Resources.loading;
            this.loadingman2.Location = new System.Drawing.Point(155, 175);
            this.loadingman2.Name = "loadingman2";
            this.loadingman2.Size = new System.Drawing.Size(191, 181);
            this.loadingman2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingman2.TabIndex = 25;
            this.loadingman2.TabStop = false;
            this.loadingman2.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(511, 491);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.loadingman2);
            this.Controls.Add(this.remainingfileslabel);
            this.Controls.Add(this.decryptedfileslabel);
            this.Controls.Add(this.totalfileslabel);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.header);
            this.Controls.Add(this.finalreport);
            this.Controls.Add(this.invalidkeylabel);
            this.Controls.Add(this.verifiedlabel);
            this.Controls.Add(this.verifyingkey);
            this.Controls.Add(this.decryptbutton);
            this.Controls.Add(this.selecticon);
            this.Controls.Add(this.floraicon);
            this.Controls.Add(this.uppertext);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.scanningicon);
            this.Controls.Add(this.invalidkey);
            this.Controls.Add(this.verifiedkey);
            this.Controls.Add(this.loadingman);
            this.Controls.Add(this.notfound);
            this.Controls.Add(this.line);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.finalreport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selecticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floraicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanningicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verifiedkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notfound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingman2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox footer;
        private System.Windows.Forms.Label uppertext;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.PictureBox decryptbutton;
        private System.Windows.Forms.PictureBox floraicon;
        private System.Windows.Forms.PictureBox selecticon;
        private System.Windows.Forms.PictureBox scanningicon;
        private System.Windows.Forms.Label verifyingkey;
        private System.Windows.Forms.PictureBox closebutton;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox verifiedkey;
        private System.Windows.Forms.Label verifiedlabel;
        private System.Windows.Forms.PictureBox invalidkey;
        private System.Windows.Forms.Label invalidkeylabel;
        private System.Windows.Forms.PictureBox notfound;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox finalreport;
        private System.Windows.Forms.Label totalfileslabel;
        private System.Windows.Forms.Label decryptedfileslabel;
        private System.Windows.Forms.Label remainingfileslabel;
        private System.Windows.Forms.PictureBox loadingman;
        private System.Windows.Forms.PictureBox loadingman2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

