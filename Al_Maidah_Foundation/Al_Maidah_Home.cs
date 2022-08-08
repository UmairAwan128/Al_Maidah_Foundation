using Al_Maidah_Foundation.Al_Maidah_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Maidah_Foundation
{
    public partial class AL_Maidah_Foundation : MaterialSkin.Controls.MaterialForm
    {
        public AL_Maidah_Foundation()
        {
            InitializeComponent();
        }

        private void MembersBtnMainForm_Click(object sender, EventArgs e)
        {
            slidePic.Show();

            slidePic.BringToFront();

            sidepanel.Height = MembersBtnMainForm.Height;
            sidepanel.Top = MembersBtnMainForm.Top;
            
            MembersForm mf = MembersForm.GetMembersFormInstance();
            mf.Show();
          
        }

        private void DoctorsButtonMainForm_Click(object sender, EventArgs e)
        {
            slidePic.Show();

            sidepanel.Height = DoctorsButtonMainForm.Height;
            sidepanel.Top = DoctorsButtonMainForm.Top;
            
            DoctorsForm df = DoctorsForm.GetDocotrsFormInstance();
            df.Show();


        }

        private void MedCampButtonMainForm_Click(object sender, EventArgs e)
        {
            slidePic.Show();

            sidepanel.Height = MedCampButtonMainForm.Height;
            sidepanel.Top = MedCampButtonMainForm.Top;

            MedicalCampForm MCF = MedicalCampForm.GetMedicalCampFormInstance();
            MCF.Show();

            
        }

        private void LabAttendbuttonMainForm_Click(object sender, EventArgs e)
        {
            slidePic.Show();

            sidepanel.Height = LabAttendbuttonMainForm.Height;
            sidepanel.Top = LabAttendbuttonMainForm.Top;

            LabAttendantForm LAF = LabAttendantForm.GetLabAttendantFormInstance();
            LAF.Show();
            
        }

        private void OtherExpbutton_Click(object sender, EventArgs e)
        {
            slidePic.Show();

            sidepanel.Height = OtherExpbutton.Height;
            sidepanel.Top = OtherExpbutton.Top;

            OtherExpenseForm OEF = OtherExpenseForm.GetExpenseFormInstance();
            OEF.Show();
            
        }

        private void Donationbutton_Click(object sender, EventArgs e)
        {
            slidePic.Show();

            sidepanel.Height = Donationbutton.Height;
            sidepanel.Top = Donationbutton.Top;

            DonationsForm DF = DonationsForm.GetDonationFormInstance();
            DF.Show();
            
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            slidePic.Show();

            sidepanel.Height = PatientsButton.Height;
            sidepanel.Top = PatientsButton.Top;

            PatientsForm PF = PatientsForm.GetPatientsFormInstance();
            PF.Show();
            
        }

        private void MedDepbutton_Click(object sender, EventArgs e)
        {
            slidePic.Show();
            
            sidepanel.Height = MedDepbutton.Height;
            sidepanel.Top = MedDepbutton.Top;
            MedDepForm MDF = MedDepForm.GetMedDepFormInstance();
            MDF.Show();
            
        }

        //currently displaying image number
        private int imageNumber = 1;

        //will load the next image the from the project folder Al_Maidah_Foundation\bin\Debug\Images
        private void loadNextImage()
        {

            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object se8nder, EventArgs e)
        {
            loadNextImage();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            slidePic.Hide();
            loadStatistics();

            sidepanel.Height = HomeButton.Height;
            sidepanel.Top = HomeButton.Top;

        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void AL_Maidah_Foundation_Load(object sender, EventArgs e)
        {
            slidePic.Hide();
            loadStatistics();
        }

        private void loadStatistics()
        {
            //calling the countMembersFuntion whose name is in sql
            SqlConnection connectSql = new SqlConnection(myconnstring);
            string callMembersCount = "SELECT dbo.countMembersfun()";
            SqlCommand cmd = new SqlCommand(callMembersCount, connectSql);
            connectSql.Open();
            TotalMembers.Text = cmd.ExecuteScalar().ToString();
            connectSql.Close();

            //calling the countPatientsFuntion whose name is in sql
            string callPatientsCount = "SELECT dbo.countPatientsfun()";
            SqlCommand cmd1 = new SqlCommand(callPatientsCount, connectSql);
            connectSql.Open();
            Totalpatient.Text = cmd1.ExecuteScalar().ToString();
            connectSql.Close();

            //calling the countMedicalCampFuntion whose name is in sql
            string callMedCampCount = "SELECT dbo.counMedicalCampsfun()";
            SqlCommand cmd2 = new SqlCommand(callMedCampCount, connectSql);
            connectSql.Open();
            TotalMedicalCamps.Text = cmd2.ExecuteScalar().ToString();
            connectSql.Close();

            //calling the sumDonationRecievedFunction whose name is in sql
            string callDonationRecivedSum = "SELECT dbo.totalDonationRecievedfun()";
            SqlCommand cmd3 = new SqlCommand(callDonationRecivedSum, connectSql);
            connectSql.Open();
            TotalDonations.Text = cmd3.ExecuteScalar().ToString();
            connectSql.Close();

            //calling the sumExpenseTillFunction whose name is in sql
            string callExpenseTillSum = "SELECT dbo.totalExpensesTill()";
            SqlCommand cmd4 = new SqlCommand(callExpenseTillSum, connectSql);
            connectSql.Open();
            TotalExpense.Text = cmd4.ExecuteScalar().ToString();
            connectSql.Close();

        }
 
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
