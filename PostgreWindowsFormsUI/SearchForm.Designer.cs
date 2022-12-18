namespace PostgreWindowsFormsUI
{
    partial class SearchForm
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
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.GetById = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dgwPerson = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPerson)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(214, 32);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(206, 24);
            this.cbxCategory.TabIndex = 49;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // GetById
            // 
            this.GetById.Location = new System.Drawing.Point(426, 32);
            this.GetById.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetById.Name = "GetById";
            this.GetById.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GetById.Size = new System.Drawing.Size(72, 31);
            this.GetById.TabIndex = 48;
            this.GetById.Text = "Get By Id";
            this.GetById.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(765, 47);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 16);
            this.lblSearch.TabIndex = 47;
            this.lblSearch.Text = "Search : ";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(837, 41);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(138, 22);
            this.tbxSearch.TabIndex = 46;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // dgwPerson
            // 
            this.dgwPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPerson.Location = new System.Drawing.Point(211, 68);
            this.dgwPerson.Name = "dgwPerson";
            this.dgwPerson.RowHeadersWidth = 51;
            this.dgwPerson.RowTemplate.Height = 24;
            this.dgwPerson.Size = new System.Drawing.Size(1032, 539);
            this.dgwPerson.TabIndex = 45;
            this.dgwPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPerson_CellClick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(207, 550);
            this.toolStripContainer1.Location = new System.Drawing.Point(1, 32);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(207, 575);
            this.toolStripContainer1.TabIndex = 50;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 620);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.GetById);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgwPerson);
            this.Name = "SearchForm";
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPerson)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Button GetById;
        private System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DataGridView dgwPerson;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}