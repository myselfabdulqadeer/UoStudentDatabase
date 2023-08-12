using DApp1.References.econtactClasses;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DApp1
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.FirstName = textBox4.Text;
            c.LastName = textBox3.Text;
            c.ContactNo = textBox2.Text;
            c.Address = textBox5.Text;
            c.Gender = comboBox1.Text;
            Console.WriteLine("happiest c", c);
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact Inserted Successfully Inserted");

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add New Contact. Try Again");
            }

            //Load data on datagrid view 
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.ContactID = Convert.ToInt32(textBox1.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Deleted Successfully!");
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Unable to Delete, Try again!");
                Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //get the data from text boxes

            c.ContactID = int.Parse(textBox1.Text);
            c.FirstName = textBox4.Text;
            c.LastName = textBox3.Text;
            c.ContactNo = textBox2.Text;
            c.Address = textBox5.Text;
            c.Gender = comboBox1.Text;

            //update data in the database

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Updated Successfully");
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Update Failed. Try Again");
                Clear();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();

        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox6.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM phoneBook_Table WHERE FirstName LIKE '%" + keyword + "%' or LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}