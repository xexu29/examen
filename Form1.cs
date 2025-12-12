using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace examen
{
    public partial class Form1 : Form
    {
        private List<Entrada> entradas = new List<Entrada>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVendre_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" || dtpData.Value.Date >= DateTime.Today || txtPreu.Text != "" || cmbZona.SelectedItem != null)
            {
                int precio=int.Parse(txtPreu.Text);
                if (precio >= 20 && precio <= 500)
                {
                    if (cmbTipus.Text.Equals("General"))
                    {
                        Entrada tiquets = new Entrada(txtNom.Text, dtpData.Value, txtPreu.Text, cmbZona.SelectedText);
                        entradas.Add(tiquets);
                        listBox1.Items.Add(txtNom.Text);
                    }
                    else if (cmbTipus.Text.Equals("Vip"))
                    {
                        EntradaVIP tiquets = new EntradaVIP(txtNom.Text, dtpData.Value, txtPreu.Text, cmbZona.SelectedText, txtVIP.Text);
                        entradas.Add(tiquets);
                        listBox1.Items.Add(txtNom.Text);
                       

                    }
                    txtNom.Clear();
                    txtPreu.Clear();
                    txtVIP.Clear();
                }
                else
                {
                    MessageBox.Show("Precio minima 20€");
                }
                
            }
            else
            {
                MessageBox.Show("Un campo no ha sido rellenado o la fecha es anterior al actual");
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPreu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbZona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipus.Text.Equals("Vip"))
            {
                lblVIP.Visible = true;
                txtVIP.Visible = true;
            }
            else
            {
                lblVIP.Visible = false;
                txtVIP.Visible = false;
            }
        }

        private void txtVIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
