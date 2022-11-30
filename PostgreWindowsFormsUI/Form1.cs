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
            _personManager = new PersonManager(new PersonDal());
        }
        private IPersonManager _personManager;
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwPerson.DataSource= _personManager.GetAll();
        }
    }
}
