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
    public partial class Login : Form
    {
        const string archivoUsuarios = "../../Archivos/usuarios.txt";
        public static List<Usuario> lstUsuarios = new List<Usuario>();
        public Login()
        {
            populateUsers(archivoUsuarios);
            InitializeComponent();
            txtBoxPassword.UseSystemPasswordChar = true;
        }
        static void populateUsers(string archivo)
        {
            lstUsuarios.Clear();
            FileStream file = new FileStream(archivo, FileMode.Open);
            StreamReader archivoReader = new StreamReader(file);
            string[] temparr = { };

            while (!(archivoReader.Peek() == -1))
            {
                Usuario tempObj = new Usuario();
                temparr = archivoReader.ReadLine().Split(';');
                tempObj.nombre = temparr[0];
                string passDecoded = Encoding.UTF8.GetString(Convert.FromBase64String(temparr[1]));
                Console.WriteLine("pass: "+ passDecoded);
                tempObj.password = passDecoded;
                lstUsuarios.Add(tempObj);
            }
            file.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario;
            string password;
            string msgError = "El usuario o contrasena ingresados son invalidos.";
            usuario = txtBoxUsuario.Text;
            password = txtBoxPassword.Text;
            if (lstUsuarios.Count != 0)
            {
                if (password != "" && usuario != "")
                {
                    if (lstUsuarios.Find(user => user.nombre == usuario) != null)
                    {
                        if (lstUsuarios.Find(user => user.nombre == usuario).password == password)
                        {
                            Console.WriteLine(usuario + " loggeado con exito!");
                            Laboratorio frmLaboratorio = new Laboratorio(lstUsuarios);
                            frmLaboratorio.Show();
                        }
                        else
                        {
                            MessageBox.Show(msgError);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no esta en el archivo.");
                        txtBoxPassword.Clear();
                        txtBoxUsuario.Clear();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe ingresar usuario y contrasena");
                }
            }
            else
            {
                MessageBox.Show("No hay usuarios en el archivo.");
            }
        }
    }
}
