using Postgre.Business.Abstract;
using Postgre.Business.Concrete;
using Postgre.DataAccess.Concrete;
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
        }
        private IPersonService _personService;
        public ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPeople();
            LoadCategories();
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

    }
}
