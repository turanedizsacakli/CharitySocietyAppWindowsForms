namespace PostgreWindowsFormsUI
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbxUrgency = new System.Windows.Forms.ComboBox();
            this.GetById = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxMotherName = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.tbxNationality = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxLocalIdNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.dgwPerson = new System.Windows.Forms.DataGridView();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxBirthCountry = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxFatherName = new System.Windows.Forms.TextBox();
            this.tbxBirthday = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Aciliyet Derecesi : ";
            // 
            // cbxUrgency
            // 
            this.cbxUrgency.FormattingEnabled = true;
            this.cbxUrgency.Location = new System.Drawing.Point(195, 203);
            this.cbxUrgency.Name = "cbxUrgency";
            this.cbxUrgency.Size = new System.Drawing.Size(133, 24);
            this.cbxUrgency.TabIndex = 30;
            // 
            // GetById
            // 
            this.GetById.Location = new System.Drawing.Point(488, 50);
            this.GetById.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetById.Name = "GetById";
            this.GetById.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GetById.Size = new System.Drawing.Size(133, 22);
            this.GetById.TabIndex = 29;
            this.GetById.Text = "Get By Id";
            this.GetById.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(646, 54);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 16);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search : ";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(711, 50);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(379, 22);
            this.tbxSearch.TabIndex = 27;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(990, 303);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 66);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbxAdd
            // 
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
            this.gbxAdd.Location = new System.Drawing.Point(66, 303);
            this.gbxAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAdd.Size = new System.Drawing.Size(877, 256);
            this.gbxAdd.TabIndex = 24;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add A Product";
            // 
            // tbxMotherName
            // 
            this.tbxMotherName.Location = new System.Drawing.Point(195, 118);
            this.tbxMotherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMotherName.Name = "tbxMotherName";
            this.tbxMotherName.Size = new System.Drawing.Size(133, 22);
            this.tbxMotherName.TabIndex = 11;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(35, 124);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(63, 16);
            this.lblCategoryId.TabIndex = 10;
            this.lblCategoryId.Text = "Ana Adı : ";
            // 
            // tbxNationality
            // 
            this.tbxNationality.Location = new System.Drawing.Point(195, 74);
            this.tbxNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNationality.Name = "tbxNationality";
            this.tbxNationality.Size = new System.Drawing.Size(133, 22);
            this.tbxNationality.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Uyruk : ";
            // 
            // tbxLocalIdNumber
            // 
            this.tbxLocalIdNumber.Location = new System.Drawing.Point(570, 68);
            this.tbxLocalIdNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLocalIdNumber.Name = "tbxLocalIdNumber";
            this.tbxLocalIdNumber.Size = new System.Drawing.Size(133, 22);
            this.tbxLocalIdNumber.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(990, 439);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name : ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(195, 25);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(133, 22);
            this.tbxName.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(408, 74);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(130, 16);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "TC Kimlik Numarası :";
            // 
            // dgwPerson
            // 
            this.dgwPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPerson.Location = new System.Drawing.Point(68, 110);
            this.dgwPerson.Name = "dgwPerson";
            this.dgwPerson.RowHeadersWidth = 51;
            this.dgwPerson.RowTemplate.Height = 24;
            this.dgwPerson.Size = new System.Drawing.Size(1026, 155);
            this.dgwPerson.TabIndex = 23;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(570, 28);
            this.tbxSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(133, 22);
            this.tbxSurname.TabIndex = 3;
            // 
            // tbxBirthCountry
            // 
            this.tbxBirthCountry.Location = new System.Drawing.Point(195, 163);
            this.tbxBirthCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBirthCountry.Name = "tbxBirthCountry";
            this.tbxBirthCountry.Size = new System.Drawing.Size(133, 22);
            this.tbxBirthCountry.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(990, 383);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(104, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tbxFatherName
            // 
            this.tbxFatherName.Location = new System.Drawing.Point(570, 108);
            this.tbxFatherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFatherName.Name = "tbxFatherName";
            this.tbxFatherName.Size = new System.Drawing.Size(133, 22);
            this.tbxFatherName.TabIndex = 5;
            // 
            // tbxBirthday
            // 
            this.tbxBirthday.Location = new System.Drawing.Point(570, 147);
            this.tbxBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBirthday.Name = "tbxBirthday";
            this.tbxBirthday.Size = new System.Drawing.Size(133, 22);
            this.tbxBirthday.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birthday : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Doğum Yeri : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Surname : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Baba Adı :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 766);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GetById);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwPerson);
            this.Name = "Form1";
            this.Text = "Charity Society App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxUrgency;
        private System.Windows.Forms.Button GetById;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxMotherName;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox tbxNationality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxLocalIdNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.DataGridView dgwPerson;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxBirthCountry;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxFatherName;
        private System.Windows.Forms.TextBox tbxBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

