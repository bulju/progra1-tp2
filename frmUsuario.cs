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
    public partial class frmUsuario : Form
    {
        public static List<Usuario> lstUsuarios;
        const string archivoUsuarios = "../../Archivos/usuarios.txt";
        const string _archivoUsuarios = "../../Archivos/_usuarios.txt";


        public frmUsuario(List<Usuario> _lstUsuarios)
        {
            lstUsuarios = _lstUsuarios;
            InitializeComponent();
            txtBoxPassword.UseSystemPasswordChar = true;
            showUsers();
        }

        private void showUsers()
        {
            lstBoxUsers.Items.Clear();
            foreach (Usuario user in lstUsuarios)
            {
                lstBoxUsers.Items.Add(user.nombre);
            }
        }

        private void writeFile(string _archivo, string archivo)
        {
            FileStream file = new FileStream(archivo,FileMode.Append);
            StreamWriter filewriter = new StreamWriter(file);

            foreach(Usuario user in lstUsuarios)
            {
                string passwordEncoded = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(user.password));
                Console.WriteLine(user.nombre + ";" + passwordEncoded);
                string tempString = user.nombre + ";" + passwordEncoded;
                filewriter.WriteLine(tempString);
            }
            filewriter.Close();
            file.Close();
            File.Delete(_archivo);
            File.Move(archivo, _archivo);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userSelected = lstBoxUsers.GetItemText(lstBoxUsers.SelectedItem);
            if (userSelected == txtBoxUser.Text)
            {
                txtBoxUser.Clear();
                txtBoxUser.ReadOnly = false;
                lstBoxUsers.ClearSelected();
            }
            else
            {
                txtBoxUser.Text = userSelected;
                txtBoxUser.ReadOnly = true;
                if (lstBoxUsers.SelectedIndex == -1)
                {
                    txtBoxUser.ReadOnly = false;
                }
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxUser.Text;
            string password = txtBoxPassword.Text;
            if (!(nombre.Contains(';')) && !(password.Contains(';')))
            {
                Usuario tempUser = new Usuario();
                tempUser.nombre = nombre;
                tempUser.password = password;
                lstUsuarios.Add(tempUser);
                showUsers();
                writeFile(archivoUsuarios, _archivoUsuarios);
            }
            else
            {
                MessageBox.Show("Caracteres invalidos, no ingreses \";\" ");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string userSelected = txtBoxUser.Text;
            lstUsuarios.Remove(lstUsuarios.Find(user => user.nombre == userSelected));
            writeFile(archivoUsuarios, _archivoUsuarios);
            showUsers();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            string userSelected = txtBoxUser.Text;
            string newPassword = txtBoxPassword.Text;
            if (!(newPassword.Contains(';')))
            {
                if (userSelected != "")
                {
                    lstUsuarios.Find(user => user.nombre == userSelected).password = newPassword;
                    writeFile(archivoUsuarios, _archivoUsuarios);
                    showUsers();
                }
            }
            else
            {
                MessageBox.Show("No ingreses \";\" en tu password, es un caracter invalido");
            }
        }
    }
}
