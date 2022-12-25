using Postgre.Business.Abstract;
using Postgre.Business.Concrete;
using Postgre.Business.DependencyResolvers;
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
            _personService = InstanceFactory.GetInstance<IPersonService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _addressService = InstanceFactory.GetInstance<IAddressService>();
            _urgencyService = InstanceFactory.GetInstance<IUrgencyService>();
            //_personService = new PersonManager(new PersonDal());
            //_categoryService = new CategoryManager(new CategoryDal());
        }

        private IPersonService _personService;
        private ICategoryService _categoryService;
        private IAddressService _addressService;
        private IUrgencyService _urgencyService;

        private void ActionForm_Load(object sender, EventArgs e)
        {
            LoadUrgencyAndCategory();

        }
        private void LoadUrgencyAndCategory()
        {
            SearchForm searchForm= new SearchForm();
            cbxUrgency.Items.Add("A");
            cbxUrgency.Items.Add("B");
            cbxUrgency.Items.Add("C");
            cbxCategoryId.Items.Add("Yardım Ailesi");
            cbxCategoryId.Items.Add("Yetim Ailesi");
            tbxId.Text = Convert.ToString(1);
            var rowCount = searchForm.dgwPerson.Rows.Count;
            //id numarası...
            var realId= Convert.ToString(rowCount + 1);
            //tbxId.Text = (string)searchForm.dgwPerson.Rows[rowCount].Cells[0].Value;
            Console.WriteLine(realId);
            //tbxId.Text = Convert.ToString(rowCount + 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
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
                    AddressId=Convert.ToInt32( tbxId.Text),

                    //you will add urgency!!! be careful about it....
                });

                _addressService.Add(new Address
                {
                    AppealDate = tbxAppealDate.Text,
                    DetectDate = tbxDetectDate.Text,
                    Country = cbxCountry.SelectedText,
                    City = cbxCity.SelectedText,
                    District = tbxDistrict.Text,
                    Hometown = cbxHometown.SelectedText,
                    PhoneNumberTwo = tbxPhoneOne.Text,
                    PhoneNumberOne = tbxPhoneTwo.Text,
                    Street = tbxStreet.Text,
                    Build = tbxBuild.Text,
                    BuildNumber = tbxBuildNumber.Text
                });

                ClearAll();
                MessageBox.Show("KİŞİ EKLENDİ...");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
        SearchForm _searchForm = new SearchForm();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _personService.Update(new Person
                {
                    PersonId = Convert.ToInt32(tbxId.Text),
                    Name = tbxName.Text,
                    Surname = tbxSurname.Text,
                    Nationality = tbxNationality.Text,
                    FatherName = tbxFatherName.Text,
                    MotherName = tbxMotherName.Text,
                    Birthday = tbxBirthday.Text,
                    BirthCountry = tbxBirthCountry.Text,
                    LocalId = tbxLocalIdNumber.Text,
                    CategoryId = cbxCategoryId.SelectedIndex + 1,
                });

                MessageBox.Show("KİŞİ GÜNCELLENDİ...");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _personService.Delete(new Person
            {
                PersonId = Convert.ToInt32(tbxId.Text)
            });
            MessageBox.Show("Kişi Silindi...");
            _searchForm.Show();
        }

        private void tbxHowManyChildren_TextChanged(object sender, EventArgs e)
        {
            //i couldnt find a way to do that...
            try
            {
                if (Convert.ToInt32(tbxHowManyChildren.Text) == 1 || tbxHowManyChildren.Text == null || tbxHowManyChildren.Text == "0") { gbxC2.Visible = false; gbxC3.Visible = false; gbxC4.Visible = false; gbxC5.Visible = false; gbxC6.Visible = false; }
                if (Convert.ToInt32(tbxHowManyChildren.Text) == 2) { gbxC2.Visible = true; gbxC3.Visible = false; gbxC4.Visible = false; gbxC5.Visible = false; gbxC6.Visible = false; }
                if (Convert.ToInt32(tbxHowManyChildren.Text) == 3) { gbxC2.Visible = true; gbxC3.Visible = true; gbxC4.Visible = false; gbxC5.Visible = false; gbxC6.Visible = false; }
                if (Convert.ToInt32(tbxHowManyChildren.Text) == 4) { gbxC2.Visible = true; gbxC3.Visible = true; gbxC4.Visible = true; gbxC5.Visible = false; gbxC6.Visible = false; }
                if (Convert.ToInt32(tbxHowManyChildren.Text) == 5) { gbxC2.Visible = true; gbxC3.Visible = true; gbxC4.Visible = true; gbxC5.Visible = true; gbxC6.Visible = false; }
                if (Convert.ToInt32(tbxHowManyChildren.Text) == 6) { gbxC2.Visible = true; gbxC3.Visible = true; gbxC4.Visible = true; gbxC5.Visible = true; gbxC6.Visible = true; }
            }
            catch (Exception)
            {
                //exception.Message = "lütfen çocuk sayısını giriniz ya da boş bırakınız...";
                //MessageBox.Show(exception.Message);
                MessageBox.Show("lütfen çocuk sayısını giriniz ya da boş bırakınız...");
            }

        }
    }
}
