namespace PostgreWindowsFormsUI
{
    partial class ActionForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUrgency = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxMotherName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.tbxBirthday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxNationality = new System.Windows.Forms.TextBox();
            this.tbxFatherName = new System.Windows.Forms.TextBox();
            this.tbxBirthCountry = new System.Windows.Forms.TextBox();
            this.tbxLocalIdNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(853, 50);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 84);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(853, 138);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(164, 84);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(853, 232);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 141);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxId);
            this.gbxAdd.Controls.Add(this.label8);
            this.gbxAdd.Controls.Add(this.cbxCategoryId);
            this.gbxAdd.Controls.Add(this.label3);
            this.gbxAdd.Controls.Add(this.label4);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.cbxUrgency);
            this.gbxAdd.Controls.Add(this.label7);
            this.gbxAdd.Controls.Add(this.tbxMotherName);
            this.gbxAdd.Controls.Add(this.label6);
            this.gbxAdd.Controls.Add(this.lblCategoryId);
            this.gbxAdd.Controls.Add(this.tbxBirthday);
            this.gbxAdd.Controls.Add(this.label2);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.tbxSurname);
            this.gbxAdd.Controls.Add(this.lblUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxNationality);
            this.gbxAdd.Controls.Add(this.tbxFatherName);
            this.gbxAdd.Controls.Add(this.tbxBirthCountry);
            this.gbxAdd.Controls.Add(this.tbxLocalIdNumber);
            this.gbxAdd.Controls.Add(this.label5);
            this.gbxAdd.Location = new System.Drawing.Point(12, 21);
            this.gbxAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAdd.Size = new System.Drawing.Size(786, 365);
            this.gbxAdd.TabIndex = 38;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Kişisel Bilgiler";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(177, 26);
            this.tbxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(133, 22);
            this.tbxId.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Kayıt Numarası :";
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(177, 270);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(133, 24);
            this.cbxCategoryId.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kategorisi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Aciliyet Derecesi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Baba Adı :";
            // 
            // cbxUrgency
            // 
            this.cbxUrgency.FormattingEnabled = true;
            this.cbxUrgency.Location = new System.Drawing.Point(177, 300);
            this.cbxUrgency.Name = "cbxUrgency";
            this.cbxUrgency.Size = new System.Drawing.Size(133, 24);
            this.cbxUrgency.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Doğum Yeri : ";
            // 
            // tbxMotherName
            // 
            this.tbxMotherName.Location = new System.Drawing.Point(177, 165);
            this.tbxMotherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMotherName.Name = "tbxMotherName";
            this.tbxMotherName.Size = new System.Drawing.Size(133, 22);
            this.tbxMotherName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birthday : ";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(10, 171);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(63, 16);
            this.lblCategoryId.TabIndex = 10;
            this.lblCategoryId.Text = "Ana Adı : ";
            // 
            // tbxBirthday
            // 
            this.tbxBirthday.Location = new System.Drawing.Point(177, 243);
            this.tbxBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBirthday.Name = "tbxBirthday";
            this.tbxBirthday.Size = new System.Drawing.Size(133, 22);
            this.tbxBirthday.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Surname : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name : ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(177, 82);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(133, 22);
            this.tbxName.TabIndex = 3;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(177, 111);
            this.tbxSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(133, 22);
            this.tbxSurname.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(10, 56);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(130, 16);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "TC Kimlik Numarası :";
            // 
            // tbxNationality
            // 
            this.tbxNationality.Location = new System.Drawing.Point(177, 139);
            this.tbxNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNationality.Name = "tbxNationality";
            this.tbxNationality.Size = new System.Drawing.Size(133, 22);
            this.tbxNationality.TabIndex = 9;
            // 
            // tbxFatherName
            // 
            this.tbxFatherName.Location = new System.Drawing.Point(177, 191);
            this.tbxFatherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFatherName.Name = "tbxFatherName";
            this.tbxFatherName.Size = new System.Drawing.Size(133, 22);
            this.tbxFatherName.TabIndex = 5;
            // 
            // tbxBirthCountry
            // 
            this.tbxBirthCountry.Location = new System.Drawing.Point(177, 217);
            this.tbxBirthCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBirthCountry.Name = "tbxBirthCountry";
            this.tbxBirthCountry.Size = new System.Drawing.Size(133, 22);
            this.tbxBirthCountry.TabIndex = 7;
            // 
            // tbxLocalIdNumber
            // 
            this.tbxLocalIdNumber.Location = new System.Drawing.Point(177, 53);
            this.tbxLocalIdNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLocalIdNumber.Name = "tbxLocalIdNumber";
            this.tbxLocalIdNumber.Size = new System.Drawing.Size(133, 22);
            this.tbxLocalIdNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Uyruk : ";
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 440);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxAdd);
            this.Name = "ActionForm";
            this.Text = "ActionForm";
            this.Load += new System.EventHandler(this.ActionForm_Load);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxAdd;
        public System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxUrgency;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbxMotherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCategoryId;
        public System.Windows.Forms.TextBox tbxBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblUnitPrice;
        public System.Windows.Forms.TextBox tbxNationality;
        public System.Windows.Forms.TextBox tbxFatherName;
        public System.Windows.Forms.TextBox tbxBirthCountry;
        public System.Windows.Forms.TextBox tbxLocalIdNumber;
        private System.Windows.Forms.Label label5;
    }
}