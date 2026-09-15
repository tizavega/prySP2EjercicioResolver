using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySP2EjercicioResolver
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 59)
            {
                e.Handled = true;

            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cboTipoBoleto.Items.Add("Estandar");
            cboTipoBoleto.Items.Add("Premium");
            cboTipoBoleto.Items.Add("Ultra");

            cboTipoBoleto.DropDownStyle = ComboBoxStyle.DropDownList;

            rbCorta.Checked = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Complete el código", "Carga Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtCodigo.Focus();
                txtCodigo.BackColor = Color.Aqua;
            }
            else
            {


                if (cboTipoBoleto.SelectedIndex == -1)
                {
                    MessageBox.Show("complete el codigo", "Carga Datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboTipoBoleto.Focus();
                    cboTipoBoleto.BackColor = Color.Aqua;
                }
                else
                {
                    StreamWriter archivo;
                    archivo = new StreamWriter("RegistroBoletos.txt");

                    archivo.WriteLine("Codigo: " + txtCodigo.Text + "  Tipo boleto: "
                        + cboTipoBoleto.Text );

                    archivo.Close();

                    MessageBox.Show("Registramos su boleto", " Registro de boleto ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

            {
              
            }
        }
    }
}
