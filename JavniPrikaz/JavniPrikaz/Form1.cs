using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavniPrikaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(25, 106, 166);
            button1.BackColor = Color.FromArgb(25, 106, 166);
            button2.BackColor = Color.FromArgb(25, 106, 166);
            button3.BackColor = Color.FromArgb(25, 106, 166);
            this.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 PrikazRadova = new Form2();
            PrikazRadova.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Ocjene = new Form3();
            Ocjene.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Poredak = new Form4();
            Poredak.Show();
        }
    }
}
