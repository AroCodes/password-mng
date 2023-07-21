using System.Diagnostics;

namespace PassManager
{
    public partial class Form1 : Form
    {
        public List<PasswordItem> PasswordList = new List<PasswordItem>();

        bool EditCheckBoxChecked = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
            {
                Debug.WriteLine(listBoxItems.SelectedIndex);
                if (buttonDelete.Enabled)
                {
                    buttonDelete.Enabled = false;
                    textBoxWebsite.Enabled = false;
                    textBoxWebsite.Text = "";
                    textBoxUsername.Enabled = false;
                    textBoxUsername.Text = "";
                    textBoxPassword.Enabled = false;
                    textBoxPassword.Text = "";
                }
                return;
            }
            else
            {
                if (!buttonDelete.Enabled)
                {
                    textBoxWebsite.Enabled = true;
                    textBoxUsername.Enabled = true;
                    textBoxPassword.Enabled = true;
                    buttonDelete.Enabled = true;
                }
                LoadTextBoxs(listBoxItems.SelectedIndex);
                
            }
        }
        private void LoadTextBoxs(int selectedItem)
        {
            textBoxWebsite.Text = PasswordList[selectedItem].Website;
            textBoxUsername.Text = PasswordList[selectedItem].Username;
            textBoxPassword.Text = PasswordList[selectedItem].Password;
        }
        public void UpdateListBox()
        {
            listBoxItems.Items.Clear();
            foreach (PasswordItem item in PasswordList)
            {
                //int indexbefore = listBoxItems.SelectedIndex;
                listBoxItems.Items.Add(item.Website);
                Debug.WriteLine(item.Website + "\\" + item.Username + "\\" + item.Password + "\n");
                //listBoxItems.SelectedIndex = indexbefore;
            }
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            PasswordList.Add(new PasswordItem("example.com", "example@gmail.com", string.Empty));
            UpdateListBox();
            listBoxItems.SelectedIndex = listBoxItems.Items.Count - 1;

        }

        private void EnableEditmode()
        {
            buttonCheckBoxEdit.Image = PassManager.Properties.Resources.edit_off_FILL0_wght400_GRAD0_opsz20;
            textBoxWebsite.BorderStyle = BorderStyle.Fixed3D;
            textBoxUsername.BorderStyle = BorderStyle.Fixed3D;
            textBoxPassword.BorderStyle = BorderStyle.Fixed3D;
            textBoxWebsite.ReadOnly = false;
            textBoxUsername.ReadOnly = false;
            textBoxPassword.ReadOnly = false;
        }
        private void DisableEditmode()
        {
            buttonCheckBoxEdit.Image = PassManager.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz20;
            textBoxWebsite.BorderStyle = BorderStyle.None;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxWebsite.ReadOnly = true;
            textBoxUsername.ReadOnly = true;
            textBoxPassword.ReadOnly = true;
        }

        private void buttonCheckBoxEdit_Click(object sender, EventArgs e)
        {
            if (!EditCheckBoxChecked)
            {
                EditCheckBoxChecked = true;
                EnableEditmode();
            }
            else
            {
                EditCheckBoxChecked = false;
                DisableEditmode();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void textBoxWebsite_TextChanged(object sender, EventArgs e)
        {
            //////Check if anyithing is selected if not don't do anyithing
            ////if (listBoxItems.SelectedIndex != -1)
            ////{
            ////    object itembefore = listBoxItems.SelectedItem;
            //Update 'database'
            PasswordList[listBoxItems.SelectedIndex].Website = textBoxWebsite.Text;
            //Update title of selected item when it's name is modified
            listBoxItems.Items[listBoxItems.SelectedIndex] = PasswordList[listBoxItems.SelectedIndex].Website;
            
            ////    listBoxItems.SelectedItem = itembefore;
            ////}
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            //Check if anyithing is selected if not don't do anyithing
            if (listBoxItems.SelectedIndex != -1)
            {
                //Update 'database'
                PasswordList[listBoxItems.SelectedIndex].Username = textBoxUsername.Text;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            //Check if anyithing is selected if not don't do anyithing
            if (listBoxItems.SelectedIndex != -1)
            {
                //Update 'database'
                PasswordList[listBoxItems.SelectedIndex].Password = textBoxPassword.Text;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1)
            {
                PasswordList.RemoveAt(listBoxItems.SelectedIndex);
                listBoxItems.Items.RemoveAt(listBoxItems.SelectedIndex);
            }
        }
    }
    public class PasswordItem
    {
        private string website = "";
        private string username = "";
        private string password = "";

        public string Website
        {
            get { return website; }
            set { website = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public PasswordItem(string w, string u, string p)
        {
            Website = w;
            Username = u;
            Password = p;
        }
    }
}