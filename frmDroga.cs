using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class frmDroga : Form
    {
        public static List<Droga> lstDrogas;
        const string archivo = "../../Archivos/droga.txt";
        const string _archivo = "../../Archivos/_droga.txt";
        public frmDroga(List<Droga> _lstDrogas)
        {
            lstDrogas = _lstDrogas;
            InitializeComponent();
            showDrogas();
        }

        private void showDrogas()
        {
            lstBoxDrogas.Items.Clear();
            foreach (Droga droga in lstDrogas)
            {
                lstBoxDrogas.Items.Add(droga.codigo);
            }
        }
        private void writeFile(string _archivo, string archivo)
        {
            FileStream file = new FileStream(archivo, FileMode.Append);
            StreamWriter filewriter = new StreamWriter(file);
            foreach (Droga droga in lstDrogas)
            {
                Console.WriteLine(droga.codigo + ";" + droga.valor);
                string tempString = droga.codigo + ";" + droga.valor;
                filewriter.WriteLine(tempString);
            }
            filewriter.Close();
            file.Close();
            File.Delete(_archivo);
            File.Move(archivo, _archivo);

        }

        private void lstBoxDrogas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string drugSelected = lstBoxDrogas.GetItemText(lstBoxDrogas.SelectedItem);
            if (drugSelected == txtBoxCodigo.Text)
            {
                txtBoxCodigo.Clear();
                txtBoxPrecio.Clear();
                txtBoxCodigo.ReadOnly = false;
                lstBoxDrogas.ClearSelected();
            }
            else
            {
                int valueSelected = lstDrogas.Find(drug => drug.codigo == Int32.Parse(drugSelected)).valor;
                txtBoxCodigo.Text = drugSelected;
                txtBoxPrecio.Text = valueSelected.ToString();
                txtBoxCodigo.ReadOnly = true;
                if (lstBoxDrogas.SelectedIndex == -1)
                {
                    txtBoxCodigo.ReadOnly = false;
                }
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string codigo = txtBoxCodigo.Text;
            string valor = txtBoxPrecio.Text;
           // Console.WriteLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(codigo,"^[0-9]*$") && System.Text.RegularExpressions.Regex.IsMatch(valor,"^[0-9]*$"))
            {
                if (lstDrogas.Find(item => item.codigo == Int32.Parse(codigo)) == null)
                {
                    Droga temp = new Droga();
                    temp.codigo = Int32.Parse(codigo);
                    temp.valor = Int32.Parse(valor);
                    lstDrogas.Add(temp);
                    showDrogas();
                    writeFile(archivo, _archivo);
                }
                else
                {
                    MessageBox.Show("La droga ya esta ingresada.");
                    txtBoxCodigo.Clear();
                    txtBoxPrecio.Clear();
                }
            }
            else
            {
                MessageBox.Show("Caracteres invalidos, solo se admiten numeros");
            }

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int itemSelected = Int32.Parse(txtBoxCodigo.Text);
            lstDrogas.Remove(lstDrogas.Find(item => item.codigo == itemSelected));
            writeFile(archivo, _archivo);
            showDrogas();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (txtBoxCodigo.Text != null)
            {
                int codigo = Int32.Parse(txtBoxCodigo.Text);
                string valor = txtBoxPrecio.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(valor, "^[0-9]*$"))
                {
                    int newValor = Int32.Parse(valor);
                    lstDrogas.Find(item => item.codigo == codigo).valor = newValor;
                    txtBoxCodigo.Clear();
                    txtBoxPrecio.Clear();
                    writeFile(archivo, _archivo);
                    showDrogas();
                }
                else
                {
                    MessageBox.Show("El valor debe ser del tipo entero.");
                }
            }
            else
            {
                MessageBox.Show("No seleccionaste item para modificar");
            }
        }
    }
}
