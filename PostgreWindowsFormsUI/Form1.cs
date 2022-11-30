﻿using Postgre.Business.Concrete;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwPerson.DataSource= _personService.GetAll();
        }

       
    }
}
