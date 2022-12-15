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
    public partial class ActionForm : Form
    {
        public ActionForm()
        {
            InitializeComponent();
            _personService = new PersonManager(new PersonDal());
            _categoryService = new CategoryManager(new CategoryDal());
        }
        private IPersonService _personService;
        private ICategoryService _categoryService;
        private void AddForm_Load(object sender, EventArgs e)
        {


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



        private void btnAdd_Click(object sender, EventArgs e)
        {


            _personService.Add(new Person
            {
                Name = tbxName.Text,
                Surname = tbxSurname.Text,
                Nationality = tbxNationality.Text,
                LocalId = tbxLocalIdNumber.Text,
                MotherName = tbxMotherName.Text,
                FatherName = tbxFatherName.Text,
                Birthday = tbxBirthday.Text,
                BirthCountry = tbxBirthCountry.Text,
                CategoryId = cbxCategoryId.SelectedIndex + 1,
                //you will add urgency!!! be careful about it....
            });

            ClearAll();
        }


        private void ClearAll()
        {
            tbxName.Text = "";
            tbxSurname.Text = "";
            tbxNationality.Text = "";
            tbxLocalIdNumber.Text = "";
            tbxMotherName.Text = "";
            tbxFatherName.Text = "";
            tbxBirthday.Text = "";
            tbxBirthCountry.Text = "";
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void AddForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
