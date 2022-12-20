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
            this.CharityButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(22, 74);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(163, 84);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "ARAMA";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(22, 254);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(163, 84);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "GÜNCELLEME";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(22, 344);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(163, 84);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "SİLME";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DistrictButton
            // 
            this.DistrictButton.Location = new System.Drawing.Point(19, 434);
            this.DistrictButton.Name = "DistrictButton";
            this.DistrictButton.Size = new System.Drawing.Size(163, 83);
            this.DistrictButton.TabIndex = 4;
            this.DistrictButton.Text = "MAHALLELER";
            this.DistrictButton.UseVisualStyleBackColor = true;
            this.DistrictButton.Click += new System.EventHandler(this.DistrictButton_Click);
            // 
            // CharityButton
            // 
            this.CharityButton.Location = new System.Drawing.Point(22, 523);
            this.CharityButton.Name = "CharityButton";
            this.CharityButton.Size = new System.Drawing.Size(163, 84);
            this.CharityButton.TabIndex = 5;
            this.CharityButton.Text = "YAPILAN YARDIMLAR";
            this.CharityButton.UseVisualStyleBackColor = true;
            this.CharityButton.Click += new System.EventHandler(this.CharityButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(22, 164);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(163, 84);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "EKLEME";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1357, 624);
            this.MainPanel.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.CharityButton);
            this.panel1.Controls.Add(this.DistrictButton);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 624);
            this.panel1.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "CHARITY SOCIETY APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CharityButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

