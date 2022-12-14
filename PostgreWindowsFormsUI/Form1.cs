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
            _personService = new PersonManager(new PersonDal());
            _categoryService= new CategoryManager(new CategoryDal());
        }
        private IPersonService _personService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadPeople();
            LoadUrgencyAndCategory();
            
        }

        private void LoadUrgencyAndCategory()
        {
            cbxUrgency.Items.Add("A");
            cbxUrgency.Items.Add("B");
            cbxUrgency.Items.Add("C");
            cbxCategoryId.Items.Add("Yardım Ailesi");
            cbxCategoryId.Items.Add("Yetim Ailesi");
        }

        private void LoadPeople()
        {
            dgwPerson.DataSource = _personService.GetAll();
            
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbxCategory.SelectedValue) == 1)
                {
                    LoadPeople();
                }
                else
                {
                    dgwPerson.DataSource = _personService.GetByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue));
                }
            }
            catch {   }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearch.Text))
            {
                dgwPerson.DataSource = _personService.GetByCategoryName(tbxSearch.Text);

            }
            else
            {
                LoadPeople();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            _personService.Add(new Person { 
                Name = tbxSearch.Text, 
                Surname=tbxSurname.Text, 
                Nationality= tbxNationality.Text,
                LocalId= tbxLocalIdNumber.Text,
                MotherName=tbxMotherName.Text, 
                FatherName=tbxFatherName.Text, 
                Birthday=tbxBirthday.Text, 
                BirthCountry=tbxBirthCountry.Text,
                CategoryId= cbxCategory.SelectedIndex +1,
                //you will add urgency!!! be careful about it....
            });
            LoadPeople();
        }

       
    }
}
