﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WindForms
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void LblInfosDeLetudiant_Click(object sender, EventArgs e)
        {
            FormCarteEtudiant = new formCarteEtudaiant()
            formCarteEtudaiant.show()
        }
    }
}
