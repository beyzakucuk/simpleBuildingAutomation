namespace apartmanOT
{
    partial class userEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.totalDebtTxtBx = new System.Windows.Forms.TextBox();
            this.phoneNoTxtBx = new System.Windows.Forms.TextBox();
            this.apartmentNoTxtBx = new System.Windows.Forms.TextBox();
            this.totalDebtLbl = new System.Windows.Forms.Label();
            this.passwordTxtBx = new System.Windows.Forms.TextBox();
            this.phoneNoLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.apartmentNoLbl = new System.Windows.Forms.Label();
            this.rentalTxtBx = new System.Windows.Forms.TextBox();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.rentalLbl = new System.Windows.Forms.Label();
            this.initialLbl = new System.Windows.Forms.Label();
            this.backBtn = new FontAwesome.Sharp.IconButton();
            this.userRegisterBtn = new FontAwesome.Sharp.IconButton();
            this.apartmentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.duesStatusComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editSaveBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "Eğer borcu yoksa 0 yazınız.";
            // 
            // totalDebtTxtBx
            // 
            this.totalDebtTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalDebtTxtBx.Location = new System.Drawing.Point(693, 22);
            this.totalDebtTxtBx.MaxLength = 15;
            this.totalDebtTxtBx.Name = "totalDebtTxtBx";
            this.totalDebtTxtBx.Size = new System.Drawing.Size(107, 29);
            this.totalDebtTxtBx.TabIndex = 101;
            this.totalDebtTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalDebtTxtBx_KeyPress);
            // 
            // phoneNoTxtBx
            // 
            this.phoneNoTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNoTxtBx.Location = new System.Drawing.Point(261, 177);
            this.phoneNoTxtBx.MaxLength = 10;
            this.phoneNoTxtBx.Name = "phoneNoTxtBx";
            this.phoneNoTxtBx.Size = new System.Drawing.Size(133, 29);
            this.phoneNoTxtBx.TabIndex = 100;
            this.phoneNoTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNoTxtBx_KeyPress);
            // 
            // apartmentNoTxtBx
            // 
            this.apartmentNoTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmentNoTxtBx.Location = new System.Drawing.Point(276, 101);
            this.apartmentNoTxtBx.MaxLength = 10;
            this.apartmentNoTxtBx.Name = "apartmentNoTxtBx";
            this.apartmentNoTxtBx.Size = new System.Drawing.Size(118, 29);
            this.apartmentNoTxtBx.TabIndex = 99;
            this.apartmentNoTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apartmentNoTxtBx_KeyPress);
            // 
            // totalDebtLbl
            // 
            this.totalDebtLbl.AutoSize = true;
            this.totalDebtLbl.BackColor = System.Drawing.Color.White;
            this.totalDebtLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalDebtLbl.Location = new System.Drawing.Point(400, 14);
            this.totalDebtLbl.Name = "totalDebtLbl";
            this.totalDebtLbl.Size = new System.Drawing.Size(252, 37);
            this.totalDebtLbl.TabIndex = 97;
            this.totalDebtLbl.Text = "Toplam Borcu(TL):";
            // 
            // passwordTxtBx
            // 
            this.passwordTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTxtBx.Location = new System.Drawing.Point(686, 177);
            this.passwordTxtBx.MaxLength = 4;
            this.passwordTxtBx.Name = "passwordTxtBx";
            this.passwordTxtBx.Size = new System.Drawing.Size(114, 29);
            this.passwordTxtBx.TabIndex = 92;
            // 
            // phoneNoLbl
            // 
            this.phoneNoLbl.AutoSize = true;
            this.phoneNoLbl.BackColor = System.Drawing.Color.White;
            this.phoneNoLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNoLbl.Location = new System.Drawing.Point(3, 172);
            this.phoneNoLbl.Name = "phoneNoLbl";
            this.phoneNoLbl.Size = new System.Drawing.Size(250, 37);
            this.phoneNoLbl.TabIndex = 95;
            this.phoneNoLbl.Text = "Telefon Numarası:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.White;
            this.passwordLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLbl.Location = new System.Drawing.Point(400, 172);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(107, 37);
            this.passwordLbl.TabIndex = 89;
            this.passwordLbl.Text = "Şifresi:";
            // 
            // apartmentNoLbl
            // 
            this.apartmentNoLbl.AutoSize = true;
            this.apartmentNoLbl.BackColor = System.Drawing.Color.White;
            this.apartmentNoLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmentNoLbl.Location = new System.Drawing.Point(3, 93);
            this.apartmentNoLbl.Name = "apartmentNoLbl";
            this.apartmentNoLbl.Size = new System.Drawing.Size(224, 37);
            this.apartmentNoLbl.TabIndex = 94;
            this.apartmentNoLbl.Text = "Daire Numarası:";
            // 
            // rentalTxtBx
            // 
            this.rentalTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentalTxtBx.Location = new System.Drawing.Point(699, 251);
            this.rentalTxtBx.MaxLength = 15;
            this.rentalTxtBx.Name = "rentalTxtBx";
            this.rentalTxtBx.Size = new System.Drawing.Size(101, 29);
            this.rentalTxtBx.TabIndex = 93;
            this.rentalTxtBx.Visible = false;
            this.rentalTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rentalTxtBx_KeyPress);
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTxtBx.Location = new System.Drawing.Point(204, 22);
            this.nameTxtBx.MaxLength = 30;
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(190, 29);
            this.nameTxtBx.TabIndex = 91;
            this.nameTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxtBx_KeyPress);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.White;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLbl.Location = new System.Drawing.Point(3, 14);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(164, 37);
            this.nameLbl.TabIndex = 90;
            this.nameLbl.Text = "Adı Soyadı:";
            // 
            // rentalLbl
            // 
            this.rentalLbl.AutoSize = true;
            this.rentalLbl.BackColor = System.Drawing.Color.White;
            this.rentalLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentalLbl.Location = new System.Drawing.Point(400, 251);
            this.rentalLbl.Name = "rentalLbl";
            this.rentalLbl.Size = new System.Drawing.Size(217, 37);
            this.rentalLbl.TabIndex = 88;
            this.rentalLbl.Text = "Kira Bedeli(TL):";
            this.rentalLbl.Visible = false;
            // 
            // initialLbl
            // 
            this.initialLbl.AutoSize = true;
            this.initialLbl.BackColor = System.Drawing.Color.White;
            this.initialLbl.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.initialLbl.Location = new System.Drawing.Point(72, 12);
            this.initialLbl.Name = "initialLbl";
            this.initialLbl.Size = new System.Drawing.Size(215, 39);
            this.initialLbl.TabIndex = 87;
            this.initialLbl.Text = "Site Sakininin;";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.backBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backBtn.IconColor = System.Drawing.Color.Black;
            this.backBtn.IconSize = 24;
            this.backBtn.Location = new System.Drawing.Point(-1, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Rotation = 0D;
            this.backBtn.Size = new System.Drawing.Size(53, 37);
            this.backBtn.TabIndex = 86;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // userRegisterBtn
            // 
            this.userRegisterBtn.BackColor = System.Drawing.Color.White;
            this.userRegisterBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.userRegisterBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userRegisterBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.userRegisterBtn.IconColor = System.Drawing.Color.Black;
            this.userRegisterBtn.IconSize = 20;
            this.userRegisterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userRegisterBtn.Location = new System.Drawing.Point(685, 392);
            this.userRegisterBtn.Name = "userRegisterBtn";
            this.userRegisterBtn.Rotation = 0D;
            this.userRegisterBtn.Size = new System.Drawing.Size(109, 46);
            this.userRegisterBtn.TabIndex = 104;
            this.userRegisterBtn.Text = "KAYDET";
            this.userRegisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userRegisterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userRegisterBtn.UseVisualStyleBackColor = false;
            this.userRegisterBtn.Click += new System.EventHandler(this.userRegisterBtn_Click);
            // 
            // apartmentStatusComboBox
            // 
            this.apartmentStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apartmentStatusComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmentStatusComboBox.FormattingEnabled = true;
            this.apartmentStatusComboBox.Items.AddRange(new object[] {
            "Ev Sahibi",
            "Kiracı"});
            this.apartmentStatusComboBox.Location = new System.Drawing.Point(293, 250);
            this.apartmentStatusComboBox.Name = "apartmentStatusComboBox";
            this.apartmentStatusComboBox.Size = new System.Drawing.Size(101, 30);
            this.apartmentStatusComboBox.TabIndex = 105;
            this.apartmentStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.apartmentStatusComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 37);
            this.label3.TabIndex = 106;
            this.label3.Text = "Daire Durumu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(400, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 37);
            this.label4.TabIndex = 107;
            this.label4.Text = "Aidat Durumu:";
            // 
            // duesStatusComboBox
            // 
            this.duesStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.duesStatusComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duesStatusComboBox.FormattingEnabled = true;
            this.duesStatusComboBox.Items.AddRange(new object[] {
            "Ödendi",
            "Ödenmedi"});
            this.duesStatusComboBox.Location = new System.Drawing.Point(699, 101);
            this.duesStatusComboBox.Name = "duesStatusComboBox";
            this.duesStatusComboBox.Size = new System.Drawing.Size(101, 30);
            this.duesStatusComboBox.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.duesStatusComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.totalDebtTxtBx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.apartmentStatusComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.phoneNoLbl);
            this.panel1.Controls.Add(this.apartmentNoLbl);
            this.panel1.Controls.Add(this.phoneNoTxtBx);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.apartmentNoTxtBx);
            this.panel1.Controls.Add(this.totalDebtLbl);
            this.panel1.Controls.Add(this.passwordTxtBx);
            this.panel1.Controls.Add(this.passwordLbl);
            this.panel1.Controls.Add(this.rentalTxtBx);
            this.panel1.Controls.Add(this.nameTxtBx);
            this.panel1.Controls.Add(this.rentalLbl);
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(-1, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 315);
            this.panel1.TabIndex = 109;
            // 
            // editSaveBtn
            // 
            this.editSaveBtn.BackColor = System.Drawing.Color.White;
            this.editSaveBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.editSaveBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editSaveBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.editSaveBtn.IconColor = System.Drawing.Color.Black;
            this.editSaveBtn.IconSize = 20;
            this.editSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editSaveBtn.Location = new System.Drawing.Point(12, 392);
            this.editSaveBtn.Name = "editSaveBtn";
            this.editSaveBtn.Rotation = 0D;
            this.editSaveBtn.Size = new System.Drawing.Size(109, 46);
            this.editSaveBtn.TabIndex = 111;
            this.editSaveBtn.Text = "KAYDET";
            this.editSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editSaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editSaveBtn.UseVisualStyleBackColor = false;
            this.editSaveBtn.Visible = false;
            this.editSaveBtn.Click += new System.EventHandler(this.editSaveBtn_Click);
            // 
            // userEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.editSaveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userRegisterBtn);
            this.Controls.Add(this.initialLbl);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "userEdit";
            this.Text = "Apartman Sakini Düzenleme";
            this.Load += new System.EventHandler(this.userEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox totalDebtTxtBx;
        public System.Windows.Forms.TextBox phoneNoTxtBx;
        public System.Windows.Forms.TextBox apartmentNoTxtBx;
        private System.Windows.Forms.Label totalDebtLbl;
        public System.Windows.Forms.TextBox passwordTxtBx;
        private System.Windows.Forms.Label phoneNoLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label apartmentNoLbl;
        public System.Windows.Forms.TextBox rentalTxtBx;
        public System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label rentalLbl;
        private System.Windows.Forms.Label initialLbl;
        private FontAwesome.Sharp.IconButton backBtn;
        private FontAwesome.Sharp.IconButton userRegisterBtn;
        private System.Windows.Forms.ComboBox apartmentStatusComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox duesStatusComboBox;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton editSaveBtn;
    }
}