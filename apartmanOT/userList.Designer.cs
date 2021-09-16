namespace apartmanOT
{
    partial class userList
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
            this.userListV = new System.Windows.Forms.ListView();
            this.nameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apartmentNoCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phonNoCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apartmentStatusCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.duesStatusCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalDebtCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rentalCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userAddBtn = new FontAwesome.Sharp.IconButton();
            this.userEditBtn = new FontAwesome.Sharp.IconButton();
            this.userRemoveBtn = new FontAwesome.Sharp.IconButton();
            this.backBtn = new FontAwesome.Sharp.IconButton();
            this.nameLbl = new System.Windows.Forms.Label();
            this.searchTxtBx = new System.Windows.Forms.TextBox();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.recordCountLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userListV
            // 
            this.userListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCH,
            this.apartmentNoCH,
            this.phonNoCH,
            this.apartmentStatusCH,
            this.duesStatusCH,
            this.totalDebtCH,
            this.passwordCH,
            this.rentalCH,
            this.dateCH});
            this.userListV.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userListV.FullRowSelect = true;
            this.userListV.GridLines = true;
            this.userListV.HideSelection = false;
            this.userListV.Location = new System.Drawing.Point(-3, 33);
            this.userListV.MultiSelect = false;
            this.userListV.Name = "userListV";
            this.userListV.Size = new System.Drawing.Size(991, 330);
            this.userListV.TabIndex = 67;
            this.userListV.UseCompatibleStateImageBehavior = false;
            this.userListV.View = System.Windows.Forms.View.Details;
            // 
            // nameCH
            // 
            this.nameCH.Text = "Adı Soyadı";
            this.nameCH.Width = 149;
            // 
            // apartmentNoCH
            // 
            this.apartmentNoCH.Text = "Daire No";
            this.apartmentNoCH.Width = 85;
            // 
            // phonNoCH
            // 
            this.phonNoCH.Text = "Telefon Numarası";
            this.phonNoCH.Width = 138;
            // 
            // apartmentStatusCH
            // 
            this.apartmentStatusCH.Text = "Daire Durumu";
            this.apartmentStatusCH.Width = 117;
            // 
            // duesStatusCH
            // 
            this.duesStatusCH.Text = "Aidat Durumu";
            this.duesStatusCH.Width = 118;
            // 
            // totalDebtCH
            // 
            this.totalDebtCH.Text = "Toplam Borcu";
            this.totalDebtCH.Width = 114;
            // 
            // passwordCH
            // 
            this.passwordCH.Text = "Şifresi";
            this.passwordCH.Width = 64;
            // 
            // rentalCH
            // 
            this.rentalCH.Text = "Kira Bedeli";
            this.rentalCH.Width = 96;
            // 
            // dateCH
            // 
            this.dateCH.Text = "Tarih";
            this.dateCH.Width = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.userAddBtn);
            this.panel1.Controls.Add(this.userEditBtn);
            this.panel1.Controls.Add(this.userRemoveBtn);
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(-3, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 62);
            this.panel1.TabIndex = 77;
            // 
            // userAddBtn
            // 
            this.userAddBtn.BackColor = System.Drawing.Color.White;
            this.userAddBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.userAddBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.userAddBtn.IconColor = System.Drawing.Color.Black;
            this.userAddBtn.IconSize = 20;
            this.userAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userAddBtn.Location = new System.Drawing.Point(12, 10);
            this.userAddBtn.Name = "userAddBtn";
            this.userAddBtn.Rotation = 0D;
            this.userAddBtn.Size = new System.Drawing.Size(109, 46);
            this.userAddBtn.TabIndex = 39;
            this.userAddBtn.Text = "EKLE";
            this.userAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userAddBtn.UseVisualStyleBackColor = false;
            this.userAddBtn.Click += new System.EventHandler(this.userAddBtn_Click);
            // 
            // userEditBtn
            // 
            this.userEditBtn.BackColor = System.Drawing.Color.White;
            this.userEditBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.userEditBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.userEditBtn.IconColor = System.Drawing.Color.Black;
            this.userEditBtn.IconSize = 20;
            this.userEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userEditBtn.Location = new System.Drawing.Point(257, 10);
            this.userEditBtn.Name = "userEditBtn";
            this.userEditBtn.Rotation = 0D;
            this.userEditBtn.Size = new System.Drawing.Size(120, 46);
            this.userEditBtn.TabIndex = 37;
            this.userEditBtn.Text = "DÜZENLE";
            this.userEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userEditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userEditBtn.UseVisualStyleBackColor = false;
            this.userEditBtn.Click += new System.EventHandler(this.userEditBtn_Click);
            // 
            // userRemoveBtn
            // 
            this.userRemoveBtn.BackColor = System.Drawing.Color.White;
            this.userRemoveBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.userRemoveBtn.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.userRemoveBtn.IconColor = System.Drawing.Color.Black;
            this.userRemoveBtn.IconSize = 20;
            this.userRemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userRemoveBtn.Location = new System.Drawing.Point(495, 10);
            this.userRemoveBtn.Name = "userRemoveBtn";
            this.userRemoveBtn.Rotation = 0D;
            this.userRemoveBtn.Size = new System.Drawing.Size(109, 46);
            this.userRemoveBtn.TabIndex = 36;
            this.userRemoveBtn.Text = "SİL";
            this.userRemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userRemoveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userRemoveBtn.UseVisualStyleBackColor = false;
            this.userRemoveBtn.Click += new System.EventHandler(this.userRemoveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.backBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backBtn.IconColor = System.Drawing.Color.Black;
            this.backBtn.IconSize = 24;
            this.backBtn.Location = new System.Drawing.Point(9, 1);
            this.backBtn.Name = "backBtn";
            this.backBtn.Rotation = 0D;
            this.backBtn.Size = new System.Drawing.Size(53, 26);
            this.backBtn.TabIndex = 87;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.White;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLbl.Location = new System.Drawing.Point(12, 388);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(432, 28);
            this.nameLbl.TabIndex = 91;
            this.nameLbl.Text = "Aradığınız Site Sakininin Daire Numarası:";
            // 
            // searchTxtBx
            // 
            this.searchTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTxtBx.Location = new System.Drawing.Point(450, 387);
            this.searchTxtBx.Name = "searchTxtBx";
            this.searchTxtBx.Size = new System.Drawing.Size(65, 29);
            this.searchTxtBx.TabIndex = 92;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.Black;
            this.searchBtn.IconSize = 20;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(535, 382);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Rotation = 0D;
            this.searchBtn.Size = new System.Drawing.Size(77, 41);
            this.searchBtn.TabIndex = 40;
            this.searchBtn.Text = "Ara";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(631, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 93;
            this.label1.Text = "Kayıtlı Daire Sayısı=";
            // 
            // recordCountLbl
            // 
            this.recordCountLbl.AutoSize = true;
            this.recordCountLbl.BackColor = System.Drawing.Color.White;
            this.recordCountLbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recordCountLbl.Location = new System.Drawing.Point(865, 388);
            this.recordCountLbl.Name = "recordCountLbl";
            this.recordCountLbl.Size = new System.Drawing.Size(23, 28);
            this.recordCountLbl.TabIndex = 94;
            this.recordCountLbl.Text = "0";
            // 
            // userList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(988, 519);
            this.Controls.Add(this.recordCountLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxtBx);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userListV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "userList";
            this.Text = "Apartman Sakinleri Listesi";
            this.Load += new System.EventHandler(this.userList_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView userListV;
        private System.Windows.Forms.ColumnHeader nameCH;
        private System.Windows.Forms.ColumnHeader apartmentNoCH;
        private System.Windows.Forms.ColumnHeader phonNoCH;
        private System.Windows.Forms.ColumnHeader apartmentStatusCH;
        private System.Windows.Forms.ColumnHeader duesStatusCH;
        private System.Windows.Forms.ColumnHeader totalDebtCH;
        private System.Windows.Forms.ColumnHeader passwordCH;
        private System.Windows.Forms.ColumnHeader rentalCH;
        private System.Windows.Forms.ColumnHeader dateCH;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton userAddBtn;
        private FontAwesome.Sharp.IconButton userEditBtn;
        private FontAwesome.Sharp.IconButton userRemoveBtn;
        private FontAwesome.Sharp.IconButton backBtn;
        private System.Windows.Forms.Label nameLbl;
        public System.Windows.Forms.TextBox searchTxtBx;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recordCountLbl;
    }
}