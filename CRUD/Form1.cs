using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=employee_record";
            string query = "update tbl_employee set FIRSTNAME='" + this.FIRSTNAME.Text + "',MI='" + this.MI.Text + "',LASTNAME='" + this.LASTNAME.Text + "',GENDER='" + this.GENDER.Text + "',POSITION='" + this.POSITION.Text + "' where EMPID='" + this.EMPID.Text + "'";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully Update");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=employee_record";
            string query = "insert into tbl_employee (FIRSTNAME,MI,LASTNAME,GENDER,POSITION) values ('" + this.FIRSTNAME.Text + "','" + this.MI.Text + "','" + this.LASTNAME.Text + "','" + this.GENDER.Text + "','" + this.POSITION.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=employee_record";
            string query = "select * from tbl_employee";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}