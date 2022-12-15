using System;

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
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DistrictButton = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.CharityButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(3, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(163, 84);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "ARAMA";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(3, 192);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(163, 84);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "GÜNCELLEME";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(3, 282);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(163, 84);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "SİLME";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DistrictButton
            // 
            this.DistrictButton.Location = new System.Drawing.Point(0, 372);
            this.DistrictButton.Name = "DistrictButton";
            this.DistrictButton.Size = new System.Drawing.Size(163, 83);
            this.DistrictButton.TabIndex = 3;
            this.DistrictButton.Text = "MAHALLELER";
            this.DistrictButton.UseVisualStyleBackColor = true;
            this.DistrictButton.Click += new System.EventHandler(this.DistrictButton_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.SearchButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.CharityButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.AddButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DistrictButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.UpdateButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DeleteButton);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(207, 550);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 37);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(207, 575);
            this.toolStripContainer1.TabIndex = 42;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // CharityButton
            // 
            this.CharityButton.Location = new System.Drawing.Point(3, 461);
            this.CharityButton.Name = "CharityButton";
            this.CharityButton.Size = new System.Drawing.Size(163, 84);
            this.CharityButton.TabIndex = 5;
            this.CharityButton.Text = "YAPILAN YARDIMLAR";
            this.CharityButton.UseVisualStyleBackColor = true;
            this.CharityButton.Click += new System.EventHandler(this.CharityButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 102);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(163, 84);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "EKLEME";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::PostgreWindowsFormsUI.Properties.Resources.logo400x400;
            this.pictureBox1.Location = new System.Drawing.Point(475, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "CHARITY SOCIETY APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void SaerchButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DistrictButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CharityButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

