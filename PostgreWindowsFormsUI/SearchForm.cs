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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            _personService = new PersonManager(new PersonDal());
            _categoryService = new CategoryManager(new CategoryDal());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadPeople();
        }
        private IPersonService _personService;
        private ICategoryService _categoryService;
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
            catch { }
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

        private void dgwPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ActionForm form=new ActionForm();
            var Row = dgwPerson.CurrentRow;
            form.Show();
            form.tbxId.Text = Row.Cells[0].Value.ToString();
            form.tbxName.Text = Row.Cells[1].Value.ToString();
            form.tbxSurname.Text = Row.Cells[2].Value.ToString();
            form.tbxFatherName.Text = Row.Cells[3].Value.ToString();
            form.tbxMotherName.Text = Row.Cells[4].Value.ToString();
            form.tbxNationality.Text = Row.Cells[5].Value.ToString();
            form.tbxBirthday.Text= Row.Cells[6].Value.ToString();
            form.tbxBirthCountry.Text = Row.Cells[7].Value.ToString();
            form.tbxLocalIdNumber.Text = Row.Cells[8].Value.ToString();
            form.cbxCategoryId.Text= Row.Cells[9].Value.ToString();
            SearchForm searchForm= new SearchForm();
            searchForm.Hide();
        }
    }
}
