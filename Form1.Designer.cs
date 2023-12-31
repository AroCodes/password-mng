﻿namespace PassManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxItems = new ListBox();
            buttonSave = new Button();
            buttonLoad = new Button();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelWebsite = new Label();
            textBoxWebsite = new TextBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            groupBoxSaveLoad = new GroupBox();
            buttonBrowse = new Button();
            textBox1 = new TextBox();
            labelKey = new Label();
            textBoxPath = new TextBox();
            labelPath = new Label();
            buttonCreateNew = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            buttonSearch = new Button();
            buttonMore = new Button();
            buttonCheckBoxEdit = new Button();
            groupBoxSaveLoad.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxItems
            // 
            listBoxItems.BackColor = Color.FromArgb(30, 30, 30);
            listBoxItems.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxItems.ForeColor = Color.White;
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 17;
            listBoxItems.Location = new Point(12, 12);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(224, 446);
            listBoxItems.TabIndex = 4;
            listBoxItems.SelectedIndexChanged += listBoxItems_SelectedIndexChanged;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(30, 30, 30);
            buttonSave.FlatAppearance.BorderColor = Color.White;
            buttonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Image = Properties.Resources.save_FILL0_wght400_GRAD0_opsz20;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(381, 77);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(81, 27);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save...";
            buttonSave.TextAlign = ContentAlignment.MiddleRight;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.FromArgb(30, 30, 30);
            buttonLoad.FlatAppearance.BorderColor = Color.White;
            buttonLoad.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            buttonLoad.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            buttonLoad.FlatStyle = FlatStyle.Flat;
            buttonLoad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoad.ForeColor = Color.White;
            buttonLoad.Image = Properties.Resources.input_FILL0_wght400_GRAD0_opsz20;
            buttonLoad.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLoad.Location = new Point(294, 77);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(81, 27);
            buttonLoad.TabIndex = 6;
            buttonLoad.Text = "Load...";
            buttonLoad.TextAlign = ContentAlignment.MiddleRight;
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(242, 59);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(74, 19);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(30, 30, 30);
            textBoxUsername.Enabled = false;
            textBoxUsername.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.ForeColor = Color.White;
            textBoxUsername.Location = new Point(322, 52);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(388, 30);
            textBoxUsername.TabIndex = 8;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // labelWebsite
            // 
            labelWebsite.AutoSize = true;
            labelWebsite.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelWebsite.Location = new Point(242, 19);
            labelWebsite.Name = "labelWebsite";
            labelWebsite.Size = new Size(60, 19);
            labelWebsite.TabIndex = 9;
            labelWebsite.Text = "Website:";
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.BackColor = Color.FromArgb(30, 30, 30);
            textBoxWebsite.Enabled = false;
            textBoxWebsite.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWebsite.ForeColor = Color.White;
            textBoxWebsite.Location = new Point(322, 12);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(388, 30);
            textBoxWebsite.TabIndex = 10;
            textBoxWebsite.TextChanged += textBoxWebsite_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(30, 30, 30);
            textBoxPassword.Enabled = false;
            textBoxPassword.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(322, 93);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(388, 30);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(242, 100);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 19);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Password:";
            // 
            // groupBoxSaveLoad
            // 
            groupBoxSaveLoad.Controls.Add(buttonBrowse);
            groupBoxSaveLoad.Controls.Add(textBox1);
            groupBoxSaveLoad.Controls.Add(labelKey);
            groupBoxSaveLoad.Controls.Add(textBoxPath);
            groupBoxSaveLoad.Controls.Add(labelPath);
            groupBoxSaveLoad.Controls.Add(buttonSave);
            groupBoxSaveLoad.Controls.Add(buttonLoad);
            groupBoxSaveLoad.ForeColor = Color.White;
            groupBoxSaveLoad.Location = new Point(242, 385);
            groupBoxSaveLoad.Name = "groupBoxSaveLoad";
            groupBoxSaveLoad.Size = new Size(468, 110);
            groupBoxSaveLoad.TabIndex = 13;
            groupBoxSaveLoad.TabStop = false;
            groupBoxSaveLoad.Text = "Save/Load file options";
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = Color.FromArgb(30, 30, 30);
            buttonBrowse.FlatAppearance.BorderColor = Color.White;
            buttonBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            buttonBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            buttonBrowse.FlatStyle = FlatStyle.Flat;
            buttonBrowse.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBrowse.ForeColor = Color.White;
            buttonBrowse.Image = Properties.Resources.folder_open_FILL1_wght400_GRAD0_opsz20;
            buttonBrowse.Location = new Point(435, 51);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(27, 22);
            buttonBrowse.TabIndex = 21;
            buttonBrowse.TextAlign = ContentAlignment.MiddleRight;
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.Enabled = false;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(48, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 23);
            textBox1.TabIndex = 25;
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Enabled = false;
            labelKey.Location = new Point(8, 25);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(29, 15);
            labelKey.TabIndex = 24;
            labelKey.Text = "Key:";
            // 
            // textBoxPath
            // 
            textBoxPath.BackColor = Color.FromArgb(30, 30, 30);
            textBoxPath.ForeColor = Color.White;
            textBoxPath.Location = new Point(48, 51);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.ReadOnly = true;
            textBoxPath.Size = new Size(381, 23);
            textBoxPath.TabIndex = 23;
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(8, 54);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(34, 15);
            labelPath.TabIndex = 22;
            labelPath.Text = "Path:";
            // 
            // buttonCreateNew
            // 
            buttonCreateNew.BackColor = Color.FromArgb(30, 30, 30);
            buttonCreateNew.FlatAppearance.BorderColor = Color.White;
            buttonCreateNew.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            buttonCreateNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            buttonCreateNew.FlatStyle = FlatStyle.Flat;
            buttonCreateNew.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateNew.ForeColor = Color.White;
            buttonCreateNew.Image = Properties.Resources.add_FILL0_wght400_GRAD0_opsz20;
            buttonCreateNew.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateNew.Location = new Point(96, 467);
            buttonCreateNew.Name = "buttonCreateNew";
            buttonCreateNew.Size = new Size(61, 27);
            buttonCreateNew.TabIndex = 7;
            buttonCreateNew.Text = "Add";
            buttonCreateNew.TextAlign = ContentAlignment.MiddleRight;
            buttonCreateNew.UseVisualStyleBackColor = false;
            buttonCreateNew.Click += buttonCreateNew_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(30, 30, 30);
            buttonDelete.Enabled = false;
            buttonDelete.FlatAppearance.BorderColor = Color.White;
            buttonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            buttonDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz20;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(161, 467);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 27);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Delete";
            buttonDelete.TextAlign = ContentAlignment.MiddleRight;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(30, 30, 30);
            buttonRefresh.FlatAppearance.BorderColor = Color.White;
            buttonRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            buttonRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Image = Properties.Resources.refresh_FILL0_wght400_GRAD0_opsz20;
            buttonRefresh.Location = new Point(64, 467);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(27, 27);
            buttonRefresh.TabIndex = 16;
            buttonRefresh.TextAlign = ContentAlignment.MiddleRight;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(30, 30, 30);
            buttonSearch.FlatAppearance.BorderColor = Color.White;
            buttonSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            buttonSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Image = Properties.Resources.search_FILL0_wght400_GRAD0_opsz20;
            buttonSearch.Location = new Point(33, 467);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(27, 27);
            buttonSearch.TabIndex = 19;
            buttonSearch.TextAlign = ContentAlignment.MiddleRight;
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonMore
            // 
            buttonMore.BackColor = Color.FromArgb(30, 30, 30);
            buttonMore.FlatAppearance.BorderColor = Color.White;
            buttonMore.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            buttonMore.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            buttonMore.FlatStyle = FlatStyle.Flat;
            buttonMore.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMore.ForeColor = Color.White;
            buttonMore.Image = Properties.Resources.more_vert_FILL0_wght400_GRAD0_opsz20;
            buttonMore.Location = new Point(12, 467);
            buttonMore.Name = "buttonMore";
            buttonMore.Size = new Size(18, 27);
            buttonMore.TabIndex = 20;
            buttonMore.TextAlign = ContentAlignment.MiddleRight;
            buttonMore.UseVisualStyleBackColor = false;
            // 
            // buttonCheckBoxEdit
            // 
            buttonCheckBoxEdit.BackColor = Color.FromArgb(30, 30, 30);
            buttonCheckBoxEdit.FlatAppearance.BorderColor = Color.White;
            buttonCheckBoxEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            buttonCheckBoxEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            buttonCheckBoxEdit.FlatStyle = FlatStyle.Flat;
            buttonCheckBoxEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCheckBoxEdit.ForeColor = Color.White;
            buttonCheckBoxEdit.Image = Properties.Resources.edit_off_FILL0_wght400_GRAD0_opsz20;
            buttonCheckBoxEdit.Location = new Point(683, 143);
            buttonCheckBoxEdit.Name = "buttonCheckBoxEdit";
            buttonCheckBoxEdit.Size = new Size(27, 27);
            buttonCheckBoxEdit.TabIndex = 7;
            buttonCheckBoxEdit.TextAlign = ContentAlignment.MiddleRight;
            buttonCheckBoxEdit.UseVisualStyleBackColor = false;
            buttonCheckBoxEdit.Click += buttonCheckBoxEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(722, 507);
            Controls.Add(buttonCheckBoxEdit);
            Controls.Add(buttonMore);
            Controls.Add(buttonSearch);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreateNew);
            Controls.Add(groupBoxSaveLoad);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxWebsite);
            Controls.Add(labelWebsite);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(listBoxItems);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            groupBoxSaveLoad.ResumeLayout(false);
            groupBoxSaveLoad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxItems;
        private Button buttonSave;
        private Button buttonLoad;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Label labelWebsite;
        private TextBox textBoxWebsite;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private GroupBox groupBoxSaveLoad;
        private Button buttonCreateNew;
        private Button buttonDelete;
        private Button buttonRefresh;
        private Button buttonSearch;
        private Button buttonMore;
        private Button buttonCheckBoxEdit;
        private TextBox textBoxPath;
        private Label labelPath;
        private TextBox textBox1;
        private Label labelKey;
        private Button buttonBrowse;
    }
}