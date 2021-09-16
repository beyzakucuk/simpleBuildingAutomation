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
    public partial class userEdit : Form
    {
        public userEdit()
        {
            InitializeComponent();
        }

        string date = DateTime.Now.ToShortDateString();
     
        private void userRegisterBtn_Click(object sender, EventArgs e)
        {
            string[] apartmentInfo = File.ReadAllLines("ApartmanSakinleriVeYonetici.txt", Encoding.UTF8);
            //Yeni kullanıcı ekleme 
            string[] userInfo = { nameTxtBx.Text, apartmentNoTxtBx.Text, phoneNoTxtBx.Text, apartmentStatusComboBox.Text, duesStatusComboBox.Text, totalDebtTxtBx.Text, passwordTxtBx.Text, rentalTxtBx.Text, date };
           //Kullanıcı daha önce eklenmiş mi kontrolu
               bool userEntityControl = false;
             for (int i = 0; i < apartmentInfo.Length; i++)
             {
                string[] userEntityInfo = apartmentInfo[i].Split('|');
                for (int j = 0; j < userEntityInfo.Length; j++)
                {
                    if (userEntityInfo[j] == apartmentNoTxtBx.Text || userEntityInfo[j] == passwordTxtBx.Text)
                     userEntityControl = true;
                    
                }
             }
             
            if (nameTxtBx.Text != "" && apartmentNoTxtBx.Text != "" && phoneNoTxtBx.Text != "" && apartmentStatusComboBox.Text != "" && duesStatusComboBox.Text != "" && totalDebtTxtBx.Text != "" && passwordTxtBx.Text != "" && rentalTxtBx.Text != ""&&userEntityControl!=true)
            { 
                //Txt ye yazdırma
                FileStream fs = new FileStream("ApartmanSakinleriVeYonetici.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine();
                for (int index = 0; index < userInfo.Length; index++)
                {

                    sw.Write(userInfo[index] + "|");
                    
                }

                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("Apartman sakini başarıyla eklendi!");
                //Txtleri temizleme
                textBoxClear(this);


            }
            else
                MessageBox.Show("Girdiğiniz bilgiler eksik ya da daha önce aynı şifre veya daire numarasını kullandınız!");


        }
        //Geri forma geçiş
        private void backBtn_Click(object sender, EventArgs e)
        {
            userList.editBtnControl = false;
            userList openingTab = new userList();
            this.Hide();
            openingTab.Show();
        }

        private void userEdit_Load(object sender, EventArgs e)
        {
            if (apartmentStatusComboBox.Text=="Kiracı")
            {
                rentalLbl.Visible = true;
                rentalTxtBx.Visible = true;
            }
            else
                rentalTxtBx.Text = "--";

            string[] apartmentInfo = File.ReadAllLines("ApartmanSakinleriVeYonetici.txt", Encoding.UTF8);
           //Eğer kullanıcı listesi formunda düzenleme butonuna tıklandıysa seçilen kullanıcının bilgilerini textBoxlara yazdırma
            if (userList.editBtnControl == true)
            {
                editSaveBtn.Visible = true;
                userRegisterBtn.Visible = false;
                
                string[] editUserInfo = apartmentInfo[userList.editIndex + 1].Split('|');
                nameTxtBx.Text = editUserInfo[0];
                apartmentNoTxtBx.Text = editUserInfo[1];
                phoneNoTxtBx.Text = editUserInfo[2];
                apartmentStatusComboBox.Text = editUserInfo[3];
                totalDebtTxtBx.Text = editUserInfo[5];
                duesStatusComboBox.Text = editUserInfo[4];
                passwordTxtBx.Text = editUserInfo[6];
                if (editUserInfo[3] == "Kiracı")
                {
                    rentalLbl.Visible = true;
                    rentalTxtBx.Visible = true;
                    rentalTxtBx.Text = editUserInfo[7];
                }
                else
                    rentalTxtBx.Text = "--";
                date = editUserInfo[8];
               
            }

        }

        private void editSaveBtn_Click(object sender, EventArgs e)
        {
            
            string[] apartmentInfo = File.ReadAllLines("ApartmanSakinleriVeYonetici.txt", Encoding.UTF8);
            //Düzenlenen kullannıcının satırını txt de bulup düzenlenmiş haliyle değiştirip baştan txt yi yazdırma
            string [] userInfo = { nameTxtBx.Text, apartmentNoTxtBx.Text, phoneNoTxtBx.Text, apartmentStatusComboBox.Text, duesStatusComboBox.Text, totalDebtTxtBx.Text, passwordTxtBx.Text, rentalTxtBx.Text, date };
            string editTempUser = string.Join("|", userInfo.Skip(0));
            string editUser = "";
            bool userEntityControl = false;
            for (int i = 0; i < apartmentInfo.Length; i++)
            {
                string[] userEntityInfo = apartmentInfo[i].Split('|');
                for (int j = 0; j < userEntityInfo.Length; j++)
                {
                    if ((userEntityInfo[j] == apartmentNoTxtBx.Text || userEntityInfo[j] == passwordTxtBx.Text)&& i!=(userList.editIndex + 1))
                    {
                        userEntityControl = true;
                        break;
                    }
                }
                   
            }
            if (nameTxtBx.Text != "" && apartmentNoTxtBx.Text != "" && phoneNoTxtBx.Text != "" && apartmentStatusComboBox.Text != "" && duesStatusComboBox.Text != "" && totalDebtTxtBx.Text != "" && passwordTxtBx.Text != "" && rentalTxtBx.Text != "" &&userEntityControl!=true)
            {
                FileStream fs = new FileStream("ApartmanSakinleriVeYonetici.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < apartmentInfo.Length; i++)
                {
                    editUser = apartmentInfo[i];
                    if (apartmentInfo[i] == apartmentInfo[userList.editIndex + 1])
                    {
                        editUser = apartmentInfo[i].Replace(apartmentInfo[userList.editIndex + 1], editTempUser);

                    }
                    if (i != (apartmentInfo.Length - 1))
                        sw.WriteLine(editUser);
                    else
                        sw.Write(editUser);

                }

                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("Apartman sakini başarıyla düzenlendi!");
                //Textboxları temizleme
                textBoxClear(this);
            }
            else
                MessageBox.Show("Girdiğiniz bilgiler eksik ya da daha önce aynı şifre veya daire numarasını kullandınız!");



        }
        //TextBoxları temizleme metodu
        public static void textBoxClear(Control ctrl)
        {
            foreach(Control item in ctrl.Controls)
            {
                if( item is TextBox)
                  ((TextBox)item).Clear();
                
                if (item.Controls.Count > 0)
                    textBoxClear(item);
            }
        }

        //TextBoxlara girilen karakterlerin kontrolü
        private void nameTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void apartmentNoTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void phoneNoTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void totalDebtTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rentalTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //Kira veya ev sahibine göre formu ayarlama
        private void apartmentStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (apartmentStatusComboBox.SelectedIndex == 1)
            {
                rentalLbl.Visible = true;
                rentalTxtBx.Visible = true;
            }
            else
            {
                rentalLbl.Visible = false;
                rentalTxtBx.Visible = false;
                rentalTxtBx.Text = "--";
            }

        }
    }
}
