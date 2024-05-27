using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Grade : Form
    {
        public Grade()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            for (int i = 1; i <= student.Course; i++)
            {
                int x;
                do
                {
                    x = int.Parse(tBGrade.Text);
                } while (x < 2 || x > 5);
                student.Grades.Add(x);
            }
        }
    }
}
