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
    public partial class Laboratorio : Form
    {
        const string archivoDrogas = "../../Archivos/droga.txt";
        const string archivoRemedios = "../../Archivos/remedio.txt";
        const string archivoVentas = "../../Archivos/venta.txt";


        public static List<Droga> lstDrogas = new List<Droga>();

        public static List<Remedio> lstRemedio = new List<Remedio>();
        public static List<Remedio> lstRemedioByPrice = new List<Remedio>();
        public static List<Remedio> lstRemedioByRecaudacion = new List<Remedio>();

        public static List<Venta> lstVentas = new List<Venta>();

        public static List<Usuario> lstUsuarios = new List<Usuario>();

        public int recaudacionTotal;
        public double precioPromedio;
        public int masDrogaOcho;
        int drogaMenosUsada;
        int drogaMasCara;
        int remedioMasBarato;
        
        public Laboratorio(List<Usuario> _lstUsuarios)
        {
            lstUsuarios = _lstUsuarios;
            populateDrogas(archivoDrogas);
            populateRemedios(archivoRemedios);
            populateVentas(archivoVentas);
            InitializeComponent();
            refreshAll();
            txtBoxRecaudacion.ReadOnly = true;
            txtBoxPromedio.ReadOnly = true;
            txtBoxDroga8.ReadOnly = true;
            txtBoxCheapest.ReadOnly = true;
            txtBoxExpensive.ReadOnly = true;
            txtBoxLessUsed.ReadOnly = true;

        }

        public void refreshAll()
        {
            getRecaudacionRemedio();
            recaudacionTotal = getRecaudacionTotal();
            txtBoxRecaudacion.Text = recaudacionTotal.ToString();
            Console.WriteLine("Recaudacion Total: " + recaudacionTotal);
            porcentajeRemedio(recaudacionTotal);
            precioPromedio = lstRemedio.Average(value => value.valor);
            Console.WriteLine("Precio Promedio: " + precioPromedio);
            txtBoxPromedio.Text = precioPromedio.ToString();
            masDrogaOcho = getDrogaOcho();
            Console.WriteLine("remedioMasDroga8: " + masDrogaOcho);
            txtBoxDroga8.Text = masDrogaOcho.ToString();
            drogaMenosUsada = getMenosUsada();
            Console.WriteLine("drogaMenosUsada: " + drogaMenosUsada);
            txtBoxLessUsed.Text = drogaMenosUsada.ToString();
            drogaMasCara = getDrogaMasCara();
            Console.WriteLine("drogaMasCara: " + drogaMasCara);
            txtBoxExpensive.Text = drogaMasCara.ToString();
            remedioMasBarato = getRemedioMasBarato();
            Console.WriteLine("remedioMasbarato: " + remedioMasBarato);
            txtBoxCheapest.Text = remedioMasBarato.ToString();
        }
        static void populateDrogas(string archivo)
        {
            lstDrogas.Clear();
            FileStream file = new FileStream(archivo, FileMode.Open);
            StreamReader archivoReader = new StreamReader(file);
            string [] temparr = { } ;
            
            while (!(archivoReader.Peek() == -1))
            {
                Droga tempObj = new Droga();
                temparr = archivoReader.ReadLine().Split(';');
                tempObj.codigo = Int32.Parse(temparr[0]);
                tempObj.valor = Int32.Parse(temparr[1]);
                lstDrogas.Add(tempObj);
            }
            file.Close();

        }
        static void populateRemedios(string archivo)
        {
            lstRemedio.Clear();
            FileStream file = new FileStream(archivo, FileMode.Open);
            StreamReader archivoReader = new StreamReader(file);
            string[] tempvar;
            while (!(archivoReader.Peek() == -1))
            {
                Remedio tempObj = new Remedio();
                tempvar = archivoReader.ReadLine().Split(';');
                tempObj.codigo = Int32.Parse(tempvar[0]);
                tempObj.droga = Int32.Parse(tempvar[1]);
                tempObj.cantidad = Int32.Parse(tempvar[2]);
                tempObj.valor = tempObj.cantidad * lstDrogas.Find(e=> tempObj.droga == e.codigo).valor;
                lstRemedio.Add(tempObj);
            }
            file.Close();
        }
        static void populateVentas(string archivo)
        {
            lstVentas.Clear();
            FileStream file = new FileStream(archivo, FileMode.Open);
            StreamReader archivoReader = new StreamReader(file);
            string[] tempvar;
            while (!(archivoReader.Peek() == -1))
            {
                Venta tempObj = new Venta();
                tempvar = archivoReader.ReadLine().Split(';');
                tempObj.factura = Int32.Parse(tempvar[0]);
                tempObj.remedio = Int32.Parse(tempvar[1]);
                tempObj.cantidad = Int32.Parse(tempvar[2]);
                lstVentas.Add(tempObj);
            }
            file.Close();
        }
        static int getRecaudacionTotal()
        {
            var total = 0;
            foreach (Remedio remedio in lstRemedio)
            {
                total += remedio.recaudacion;
            }
            return total;
        }

        static void getRecaudacionRemedio()
        {
           foreach (Remedio remedio in lstRemedio)
            {
                remedio.recaudacion = 0;
                foreach (Venta venta in lstVentas)
                {
                    if (venta.remedio == remedio.codigo)
                    {
                        remedio.recaudacion += venta.cantidad * remedio.valor;
                    }
                }
                Console.WriteLine("Se recaudo:" + remedio.recaudacion + " remedio: " + remedio.codigo);
            }

        }

        static void porcentajeRemedio(int total)
        {
            foreach (Remedio remedio in lstRemedio)
            {
                remedio.porcentaje = (remedio.recaudacion * 1000) / total;
                remedio.porcentaje /= 1000;
                Console.WriteLine("Porcentaje: " + remedio.porcentaje + " Remedio: " + remedio.codigo);
            }
        }

        static int getDrogaOcho()
        {
            int codMayor = 0;
            int cantMayor = 0;
            foreach(Remedio remedio in lstRemedio)
            {
                if (remedio.droga == 8)
                {
                    if (remedio.cantidad > cantMayor)
                    {
                        codMayor = remedio.codigo;
                        cantMayor = remedio.cantidad;
                    }
                }
            }
            return codMayor;
        }
        static int getMenosUsada()
        {
            int lessUsed = 0;
            int quantityLessUsed = 0;
            foreach(Droga droga in lstDrogas)
            {
                int quantity = 0;
                foreach(Remedio remedio in lstRemedio)
                {
                    if (remedio.droga == droga.codigo)
                    {
                        quantity += remedio.cantidad;
                    }
                }
                if (quantityLessUsed == 0)
                {
                    lessUsed = droga.codigo;
                    quantityLessUsed = quantity;
                }
                if (quantity < quantityLessUsed)
                {
                    lessUsed = droga.codigo;
                    quantityLessUsed = quantity;
                }
            }
            return lessUsed;
        }
        static int getDrogaMasCara()
        {
            int codMasCara = 0;
            int precMasCara = 0;
            foreach (Droga droga in lstDrogas)
            {
                if (droga.valor > precMasCara)
                {
                    codMasCara = droga.codigo;
                    precMasCara = droga.valor;
                }
            }
            return codMasCara;
        }
        static int getRemedioMasBarato()
        {
            int codCheapest = 0;
            int precCheapest = 0;
            foreach (Remedio remedio in lstRemedio)
            {
                if (precCheapest == 0)
                {
                    precCheapest = remedio.valor;
                    codCheapest = remedio.codigo;
                }
                if (remedio.valor < precCheapest)
                {
                    codCheapest = remedio.codigo;
                    precCheapest = remedio.valor;
                }
            }
            return codCheapest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void altaBajaYModiicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAbmUser_Click(object sender, EventArgs e)
        {
            frmUsuario frmusuario = new frmUsuario(lstUsuarios);
            frmusuario.Show();
        }

        private void btnAbmRemedio_Click(object sender, EventArgs e)
        {
            frmRemedio frmremedio = new frmRemedio(lstRemedio,lstDrogas);
            frmremedio.Show();
        }

        private void btnAbmVenta_Click(object sender, EventArgs e)
        {
            frmVenta frmventa = new frmVenta(lstVentas,lstRemedio);
            frmventa.Show();
        }

        private void btnAbmDroga_Click(object sender, EventArgs e)
        {
            frmDroga frmdroga = new frmDroga(lstDrogas);
            frmdroga.Show();
        }

        private void btnShowValores_Click(object sender, EventArgs e)
        {
            lstBoxInfo.Items.Clear();
            foreach (Remedio remedio in lstRemedio)
            {
                string tempString = "Remedio: " + remedio.codigo + "\trecaudacion: $" + remedio.recaudacion;
                lstBoxInfo.Items.Add(tempString);
            }
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            lstBoxInfo.Items.Clear();
            foreach (Remedio remedio in lstRemedio)
            {
                string tempString = "Remedio: " + remedio.codigo + "\tvalor: $" + remedio.valor;
                lstBoxInfo.Items.Add(tempString);
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            lstBoxInfo.Items.Clear();
            foreach (Remedio remedio in lstRemedio)
            {
                string tempString = "Remedio: " + remedio.codigo + "\tporcentaje: "  + remedio.porcentaje;
                lstBoxInfo.Items.Add(tempString);
            }            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshAll();
        }
    }
}
