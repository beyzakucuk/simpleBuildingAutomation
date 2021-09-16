using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apartmanOT
{
    public partial class payPage : Form
    {
        public payPage()
        {
            InitializeComponent();
        }

        private void payingBtn_Click(object sender, EventArgs e)
        {
            //Yapılan ödemeye göre bilgileri değiştirip txtyi tekrar yazdırma
            if (payToCodeTxtBx.Text != "")
            {
                string[] apartmentInfo = File.ReadAllLines("ApartmanSakinleriVeYonetici.txt", Encoding.UTF8);
                string[] userInfo;
                FileStream fs = new FileStream("ApartmanSakinleriVeYonetici.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                string edit;

                if (duesRadioBtn.Checked == true)
                {
                    for (int i = 0; i < apartmentInfo.Length; i++)
                    {
                        edit = apartmentInfo[i];
                        userInfo = apartmentInfo[i].Split('|');
                        for (int t = 0; t < userInfo.Length; t++)
                        {
                            if (userInfo[t] == userLogin.userPassword)
                                edit = apartmentInfo[i].Replace(userInfo[(t - 2)], "Ödendi");

                        }

                        if (i != (apartmentInfo.Length - 1))
                            sw.WriteLine(edit);
                        else
                            sw.Write(edit);

                    }

                }
                else
                {

                    for (int i = 0; i < apartmentInfo.Length; i++)
                    {
                        edit = apartmentInfo[i];
                        userInfo = apartmentInfo[i].Split('|');
                        for (int t = 0; t < userInfo.Length; t++)
                        {
                            if (userInfo[t] == userLogin.userPassword)
                                edit = apartmentInfo[i].Replace(userInfo[(t - 1)], "0");

                        }

                        if (i != (apartmentInfo.Length - 1))
                            sw.WriteLine(edit);
                        else
                            sw.Write(edit);

                    }

                }
                sw.Flush();
                sw.Close();
                fs.Close();

                //Formu toparlama
                payInfoLbl.Visible = true;
                codeExpoLbl.Visible = false;
                payToCodeTxtBx.Visible = false;
                timer1.Enabled = false;
                timerForPayLbl.Visible = false;
                payingBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ödeme gerçekleştirilemedi!");
                payInfoPnl.Visible = false;
                codeSendBtn.Visible = true;
                timer1.Enabled = false;
                second = 60;
            }

        }
        //Önceki forma geçiş
        private void backBtn_Click(object sender, EventArgs e)
        {
            homePage openingTab = new homePage();
            this.Hide();
            openingTab.Show();
        }

        private void payPage_Load(object sender, EventArgs e)
        {
            //Aidat bedelini ve toplam borcunu yazdırma
            feeLbl.Text = File.ReadAllText("Aidat.txt") + " TL";
            totalDebtLbl.Text = homePage.totalDebt + " TL";
        }

        private void fourNo2txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //TextBox girilen karakter kontrolü
        private void fourNo1txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fourNo3txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fourNo4txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bbdMonthTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bbdYearTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cvvTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       //Telefondan gönderilen kodu girme süresi ayarlama
        int second = 60;  
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            second = second - 1;
            timerForPayLbl.Text = second.ToString();
            if(second==0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Ödeme gerçekleştirilemedi lütfen tekrar deneyiniz!");
                payInfoPnl.Visible = false;
                codeSendBtn.Visible = true;
                second = 60;
            }

        }

        private void codeSendBtn_Click(object sender, EventArgs e)
        {
            //Kredi kartı bilgi alanları tam doluluk kontrolü
           
                if (fourNo1txtBx.Text != "" && fourNo2txtBx.Text != "" && fourNo3txtBx.Text != "" && fourNo4txtBx.Text != "" && cvvTxtBx.Text != "" && bbdMonthTxtBx.Text != "" && bbdYearTxtBx.Text != "" && fourNo1txtBx.Text.Length == 4 && fourNo2txtBx.Text.Length == 4&&fourNo3txtBx.Text.Length==4&&fourNo4txtBx.Text.Length==4&&bbdMonthTxtBx.Text.Length==2&&bbdYearTxtBx.Text.Length==2&&cvvTxtBx.Text.Length==3)
                {
                
                    payInfoPnl.Visible = true;
                    payInfoLbl.Visible = false;
                    timer1.Enabled = true;
                    codeSendBtn.Visible = false;
               
                }
                else
                    MessageBox.Show("Kredi kartı bilgileriniz eksik!");
        }
    }
}
