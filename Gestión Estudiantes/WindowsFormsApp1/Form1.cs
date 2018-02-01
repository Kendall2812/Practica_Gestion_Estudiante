using System;
using System.Windows.Forms;
using Npgsql;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand comandos;

        public Form1()
        {
            InitializeComponent();
            CargarCombo();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "postgresql";
            string baseDatos = "Gestion_Estudiantes";//nombre de la base en la que voy a trabajar

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }

        public void Registrar()
        {
            try
            {
                int cedula = Convert.ToInt32(txtCedula.Text);
                String nombre = txtNombre.Text;
                DateTime fecha = Convert.ToDateTime(Fecha_Nacer.Value.Date.ToString("dd/MM/yyyy"));
                String lugar = txtResidencia.Text;

                if (nombre.Equals("") || lugar.Equals("") || fecha.Equals(""))
                {
                    MessageBox.Show("No pueden quedar espacios vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Conexion();
                    try
                    {
                        conexion.Open();
                        comandos = new NpgsqlCommand("SELECT cedula FROM tabla_estudiante1 WHERE cedula = '" + cedula + "'", conexion);
                        NpgsqlDataReader dr = comandos.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                MessageBox.Show("Error esta cedula ya se encuentra registrada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            conexion.Close();
                            conexion.Open();
                            comandos = new NpgsqlCommand("INSERT INTO tabla_estudiante1 (cedula,nombre,fecha_nacimiento,residencia) VALUES ('" + cedula + "', '" + nombre + "', '" + fecha + "', '" + lugar + "')", conexion);
                            comandos.ExecuteNonQuery();
                            conexion.Close();
                            MessageBox.Show("La informacion se guardo con exito.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            txtCedula.Text = "";
                            txtNombre.Text = "";
                            Fecha_Nacer.Value = DateTime.Now;
                            txtResidencia.Text = "";

                            Lista_Estudiante.Items.Clear();
                            CargarCombo();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error no se pudo guardar la informacion.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El espacio de la cedula no puede quedar en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void CargarCombo()
        {
            List<object> estudiantes = new List<object>(); 
            Conexion();
            try
            {
                conexion.Open();
                comandos = new NpgsqlCommand("SELECT nombre FROM tabla_estudiante1", conexion);
                NpgsqlDataReader dr= comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        estudiantes.Add(dr.GetString(0));
                    }
                }
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo extraer la informacion.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Lista_Estudiante.Items.Add("Seleccionar");
            Lista_Estudiante.SelectedItem = "Seleccionar";
            for (int x = 0; x < estudiantes.Count; x++)
            {   
                Lista_Estudiante.Items.Add(estudiantes[x]);              
            }

            estudiantes.Clear();
        }

        public List<object> informacion(String nombre)
        {
            List<object> datos = new List<object>();
            Conexion();
            try
            {
                conexion.Open();
                comandos = new NpgsqlCommand("SELECT cedula,nombre,fecha_nacimiento,residencia FROM tabla_estudiante1 WHERE nombre = '" + nombre + "'", conexion);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        datos.Add(dr.GetInt32(0));
                        datos.Add(dr.GetString(1));
                        datos.Add(dr.GetDateTime(2));
                        datos.Add(dr.GetString(3));
                    }
                }
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo extraer la informacion.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }

        public void Cosulta()
        {
            List<object> datos2 = new List<object>();

            String nombre = Lista_Estudiante.SelectedItem.ToString();
            datos2 = informacion(nombre);

            txtCedula2.Text = datos2[0].ToString();
            txtNombre2.Text = datos2[1].ToString();
            Fecha_Nacer2.Value = Convert.ToDateTime(datos2[2].ToString());
            txtResidencia2.Text = datos2[3].ToString();
            datos2.Clear();
        }

        private void Lista_Estudiante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cosulta();
        }
    }
}
