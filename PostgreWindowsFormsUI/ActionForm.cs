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
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control = Postgre.Entities.Concrete.Control;

namespace PostgreWindowsFormsUI
{
    public partial class ActionForm : Form
    {
        private IPersonService _personService;
        private ICategoryService _categoryService;
        private IAddressService _addressService;
        private IUrgencyService _urgencyService;
        private IPersonKnowledgeService _personKnowledgeService;

        private IControlService _controlService;
        public ActionForm()
        {
            InitializeComponent();
            //_personService = new PersonManager(new PersonDal());
            //_categoryService = new CategoryManager(new CategoryDal());

            _personService = InstanceFactory.GetInstance<IPersonService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _addressService = InstanceFactory.GetInstance<IAddressService>();
            _urgencyService = InstanceFactory.GetInstance<IUrgencyService>();
            _personKnowledgeService = InstanceFactory.GetInstance<IPersonKnowledgeService>();
            _controlService = new ControlManager(new ControlDal());
        }
        private void ActionForm_Load(object sender, EventArgs e)
        {
            LoadUrgencyAndCategory();
            Ids();
        }
        private void LoadUrgencyAndCategory()
        {
            SearchForm searchForm = new SearchForm();
            cbxUrgency.Items.Add("A");
            cbxUrgency.Items.Add("B");
            cbxUrgency.Items.Add("C");
            cbxCategoryId.Items.Add("Yardım Ailesi");
            cbxCategoryId.Items.Add("Yetim Ailesi");

            cbxMarital.Items.Add("Evli");
            cbxMarital.Items.Add("Bekar");
            cbxMarital.Items.Add("Dul");

            cbxCountry.Items.Add("Türkiye");
            cbxCountry.Items.Add("Suriye");
            cbxCountry.Items.Add("Afganistan");
            cbxCountry.Items.Add("Irak");
            cbxCountry.Items.Add("İran");

            cbxCity.Items.Add("Adana");
            cbxCity.Items.Add("Ankara");
            cbxCity.Items.Add("İstanbul");
            cbxCity.Items.Add("Gaziantep");

            cbxHometown.Items.Add("Yeşilevler Mahallesi");
            cbxHometown.Items.Add("Gürselpaşa Mahallesi");

            cbxDistrict.Items.Add("Seyhan");
            cbxDistrict.Items.Add("Yüreğir");
            cbxDistrict.Items.Add("Çukurova");


            tbxId.Text = Convert.ToString(1);
            var rowCount = searchForm.dgwPerson.Rows.Count;
            //id numarası...
            var realId = Convert.ToString(rowCount + 1);
            //this line will open after first id...
            //tbxId.Text = (string)searchForm.dgwPerson.Rows[rowCount].Cells[0].Value;

            Console.WriteLine(realId);
            //tbxId.Text = Convert.ToString(rowCount + 1);
        }
        private void Ids()
        {
            tbxId.Enabled = false;
            tbxAddressId.Enabled = false;
            tbxPartnerId.Enabled = false;
            tbxChildFifthId.Enabled = false;
            tbxChildOneId.Enabled = false;
            tbxChildTwoId.Enabled = false;
            tbxChildThreeId.Enabled = false;
            tbxChildForthId.Enabled = false;
            tbxChildSixthId.Enabled = false;
            List<Control> myControls = _controlService.GetAll();
            if (myControls != null)
            {
                foreach (Control control in myControls)
                {
                    tbxId.Text = Convert.ToString(control.PersonId + 1);
                    tbxAddressId.Text = Convert.ToString(control.AddressId + 1);
                    lblKnowledge.Text = Convert.ToString(control.KnowledgeId + 1);
                }
            }
            else
            {
                tbxId.Text = Convert.ToString(1);
                tbxAddressId.Text = Convert.ToString(1);
                lblKnowledge.Text = Convert.ToString(1);
            }

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
                    Blood = tbxBlood.Text,
                    Work = tbxWork.Text,
                    Income = tbxIncome.Text,
                    Outgoing = tbxOutgoing.Text,
                    Debt = tbxDebt.Text,
                    Aid = tbxAid.Text,
                    Stuff = tbxStuff.Text,
                    Student = tbxStudent.Text,

                    CategoryId = cbxCategoryId.SelectedIndex + 1,
                    AddressId = Convert.ToInt32(lblKnowledge.Text),
                    KnowledgeId = Convert.ToInt32(tbxId.Text),
                    UrgencyId = cbxUrgency.SelectedIndex + 1,
                });

                _addressService.Add(new Address
                {
                    AppealDate = tbxAppealDate.Text,
                    DetectDate = tbxDetectDate.Text,
                    Country = cbxCountry.SelectedText,
                    City = cbxCity.SelectedText,
                    District = cbxDistrict.Text,
                    Hometown = cbxHometown.SelectedText,
                    PhoneNumberTwo = tbxPhoneOne.Text,
                    PhoneNumberOne = tbxPhoneTwo.Text,
                    Street = tbxStreet.Text,
                    Build = tbxBuild.Text,
                    BuildNumber = tbxBuildNumber.Text
                });

                _personKnowledgeService.Add(new PersonKnowledge
                {
                    Knowledge = rtbKnowledge.Text,
                });

