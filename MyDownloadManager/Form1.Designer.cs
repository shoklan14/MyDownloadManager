namespace MyDownloadManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxPB = new System.Windows.Forms.PictureBox();
            this.btnBrows = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lbltransferrate = new System.Windows.Forms.Label();
            this.lbldownloaded = new System.Windows.Forms.Label();
            this.lblfilesize = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcurrenttransferrate = new System.Windows.Forms.Label();
            this.lblcurrentfilesize = new System.Windows.Forms.Label();
            this.lblcurrentdownloaded = new System.Windows.Forms.Label();
            this.lblcurrentstatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblcurrentstatus);
            this.panel1.Controls.Add(this.lblcurrentdownloaded);
            this.panel1.Controls.Add(this.lblcurrentfilesize);
            this.panel1.Controls.Add(this.lblcurrenttransferrate);
            this.panel1.Controls.Add(this.picBoxPB);
            this.panel1.Controls.Add(this.btnBrows);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPauseResume);
            this.panel1.Controls.Add(this.lblURL);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.lbltransferrate);
            this.panel1.Controls.Add(this.lbldownloaded);
            this.panel1.Controls.Add(this.lblfilesize);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 269);
            this.panel1.TabIndex = 1;
            // 
            // picBoxPB
            // 
            this.picBoxPB.Location = new System.Drawing.Point(15, 198);
            this.picBoxPB.Name = "picBoxPB";
            this.picBoxPB.Size = new System.Drawing.Size(519, 30);
            this.picBoxPB.TabIndex = 14;
            this.picBoxPB.TabStop = false;
            // 
            // btnBrows
            // 
            this.btnBrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrows.Location = new System.Drawing.Point(507, 41);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(33, 23);
            this.btnBrows.TabIndex = 13;
            this.btnBrows.Text = "...";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(459, 234);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Cancel";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Location = new System.Drawing.Point(378, 234);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(75, 23);
            this.btnPauseResume.TabIndex = 11;
            this.btnPauseResume.Text = "Pause";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(504, 67);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(35, 13);
            this.lblURL.TabIndex = 10;
            this.lblURL.Text = "label3";
            this.lblURL.Visible = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(297, 234);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 9;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lbltransferrate
            // 
            this.lbltransferrate.AutoSize = true;
            this.lbltransferrate.Location = new System.Drawing.Point(12, 171);
            this.lbltransferrate.Name = "lbltransferrate";
            this.lbltransferrate.Size = new System.Drawing.Size(70, 13);
            this.lbltransferrate.TabIndex = 7;
            this.lbltransferrate.Text = "Transfer rate:";
            // 
            // lbldownloaded
            // 
            this.lbldownloaded.AutoSize = true;
            this.lbldownloaded.Location = new System.Drawing.Point(12, 146);
            this.lbldownloaded.Name = "lbldownloaded";
            this.lbldownloaded.Size = new System.Drawing.Size(70, 13);
            this.lbldownloaded.TabIndex = 6;
            this.lbldownloaded.Text = "Downloaded:";
            // 
            // lblfilesize
            // 
            this.lblfilesize.AutoSize = true;
            this.lblfilesize.Location = new System.Drawing.Point(12, 123);
            this.lblfilesize.Name = "lblfilesize";
            this.lblfilesize.Size = new System.Drawing.Size(47, 13);
            this.lblfilesize.TabIndex = 5;
            this.lblfilesize.Text = "File size:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 97);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(77, 44);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(424, 20);
            this.txtPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(77, 11);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(463, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.MouseHover += new System.EventHandler(this.txtURL_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File URL";
            // 
            // lblcurrenttransferrate
            // 
            this.lblcurrenttransferrate.AutoSize = true;
            this.lblcurrenttransferrate.Location = new System.Drawing.Point(177, 171);
            this.lblcurrenttransferrate.Name = "lblcurrenttransferrate";
            this.lblcurrenttransferrate.Size = new System.Drawing.Size(10, 13);
            this.lblcurrenttransferrate.TabIndex = 15;
            this.lblcurrenttransferrate.Text = "-";
            // 
            // lblcurrentfilesize
            // 
            this.lblcurrentfilesize.AutoSize = true;
            this.lblcurrentfilesize.Location = new System.Drawing.Point(177, 123);
            this.lblcurrentfilesize.Name = "lblcurrentfilesize";
            this.lblcurrentfilesize.Size = new System.Drawing.Size(10, 13);
            this.lblcurrentfilesize.TabIndex = 16;
            this.lblcurrentfilesize.Text = "-";
            // 
            // lblcurrentdownloaded
            // 
            this.lblcurrentdownloaded.AutoSize = true;
            this.lblcurrentdownloaded.Location = new System.Drawing.Point(177, 146);
            this.lblcurrentdownloaded.Name = "lblcurrentdownloaded";
            this.lblcurrentdownloaded.Size = new System.Drawing.Size(10, 13);
            this.lblcurrentdownloaded.TabIndex = 17;
            this.lblcurrentdownloaded.Text = "-";
            // 
            // lblcurrentstatus
            // 
            this.lblcurrentstatus.AutoSize = true;
            this.lblcurrentstatus.Location = new System.Drawing.Point(177, 97);
            this.lblcurrentstatus.Name = "lblcurrentstatus";
            this.lblcurrentstatus.Size = new System.Drawing.Size(10, 13);
            this.lblcurrentstatus.TabIndex = 18;
            this.lblcurrentstatus.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyDownloadManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltransferrate;
        private System.Windows.Forms.Label lbldownloaded;
        private System.Windows.Forms.Label lblfilesize;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.PictureBox picBoxPB;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblcurrentstatus;
        private System.Windows.Forms.Label lblcurrentdownloaded;
        private System.Windows.Forms.Label lblcurrentfilesize;
        private System.Windows.Forms.Label lblcurrenttransferrate;
    }
}

