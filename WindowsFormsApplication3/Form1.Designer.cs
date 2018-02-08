namespace WindowsFormsApplication3
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
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonGroup4 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonLinkLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lbvoobconf = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chkhd = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbvoob = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbconv = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbver2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbver = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.convert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.verify = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).BeginInit();
            this.kryptonGroup4.Panel.SuspendLayout();
            this.kryptonGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new System.Drawing.Point(58, 110);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new System.Drawing.Size(74, 24);
            kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kryptonLabel2.TabIndex = 22;
            kryptonLabel2.Values.Text = "STEP 1";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.SparkleBlue;
            // 
            // kryptonGroup4
            // 
            this.kryptonGroup4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup4.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonGroup4.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroup4.Name = "kryptonGroup4";
            // 
            // kryptonGroup4.Panel
            // 
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonLinkLabel1);
            this.kryptonGroup4.Panel.Controls.Add(this.lbvoobconf);
            this.kryptonGroup4.Panel.Controls.Add(this.chkhd);
            this.kryptonGroup4.Panel.Controls.Add(this.pictureBox2);
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonButton2);
            this.kryptonGroup4.Panel.Controls.Add(this.lbvoob);
            this.kryptonGroup4.Panel.Controls.Add(this.lbconv);
            this.kryptonGroup4.Panel.Controls.Add(this.lbver2);
            this.kryptonGroup4.Panel.Controls.Add(this.lbver);
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonGroup3);
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonGroup2);
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonGroup1);
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroup4.Panel.Controls.Add(kryptonLabel2);
            this.kryptonGroup4.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroup4.Panel.Controls.Add(this.progressBar1);
            this.kryptonGroup4.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroup4_Panel_Paint);
            this.kryptonGroup4.Size = new System.Drawing.Size(650, 453);
            this.kryptonGroup4.TabIndex = 16;
            // 
            // kryptonLinkLabel1
            // 
            this.kryptonLinkLabel1.Location = new System.Drawing.Point(3, 424);
            this.kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            this.kryptonLinkLabel1.Size = new System.Drawing.Size(99, 24);
            this.kryptonLinkLabel1.TabIndex = 37;
            this.kryptonLinkLabel1.Values.Text = "By GregStein";
            this.kryptonLinkLabel1.LinkClicked += new System.EventHandler(this.kryptonLinkLabel1_LinkClicked);
            // 
            // lbvoobconf
            // 
            this.lbvoobconf.Location = new System.Drawing.Point(410, 309);
            this.lbvoobconf.Name = "lbvoobconf";
            this.lbvoobconf.Size = new System.Drawing.Size(6, 2);
            this.lbvoobconf.StateCommon.ShortText.Color1 = System.Drawing.Color.Lime;
            this.lbvoobconf.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvoobconf.TabIndex = 36;
            this.lbvoobconf.Values.Text = "";
            // 
            // chkhd
            // 
            this.chkhd.Location = new System.Drawing.Point(408, 125);
            this.chkhd.Name = "chkhd";
            this.chkhd.Size = new System.Drawing.Size(237, 23);
            this.chkhd.StateCommon.ShortText.Color1 = System.Drawing.Color.Yellow;
            this.chkhd.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkhd.TabIndex = 35;
            this.chkhd.Values.Text = "Let\'s check if you own the HD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.tcbg1;
            this.pictureBox2.Image = global::WindowsFormsApplication3.Properties.Resources.hd_to_tc1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(500, 390);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton2.Size = new System.Drawing.Size(110, 50);
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 33;
            this.kryptonButton2.Values.Text = "EXIT";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // lbvoob
            // 
            this.lbvoob.Location = new System.Drawing.Point(410, 298);
            this.lbvoob.Name = "lbvoob";
            this.lbvoob.Size = new System.Drawing.Size(6, 2);
            this.lbvoob.StateCommon.ShortText.Color1 = System.Drawing.Color.Lime;
            this.lbvoob.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvoob.TabIndex = 30;
            this.lbvoob.Values.Text = "";
            // 
            // lbconv
            // 
            this.lbconv.Location = new System.Drawing.Point(408, 231);
            this.lbconv.Name = "lbconv";
            this.lbconv.Size = new System.Drawing.Size(6, 2);
            this.lbconv.StateCommon.ShortText.Color1 = System.Drawing.Color.Lime;
            this.lbconv.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconv.TabIndex = 29;
            this.lbconv.Values.Text = "";
            // 
            // lbver2
            // 
            this.lbver2.Location = new System.Drawing.Point(408, 125);
            this.lbver2.Name = "lbver2";
            this.lbver2.Size = new System.Drawing.Size(6, 2);
            this.lbver2.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbver2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbver2.TabIndex = 28;
            this.lbver2.Values.Text = "";
            // 
            // lbver
            // 
            this.lbver.Location = new System.Drawing.Point(408, 125);
            this.lbver.Name = "lbver";
            this.lbver.Size = new System.Drawing.Size(6, 2);
            this.lbver.StateCommon.ShortText.Color1 = System.Drawing.Color.Lime;
            this.lbver.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbver.TabIndex = 28;
            this.lbver.Values.Text = "";
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(193, 284);
            this.kryptonGroup3.Name = "kryptonGroup3";
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroup3.Size = new System.Drawing.Size(211, 60);
            this.kryptonGroup3.TabIndex = 27;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(12, 13);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(184, 36);
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 9;
            this.kryptonButton1.Values.Text = "Auto Config Voobly";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Location = new System.Drawing.Point(193, 212);
            this.kryptonGroup2.Name = "kryptonGroup2";
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.convert);
            this.kryptonGroup2.Size = new System.Drawing.Size(209, 66);
            this.kryptonGroup2.TabIndex = 26;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(35, 18);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(127, 34);
            this.convert.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.TabIndex = 8;
            this.convert.Values.Text = "Convert !";
            this.convert.Click += new System.EventHandler(this.convert_Click_1);
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(191, 110);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.verify);
            this.kryptonGroup1.Size = new System.Drawing.Size(211, 64);
            this.kryptonGroup1.TabIndex = 25;
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(51, 14);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(94, 34);
            this.verify.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify.TabIndex = 7;
            this.verify.Values.ExtraText = "Verify";
            this.verify.Values.Text = "";
            this.verify.Click += new System.EventHandler(this.verify_Click_1);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(56, 284);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(74, 24);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 24;
            this.kryptonLabel4.Values.Text = "STEP 3";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(56, 212);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(74, 24);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 23;
            this.kryptonLabel3.Values.Text = "STEP 2";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(126, 11);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(519, 63);
            this.kryptonLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.SystemColors.Info;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 21;
            this.kryptonLabel1.Values.Text = "This tool will convert Age of Empires II HD to The Conquerors\r\nand create a seper" +
    "ate installation folder. You can also auto configure\r\nVoobly to start playing mu" +
    "ltiplayer instantly. GLHF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(193, 180);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 26);
            this.progressBar1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 453);
            this.Controls.Add(this.kryptonGroup4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HD To TC Conversion Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).EndInit();
            this.kryptonGroup4.Panel.ResumeLayout(false);
            this.kryptonGroup4.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).EndInit();
            this.kryptonGroup4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup4;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton convert;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton verify;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbvoob;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbconv;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbver;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbver2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel chkhd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbvoobconf;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
    }
}

