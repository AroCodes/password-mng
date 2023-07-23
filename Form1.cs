using System.Diagnostics;
using System.Xml.Serialization;
using System.Xml;

namespace PassManager
{
    public partial class Form1 : Form
    {
        // Flag to indicate whether the ListBox selection is currently being changed
        public bool currentlyChanging = false;

        // List to store PasswordItem objects representing passwords
        public List<PasswordItem> PasswordList = new();

        // Flag to track if the edit checkbox is checked
        bool EditCheckBoxChecked = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When nothing is selected in the ListBox
            if (listBoxItems.SelectedIndex == -1 && !currentlyChanging)
            {
                buttonDelete.Enabled = false;
                textBoxWebsite.Enabled = false;
                textBoxUsername.Enabled = false;
                textBoxPassword.Enabled = false;
                textBoxWebsite.Text = "";
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                Debug.WriteLine("listBox was -1");
            }
            // When an item is selected in the ListBox
            else if (listBoxItems.SelectedIndex != -1)
            {
                buttonDelete.Enabled = true;
                textBoxWebsite.Enabled = true;
                textBoxUsername.Enabled = true;
                textBoxPassword.Enabled = true;
                LoadTextBoxs(listBoxItems.SelectedIndex);
                Debug.WriteLine("listBox changed and wasn't -1, it was" + listBoxItems.SelectedIndex);
            }
        }

        private void LoadTextBoxs(int selectedItem)
        {
            // Load the selected item's data into text boxes
            textBoxWebsite.Text = PasswordList[selectedItem].Website;
            textBoxUsername.Text = PasswordList[selectedItem].Username;
            textBoxPassword.Text = PasswordList[selectedItem].Password;
        }

        public void UpdateListBox()
        {
            // Update the ListBox with the items from the PasswordList
            listBoxItems.Items.Clear();
            foreach (PasswordItem item in PasswordList)
            {
                listBoxItems.Items.Add(item.Website);
                Debug.WriteLine(item.Website + "\\" + item.Username + "\\" + item.Password + "\n");
            }
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            // Create a new PasswordItem and add it to the PasswordList
            PasswordList.Add(new PasswordItem());
            UpdateListBox();
            listBoxItems.SelectedIndex = listBoxItems.Items.Count - 1;
        }

        private void EnableEditmode()
        {
            // Enable edit mode for text boxes and change the edit checkbox image
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
            // Disable edit mode for text boxes and change the edit checkbox image
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
            // Toggle edit mode based on the checkbox state
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
            // Refresh the ListBox with the latest PasswordList data
            UpdateListBox();
        }

        private void textBoxWebsite_TextChanged(object sender, EventArgs e)
        {
            // Update the Website property of the selected item when its name is modified
            if (listBoxItems.SelectedIndex != -1)
            {
                PasswordList[listBoxItems.SelectedIndex].Website = textBoxWebsite.Text;
                //Update title of selected item when its name is modified
                currentlyChanging = true;
                listBoxItems.Items[listBoxItems.SelectedIndex] = PasswordList[listBoxItems.SelectedIndex].Website;
                currentlyChanging = false;
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            // Check if anything is selected; if not, don't do anything
            if (listBoxItems.SelectedIndex != -1)
            {
                // Update the 'database' with the modified username
                PasswordList[listBoxItems.SelectedIndex].Username = textBoxUsername.Text;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // Check if anything is selected; if not, don't do anything
            if (listBoxItems.SelectedIndex != -1)
            {
                // Update the 'database' with the modified password
                PasswordList[listBoxItems.SelectedIndex].Password = textBoxPassword.Text;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Delete the selected item from the PasswordList and the ListBox
            if (listBoxItems.SelectedIndex != -1)
            {
                PasswordList.RemoveAt(listBoxItems.SelectedIndex);
                listBoxItems.Items.RemoveAt(listBoxItems.SelectedIndex);
            }
        }
        // 'Avoid flickering'
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }
        //// Style comboBox right
        //private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if (e.Index < 0) return;

        //    ComboBox comboBox = (ComboBox)sender;
        //    e.DrawBackground();

        //    // Determine the color for the text and background based on selection and focus
        //    Color textColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.White : Color.White;
        //    Color bgColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(50, 50, 50) : Color.FromArgb(30, 30, 30);

        //    // Draw the background
        //    using (SolidBrush brush = new SolidBrush(bgColor))
        //    {
        //        e.Graphics.FillRectangle(brush, e.Bounds);
        //    }

        //    // Draw the item text
        //    using (StringFormat sf = new StringFormat())
        //    {
        //        sf.LineAlignment = StringAlignment.Center;
        //        sf.Alignment = StringAlignment.Near;

        //        using (SolidBrush brush = new SolidBrush(textColor))
        //        {
        //            e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, brush, e.Bounds, sf);
        //        }
        //    }

        //    e.DrawFocusRectangle();
        //}

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveToXML(textBoxPath.Text);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "All Files (*.*) | *.*|XML files (*.xml) | *.xml|CSV file (*.csv) | *.csv";
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = oSaveFileDialog.FileName;
                string extesion = Path.GetExtension(fileName);
                switch (extesion)
                {
                    case ".csv"://do something here 
                        textBoxPath.Text = fileName;
                        break;
                    case ".xml"://do something here 
                        textBoxPath.Text = fileName;
                        break;
                    default://do something here
                        textBoxPath.Text = fileName;
                        break;
                }
            }
        }
        private void SaveToXML(string filePath)
        {
            TextWriter? writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(List<PasswordItem>));
                writer = new StreamWriter(filePath);
                serializer.Serialize(writer, PasswordList);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        private List<PasswordItem> LoadFromXML(string filePath)
        {
            TextReader? reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(List<PasswordItem>));
                reader = new StreamReader(filePath);
                try
                {
                    List<PasswordItem>? ReadReturnedPasswordItems = (List<PasswordItem>?)serializer.Deserialize(reader);
                    return ReadReturnedPasswordItems;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message + "\nLoading empty passwords...", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    List<PasswordItem> emptyReturnedPasswordItems = new List<PasswordItem>();
                    return emptyReturnedPasswordItems;
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            PasswordList = LoadFromXML(textBoxPath.Text);
            UpdateListBox();
        }
    }
    [Serializable]
    public class PasswordItem
    {
        public string Website = "";
        public string Username = "";
        public string Password = "";

        //// Properties to access the private fields
        //public string Website
        //{
        //    get { return website; }
        //    set { website = value; }
        //}
        //public string Username
        //{
        //    get { return username; }
        //    set { username = value; }
        //}
        //public string Password
        //{
        //    get { return password; }
        //    set { password = value; }
        //}

        // Constructor to initialize a PasswordItem object
        //public PasswordItem(string w, string u, string p)
        //{
        //    Website = w;
        //    Username = u;
        //    Password = p;
        //}
    }
}