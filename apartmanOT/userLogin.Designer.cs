namespace apartmanOT
{
    partial class userLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.mainApartmentNoTxtBx = new System.Windows.Forms.TextBox();
            this.mainPasswordTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new FontAwesome.Sharp.IconButton();
            this.signUpButton = new FontAwesome.Sharp.IconButton();
            this.AdminSignUpPanel = new System.Windows.Forms.Panel();
            this.adminSignUpButton = new FontAwesome.Sharp.IconButton();
            this.password2TxtBx = new System.Windows.Forms.TextBox();
            this.passwordTxtBx = new System.Windows.Forms.TextBox();
            this.apartmentNoTxtBx = new System.Windows.Forms.TextBox();
            this.phoneNoTxtBx = new System.Windows.Forms.TextBox();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AdminSignUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daire Numarası:";
            // 
            // mainApartmentNoTxtBx
            // 
            this.mainApartmentNoTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainApartmentNoTxtBx.ForeColor = System.Drawing.Color.Black;
            this.mainApartmentNoTxtBx.Location = new System.Drawing.Point(281, 130);
            this.mainApartmentNoTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainApartmentNoTxtBx.Name = "mainApartmentNoTxtBx";
            this.mainApartmentNoTxtBx.Size = new System.Drawing.Size(180, 40);
            this.mainApartmentNoTxtBx.TabIndex = 1;
            this.mainApartmentNoTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainApartmentNoTxtBx_KeyPress);
            // 
            // mainPasswordTxtBx
            // 
            this.mainPasswordTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainPasswordTxtBx.ForeColor = System.Drawing.Color.Black;
            this.mainPasswordTxtBx.Location = new System.Drawing.Point(281, 238);
            this.mainPasswordTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPasswordTxtBx.Name = "mainPasswordTxtBx";
            this.mainPasswordTxtBx.Size = new System.Drawing.Size(180, 40);
            this.mainPasswordTxtBx.TabIndex = 2;
            this.mainPasswordTxtBx.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(188, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // loginButton
            // 
            this.loginButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.loginButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.loginButton.IconColor = System.Drawing.Color.Black;
            this.loginButton.IconSize = 16;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.loginButton.Location = new System.Drawing.Point(299, 335);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Rotation = 0D;
            this.loginButton.Size = new System.Drawing.Size(164, 41);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.signUpButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signUpButton.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.signUpButton.IconColor = System.Drawing.Color.Black;
            this.signUpButton.IconSize = 16;
            this.signUpButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.signUpButton.Location = new System.Drawing.Point(688, 484);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Rotation = 0D;
            this.signUpButton.Size = new System.Drawing.Size(164, 42);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Üye Ol";
            this.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // AdminSignUpPanel
            // 
            this.AdminSignUpPanel.BackColor = System.Drawing.Color.Gray;
            this.AdminSignUpPanel.Controls.Add(this.adminSignUpButton);
            this.AdminSignUpPanel.Controls.Add(this.password2TxtBx);
            this.AdminSignUpPanel.Controls.Add(this.passwordTxtBx);
            this.AdminSignUpPanel.Controls.Add(this.apartmentNoTxtBx);
            this.AdminSignUpPanel.Controls.Add(this.phoneNoTxtBx);
            this.AdminSignUpPanel.Controls.Add(this.nameTxtBx);
            this.AdminSignUpPanel.Controls.Add(this.label7);
            this.AdminSignUpPanel.Controls.Add(this.label6);
            this.AdminSignUpPanel.Controls.Add(this.label5);
            this.AdminSignUpPanel.Controls.Add(this.label4);
            this.AdminSignUpPanel.Controls.Add(this.label3);
            this.AdminSignUpPanel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminSignUpPanel.Location = new System.Drawing.Point(580, 76);
            this.AdminSignUpPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdminSignUpPanel.Name = "AdminSignUpPanel";
            this.AdminSignUpPanel.Size = new System.Drawing.Size(471, 400);
            this.AdminSignUpPanel.TabIndex = 6;
            this.AdminSignUpPanel.Visible = false;
            // 
            // adminSignUpButton
            // 
            this.adminSignUpButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.adminSignUpButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminSignUpButton.IconChar = FontAwesome.Sharp.IconChar.Magic;
            this.adminSignUpButton.IconColor = System.Drawing.Color.Black;
            this.adminSignUpButton.IconSize = 16;
            this.adminSignUpButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.adminSignUpButton.Location = new System.Drawing.Point(303, 319);
            this.adminSignUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminSignUpButton.Name = "adminSignUpButton";
            this.adminSignUpButton.Rotation = 0D;
            this.adminSignUpButton.Size = new System.Drawing.Size(164, 41);
            this.adminSignUpButton.TabIndex = 7;
            this.adminSignUpButton.Text = "Kaydol";
            this.adminSignUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminSignUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminSignUpButton.UseVisualStyleBackColor = true;
            this.adminSignUpButton.Click += new System.EventHandler(this.adminSignUpButton_Click);
            // 
            // password2TxtBx
            // 
            this.password2TxtBx.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password2TxtBx.ForeColor = System.Drawing.Color.Black;
            this.password2TxtBx.Location = new System.Drawing.Point(285, 249);
            this.password2TxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password2TxtBx.Name = "password2TxtBx";
            this.password2TxtBx.Size = new System.Drawing.Size(180, 40);
            this.password2TxtBx.TabIndex = 15;
            this.password2TxtBx.UseSystemPasswordChar = true;
            // 
            // passwordTxtBx
            // 
            this.passwordTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTxtBx.ForeColor = System.Drawing.Color.Black;
            this.passwordTxtBx.Location = new System.Drawing.Point(285, 191);
            this.passwordTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTxtBx.Name = "passwordTxtBx";
            this.passwordTxtBx.Size = new System.Drawing.Size(180, 40);
            this.passwordTxtBx.TabIndex = 14;
            this.passwordTxtBx.UseSystemPasswordChar = true;
            // 
            // apartmentNoTxtBx
            // 
            this.apartmentNoTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apartmentNoTxtBx.ForeColor = System.Drawing.Color.Black;
            this.apartmentNoTxtBx.Location = new System.Drawing.Point(285, 133);
            this.apartmentNoTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apartmentNoTxtBx.Name = "apartmentNoTxtBx";
            this.apartmentNoTxtBx.Size = new System.Drawing.Size(180, 40);
            this.apartmentNoTxtBx.TabIndex = 13;
            this.apartmentNoTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apartmentNoTxtBx_KeyPress);
            // 
            // phoneNoTxtBx
            // 
            this.phoneNoTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNoTxtBx.ForeColor = System.Drawing.Color.Black;
            this.phoneNoTxtBx.Location = new System.Drawing.Point(285, 75);
            this.phoneNoTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNoTxtBx.MaxLength = 10;
            this.phoneNoTxtBx.Name = "phoneNoTxtBx";
            this.phoneNoTxtBx.Size = new System.Drawing.Size(180, 40);
            this.phoneNoTxtBx.TabIndex = 12;
            this.phoneNoTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNoTxtBx_KeyPress);
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTxtBx.ForeColor = System.Drawing.Color.Black;
            this.nameTxtBx.Location = new System.Drawing.Point(285, 17);
            this.nameTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(180, 40);
            this.nameTxtBx.TabIndex = 7;
            this.nameTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxtBx_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Şifrenizi Yeniden Giriniz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şifreniz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Daire Numaranız:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon Numaranız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adınız Soyadınız:";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.White;
            this.warningLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warningLabel.ForeColor = System.Drawing.Color.Black;
            this.warningLabel.Location = new System.Drawing.Point(67, 494);
            this.warningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(580, 23);
            this.warningLabel.TabIndex = 16;
            this.warningLabel.Text = "Apartman yöneticisiyseniz ve ilk defa giriş yapıyorsanız lütfen üye olunuz!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1076, 63);
            this.label8.TabIndex = 17;
            this.label8.Text = "Apartman Otomasyonu                                             \r\n";
            // 
            // userLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1306, 675);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.AdminSignUpPanel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainPasswordTxtBx);
            this.Controls.Add(this.mainApartmentNoTxtBx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "userLogin";
            this.Text = "Apartman Otomasyonu";
            this.AdminSignUpPanel.ResumeLayout(false);
            this.AdminSignUpPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mainApartmentNoTxtBx;
        private System.Windows.Forms.TextBox mainPasswordTxtBx;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton loginButton;
        private FontAwesome.Sharp.IconButton signUpButton;
        private System.Windows.Forms.Panel AdminSignUpPanel;
        private FontAwesome.Sharp.IconButton adminSignUpButton;
        private System.Windows.Forms.TextBox password2TxtBx;
        private System.Windows.Forms.TextBox passwordTxtBx;
        private System.Windows.Forms.TextBox apartmentNoTxtBx;
        private System.Windows.Forms.TextBox phoneNoTxtBx;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label label8;
    }
}

