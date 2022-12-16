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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            logo.Visible = false;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            //Panel.Controls.Add(frm);
            frm.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //SearchForm searchForm= new SearchForm();
            //searchForm.Show();
            SearchForm form = new SearchForm();
            CallForms(form);
            //usable styles...
            //form.FormBorderStyle = FormBorderStyle.Fixed3D;
            //form.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ActionForm actionForm = new ActionForm();
            actionForm.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ActionForm actionForm = new ActionForm();
            actionForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ActionForm actionForm = new ActionForm();
            actionForm.Show();
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
