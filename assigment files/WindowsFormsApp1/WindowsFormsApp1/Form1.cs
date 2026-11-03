using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
using System;
using System.Windows.Forms;

namespace UniversityRegistration
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnCalculate_Click(object sender, EventArgs e)
            {
                try
                {
                    // 1. Akhrinta magaca iyo ID-ga
                    string studentName = txtName.Text;
                    string studentId = txtId.Text;

                    // 2. Hubinta tirada koorsooyinka iyadoo la adeegsanayo TryParse
                    if (!int.TryParse(txtCourses.Text, out int numOfCourses))
                    {
                        MessageBox.Show("Fadlan geli tiro sax ah oo ku saabsan tirada koorsooyinka!", "Cillad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Xadka koorsooyinka waa inuu u dhaxeeyaa 1 iyo 8
                    if (numOfCourses < 1 || numOfCourses > 8)
                    {
                        MessageBox.Show("Tirada koorsooyinka waa inay u dhaxaysaa 1 iyo 8!", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 3. Hubinta heerka sanadka (Study Level)
                    if (!int.TryParse(txtStudyLevel.Text, out int studyLevel))
                    {
                        MessageBox.Show("Fadlan geli heerka sanadka (1 ilaa 4)!", "Cillad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double feePerCourse = 0;

                    // Go'aaminta qiimaha koorsada iyadoo la raacayo sanadka
                    if (studyLevel == 1)
                    {
                        feePerCourse = 40;
                    }
                    else if (studyLevel == 2)
                    {
                        feePerCourse = 45;
                    }
                    else if (studyLevel == 3)
                    {
                        feePerCourse = 50;
                    }
                    else if (studyLevel == 4)
                    {
                        feePerCourse = 55;
                    }
                    else
                    {
                        MessageBox.Show("Heerka sanadka waa inuu ahaadaa 1, 2, 3, ama 4!", "Cillad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 4. Xisaabinta khidmadda asaasiga ah (Tuition Fee)
                    double tuitionFee = numOfCourses * feePerCourse;

                    // 5. Adeegyada dheeraadka ah (Accommodation iyo Transport)
                    double accommodationFee = 120;
                    double transportFee = 50;

                    // 6. Qiimo-dhimista (Discounts) adigoo isticmaalaya Shuruudo Isdaba-joog ah (Nested If)
                    double discountAmount = 0;

                    // Haddii uu diiwaangeliyay 6 koorso ama ka badan
                    if (numOfCourses >= 6)
                    {
                        discountAmount += tuitionFee * 0.10;
                    }

                    // Shuruudaha la xiriira hoyga iyo gaadiidka
                    bool hasAccommodation = true;
                    bool hasTransport = true;

                    if (hasAccommodation && hasTransport)
                    {
                        if (numOfCourses >= 5)
                        {
                            discountAmount += (tuitionFee + accommodationFee + transportFee) * 0.05;
                        }
                    }

                    // 7. Xisaabinta wadarta guud ee ugu dambaysa
                    double finalAmount = (tuitionFee + accommodationFee + transportFee) - discountAmount;

                    // 8. Ku soo bandhigida natiijada foomka dhexdiisa ama fariin ahaan
                    MessageBox.Show($"Magaca: {studentName}\nID: {studentId}\nTuition Fee: {tuitionFee:C2}\nDiscount: {discountAmount:C2}\nWadarta Guud: {finalAmount:C2}",
                                    "Natiijada Diiwaangelinta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cillad ayaa dhacday: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                txtName.Clear();
                txtId.Clear();
                txtCourses.Clear();
                txtStudyLevel.Clear();
            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
    private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