                _controlService.Update(new Control
                {
                    ControlId = 1,
                    PersonId = Convert.ToInt32(tbxId.Text),
                    AddressId = Convert.ToInt32(tbxAddressId.Text),
                    KnowledgeId = Convert.ToInt32(lblKnowledge.Text),
                });
                ClearAll();
                MessageBox.Show("KİŞİ EKLENDİ...");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //to make clear all from...
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
            tbxBlood.Text = "";
            tbxWork.Text = "";
            tbxIncome.Text = "";
            tbxOutgoing.Text = "";
            tbxDebt.Text = "";
            tbxAid.Text = "";
            tbxStuff.Text = "";
            tbxStudent.Text = "";
            lblKnowledge.Text = "";
            tbxId.Text= "";
            tbxAppealDate.Text = "";
            tbxDetectDate.Text = "";
            cbxCountry.SelectedText = "";
            cbxCity.SelectedText = "";
            cbxDistrict.Text = "";
            cbxHometown.SelectedText = "";
            tbxPhoneOne.Text = "";
            tbxPhoneTwo.Text = "";
            tbxStreet.Text = "";
            tbxBuild.Text = "";
            tbxBuildNumber.Text = "";
            rtbKnowledge.Text = "";

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
                    LocalId = tbxLocalIdNumber.Text,
                    MotherName = tbxMotherName.Text,
                    FatherName = tbxFatherName.Text,
                    Birthday = tbxBirthday.Text,
                    BirthCountry = tbxBirthCountry.Text,
                    Blood = tbxBlood.Text,
                    Work = tbxWork.Text,
                    Income = tbxIncome.Text,
                    Outgoing = tbxOutgoing.Text,
                    Debt = tbxDebt.Text,
                    Aid = tbxAid.Text,
                    Stuff = tbxStuff.Text,
                    Student = tbxStudent.Text,
                });
                _addressService.Update(new Address
                {
                    //for id 

                    AppealDate = tbxAppealDate.Text,
                    DetectDate = tbxDetectDate.Text,
                    Country = cbxCountry.SelectedText,
                    City = cbxCity.SelectedText,
                    District = cbxDistrict.Text,
                    Hometown = cbxHometown.SelectedText,
                    PhoneNumberTwo = tbxPhoneOne.Text,
                    PhoneNumberOne = tbxPhoneTwo.Text,
                    Street = tbxStreet.Text,
                    Build = tbxBuild.Text,
                    BuildNumber = tbxBuildNumber.Text
                });

                _personKnowledgeService.Update(new PersonKnowledge
                {
                    //for id...
                    Knowledge = rtbKnowledge.Text,
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

        //to make visible true or false children...
        private void tbxHowManyChildren_TextChanged(object sender, EventArgs e)
        {
            if (cbxMarital.SelectedIndex != 2)
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
                    MessageBox.Show("lütfen çocuk sayısını giriniz ya da boş bırakınız...");
                }
            }

            IdsForChildren();
        }

        //to add childrenId... 
        private void IdsForChildren()
        {
            if (gbxC1.Visible == true)
            {
                var newIdForChild = Convert.ToInt32(tbxPartnerId.Text) + 1;
                tbxChildOneId.Text = Convert.ToString(newIdForChild);
            }
            //it is not necessary because if Visible is true we will save it...
            //else{tbxChildOneId.Text = "";tbxChildTwoId.Text = "";tbxChildThreeId.Text = "";tbxChildForthId.Text = "";tbxChildFifthId.Text = "";tbxChildSixthId.Text = "";}
            if (gbxC2.Visible == true)
            {
                var newIdForChild = Convert.ToInt32(tbxChildOneId.Text) + 1;
                tbxChildTwoId.Text = Convert.ToString(newIdForChild);
            }
            if (gbxC3.Visible == true)
            {
                var newIdForChild = Convert.ToInt32(tbxChildTwoId.Text) + 1;
                tbxChildThreeId.Text = Convert.ToString(newIdForChild);
            }
            if (gbxC4.Visible == true)
            {
                var newIdForChild = Convert.ToInt32(tbxChildThreeId.Text) + 1;
                tbxChildForthId.Text = Convert.ToString(newIdForChild);
            }
            if (gbxC5.Visible == true)
            {
                var newIdForChild = Convert.ToInt32(tbxChildForthId.Text) + 1;
                tbxChildFifthId.Text = Convert.ToString(newIdForChild);
            }
            if (gbxC6.Visible == true)
            {
                var newIdForChild = Convert.ToInt32(tbxChildFifthId.Text) + 1;
                tbxChildSixthId.Text = Convert.ToString(newIdForChild);
            }

        }

        //to add partnerId... 
        private void cbxMarital_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(cbxMarital.SelectedIndex);
                if (cbxMarital.SelectedIndex == 0 || cbxMarital.SelectedIndex == 3)
                {
                    var partnerId = Convert.ToInt32(tbxId.Text) + 1;
                    //var partnerIdText = Convert.ToString(partnerId);
                    //tbxPartnerId.Text = partnerIdText;
                    tbxPartnerId.Text = Convert.ToString(partnerId);
                }
                else
                {
                    tbxPartnerId.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("lütfen medeni halini giriniz...");
            }

        }
    }
}
