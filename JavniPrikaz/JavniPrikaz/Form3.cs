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

namespace JavniPrikaz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(
                    Properties.Settings.Default.WSCConnectionString
                );

            sqlcon.Open();

            string query = "SELECT Rad.Naziv as 'Naziv rada',Natjecatelj.Ime as 'Ime natjecatelja',Natjecatelj.Prezime as 'Prezime natjecatelja'," +
                "Sudac.Ime as 'Ime sudca',Sudac.Prezime as 'Prezime sudca' ,Rad.Datoteka,Ocjena.Vrijednost as 'Ocjena' from Rad inner join Ocjena on Rad.ID = Ocjena.RadId" +
                " inner join Natjecatelj on Natjecatelj.ID = Rad.NatjecateljId inner join Sudac on Sudac.ID = Ocjena.SudacId";

            SqlCommand cmd = new SqlCommand(query, sqlcon);

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            this.dataGridView1.DataSource = dt;
            dr.Close();


            dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[5].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Underline);
        }
    }
}
