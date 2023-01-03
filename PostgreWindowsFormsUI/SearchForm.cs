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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            _personService = new PersonManager(new PersonDal());
            _categoryService = new CategoryManager(new CategoryDal());
            _addressService = new AddressManager(new AddressDal());
            _urgencyService = new UrgencyManager(new UrgencyDal());
            _knowledgeService=new PersonKnowledgeManager(new PersonKnowledgeDal());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadPeople();
            LoadUrgency();

            //dgwPerson[0, dgwPerson.RowCount - 1].Cells[0].Value.ToString();
            //dgwPerson.FirstDisplayedScrollingRowIndex = dgwPerson.RowCount - 1;
            //.Selected = true;
            //dgwPerson.CurrentRow.Cells[rowCount].Value;
        }

        private IPersonService _personService;
        private ICategoryService _categoryService;
        private IAddressService _addressService;
        private IUrgencyService _urgencyService;
        private IPersonKnowledgeService _knowledgeService;
        private void LoadPeople()
        {
            dgwPerson.DataSource = _personService.GetAll();
        }
        private void LoadUrgency()
        {
            cbxUrgency.DataSource = _urgencyService.GetAll();
            cbxUrgency.DisplayMember = "UrgencyName";
            cbxUrgency.ValueMember = "UrgencyId";
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

        private void cbxUrgency_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbxUrgency.SelectedValue) == 1)
                {
                    LoadPeople();
                }
                else
                {
                    dgwPerson.DataSource = _personService.GetByUrgencyId(Convert.ToInt32(cbxUrgency.SelectedValue));
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
            ActionForm form = new ActionForm();
            var Row = dgwPerson.CurrentRow;
            
            form.Show();
            form.tbxId.Text = Row.Cells[0].Value.ToString();
            form.tbxName.Text = (Row.Cells[1].Value.ToString()!=null)? Row.Cells[1].Value.ToString():"";
            form.tbxSurname.Text = (Row.Cells[2].Value.ToString()!=null)? Row.Cells[2].Value.ToString():"";
            form.tbxFatherName.Text = (Row.Cells[3].Value.ToString() != null) ? Row.Cells[3].Value.ToString() : "";
            form.tbxMotherName.Text = (Row.Cells[4].Value.ToString() != null) ? Row.Cells[4].Value.ToString() : "";
            form.tbxNationality.Text = (Row.Cells[5].Value.ToString() != null) ? Row.Cells[5].Value.ToString() : "";
            form.tbxBirthday.Text = (Row.Cells[6].Value.ToString() != null) ? Row.Cells[6].Value.ToString() : "";
            form.tbxBirthCountry.Text = (Row.Cells[7].Value.ToString() != null) ? Row.Cells[7].Value.ToString() : "";
            form.tbxLocalIdNumber.Text = (Row.Cells[8].Value.ToString() != null) ? Row.Cells[8].Value.ToString() : "";
            form.cbxCategoryId.Text = (Row.Cells[9].Value.ToString() != null) ? Row.Cells[9].Value.ToString() : "";
            form.tbxWork.Text= (Row.Cells[10].Value.ToString() != null) ? Row.Cells[10].Value.ToString() : "";
            form.tbxIncome.Text= (Row.Cells[11].Value.ToString() != null) ? Row.Cells[11].Value.ToString() : "";
            form.tbxOutgoing.Text= (Row.Cells[12].Value.ToString() != null) ? Row.Cells[12].Value.ToString() : "";
            form.tbxDebt.Text= (Row.Cells[13].Value.ToString() != null) ? Row.Cells[13].Value.ToString() : "";
            form.tbxAid.Text= (Row.Cells[14].Value.ToString() != null) ? Row.Cells[14].Value.ToString() : "";
            form.tbxStuff.Text= (Row.Cells[15].Value.ToString() != null) ? Row.Cells[15].Value.ToString() : "";
            form.tbxStudent.Text= (Row.Cells[16].Value.ToString() != null) ? Row.Cells[16].Value.ToString() : "";

            var callAdressId = Row.Cells[26].Value.ToString();
            List<Address> callingAddress = _addressService.GetAll();
            foreach (var item in callingAddress)
            {
                if (item.AddressId.ToString()==callAdressId)
                {
                    form.tbxAddressId.Text = item.AddressId.ToString();
                    form.tbxAppealDate.Text= item.AppealDate.ToString();
                    form.tbxDetectDate.Text= item.DetectDate.ToString();
                    form.cbxCountry.Text= item.Country.ToString();
                    form.cbxCity.Text= item.City.ToString();
                    form.cbxDistrict.Text= item.District.ToString();
                    form.cbxHometown.Text= item.Hometown.ToString();
                    form.tbxStreet.Text= item.Street.ToString();
                    form.tbxBuild.Text= item.Build.ToString();
                    form.tbxBuildNumber.Text= item.BuildNumber.ToString();
                    form.tbxPhoneOne.Text=item.PhoneNumberOne.ToString();
                    form.tbxPhoneTwo.Text=item.PhoneNumberTwo.ToString();
                }
            }

            var callKnowledgeId = Row.Cells[27].Value.ToString();
            List<PersonKnowledge> calllingKnowledge= _knowledgeService.GetAll();
            foreach (var item in calllingKnowledge)
            {
                if (item.KnowledgeId.ToString() == callKnowledgeId)
                {
                    form.lblKnowledge.Text= item.KnowledgeId.ToString();
                    form.rtbKnowledge.Text=item.Knowledge;
                }
            }
            SearchForm searchForm = new SearchForm();
            searchForm.Hide();
        }

        //cells
        //    0 personid
        //    1 name
        //    2 surname
        //    3 fathername
        //    4 mothername
        //    5 nationality
        //    6 birthday
        //    7 birtcountry
        //    8 localid
        //    9 blood
        //    10 work
        //    11 income
        //    12 outgoing
        //    13 debt
        //    14 aid
        //    15 stuff
        //    16 student

        //    17 partnerLocalid
        //    18 childoneid
        //    19 20 21 22 23 
        //    24 categoryid
        //    25 urgencyid
        //    26 addressid
        //    27 knowledgeid
        //    28 urgencyid
        //    29 addressid
        //    30 knowledgeid
        
        //    31 category
        //    32 address
        //    33 urgency
        //    34 knowledge

    }
}
