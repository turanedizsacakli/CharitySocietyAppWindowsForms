using Postgre.Business.Abstract;
using Postgre.Business.Concrete;
using Postgre.DataAccess.Concrete;
using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control = Postgre.Entities.Concrete.Control;

namespace PostgreWindowsFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //_personService = new PersonManager(new PersonDal());
            //_categoryService = new CategoryManager(new CategoryDal());
            
        }
        //private IPersonService _personService;
        //private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadCategories();
            //LoadPeople();
        }

        private void CallForms(Form frm)
        {

            //logo.Visible = false;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
      
        private void CloseFroms(Form frm)
        {
            frm.Hide();
        }
        SearchForm _form = new SearchForm();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //SearchForm searchForm= new SearchForm();
            //searchForm.Show();
            
            CloseFroms(_actionForm);
            CallForms(_form);
            //usable styles...
            //form.FormBorderStyle = FormBorderStyle.Fixed3D;
            //form.FormBorderStyle = FormBorderStyle.Sizable;

        }
        ActionForm _actionForm = new ActionForm();
        private void AddButton_Click(object sender, EventArgs e)
        {
            
            //actionForm.Show();
            CloseFroms(_form);
            CallForms(_actionForm);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ActionForm actionForm = new ActionForm();
            //actionForm.Show();
            CloseFroms(_form);
            CallForms(actionForm);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ActionForm actionForm = new ActionForm();
            //actionForm.Show();
            CloseFroms(_form);
            CallForms(actionForm);
        }

        private void DistrictButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yakında eklenecek...");
        }

        private void CharityButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yakında eklenecek...");
        }

          
    }
}
