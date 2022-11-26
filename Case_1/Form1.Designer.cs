namespace Case_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drawHexagon = new System.Windows.Forms.Button();
            this.drawTriangle = new System.Windows.Forms.Button();
            this.drawCircle = new System.Windows.Forms.Button();
            this.drawSquare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorWhite = new System.Windows.Forms.Button();
            this.colorBrown = new System.Windows.Forms.Button();
            this.colorPurple = new System.Windows.Forms.Button();
            this.colorYellow = new System.Windows.Forms.Button();
            this.colorBlack = new System.Windows.Forms.Button();
            this.colorOrange = new System.Windows.Forms.Button();
            this.colorGreen = new System.Windows.Forms.Button();
            this.colorBlue = new System.Windows.Forms.Button();
            this.colorRed = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.penBttn = new System.Windows.Forms.Button();
            this.recycleBinBttn = new System.Windows.Forms.Button();
            this.mouseHandBttn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveFolderBttn = new System.Windows.Forms.Button();
            this.openFolderBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1019, 594);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.drawHexagon);
            this.groupBox1.Controls.Add(this.drawTriangle);
            this.groupBox1.Controls.Add(this.drawCircle);
            this.groupBox1.Controls.Add(this.drawSquare);
            this.groupBox1.Location = new System.Drawing.Point(1037, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÇİZİM ŞEKLİ";
            // 
            // drawHexagon
            // 
            this.drawHexagon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawHexagon.BackgroundImage")));
            this.drawHexagon.Location = new System.Drawing.Point(102, 94);
            this.drawHexagon.Name = "drawHexagon";
            this.drawHexagon.Size = new System.Drawing.Size(89, 69);
            this.drawHexagon.TabIndex = 3;
            this.drawHexagon.UseVisualStyleBackColor = true;
            this.drawHexagon.Click += new System.EventHandler(this.drawHexagon_Click);
            // 
            // drawTriangle
            // 
            this.drawTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawTriangle.BackgroundImage")));
            this.drawTriangle.Location = new System.Drawing.Point(6, 94);
            this.drawTriangle.Name = "drawTriangle";
            this.drawTriangle.Size = new System.Drawing.Size(89, 69);
            this.drawTriangle.TabIndex = 2;
            this.drawTriangle.UseVisualStyleBackColor = true;
            this.drawTriangle.Click += new System.EventHandler(this.drawTriangle_Click);
            // 
            // drawCircle
            // 
            this.drawCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawCircle.BackgroundImage")));
            this.drawCircle.Location = new System.Drawing.Point(102, 19);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(90, 69);
            this.drawCircle.TabIndex = 1;
            this.drawCircle.UseVisualStyleBackColor = true;
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // drawSquare
            // 
            this.drawSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawSquare.BackgroundImage")));
            this.drawSquare.Location = new System.Drawing.Point(6, 19);
            this.drawSquare.Name = "drawSquare";
            this.drawSquare.Size = new System.Drawing.Size(89, 69);
            this.drawSquare.TabIndex = 0;
            this.drawSquare.UseVisualStyleBackColor = true;
            this.drawSquare.Click += new System.EventHandler(this.drawSquare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.colorWhite);
            this.groupBox2.Controls.Add(this.colorBrown);
            this.groupBox2.Controls.Add(this.colorPurple);
            this.groupBox2.Controls.Add(this.colorYellow);
            this.groupBox2.Controls.Add(this.colorBlack);
            this.groupBox2.Controls.Add(this.colorOrange);
            this.groupBox2.Controls.Add(this.colorGreen);
            this.groupBox2.Controls.Add(this.colorBlue);
            this.groupBox2.Controls.Add(this.colorRed);
            this.groupBox2.Location = new System.Drawing.Point(1037, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 190);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RENK SEÇİMİ";
            // 
            // colorWhite
            // 
            this.colorWhite.Location = new System.Drawing.Point(136, 131);
            this.colorWhite.Name = "colorWhite";
            this.colorWhite.Size = new System.Drawing.Size(59, 50);
            this.colorWhite.TabIndex = 8;
            this.colorWhite.UseVisualStyleBackColor = true;
            // 
            // colorBrown
            // 
            this.colorBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colorBrown.Location = new System.Drawing.Point(71, 131);
            this.colorBrown.Name = "colorBrown";
            this.colorBrown.Size = new System.Drawing.Size(59, 50);
            this.colorBrown.TabIndex = 7;
            this.colorBrown.UseVisualStyleBackColor = false;
            // 
            // colorPurple
            // 
            this.colorPurple.BackColor = System.Drawing.Color.Purple;
            this.colorPurple.Location = new System.Drawing.Point(6, 131);
            this.colorPurple.Name = "colorPurple";
            this.colorPurple.Size = new System.Drawing.Size(59, 50);
            this.colorPurple.TabIndex = 6;
            this.colorPurple.UseVisualStyleBackColor = false;
            // 
            // colorYellow
            // 
            this.colorYellow.BackColor = System.Drawing.Color.Yellow;
            this.colorYellow.Location = new System.Drawing.Point(136, 75);
            this.colorYellow.Name = "colorYellow";
            this.colorYellow.Size = new System.Drawing.Size(59, 50);
            this.colorYellow.TabIndex = 5;
            this.colorYellow.UseVisualStyleBackColor = false;
            // 
            // colorBlack
            // 
            this.colorBlack.BackColor = System.Drawing.Color.Black;
            this.colorBlack.Location = new System.Drawing.Point(71, 75);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(59, 50);
            this.colorBlack.TabIndex = 4;
            this.colorBlack.UseVisualStyleBackColor = false;
            // 
            // colorOrange
            // 
            this.colorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorOrange.Location = new System.Drawing.Point(6, 75);
            this.colorOrange.Name = "colorOrange";
            this.colorOrange.Size = new System.Drawing.Size(59, 50);
            this.colorOrange.TabIndex = 3;
            this.colorOrange.UseVisualStyleBackColor = false;
            // 
            // colorGreen
            // 
            this.colorGreen.BackColor = System.Drawing.Color.Green;
            this.colorGreen.Location = new System.Drawing.Point(136, 19);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(59, 50);
            this.colorGreen.TabIndex = 2;
            this.colorGreen.UseVisualStyleBackColor = false;
            // 
            // colorBlue
            // 
            this.colorBlue.BackColor = System.Drawing.Color.Blue;
            this.colorBlue.Location = new System.Drawing.Point(71, 19);
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(59, 50);
            this.colorBlue.TabIndex = 1;
            this.colorBlue.UseVisualStyleBackColor = false;
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.Red;
            this.colorRed.Location = new System.Drawing.Point(6, 19);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(59, 50);
            this.colorRed.TabIndex = 0;
            this.colorRed.UseVisualStyleBackColor = false;
            this.colorRed.Click += new System.EventHandler(this.colorRed_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.penBttn);
            this.groupBox3.Controls.Add(this.recycleBinBttn);
            this.groupBox3.Controls.Add(this.mouseHandBttn);
            this.groupBox3.Location = new System.Drawing.Point(1037, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 78);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ŞEKİL İŞLEMLERİ";
            // 
            // penBttn
            // 
            this.penBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("penBttn.BackgroundImage")));
            this.penBttn.Location = new System.Drawing.Point(136, 19);
            this.penBttn.Name = "penBttn";
            this.penBttn.Size = new System.Drawing.Size(59, 51);
            this.penBttn.TabIndex = 10;
            this.penBttn.UseVisualStyleBackColor = false;
            this.penBttn.Click += new System.EventHandler(this.penBttn_Click);
            // 
            // recycleBinBttn
            // 
            this.recycleBinBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recycleBinBttn.BackgroundImage")));
            this.recycleBinBttn.Location = new System.Drawing.Point(71, 19);
            this.recycleBinBttn.Name = "recycleBinBttn";
            this.recycleBinBttn.Size = new System.Drawing.Size(59, 51);
            this.recycleBinBttn.TabIndex = 1;
            this.recycleBinBttn.UseVisualStyleBackColor = false;
            // 
            // mouseHandBttn
            // 
            this.mouseHandBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mouseHandBttn.BackgroundImage")));
            this.mouseHandBttn.Location = new System.Drawing.Point(6, 19);
            this.mouseHandBttn.Name = "mouseHandBttn";
            this.mouseHandBttn.Size = new System.Drawing.Size(59, 51);
            this.mouseHandBttn.TabIndex = 0;
            this.mouseHandBttn.UseVisualStyleBackColor = false;
            this.mouseHandBttn.Click += new System.EventHandler(this.mouseHandBttn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.saveFolderBttn);
            this.groupBox4.Controls.Add(this.openFolderBttn);
            this.groupBox4.Location = new System.Drawing.Point(1037, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 78);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DOSYA İŞLEMLERİ";
            // 
            // saveFolderBttn
            // 
            this.saveFolderBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveFolderBttn.BackgroundImage")));
            this.saveFolderBttn.Location = new System.Drawing.Point(71, 19);
            this.saveFolderBttn.Name = "saveFolderBttn";
            this.saveFolderBttn.Size = new System.Drawing.Size(59, 51);
            this.saveFolderBttn.TabIndex = 1;
            this.saveFolderBttn.UseVisualStyleBackColor = false;
            // 
            // openFolderBttn
            // 
            this.openFolderBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openFolderBttn.BackgroundImage")));
            this.openFolderBttn.Location = new System.Drawing.Point(6, 19);
            this.openFolderBttn.Name = "openFolderBttn";
            this.openFolderBttn.Size = new System.Drawing.Size(59, 51);
            this.openFolderBttn.TabIndex = 0;
            this.openFolderBttn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 629);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button drawCircle;
        private System.Windows.Forms.Button drawSquare;
        private System.Windows.Forms.Button drawHexagon;
        private System.Windows.Forms.Button drawTriangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button colorWhite;
        private System.Windows.Forms.Button colorBrown;
        private System.Windows.Forms.Button colorPurple;
        private System.Windows.Forms.Button colorYellow;
        private System.Windows.Forms.Button colorBlack;
        private System.Windows.Forms.Button colorOrange;
        private System.Windows.Forms.Button colorGreen;
        private System.Windows.Forms.Button colorBlue;
        private System.Windows.Forms.Button colorRed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button penBttn;
        private System.Windows.Forms.Button recycleBinBttn;
        private System.Windows.Forms.Button mouseHandBttn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button saveFolderBttn;
        private System.Windows.Forms.Button openFolderBttn;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

