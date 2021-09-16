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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        public static string totalDebt="";
        private void homePage_Load(object sender, EventArgs e)
        {
            //Giriş yapan kullanıcı veya admine göre forma txtden okutup yazdırma
            string[] apartmentInfo = File.ReadAllLines("ApartmanSakinleriVeYonetici.txt", Encoding.UTF8);
            //Adminse
            if (userLogin.adminControl == true)
            {
                string[] adminInfo = apartmentInfo[0].Split('|');
                adminPnl.Visible = true;
                payingBtn.Visible = false;
                payingLbl.Visible = false;
                nameLbl.Text = "Sayın  " + adminInfo[0]; 
                feeTxtBx.Text = File.ReadAllText("Aidat.txt");
                feeDayTxtBx.Text = File.ReadAllText("AidatToplamaGunu.txt");
               
            }
            else
            {
                //Kullanıcıysa
                string[] userInfo;

                for (int i = 1; i < apartmentInfo.Length; i++)
                {
                    if (apartmentInfo[i].Contains(userLogin.userPassword))
                    {
                        userInfo = apartmentInfo[i].Split('|');
                        nameLbl.Text = "Sayın " + userInfo[0];
                        apartmentNoLbl2.Text = userInfo[1];
                        phoneNoLbl2.Text = userInfo[2];
                        apartmentStatusLbl2.Text = userInfo[3];
                        duesStatusLbl2.Text = userInfo[4];
                        totalDebtLbl2.Text = userInfo[5];
                        rentalLbl2.Text = userInfo[7];
                        totalDebt = userInfo[5];
                        if (duesStatusLbl2.Text == "Ödenmedi")
                        {

                            duesInfoNI.Visible = true;
                            duesInfoNI.ShowBalloonTip(3000, "Unutmayınız!", "Aidatı ödemediniz", ToolTipIcon.Info);

                        }
                        else if (duesStatusLbl2.Text == "Ödendi" && totalDebtLbl2.Text == "0")
                            payingBtn.Enabled = false;
                        break;
                    }

                }
            }
            
        }
        //Diğer formlara geçiş
        private void userEditbtn_Click(object sender, EventArgs e)
        {
            if (feeDayTxtBx.Text == "" || feeTxtBx.Text == "")
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
            else
            {
                userList openingTab = new userList();
                this.Hide();
                openingTab.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            userLogin.adminControl = false;
            userLogin openingTab = new userLogin();
            this.Hide();
            openingTab.Show();
        }

        private void payingBtn_Click(object sender, EventArgs e)
        {
            payPage openingTab = new payPage();
            this.Hide();
            openingTab.Show();
        }

        //Aidat belirleme veya değiştirme
  
        private void editDuesBtn_Click(object sender, EventArgs e)
        {
            if (feeTxtBx.Text != "")
            { 
                FileStream fs = new FileStream("Aidat.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(feeTxtBx.Text);
                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("Aidat miktarı belirlendi!");

            }
            else
            MessageBox.Show("Lütfen aidat mikatarını giriniz!");



        }
        //TextBox kontrolu
        private void feeTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void feeDayBtn_Click(object sender, EventArgs e)
        {
            if (feeDayTxtBx.Text != "" && Convert.ToInt32(feeDayTxtBx.Text) > 0 && Convert.ToInt32(feeDayTxtBx.Text) < 30)
            {  
                
                MessageBox.Show("Aidatın toplanacağı gün belirlendi!");
                FileStream fs = new FileStream("AidatToplamaGunu.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(feeDayTxtBx.Text);
                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("Aidatın toplanacağı gün belirlendi!");
            }
            else
            MessageBox.Show("Lütfen aidatın ayın kaçında toplanacağını bir ay için geçerli bir sayı ile giriniz!");

        }

        private void feeDayTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void totalDebtBtn_Click(object sender, EventArgs e)
        {
            //Aidat toplama gününe göre kullanıcı bilgilerini düzenleme
            if (File.Exists("AidatToplamaGunu.txt") == true&&File.Exists("Aidat.txt")==true)
            {
                string feeDay = File.ReadAllText("AidatToplamaGunu.txt");
                if (Convert.ToInt32(feeDay) == DateTime.Now.Day)
                {
                    string[] apartmentInfo = File.ReadAllLines("ApartmanSakinleriVeYonetici.txt", Encoding.UTF8);
                    string fee = File.ReadAllText("Aidat.txt");
                    FileStream fs = new FileStream("ApartmanSakinleriVeYonetici.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    string editUser = "";

                    for (int i = 0; i < apartmentInfo.Length; i++)
                    {
                        editUser = apartmentInfo[i];
                        string[] userInfo = apartmentInfo[i].Split('|');
                        for (int j = 0; j < userInfo.Length; j++)
                        {
                            if (userInfo[j] == "Ödenmedi")
                            {
                                editUser = apartmentInfo[i].Replace(userInfo[(j + 1)], (Convert.ToInt32(userInfo[(j+1)]) + Convert.ToInt32(fee)).ToString());

                            }
                            else if (userInfo[j]=="Ödendi")
                                editUser = apartmentInfo[i].Replace(userInfo[j],"Ödenmedi");


                        }
                        if (i != (apartmentInfo.Length - 1))
                            sw.WriteLine(editUser);
                        else
                            sw.Write(editUser);
                    }

                    sw.Flush();
                    sw.Close();
                    fs.Close();
                    totalDebtBtn.BackColor = Color.Gray;
                    totalDebtBtn.Enabled = false;
                    MessageBox.Show(DateTime.Now.Month + ". ayın aidat borçları işlendi.");
                }
                else
                    MessageBox.Show("Bugün aidat toplama günü değil!");
            }
            else
                MessageBox.Show("Aidat toplama gününü ve aidat miktarını belirleyiniz!");
            
        }
    }
}
