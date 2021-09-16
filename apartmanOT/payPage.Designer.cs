namespace apartmanOT
{
    partial class payPage
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
            this.payInfoPnl = new System.Windows.Forms.Panel();
            this.timerForPayLbl = new System.Windows.Forms.Label();
            this.payToCodeTxtBx = new System.Windows.Forms.TextBox();
            this.payingBtn = new FontAwesome.Sharp.IconButton();
            this.payInfoLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infoLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.codeSendBtn = new FontAwesome.Sharp.IconButton();
            this.bbdYearTxtBx = new System.Windows.Forms.TextBox();
            this.bbdMonthTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cvvTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fourNo4txtBx = new System.Windows.Forms.TextBox();
            this.fourNo1txtBx = new System.Windows.Forms.TextBox();
            this.fourNo2txtBx = new System.Windows.Forms.TextBox();
            this.fourNo3txtBx = new System.Windows.Forms.TextBox();
            this.backBtn = new FontAwesome.Sharp.IconButton();
            this.feeLbl = new System.Windows.Forms.Label();
            this.duesRadioBtn = new System.Windows.Forms.RadioButton();
            this.totalDebtRadioBtn = new System.Windows.Forms.RadioButton();
            this.paySelectLbl = new System.Windows.Forms.Label();
            this.totalDebtLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.codeExpoLbl = new System.Windows.Forms.Label();
            this.payInfoPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payInfoPnl
            // 
            this.payInfoPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.payInfoPnl.Controls.Add(this.timerForPayLbl);
            this.payInfoPnl.Controls.Add(this.payToCodeTxtBx);
            this.payInfoPnl.Controls.Add(this.payingBtn);
            this.payInfoPnl.Controls.Add(this.codeExpoLbl);
            this.payInfoPnl.Controls.Add(this.payInfoLbl);
            this.payInfoPnl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.payInfoPnl.Location = new System.Drawing.Point(409, 24);
            this.payInfoPnl.Name = "payInfoPnl";
            this.payInfoPnl.Size = new System.Drawing.Size(389, 218);
            this.payInfoPnl.TabIndex = 56;
            this.payInfoPnl.Visible = false;
            // 
            // timerForPayLbl
            // 
            this.timerForPayLbl.AutoSize = true;
            this.timerForPayLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timerForPayLbl.Location = new System.Drawing.Point(27, 27);
            this.timerForPayLbl.Name = "timerForPayLbl";
            this.timerForPayLbl.Size = new System.Drawing.Size(0, 37);
            this.timerForPayLbl.TabIndex = 64;
            // 
            // payToCodeTxtBx
            // 
            this.payToCodeTxtBx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.payToCodeTxtBx.Location = new System.Drawing.Point(136, 105);
            this.payToCodeTxtBx.MaxLength = 10;
            this.payToCodeTxtBx.Name = "payToCodeTxtBx";
            this.payToCodeTxtBx.Size = new System.Drawing.Size(94, 29);
            this.payToCodeTxtBx.TabIndex = 64;
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
            this.payingBtn.Location = new System.Drawing.Point(270, 169);
            this.payingBtn.Name = "payingBtn";
            this.payingBtn.Rotation = 0D;
            this.payingBtn.Size = new System.Drawing.Size(109, 46);
            this.payingBtn.TabIndex = 35;
            this.payingBtn.Text = "Ödemeyi Yap";
            this.payingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.payingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.payingBtn.UseVisualStyleBackColor = false;
            this.payingBtn.Click += new System.EventHandler(this.payingBtn_Click);
            // 
            // payInfoLbl
            // 
            this.payInfoLbl.AutoSize = true;
            this.payInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.payInfoLbl.Location = new System.Drawing.Point(17, 64);
            this.payInfoLbl.Name = "payInfoLbl";
            this.payInfoLbl.Size = new System.Drawing.Size(362, 84);
            this.payInfoLbl.TabIndex = 39;
            this.payInfoLbl.Text = "Ödemeniz Başarıyla \r\nGerçekleşmiştir.\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(-6, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 15);
            this.panel2.TabIndex = 55;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLbl.Location = new System.Drawing.Point(12, 266);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(336, 37);
            this.infoLbl.TabIndex = 52;
            this.infoLbl.Text = "Kart Bilgilerinizi Giriniz.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.codeSendBtn);
            this.panel1.Controls.Add(this.bbdYearTxtBx);
            this.panel1.Controls.Add(this.bbdMonthTxtBx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cvvTxtBx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fourNo4txtBx);
            this.panel1.Controls.Add(this.fourNo1txtBx);
            this.panel1.Controls.Add(this.fourNo2txtBx);
            this.panel1.Controls.Add(this.fourNo3txtBx);
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(-6, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 146);
            this.panel1.TabIndex = 54;
            // 
            // codeSendBtn
            // 
            this.codeSendBtn.BackColor = System.Drawing.Color.White;
            this.codeSendBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.codeSendBtn.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.codeSendBtn.IconColor = System.Drawing.Color.Black;
            this.codeSendBtn.IconSize = 20;
            this.codeSendBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.codeSendBtn.Location = new System.Drawing.Point(664, 85);
            this.codeSendBtn.Name = "codeSendBtn";
            this.codeSendBtn.Rotation = 0D;
            this.codeSendBtn.Size = new System.Drawing.Size(109, 46);
            this.codeSendBtn.TabIndex = 63;
            this.codeSendBtn.Text = "Ödemeyi Yap";
            this.codeSendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.codeSendBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.codeSendBtn.UseVisualStyleBackColor = false;
            this.codeSendBtn.Click += new System.EventHandler(this.codeSendBtn_Click);
            // 
            // bbdYearTxtBx
            // 
            this.bbdYearTxtBx.Location = new System.Drawing.Point(377, 63);
            this.bbdYearTxtBx.MaxLength = 2;
            this.bbdYearTxtBx.Name = "bbdYearTxtBx";
            this.bbdYearTxtBx.Size = new System.Drawing.Size(52, 25);
            this.bbdYearTxtBx.TabIndex = 62;
            this.bbdYearTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bbdYearTxtBx_KeyPress);
            // 
            // bbdMonthTxtBx
            // 
            this.bbdMonthTxtBx.Location = new System.Drawing.Point(312, 63);
            this.bbdMonthTxtBx.MaxLength = 2;
            this.bbdMonthTxtBx.Name = "bbdMonthTxtBx";
            this.bbdMonthTxtBx.Size = new System.Drawing.Size(52, 25);
            this.bbdMonthTxtBx.TabIndex = 61;
            this.bbdMonthTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bbdMonthTxtBx_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 37);
            this.label3.TabIndex = 60;
            this.label3.Text = "Son Kullanma Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 59;
            this.label2.Text = "CVV:";
            // 
            // cvvTxtBx
            // 
            this.cvvTxtBx.Location = new System.Drawing.Point(110, 106);
            this.cvvTxtBx.MaxLength = 3;
            this.cvvTxtBx.Name = "cvvTxtBx";
            this.cvvTxtBx.Size = new System.Drawing.Size(70, 25);
            this.cvvTxtBx.TabIndex = 58;
            this.cvvTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cvvTxtBx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Kart numarası:";
            // 
            // fourNo4txtBx
            // 
            this.fourNo4txtBx.Location = new System.Drawing.Point(453, 13);
            this.fourNo4txtBx.MaxLength = 4;
            this.fourNo4txtBx.Name = "fourNo4txtBx";
            this.fourNo4txtBx.Size = new System.Drawing.Size(70, 25);
            this.fourNo4txtBx.TabIndex = 33;
            this.fourNo4txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fourNo4txtBx_KeyPress);
            // 
            // fourNo1txtBx
            // 
            this.fourNo1txtBx.Location = new System.Drawing.Point(301, 12);
            this.fourNo1txtBx.MaxLength = 4;
            this.fourNo1txtBx.Name = "fourNo1txtBx";
            this.fourNo1txtBx.Size = new System.Drawing.Size(70, 25);
            this.fourNo1txtBx.TabIndex = 30;
            this.fourNo1txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fourNo1txtBx_KeyPress);
            // 
            // fourNo2txtBx
            // 
            this.fourNo2txtBx.Location = new System.Drawing.Point(225, 12);
            this.fourNo2txtBx.MaxLength = 4;
            this.fourNo2txtBx.Name = "fourNo2txtBx";
            this.fourNo2txtBx.Size = new System.Drawing.Size(70, 25);
            this.fourNo2txtBx.TabIndex = 31;
            this.fourNo2txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fourNo2txtBx_KeyPress);
            // 
            // fourNo3txtBx
            // 
            this.fourNo3txtBx.Location = new System.Drawing.Point(377, 13);
            this.fourNo3txtBx.MaxLength = 4;
            this.fourNo3txtBx.Name = "fourNo3txtBx";
            this.fourNo3txtBx.Size = new System.Drawing.Size(70, 25);
            this.fourNo3txtBx.TabIndex = 32;
            this.fourNo3txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fourNo3txtBx_KeyPress);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.backBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backBtn.IconColor = System.Drawing.Color.Black;
            this.backBtn.IconSize = 24;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Rotation = 0D;
            this.backBtn.Size = new System.Drawing.Size(53, 37);
            this.backBtn.TabIndex = 53;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // feeLbl
            // 
            this.feeLbl.AutoSize = true;
            this.feeLbl.BackColor = System.Drawing.Color.White;
            this.feeLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feeLbl.Location = new System.Drawing.Point(259, 203);
            this.feeLbl.Name = "feeLbl";
            this.feeLbl.Size = new System.Drawing.Size(67, 37);
            this.feeLbl.TabIndex = 51;
            this.feeLbl.Text = "(TL)";
            // 
            // duesRadioBtn
            // 
            this.duesRadioBtn.AutoSize = true;
            this.duesRadioBtn.BackColor = System.Drawing.Color.White;
            this.duesRadioBtn.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duesRadioBtn.Location = new System.Drawing.Point(238, 159);
            this.duesRadioBtn.Name = "duesRadioBtn";
            this.duesRadioBtn.Size = new System.Drawing.Size(105, 41);
            this.duesRadioBtn.TabIndex = 50;
            this.duesRadioBtn.TabStop = true;
            this.duesRadioBtn.Text = "Aidat";
            this.duesRadioBtn.UseVisualStyleBackColor = false;
            // 
            // totalDebtRadioBtn
            // 
            this.totalDebtRadioBtn.AutoSize = true;
            this.totalDebtRadioBtn.BackColor = System.Drawing.Color.White;
            this.totalDebtRadioBtn.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalDebtRadioBtn.Location = new System.Drawing.Point(17, 159);
            this.totalDebtRadioBtn.Name = "totalDebtRadioBtn";
            this.totalDebtRadioBtn.Size = new System.Drawing.Size(196, 41);
            this.totalDebtRadioBtn.TabIndex = 49;
            this.totalDebtRadioBtn.TabStop = true;
            this.totalDebtRadioBtn.Text = "Toplam Borç";
            this.totalDebtRadioBtn.UseVisualStyleBackColor = false;
            // 
            // paySelectLbl
            // 
            this.paySelectLbl.AutoSize = true;
            this.paySelectLbl.BackColor = System.Drawing.Color.Gray;
            this.paySelectLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paySelectLbl.Location = new System.Drawing.Point(10, 90);
            this.paySelectLbl.Name = "paySelectLbl";
            this.paySelectLbl.Size = new System.Drawing.Size(347, 37);
            this.paySelectLbl.TabIndex = 48;
            this.paySelectLbl.Text = "Hangisini Ödeyeceksiniz?";
            // 
            // totalDebtLbl
            // 
            this.totalDebtLbl.AutoSize = true;
            this.totalDebtLbl.BackColor = System.Drawing.Color.White;
            this.totalDebtLbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalDebtLbl.Location = new System.Drawing.Point(45, 203);
            this.totalDebtLbl.Name = "totalDebtLbl";
            this.totalDebtLbl.Size = new System.Drawing.Size(67, 37);
            this.totalDebtLbl.TabIndex = 57;
            this.totalDebtLbl.Text = "(TL)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // codeExpoLbl
            // 
            this.codeExpoLbl.AutoSize = true;
            this.codeExpoLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.codeExpoLbl.Location = new System.Drawing.Point(70, 35);
            this.codeExpoLbl.Name = "codeExpoLbl";
            this.codeExpoLbl.Size = new System.Drawing.Size(316, 52);
            this.codeExpoLbl.TabIndex = 40;
            this.codeExpoLbl.Text = "saniye içinde lütfen  telefonunuza\r\n gelen kodu giriniz.";
            // 
            // payPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalDebtLbl);
            this.Controls.Add(this.payInfoPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.feeLbl);
            this.Controls.Add(this.duesRadioBtn);
            this.Controls.Add(this.totalDebtRadioBtn);
            this.Controls.Add(this.paySelectLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "payPage";
            this.Text = "payPage";
            this.Load += new System.EventHandler(this.payPage_Load);
            this.payInfoPnl.ResumeLayout(false);
            this.payInfoPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel payInfoPnl;
        private System.Windows.Forms.Label payInfoLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox fourNo4txtBx;
        public System.Windows.Forms.TextBox fourNo1txtBx;
        private FontAwesome.Sharp.IconButton payingBtn;
        public System.Windows.Forms.TextBox fourNo2txtBx;
        public System.Windows.Forms.TextBox fourNo3txtBx;
        public FontAwesome.Sharp.IconButton backBtn;
        private System.Windows.Forms.Label feeLbl;
        private System.Windows.Forms.RadioButton duesRadioBtn;
        private System.Windows.Forms.RadioButton totalDebtRadioBtn;
        private System.Windows.Forms.Label paySelectLbl;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox bbdYearTxtBx;
        public System.Windows.Forms.TextBox bbdMonthTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox cvvTxtBx;
        private System.Windows.Forms.Label totalDebtLbl;
        private FontAwesome.Sharp.IconButton codeSendBtn;
        public System.Windows.Forms.TextBox payToCodeTxtBx;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerForPayLbl;
        private System.Windows.Forms.Label codeExpoLbl;
    }
}