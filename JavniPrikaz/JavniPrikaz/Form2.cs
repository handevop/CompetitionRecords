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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                SqlConnection sqlcon = new SqlConnection(
                    Properties.Settings.Default.WSCConnectionString
                );

                sqlcon.Open();

                string query = "SELECT Rad.Naziv as 'Naziv rada',Natjecatelj.Ime as 'Ime natjecatelja',Natjecatelj.Prezime as 'Prezime natjecatelja'," +
                    "Mentor.Ime as 'Ime mentora',Mentor.Prezime as 'Prezime mentora',Rad.DatumPrijave,RadKategorija.Naziv as 'Kategorija rada',Datoteka from Rad" +
                    " inner join Natjecatelj on Natjecatelj.ID = Rad.NatjecateljId inner join Mentor on Mentor.ID = Rad.MentorId inner join RadKategorija " +
                    "on Rad.RadKategorijaId = RadKategorija.ID where Rad.StatusRada = 0";

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dataGridView1.DataSource = dt;
                dr.Close();


                dataGridView1.Columns[7].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView1.Columns[7].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Underline);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                SqlConnection sqlcon = new SqlConnection(
                    Properties.Settings.Default.WSCConnectionString
                );

                sqlcon.Open();

                string query = "SELECT Rad.Naziv as 'Naziv rada',Natjecatelj.Ime as 'Ime natjecatelja',Natjecatelj.Prezime as 'Prezime natjecatelja'," +
                    "Mentor.Ime as 'Ime mentora',Mentor.Prezime as 'Prezime mentora',Rad.DatumPrijave,RadKategorija.Naziv as 'Kategorija rada',Datoteka from Rad" +
                    " inner join Natjecatelj on Natjecatelj.ID = Rad.NatjecateljId inner join Mentor on Mentor.ID = Rad.MentorId inner join RadKategorija " +
                    "on Rad.RadKategorijaId = RadKategorija.ID";

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dataGridView1.DataSource = dt;
                dr.Close();


                dataGridView1.Columns[7].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView1.Columns[7].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Underline);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                SqlConnection sqlcon = new SqlConnection(
                    Properties.Settings.Default.WSCConnectionString
                );

                sqlcon.Open();

                string query = "SELECT Rad.Naziv as 'Naziv rada',Natjecatelj.Ime as 'Ime natjecatelja',Natjecatelj.Prezime as 'Prezime natjecatelja'," +
                    "Mentor.Ime as 'Ime mentora',Mentor.Prezime as 'Prezime mentora',Rad.DatumPrijave,RadKategorija.Naziv as 'Kategorija rada',Datoteka from Rad" +
                    " inner join Natjecatelj on Natjecatelj.ID = Rad.NatjecateljId inner join Mentor on Mentor.ID = Rad.MentorId inner join RadKategorija " +
                    "on Rad.RadKategorijaId = RadKategorija.ID where Rad.StatusRada = 2";

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dataGridView1.DataSource = dt;
                dr.Close();


                dataGridView1.Columns[7].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView1.Columns[7].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Underline);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                SqlConnection sqlcon = new SqlConnection(
                    Properties.Settings.Default.WSCConnectionString
                );

                sqlcon.Open();

                string query = "SELECT Rad.Naziv as 'Naziv rada',Natjecatelj.Ime as 'Ime natjecatelja',Natjecatelj.Prezime as 'Prezime natjecatelja'," +
                    "Mentor.Ime as 'Ime mentora',Mentor.Prezime as 'Prezime mentora',Rad.DatumPrijave,RadKategorija.Naziv as 'Kategorija rada',Datoteka from Rad" +
                    " inner join Natjecatelj on Natjecatelj.ID = Rad.NatjecateljId inner join Mentor on Mentor.ID = Rad.MentorId inner join RadKategorija " +
                    "on Rad.RadKategorijaId = RadKategorija.ID";

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dataGridView1.DataSource = dt;
                dr.Close();


                dataGridView1.Columns[7].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView1.Columns[7].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Underline);
            }
            else if (radioButton2.Checked)
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                SqlConnection sqlcon = new SqlConnection(
                    Properties.Settings.Default.WSCConnectionString
                );

                sqlcon.Open();

                string query = "SELECT Rad.Naziv as 'Naziv rada',Natjecatelj.Ime as 'Ime natjecatelja',Natjecatelj.Prezime as 'Prezime natjecatelja'," +
                    "Mentor.Ime as 'Ime mentora',Mentor.Prezime as 'Prezime mentora',Rad.DatumPrijave,RadKategorija.Naziv as 'Kategorija rada',Datoteka from Rad" +
                    " inner join Natjecatelj on Natjecatelj.ID = Rad.NatjecateljId inner join Mentor on Mentor.ID = Rad.MentorId inner join RadKategorija " +
                    "on Rad.RadKategorijaId = RadKategorija.ID where Rad.StatusRada = 2";

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dataGridView1.DataSource = dt;
                dr.Close();


                dataGridView1.Columns[7].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView1.Columns[7].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Underline);
            }
            else
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                SqlConnection sqlcon = new SqlConnection(
                    Properties.Settings.Default.WSCConnectionString
                );

                sqlcon.Open();

                string query = "SELECT Rad.Naziv as 'Naziv rada',Natjecatelj.Ime as 'Ime natjecatelja',Natjecatelj.Prezime as 'Prezime natjecatelja'," +
                    "Mentor.Ime as 'Ime mentora',Mentor.Prezime as 'Prezime mentora',Rad.DatumPrijave,RadKategorija.Naziv as 'Kategorija rada',Datoteka from Rad" +
                    " inner join Natjecatelj on Natjecatelj.ID = Rad.NatjecateljId inner join Mentor on Mentor.ID = Rad.MentorId inner join RadKategorija " +
                    "on Rad.RadKategorijaId = RadKategorija.ID where Rad.StatusRada = 0";

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dataGridView1.DataSource = dt;
                dr.Close();


                dataGridView1.Columns[7].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView1.Columns[7].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Underline);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText.Contains("Datoteka"))
            {
                if (!String.IsNullOrWhiteSpace(dataGridView1.CurrentCell.EditedFormattedValue.ToString()))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(@dataGridView1.CurrentCell.EditedFormattedValue.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Ova putanja je nepostojeća!");
                    }
                }
            }
        }
    }
}
