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
    public partial class fGrade : Form
    {
        private Student _student;
        private int _currentGradeIndex;
        public fGrade(ref Student student)
        {
            InitializeComponent();
            _student = student;
            _currentGradeIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tBGrade.Text);
            if (x >= 2 && x <= 5)
            {
                _student.Grades.Add(x);
                _currentGradeIndex++;
                tBGrade.Text = string.Empty;

                if (_currentGradeIndex >= int.Parse(tBCourse.Text))
                {
                    MessageBox.Show("Всі оцінки введені.");
                    btnOK.Enabled = false;  // Деактивуємо кнопку OK
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть оцінку від 2 до 5.");
                tBGrade.Text = string.Empty;
            }
        }
        /*for (int i = 1; i <= int.Parse(tBCourse.Text); i++)
        {
            int x;
            do
            {
                x = int.Parse(tBGrade.Text);
                if (x >= 2 && x <= 5)
                {
                    _student.Grades.Add(x);
                }
                tBGrade.Text = string.Empty;
            } while (x < 2 || x > 5);
        }
        DialogResult = DialogResult.OK;*/

    }
}
