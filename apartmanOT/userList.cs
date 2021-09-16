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
    public partial class userList : Form
    {
        public userList()
        {
            InitializeComponent();
            
        }
        //Diğer formlara geçiş
        private void userAddBtn_Click(object sender, EventArgs e)
        {
           
            userEdit openingTab = new userEdit();
            this.Hide();
            openingTab.Show();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            homePage openingTab = new homePage();
            this.Hide();
            openingTab.Show();
        }

        string[] apartmentInfo = File.ReadAllLines("ApartmanSakinleriVeYonetici.txt", Encoding.UTF8);
        private void userList_Load(object sender, EventArgs e)
        {
            //Listview e txt dosyasından bilgileri okutup  yazdırma

            for (int index = 1; index < apartmentInfo.Length; index++)
            {
                string[] userInfo = apartmentInfo[index].Split('|');
                ListViewItem userInfoLVI = new ListViewItem(userInfo);
                userListV.Items.Add(userInfoLVI);
            }


            recordCountLbl.Text = Convert.ToString(userListV.Items.Count);
        }

        public static int editIndex;
        public static bool editBtnControl= false;
        private void userEditBtn_Click(object sender, EventArgs e)
        {
            //Düzenleme yapmak için seçilen kullanıcı kontrolu
            if (userListV.SelectedIndices.Count > 0)
            {
                editIndex = userListV.FocusedItem.Index;
                editBtnControl = true;
                userEdit openingTab = new userEdit();
                this.Hide();
                openingTab.Show();
            }
            else
                MessageBox.Show("Lütfen düzenlemek istediğiniz  apartman sakinini seçiniz!");
        }

        private void userRemoveBtn_Click(object sender, EventArgs e)
        {
            //Silme yapmak için seçilen kullanıcı kontrolu ve silme işlemi

            if (userListV.SelectedIndices.Count>0)
            {
                string[] adminInfo = apartmentInfo[0].Split('|');
                //Listviewden silme
                userListV.Items.Remove(userListV.SelectedItems[0]);
                //Txtden silme
                FileStream fs = new FileStream("ApartmanSakinleriVeYonetici.txt", FileMode.Truncate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < adminInfo.Length; i++)
                {
                    sw.Write(adminInfo[i] + "|");
                }
                sw.WriteLine();

                for (int index = 0; index < userListV.Items.Count; index++)
                {
                    for (int j = 0; j < userListV.Columns.Count; j++)
                    {
                        sw.Write(userListV.Items[index].SubItems[j].Text + "|");
                      
                    }
                    if (index != (userListV.Items.Count - 1))
                    sw.WriteLine();
                    

                }
                sw.Flush();
                sw.Close();
                fs.Close();
                recordCountLbl.Text = Convert.ToString(userListV.Items.Count);
                MessageBox.Show("Bir site sakini silindi!");
            }
            else
                MessageBox.Show("Lütfen silmek istediğiniz apartman sakinini seçiniz!");

        }

        //Aranan kullanıcıyı bulma
        int clickControl = 0;
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (clickControl == 0)
            {
                for (int i = 0; i < userListV.Items.Count; i++)
                {
                    if (userListV.Items[i].SubItems[1].Text == searchTxtBx.Text)
                    { 
                        userListV.Focus();
                        userListV.Items[i].Selected = true;
                        userListV.Items[i].BackColor = Color.Gray;
                       
                    }
                    else
                        userListV.Items[i].BackColor = Color.Empty;

                }
            }
        }

    }
}
