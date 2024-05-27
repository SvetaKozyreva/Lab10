using Lab10;

namespace Lab10
{
    public partial class fStudent : Form
    {
        private Student _stud;

        public fStudent(ref Student student)
        {
            InitializeComponent();
            _stud = student;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int age = int.Parse(tBAge.Text);
            int course = int.Parse(tBCourse.Text);

            _stud.Fullname = tBFullname.Text;
            _stud.Age = age;
            _stud.Course = course;
            _stud.University = tBUniversity.Text;
            _stud.Specialty = tBSpecialty.Text;
            _stud.Livedorm = chBLivedrom.Checked;
            _stud.PaidFree = chBPaidFree.Checked;
            _stud.Contract = chBContract.Checked;

            fGrade fg = new fGrade(ref _stud);
            if (fg.ShowDialog() == DialogResult.OK)
            {
                _stud.AverageGrade = _stud.Average();
                DialogResult = DialogResult.OK;
                Close();
            }  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
