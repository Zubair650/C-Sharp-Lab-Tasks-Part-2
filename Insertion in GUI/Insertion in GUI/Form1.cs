using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Insertion_in_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CName(object sender, EventArgs e)
        {

        }

        private void CCode(object sender, EventArgs e)
        {

        }

        private void AddCourseButton(object sender, EventArgs e)
        {
            string cname = textBox1.Text;
            int ccode = Int32.Parse(textBox2.Text);

            string connString = @"Server=DESKTOP-EDQLLBL;Database=Courses;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = string.Format("insert into courses values ('{0}',{1})", cname, ccode);
            SqlCommand cmd = new SqlCommand(query,conn);
            int r = cmd.ExecuteNonQuery();
            if(r>0)
            {
                MessageBox.Show("Course Added");
            }
            else
            {
                MessageBox.Show("Course can't be Added");
            }
            conn.Close();

        }
    }
}
