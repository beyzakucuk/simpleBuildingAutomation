namespace apartmanOT
{
    partial class homePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.adminPnl = new System.Windows.Forms.Panel();
            this.totalDebtBtn = new FontAwesome.Sharp.IconButton();
            this.feeDayBtn = new FontAwesome.Sharp.IconButton();
            this.feeDayTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editDuesBtn = new FontAwesome.Sharp.IconButton();
            this.feeTxtBx = new System.Windows.Forms.TextBox();
            this.feeLbl = new System.Windows.Forms.Label();
            this.userEditbtn = new FontAwesome.Sharp.IconButton();
            this.backBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.payingBtn = new FontAwesome.Sharp.IconButton();
            this.payingLbl = new System.Windows.Forms.Label();
            this.apartmentStatusLbl2 = new System.Windows.Forms.Label();
            this.totalDebtLbl2 = new System.Windows.Forms.Label();
            this.duesStatusLbl2 = new System.Windows.Forms.Label();
            this.rentalLbl2 = new System.Windows.Forms.Label();
            this.phoneNoLbl2 = new System.Windows.Forms.Label();
            this.apartmentNoLbl2 = new System.Windows.Forms.Label();
            this.totalDebtLbl = new System.Windows.Forms.Label();
            this.duesStatusLbl = new System.Windows.Forms.Label();
            this.rentalLbl = new System.Windows.Forms.Label();
            this.apartmentStatusLbl = new System.Windows.Forms.Label();
            this.phoneNoLbl = new System.Windows.Forms.Label();
            this.apartmentNoLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.duesInfoNI = new System.Windows.Forms.NotifyIcon(this.components);
            this.adminPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminPnl
            // 
            this.adminPnl.Controls.Add(this.totalDebtBtn);
            this.adminPnl.Controls.Add(this.feeDayBtn);
            this.adminPnl.Controls.Add(this.feeDayTxtBx);
            this.adminPnl.Controls.Add(this.label1);
            this.adminPnl.Controls.Add(this.editDuesBtn);
            this.adminPnl.Controls.Add(this.feeTxtBx);
            this.adminPnl.Controls.Add(this.feeLbl);
            this.adminPnl.Controls.Add(this.userEditbtn);
            this.adminPnl.Location = new System.Drawing.Point(104, 120);
            this.adminPnl.Name = "adminPnl";
            this.adminPnl.Size = new System.Drawing.Size(704, 334);
            this.adminPnl.TabIndex = 56;
            this.adminPnl.Visible = false;
            // 
            // totalDebtBtn
            // 
            this.totalDebtBtn.BackColor = System.Drawing.Color.White;
            this.totalDebtBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.totalDebtBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalDebtBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.totalDebtBtn.IconColor = System.Drawing.Color.Black;
            this.totalDebtBtn.IconSize = 20;
            this.totalDebtBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalDebtBtn.Location = new System.Drawing.Point(480, 215);
            this.totalDebtBtn.Name = "totalDebtBtn";
            this.totalDebtBtn.Rotation = 0D;
            this.totalDebtBtn.Size = new System.Drawing.Size(172, 76);
            this.totalDebtBtn.TabIndex = 96;
            this.totalDebtBtn.Text = "Borçları işlet";
            this.totalDebtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalDebtBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.totalDebtBtn.UseVisualStyleBackColor = false;
            this.totalDebtBtn.Click += new System.EventHandler(this.totalDebtBtn_Click);
            // 
            // feeDayBtn
            // 
            this.feeDayBtn.BackColor = System.Drawing.Color.White;
            this.feeDayBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.feeDayBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feeDayBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.feeDayBtn.IconColor = System.Drawing.Color.Black;
            this.feeDayBtn.IconSize = 16;
            this.feeDayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feeDayBtn.Location = new System.Drawing.Point(584, 134);
            this.feeDayBtn.Name = "feeDayBtn";
            this.feeDayBtn.Rotation = 0D;
            this.feeDayBtn.Size = new System.Drawing.Size(101, 44);
            this.feeDayBtn.TabIndex = 28;
            this.feeDayBtn.Text = "Kaydet";
            this.feeDayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.feeDayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.feeDayBtn.UseVisualStyleBackColor = false;
            this.feeDayBtn.Click += new System.EventHandler(this.feeDayBtn_Click);
            // 
            // feeDayTxtBx
            // 
            this.feeDayTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feeDayTxtBx.Location = new System.Drawing.Point(480, 139);
            this.feeDayTxtBx.MaxLength = 2;
            this.feeDayTxtBx.Name = "feeDayTxtBx";
            this.feeDayTxtBx.Size = new System.Drawing.Size(85, 29);
            this.feeDayTxtBx.TabIndex = 27;
            this.feeDayTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.feeDayTxtBx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 44);
            this.label1.TabIndex = 26;
            this.label1.Text = "Aidatın her ay toplandığı gün:";
            // 
            // editDuesBtn
            // 
            this.editDuesBtn.BackColor = System.Drawing.Color.White;
            this.editDuesBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.editDuesBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editDuesBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.editDuesBtn.IconColor = System.Drawing.Color.Black;
            this.editDuesBtn.IconSize = 16;
            this.editDuesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editDuesBtn.Location = new System.Drawing.Point(438, 54);
            this.editDuesBtn.Name = "editDuesBtn";
            this.editDuesBtn.Rotation = 0D;
            this.editDuesBtn.Size = new System.Drawing.Size(101, 44);
            this.editDuesBtn.TabIndex = 25;
            this.editDuesBtn.Text = "Kaydet";
            this.editDuesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editDuesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editDuesBtn.UseVisualStyleBackColor = false;
            this.editDuesBtn.Click += new System.EventHandler(this.editDuesBtn_Click);
            // 
            // feeTxtBx
            // 
            this.feeTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feeTxtBx.Location = new System.Drawing.Point(304, 63);
            this.feeTxtBx.MaxLength = 10;
            this.feeTxtBx.Name = "feeTxtBx";
            this.feeTxtBx.Size = new System.Drawing.Size(121, 29);
            this.feeTxtBx.TabIndex = 21;
            this.feeTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.feeTxtBx_KeyPress);
            // 
            // feeLbl
            // 
            this.feeLbl.AutoSize = true;
            this.feeLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feeLbl.Location = new System.Drawing.Point(9, 51);
            this.feeLbl.Name = "feeLbl";
            this.feeLbl.Size = new System.Drawing.Size(289, 44);
            this.feeLbl.TabIndex = 20;
            this.feeLbl.Text = "Aidat Miktarı(TL):";
            // 
            // userEditbtn
            // 
            this.userEditbtn.BackColor = System.Drawing.Color.White;
            this.userEditbtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.userEditbtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userEditbtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.userEditbtn.IconColor = System.Drawing.Color.Black;
            this.userEditbtn.IconSize = 24;
            this.userEditbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userEditbtn.Location = new System.Drawing.Point(17, 215);
            this.userEditbtn.Name = "userEditbtn";
            this.userEditbtn.Rotation = 0D;
            this.userEditbtn.Size = new System.Drawing.Size(325, 76);
            this.userEditbtn.TabIndex = 20;
            this.userEditbtn.Text = "Site Sakini Ekle,Sil veya Düzenle";
            this.userEditbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userEditbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userEditbtn.UseVisualStyleBackColor = false;
            this.userEditbtn.Click += new System.EventHandler(this.userEditbtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.backBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backBtn.IconColor = System.Drawing.Color.Black;
            this.backBtn.IconSize = 20;
            this.backBtn.Location = new System.Drawing.Point(6, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Rotation = 0D;
            this.backBtn.Size = new System.Drawing.Size(38, 23);
            this.backBtn.TabIndex = 55;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(6, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 354);
            this.panel1.TabIndex = 54;
            // 
            // payingBtn
            // 
            this.payingBtn.BackColor = System.Drawing.Color.White;
            this.payingBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.payingBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.payingBtn.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.payingBtn.IconColor = System.Drawing.Color.Black;
            this.payingBtn.IconSize = 20;
            this.payingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payingBtn.Location = new System.Drawing.Point(495, 12);
            this.payingBtn.Name = "payingBtn";
            this.payingBtn.Rotation = 0D;
            this.payingBtn.Size = new System.Drawing.Size(122, 46);
            this.payingBtn.TabIndex = 53;
            this.payingBtn.Text = "Ödeme Yap";
            this.payingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.payingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.payingBtn.UseVisualStyleBackColor = false;
            this.payingBtn.Click += new System.EventHandler(this.payingBtn_Click);
            // 
            // payingLbl
            // 
            this.payingLbl.AutoSize = true;
            this.payingLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.payingLbl.Location = new System.Drawing.Point(182, 14);
            this.payingLbl.Name = "payingLbl";
            this.payingLbl.Size = new System.Drawing.Size(607, 44);
            this.payingLbl.TabIndex = 52;
            this.payingLbl.Text = "Ödeme yapmak için                  tıklayınız.";
            // 
            // apartmentStatusLbl2
            // 
            this.apartmentStatusLbl2.AutoSize = true;
            this.apartmentStatusLbl2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmentStatusLbl2.Location = new System.Drawing.Point(470, 232);
            this.apartmentStatusLbl2.Name = "apartmentStatusLbl2";
            this.apartmentStatusLbl2.Size = new System.Drawing.Size(0, 44);
            this.apartmentStatusLbl2.TabIndex = 51;
            // 
            // totalDebtLbl2
            // 
            this.totalDebtLbl2.AutoSize = true;
            this.totalDebtLbl2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalDebtLbl2.Location = new System.Drawing.Point(470, 400);
            this.totalDebtLbl2.Name = "totalDebtLbl2";
            this.totalDebtLbl2.Size = new System.Drawing.Size(0, 44);
            this.totalDebtLbl2.TabIndex = 50;
            // 
            // duesStatusLbl2
            // 
            this.duesStatusLbl2.AutoSize = true;
            this.duesStatusLbl2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duesStatusLbl2.Location = new System.Drawing.Point(470, 344);
            this.duesStatusLbl2.Name = "duesStatusLbl2";
            this.duesStatusLbl2.Size = new System.Drawing.Size(0, 44);
            this.duesStatusLbl2.TabIndex = 49;
            // 
            // rentalLbl2
            // 
            this.rentalLbl2.AutoSize = true;
            this.rentalLbl2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentalLbl2.Location = new System.Drawing.Point(470, 294);
            this.rentalLbl2.Name = "rentalLbl2";
            this.rentalLbl2.Size = new System.Drawing.Size(0, 44);
            this.rentalLbl2.TabIndex = 48;
            // 
            // phoneNoLbl2
            // 
            this.phoneNoLbl2.AutoSize = true;
            this.phoneNoLbl2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNoLbl2.Location = new System.Drawing.Point(470, 176);
            this.phoneNoLbl2.Name = "phoneNoLbl2";
            this.phoneNoLbl2.Size = new System.Drawing.Size(0, 44);
            this.phoneNoLbl2.TabIndex = 47;
            // 
            // apartmentNoLbl2
            // 
            this.apartmentNoLbl2.AutoSize = true;
            this.apartmentNoLbl2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmentNoLbl2.Location = new System.Drawing.Point(470, 120);
            this.apartmentNoLbl2.Name = "apartmentNoLbl2";
            this.apartmentNoLbl2.Size = new System.Drawing.Size(0, 44);
            this.apartmentNoLbl2.TabIndex = 46;
            // 
            // totalDebtLbl
            // 
            this.totalDebtLbl.AutoSize = true;
            this.totalDebtLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalDebtLbl.Location = new System.Drawing.Point(137, 405);
            this.totalDebtLbl.Name = "totalDebtLbl";
            this.totalDebtLbl.Size = new System.Drawing.Size(290, 44);
            this.totalDebtLbl.TabIndex = 45;
            this.totalDebtLbl.Text = "Toplam Borcunuz:";
            // 
            // duesStatusLbl
            // 
            this.duesStatusLbl.AutoSize = true;
            this.duesStatusLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duesStatusLbl.Location = new System.Drawing.Point(137, 348);
            this.duesStatusLbl.Name = "duesStatusLbl";
            this.duesStatusLbl.Size = new System.Drawing.Size(301, 44);
            this.duesStatusLbl.TabIndex = 44;
            this.duesStatusLbl.Text = "Aidat Durumunuz:";
            // 
            // rentalLbl
            // 
            this.rentalLbl.AutoSize = true;
            this.rentalLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentalLbl.Location = new System.Drawing.Point(137, 291);
            this.rentalLbl.Name = "rentalLbl";
            this.rentalLbl.Size = new System.Drawing.Size(238, 44);
            this.rentalLbl.TabIndex = 43;
            this.rentalLbl.Text = "Kira Bedeliniz:";
            // 
            // apartmentStatusLbl
            // 
            this.apartmentStatusLbl.AutoSize = true;
            this.apartmentStatusLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmentStatusLbl.Location = new System.Drawing.Point(137, 234);
            this.apartmentStatusLbl.Name = "apartmentStatusLbl";
            this.apartmentStatusLbl.Size = new System.Drawing.Size(300, 44);
            this.apartmentStatusLbl.TabIndex = 42;
            this.apartmentStatusLbl.Text = "Daire Durumunuz:";
            // 
            // phoneNoLbl
            // 
            this.phoneNoLbl.AutoSize = true;
            this.phoneNoLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNoLbl.Location = new System.Drawing.Point(137, 177);
            this.phoneNoLbl.Name = "phoneNoLbl";
            this.phoneNoLbl.Size = new System.Drawing.Size(312, 44);
            this.phoneNoLbl.TabIndex = 41;
            this.phoneNoLbl.Text = "Telefon Numaranız:";
            // 
            // apartmentNoLbl
            // 
            this.apartmentNoLbl.AutoSize = true;
            this.apartmentNoLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmentNoLbl.Location = new System.Drawing.Point(137, 120);
            this.apartmentNoLbl.Name = "apartmentNoLbl";
            this.apartmentNoLbl.Size = new System.Drawing.Size(282, 44);
            this.apartmentNoLbl.TabIndex = 40;
            this.apartmentNoLbl.Text = "Daire Numaranız:";
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.Gray;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLbl.Location = new System.Drawing.Point(96, 63);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(711, 57);
            this.nameLbl.TabIndex = 39;
            this.nameLbl.Text = "Sayın Beyza Küçük";
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.ıconPictureBox1.IconSize = 148;
            this.ıconPictureBox1.Location = new System.Drawing.Point(-6, -7);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(167, 148);
            this.ıconPictureBox1.TabIndex = 38;
            this.ıconPictureBox1.TabStop = false;
            // 
            // duesInfoNI
            // 
            this.duesInfoNI.Icon = ((System.Drawing.Icon)(resources.GetObject("duesInfoNI.Icon")));
            this.duesInfoNI.Text = "notifyIcon1";
            this.duesInfoNI.Visible = true;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminPnl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.payingBtn);
            this.Controls.Add(this.payingLbl);
            this.Controls.Add(this.apartmentStatusLbl2);
            this.Controls.Add(this.totalDebtLbl2);
            this.Controls.Add(this.duesStatusLbl2);
            this.Controls.Add(this.rentalLbl2);
            this.Controls.Add(this.phoneNoLbl2);
            this.Controls.Add(this.apartmentNoLbl2);
            this.Controls.Add(this.totalDebtLbl);
            this.Controls.Add(this.duesStatusLbl);
            this.Controls.Add(this.rentalLbl);
            this.Controls.Add(this.apartmentStatusLbl);
            this.Controls.Add(this.phoneNoLbl);
            this.Controls.Add(this.apartmentNoLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.ıconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "homePage";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.homePage_Load);
            this.adminPnl.ResumeLayout(false);
            this.adminPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton editDuesBtn;
        private System.Windows.Forms.TextBox feeTxtBx;
        private System.Windows.Forms.Label feeLbl;
        private FontAwesome.Sharp.IconButton userEditbtn;
        private FontAwesome.Sharp.IconButton backBtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton payingBtn;
        private System.Windows.Forms.Label payingLbl;
        private System.Windows.Forms.Label apartmentStatusLbl2;
        private System.Windows.Forms.Label totalDebtLbl2;
        private System.Windows.Forms.Label duesStatusLbl2;
        private System.Windows.Forms.Label rentalLbl2;
        private System.Windows.Forms.Label phoneNoLbl2;
        private System.Windows.Forms.Label apartmentNoLbl2;
        private System.Windows.Forms.Label totalDebtLbl;
        private System.Windows.Forms.Label duesStatusLbl;
        private System.Windows.Forms.Label rentalLbl;
        private System.Windows.Forms.Label apartmentStatusLbl;
        private System.Windows.Forms.Label phoneNoLbl;
        private System.Windows.Forms.Label apartmentNoLbl;
        public System.Windows.Forms.Label nameLbl;
        public FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        public System.Windows.Forms.Panel adminPnl;
        private System.Windows.Forms.NotifyIcon duesInfoNI;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton feeDayBtn;
        private System.Windows.Forms.TextBox feeDayTxtBx;
        private FontAwesome.Sharp.IconButton totalDebtBtn;
    }
}