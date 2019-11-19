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
    public partial class frmRemedio : Form
    {
        public static List<Remedio> lstRemedio = new List<Remedio>();
        public static List<Droga> lstDrogas = new List<Droga>();
        const string archivo = "../../Archivos/remedio.txt";
        const string _archivo = "../../Archivos/_remedio.txt";
        public frmRemedio(List<Remedio> _lstRemedio, List<Droga> _lstDroga)
        {
            lstDrogas = _lstDroga;
            lstRemedio = _lstRemedio;
            InitializeComponent();
            showRemedios();
        }

        private void showRemedios()
        {
            lstBoxRemedio.Items.Clear();
            foreach (Remedio item in lstRemedio)
            {
                lstBoxRemedio.Items.Add(item.codigo);
            }
        }

        private void writeFile(string _archivo, string archivo)
        {
            FileStream file = new FileStream(archivo, FileMode.Append);
            StreamWriter filewriter = new StreamWriter(file);
            foreach (Remedio item in lstRemedio)
            {
                string tempString = item.codigo + ";" + item.droga + ";" + item.cantidad;
                Console.WriteLine(tempString);
                filewriter.WriteLine(tempString);
            }
            filewriter.Close();
            file.Close();
            File.Delete(_archivo);
            File.Move(archivo, _archivo);

        }

        private void Droga_Click(object sender, EventArgs e)
        {

        }

        private void lstBoxRemedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelected = lstBoxRemedio.GetItemText(lstBoxRemedio.SelectedItem);
            if (itemSelected == txtBoxCodigo.Text)
            {
                txtBoxCodigo.Clear();
                txtBoxDroga.Clear();
                txtBoxCantidad.Clear();
                txtBoxCodigo.ReadOnly = false;
                lstBoxRemedio.ClearSelected();
            }
            else
            {
                if (lstBoxRemedio.SelectedIndex == -1)
                {
                    txtBoxCodigo.ReadOnly = false;
                }
                else
                {
                    int drogaSelected = lstRemedio.Find(item => item.codigo == Int32.Parse(itemSelected)).droga;
                    int cantidadSelected = lstRemedio.Find(item => item.codigo == Int32.Parse(itemSelected)).cantidad;
                    txtBoxCodigo.Text = itemSelected;
                    txtBoxCantidad.Text = cantidadSelected.ToString();
                    txtBoxDroga.Text = drogaSelected.ToString();
                    txtBoxCodigo.ReadOnly = true;
                }
            }
        }

        private void txtBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDroga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string codigo = txtBoxCodigo.Text;
            string cantidad = txtBoxCantidad.Text;
            string droga = txtBoxDroga.Text;
            // Console.WriteLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(codigo, "^[0-9]*$") && System.Text.RegularExpressions.Regex.IsMatch(droga, "^[0-9]*$") && System.Text.RegularExpressions.Regex.IsMatch(cantidad, "^[0-9]*$"))
            {
                if (lstRemedio.Find(item => item.codigo == Int32.Parse(codigo)) == null)
                {
                    if (lstDrogas.Find(item=> item.codigo == Int32.Parse(droga)) != null)
                    {
                        Remedio temp = new Remedio();
                        temp.codigo = Int32.Parse(codigo);
                        temp.droga = Int32.Parse(droga);
                        temp.cantidad = Int32.Parse(cantidad);
                        lstRemedio.Add(temp);
                        showRemedios();
                        writeFile(archivo, _archivo);
                    }
                    else
                    {
                        MessageBox.Show("La droga de este remedio no fue cargada, cargue primero la droga.");
                        txtBoxCodigo.Clear();
                        txtBoxDroga.Clear();
                        txtBoxCantidad.Clear();
                    }
                    
                }
                else
                {
                    MessageBox.Show("El remedio ya esta ingresado, modifiquelo.");
                    txtBoxCodigo.Clear();
                    txtBoxDroga.Clear();
                    txtBoxCantidad.Clear();
                }
            }
            else
            {
                MessageBox.Show("Caracteres invalidos, solo se admiten numeros");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (txtBoxCodigo.Text != null)
            {
                int itemSelected = Int32.Parse(txtBoxCodigo.Text);
                lstRemedio.Remove(lstRemedio.Find(item => item.codigo == itemSelected));
                txtBoxCantidad.Clear();
                txtBoxCodigo.Clear();
                txtBoxDroga.Clear();
                writeFile(archivo, _archivo);
                showRemedios();
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (txtBoxCodigo.Text != null)
            {
                int codigo = Int32.Parse(txtBoxCodigo.Text);
                string droga = txtBoxDroga.Text;
                string cantidad = txtBoxCantidad.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(droga, "^[0-9]*$") && System.Text.RegularExpressions.Regex.IsMatch(cantidad, "^[0-9]*$"))
                {
                    if (lstDrogas.Find(item => item.codigo == Int32.Parse(droga)) != null)
                    {
                        int newDroga = Int32.Parse(droga);
                        int newCantidad = Int32.Parse(cantidad);
                        lstRemedio.Find(item => item.codigo == codigo).droga = newDroga;
                        lstRemedio.Find(item => item.codigo == codigo).cantidad = newCantidad;
                        txtBoxCodigo.Clear();
                        txtBoxCantidad.Clear();
                        txtBoxDroga.Clear();
                        writeFile(archivo, _archivo);
                        showRemedios();
                    }
                    else
                    {
                        MessageBox.Show("La droga que estas intentando ingresar, no fue dada de alta, primero dar de alta la droga y luego hacer la modificacion.");
                        txtBoxDroga.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("El valor de droga y cantidad deben ser del tipo entero.");
                    txtBoxDroga.Clear();
                    txtBoxCantidad.Clear();
                }
            }
            else
            {
                MessageBox.Show("No seleccionaste item para modificar");
            }
        }
    }
}
