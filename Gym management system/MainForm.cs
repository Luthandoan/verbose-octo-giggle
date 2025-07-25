﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymS1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MemberForm memberForm = new MemberForm();
            memberForm.Show();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            ClassForm classForm = new ClassForm();
            classForm.Show();

        }

        private void btnPrograms_Click(object sender, EventArgs e)
        {
            ProgramForm programForm = new ProgramForm();
            programForm.Show();

        }
    }
}
