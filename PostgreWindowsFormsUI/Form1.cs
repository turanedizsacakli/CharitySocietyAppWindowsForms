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



private void SearchButton_Click(object sender, EventArgs e)
        {
SearchForm searchForm= new SearchForm();
            searchForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ActionForm actionForm= new ActionForm();
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





        // there are comments because i can try to get all category search from main form and so i didnt 
        // remove the codes of the get all category

        //private void LoadPeople()
        //{
        //    dgwPerson.DataSource = _personService.GetAll();

        //}

        //private void LoadCategories()
        //{
        //    cbxCategory.DataSource = _categoryService.GetAll();
        //    cbxCategory.DisplayMember = "CategoryName";
        //    cbxCategory.ValueMember = "CategoryId";
        //}




    }
}
