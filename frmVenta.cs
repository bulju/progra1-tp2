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
    public partial class frmVenta : Form
    {
        public static List<Remedio> lstRemedio = new List<Remedio>();
        public static List<Venta> lstVentas = new List<Venta>();
        const string archivo = "../../Archivos/venta.txt";
        const string _archivo = "../../Archivos/_venta.txt";
        public frmVenta(List<Venta> _lstVentas, List<Remedio> _lstRemedio)
        {
            lstRemedio = _lstRemedio;
            lstVentas = _lstVentas;
            InitializeComponent();
            showVentas();
        }
        private void showVentas()
        {
            lstBoxRemedio.Items.Clear();
            foreach (Venta item in lstVentas)
            {
                lstBoxRemedio.Items.Add(item.factura);
            }
        }

        private void writeFile(string _archivo, string archivo)
        {
            FileStream file = new FileStream(archivo, FileMode.Append);
            StreamWriter filewriter = new StreamWriter(file);
            foreach (Venta item in lstVentas)
            {
                string tempString = item.factura + ";" + item.remedio + ";" + item.cantidad;
                Console.WriteLine(tempString);
                filewriter.WriteLine(tempString);
            }
            filewriter.Close();
            file.Close();
            File.Delete(_archivo);
            File.Move(archivo, _archivo);

        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            string codigo = txtBoxCodigo.Text;
            string cantidad = txtBoxCantidad.Text;
            string remedio = txtBoxRemedio.Text;
            // Console.WriteLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(codigo, "^[0-9]*$") && System.Text.RegularExpressions.Regex.IsMatch(remedio, "^[0-9]*$") && System.Text.RegularExpressions.Regex.IsMatch(cantidad, "^[0-9]*$"))
            {
                if (lstVentas.Find(item => item.factura == Int32.Parse(codigo)) == null)
                {
                    if (lstRemedio.Find(item => item.codigo == Int32.Parse(remedio)) != null)
                    {
                        Venta temp = new Venta();
                        temp.factura = Int32.Parse(codigo);
                        temp.remedio = Int32.Parse(remedio);
                        temp.cantidad = Int32.Parse(cantidad);
                        lstVentas.Add(temp);
                        showVentas();
                        writeFile(archivo, _archivo);
                    }
                    else
                    {
                        MessageBox.Show("La droga de este remedio no fue cargada, cargue primero la droga.");
                        txtBoxCodigo.Clear();
                        txtBoxRemedio.Clear();
                        txtBoxCantidad.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("El remedio ya esta ingresado, modifiquelo.");
                    txtBoxCodigo.Clear();
                    txtBoxRemedio.Clear();
                    txtBoxCantidad.Clear();
                }
            }
            else
            {
                MessageBox.Show("Caracteres invalidos, solo se admiten numeros");
                txtBoxCodigo.Clear();
                txtBoxRemedio.Clear();
                txtBoxCantidad.Clear();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (txtBoxCodigo.Text != null)
            {
                int itemSelected = Int32.Parse(txtBoxCodigo.Text);
                lstVentas.Remove(lstVentas.Find(item => item.factura == itemSelected));
                txtBoxCantidad.Clear();
                txtBoxCodigo.Clear();
                txtBoxRemedio.Clear();
                writeFile(archivo, _archivo);
                showVentas();
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (txtBoxCodigo.Text != null)
            {
                int codigo = Int32.Parse(txtBoxCodigo.Text);
                string remedio = txtBoxRemedio.Text;
                string cantidad = txtBoxCantidad.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(remedio, "^[0-9]*$") && System.Text.RegularExpressions.Regex.IsMatch(cantidad, "^[0-9]*$"))
                {
                    if (lstRemedio.Find(item => item.codigo == Int32.Parse(remedio)) != null)
                    {
                        int newRemedio = Int32.Parse(remedio);
                        int newCantidad = Int32.Parse(cantidad);
                        lstVentas.Find(item => item.factura == codigo).remedio = newRemedio;
                        lstVentas.Find(item => item.factura == codigo).cantidad = newCantidad;
                        txtBoxCodigo.Clear();
                        txtBoxCantidad.Clear();
                        txtBoxRemedio.Clear();
                        writeFile(archivo, _archivo);
                        showVentas();

                    }
                    else
                    {
                        MessageBox.Show("El remedio que estas intentando ingresar, no fue dado de alta, primero dar de alta el remedio y luego hacer la modificacion.");
                        txtBoxRemedio.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("El valor de remedio y cantidad deben ser del tipo entero.");
                    txtBoxRemedio.Clear();
                    txtBoxCantidad.Clear();
                }
            }
            else
            {
                MessageBox.Show("No seleccionaste item para modificar");
            }
        }


        private void lstBoxRemedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelected = lstBoxRemedio.GetItemText(lstBoxRemedio.SelectedItem);
            if (itemSelected == txtBoxCodigo.Text)
            {
                txtBoxCodigo.Clear();
                txtBoxRemedio.Clear();
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
                    int remedioSelected = lstVentas.Find(item => item.factura == Int32.Parse(itemSelected)).remedio;
                    int cantidadSelected = lstVentas.Find(item => item.factura == Int32.Parse(itemSelected)).cantidad;
                    txtBoxCodigo.Text = itemSelected;
                    txtBoxCantidad.Text = cantidadSelected.ToString();
                    txtBoxRemedio.Text = remedioSelected.ToString();
                    txtBoxCodigo.ReadOnly = true;
                }
            }
        }
    }
}
