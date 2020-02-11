using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenRadSaViseFormi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();
            DialogResult rez = frm.ShowDialog();
            if (rez == System.Windows.Forms.DialogResult.OK) listBox1.Items.Add(frm.Student1.ToString());
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedIndex < 0)) listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
