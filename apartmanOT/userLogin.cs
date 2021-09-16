using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace apartmanOT
{
    public partial class userLogin : Form
    {
        public userLogin()
        {
            InitializeComponent();
           
        }
           
        
        private void signUpButton_Click(object sender, EventArgs e)
        { 
            //Admin kayıt panelini açma
            AdminSignUpPanel.Visible = true;
            signUpButton.Visible = false;
            warningLabel.Visible = false;
        }
        
        private void adminSignUpButton_Click(object sender, EventArgs e)
        {
            //Admin kaydetme bilgilerini txt de tutma.
            string[] adminInfoEntered = { nameTxtBx.Text, apartmentNoTxtBx.Text, phoneNoTxtBx.Text, passwordTxtBx.Text };
            
            if (passwordTxtBx.Text == password2TxtBx.Text&&nameTxtBx.Text!=""&&passwordTxtBx.Text!=""&&phoneNoTxtBx.Text!=""&&apartmentNoTxtBx.Text!="")
            {
                AdminSignUpPanel.Visible = false;
                FileStream fs = new FileStream("ApartmanSakinleriVeYonetici.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                for (int index = 0; index < adminInfoEntered.Length; index++)
                {
                    sw.Write(adminInfoEntered[index] + "|");
                    
                }
                sw.Flush();
                sw.Close();
                fs.Close();
                userEdit.textBoxClear(this);
               
            }
            else
                MessageBox.Show("Şifreleriniz Birbirine Uyuşmuyor ya da Bilgilerinizi Eksik Girdiniz!!");


        }
        public static bool adminControl=false;
        public static string userPassword = "";
        private void loginButton_Click(object sender, EventArgs e)
        {
            //Giriş yapmaya calışan kullanıcının veya adminin verierini txtden kontrol etme
            bool txtBxControl = false;
            bool userControl = false; 
            int repeatControl=0;
            if (File.Exists("ApartmanSakinleriVeYonetici.txt") == true)
            {
                string[] apartmentInfo = File.ReadAllLines("ApartmanSakinleriVeYonetici.txt", Encoding.UTF8);
                string[] adminInfo = apartmentInfo[0].Split('|');
                //Adminse
                if (adminInfo[3] == mainPasswordTxtBx.Text && adminInfo[1] == mainApartmentNoTxtBx.Text)
                {
                    adminControl = true;
                    homePage openinTab = new homePage();
                    this.Hide();
                    openinTab.Show();
                }
                else
                {
                    //Kullanıcıysa
                    
                     for (int i = 1; i < apartmentInfo.Length; i++)
                     {    
                            string[] userInfo = apartmentInfo[i].Split('|');
                        for (int j = 0; j < userInfo.Length; j++)
                        {
                                
                            if (mainApartmentNoTxtBx.Text != "" && mainPasswordTxtBx.Text != "")
                            {
                               
                                if (userInfo[j] == mainApartmentNoTxtBx.Text && userInfo[j + 5] == mainPasswordTxtBx.Text)
                                {
                                        repeatControl++;
                                        userPassword = mainPasswordTxtBx.Text;
                                        homePage openinTab = new homePage();
                                        this.Hide();
                                        openinTab.Show();
                                        
                                }
                                else
                                  userControl = true;
                            }
                            else
                            txtBxControl = true;
                        }
                     }
                    
                }
            }
            else
                MessageBox.Show("Lütfen kayıt olunuz!");

            if (txtBxControl == true)
                MessageBox.Show("Lütfen bilgilerinizi giriniz!");
            if (userControl == true && repeatControl == 0)
                MessageBox.Show("Böyle bir kullanıcı mevcut değil! ");
           
        }

        //TextBoxlara girilen karakter kontrolleri
        private void mainApartmentNoTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nameTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void phoneNoTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void apartmentNoTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
