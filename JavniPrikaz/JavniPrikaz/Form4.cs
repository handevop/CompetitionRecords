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
    public partial class Form4 : Form
    {
        string id = "";

        public Form4()
        {
            InitializeComponent();
        }

        public void trazi()
        {
            SqlConnection sqlcon = new SqlConnection(
                Properties.Settings.Default.WSCConnectionString
            );

            sqlcon.Open();

            string query = "SELECT ID from RadKategorija where RadKategorija.Naziv = @Naziv";

            SqlCommand cmd = new SqlCommand(query, sqlcon);

            cmd.Parameters.AddWithValue("@Naziv", comboBox1.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    id = dr[0].ToString();
                }
            }

            dr.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            SqlConnection sqlcon = new SqlConnection(
                Properties.Settings.Default.WSCConnectionString
            );

            sqlcon.Open();

            string query = "SELECT RadKategorija.Naziv from RadKategorija";

            SqlCommand cmd = new SqlCommand(query, sqlcon);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0]);
                }
            }

            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            trazi();
            SqlConnection sqlcon = new SqlConnection(
                Properties.Settings.Default.WSCConnectionString
            );

            sqlcon.Open();

            string query = "SELECT Rad.Naziv as 'Naziv rada',Natjecatelj.Ime as 'Ime natjecatelja',Natjecatelj.Prezime as 'Prezime natjecatelja'," +
                "Mentor.Ime as 'Ime mentora',Mentor.Prezime as 'Prezime mentora',AVG( CAST(Ocjena.Vrijednost as float) ) as 'Prosjek ocjena' from Rad" +
                " inner join Natjecatelj on Natjecatelj.ID = Rad.NatjecateljId inner join Mentor on Mentor.ID = Rad.MentorId" +
                " inner join Ocjena on Ocjena.RadId = Rad.ID" +
                " WHERE Rad.RadKategorijaId = @KategorijaID" +
                " GROUP BY Rad.Naziv , Natjecatelj.Ime , Natjecatelj.Prezime , Mentor.Ime,Mentor.Prezime" +
                " ORDER BY AVG( CAST(Ocjena.Vrijednost as float) ) asc";

            SqlCommand cmd = new SqlCommand(query, sqlcon);

            cmd.Parameters.AddWithValue("@KategorijaID", id);

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            this.dataGridView1.DataSource = dt;
            dr.Close();

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
    }
}
