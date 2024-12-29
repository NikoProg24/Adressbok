namespace Inlämningsuppgift1._1
{
    partial class Adressbok
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
            listBoxContacts = new ListBox();
            labelName = new Label();
            labelAddress = new Label();
            labelZipCode = new Label();
            labelCity = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            textBoxName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxZipCode = new TextBox();
            textBoxCity = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonCreate = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // listBoxContacts
            // 
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.HorizontalScrollbar = true;
            listBoxContacts.Location = new Point(60, 219);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(578, 420);
            listBoxContacts.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(696, 229);
            labelName.Name = "labelName";
            labelName.Size = new Size(79, 32);
            labelName.TabIndex = 1;
            labelName.Text = "Namn";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(696, 305);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(84, 32);
            labelAddress.TabIndex = 2;
            labelAddress.Text = "Adress";
            // 
            // labelZipCode
            // 
            labelZipCode.AutoSize = true;
            labelZipCode.Location = new Point(696, 383);
            labelZipCode.Name = "labelZipCode";
            labelZipCode.Size = new Size(149, 32);
            labelZipCode.TabIndex = 3;
            labelZipCode.Text = "Postnummer";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(696, 463);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(88, 32);
            labelCity.TabIndex = 4;
            labelCity.Text = "Postort";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(696, 538);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(184, 32);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Telefonnummer";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(696, 611);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(128, 32);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Mejladress";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(881, 229);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(298, 39);
            textBoxName.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(881, 298);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(298, 39);
            textBoxAddress.TabIndex = 8;
            // 
            // textBoxZipCode
            // 
            textBoxZipCode.Location = new Point(881, 376);
            textBoxZipCode.Name = "textBoxZipCode";
            textBoxZipCode.Size = new Size(298, 39);
            textBoxZipCode.TabIndex = 9;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(881, 456);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(298, 39);
            textBoxCity.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(881, 531);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(298, 39);
            textBoxPhone.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(881, 604);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(298, 39);
            textBoxEmail.TabIndex = 12;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(280, 141);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(358, 39);
            textBoxSearch.TabIndex = 13;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(60, 139);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(184, 43);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Sök kontakt";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(60, 682);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(184, 43);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Radera";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(995, 682);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(184, 43);
            buttonUpdate.TabIndex = 16;
            buttonUpdate.Text = "Uppdatera";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(970, 137);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(184, 43);
            buttonCreate.TabIndex = 17;
            buttonCreate.Text = "Skapa";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(60, 72);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(184, 46);
            buttonClear.TabIndex = 18;
            buttonClear.Text = "Rensa";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Adressbok
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 767);
            Controls.Add(buttonClear);
            Controls.Add(buttonCreate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxZipCode);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxName);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelCity);
            Controls.Add(labelZipCode);
            Controls.Add(labelAddress);
            Controls.Add(labelName);
            Controls.Add(listBoxContacts);
            Name = "Adressbok";
            Text = "Adressbok";
            Load += Adressbok_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxContacts;
        private Label labelName;
        private Label labelAddress;
        private Label labelZipCode;
        private Label labelCity;
        private Label labelPhone;
        private Label labelEmail;
        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxZipCode;
        private TextBox textBoxCity;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonCreate;
        private Button buttonClear;
    }
}
