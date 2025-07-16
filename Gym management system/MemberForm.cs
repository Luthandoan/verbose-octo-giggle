using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymS1
{
    public partial class MemberForm : Form
    {

        private String connectionString = "Data Source=R3xl33\\SQLEXPRESS;Initial Catalog=Gym Management System;Integrated Security=True";
        public MemberForm()
        {
            InitializeComponent();
            LoadMemberData();
        }

        private void LoadMemberData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Members";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvMembers.DataSource = dataTable;
            }
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            DateTime dob = dtpDateOfBirth.Value;
            string gender = cmbGender.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string trainingProgram = cmbTrainingProgram.Text;
            DateTime membershipStart = dtpMembershipStart.Value;
            DateTime membershipEnd = dtpMembershipEnd.Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Members (FirstName, LastName, DateOfBirth, Gender, Phone, Address, TrainingProgram, MembershipStart, MembershipEnd) " +
                               "VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Phone, @Address, @TrainingProgram, @MembershipStart, @MembershipEnd)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DateOfBirth", dob);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@TrainingProgram", trainingProgram);
                command.Parameters.AddWithValue("@MembershipStart", membershipStart);
                command.Parameters.AddWithValue("@MembershipEnd", membershipEnd);
                command.ExecuteNonQuery();
            }

            LoadMemberData();
        }

        // Implement other CRUD operations (Read, Update, Delete, Search) similarly
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
