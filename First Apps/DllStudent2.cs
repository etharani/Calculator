﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace First_Apps
{
    public partial class DllStudent2 : Form
    {
        StudentDLL s1;
        public DllStudent2(StudentDLL s1 )
        {
            InitializeComponent();
            this.s1 = s1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s1.studentGetData(s1.studentCalTotal(), s1.studentCalAverage(s1.studentCalTotal()), s1.studentGetResult(s1.studentCalAverage(s1.studentCalTotal()))),"Student details");
        }
    }
}
