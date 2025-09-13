using Newtonsoft.Json;
using Practica1_Agenda.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_Agenda
{
    public partial class Form1 : Form
    {
        string direccion = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "agenda.json");
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(direccion))
            {
                try
                {
                    string json = File.ReadAllText(direccion);
                    var registros = JsonConvert.DeserializeObject<BDJson>(json);
                    cargarRegistros(registros);
                    SLRegistros.Text = "Num Registros: " + (dgvDatos.RowCount - 1);
                    SLFecha.Text = registros.UltimaActualizacion.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR "+ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cargarRegistros(BDJson registros)
        {
            foreach (var perona in registros.personas)
            {
                dgvDatos.Rows.Add(new object[] { perona.nombre, perona.apPat, perona.apMat, perona.direccion, perona.telefono, perona.correo});
            }

        }

        private BDJson cargardatos()
        {
            var registros = new BDJson();
            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells[0].Value == null) continue;
                var personas = new persona();
                {
                    personas.nombre = (fila.Cells[0].Value ?? "").ToString();
                    personas.apPat = (fila.Cells[1].Value ?? "").ToString();
                    personas.apMat = (fila.Cells[2].Value ?? "").ToString();
                    personas.direccion = (fila.Cells[3].Value ?? "").ToString();
                    personas.telefono = (fila.Cells[4].Value ?? "").ToString();
                    personas.correo = (fila.Cells[5].Value ?? "").ToString();
                }
                registros.personas.Add(personas);   
            }
            return registros;
        }

        private void guardarJson(BDJson lista)
        {
            var caracteristicas = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore,
            };
            string json = JsonConvert.SerializeObject(lista, caracteristicas);
            File.WriteAllText(direccion, json);
        }

        private void dgvDatos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDatos.EndEdit();
                var baseDatos = cargardatos();
                guardarJson(baseDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                dgvDatos.EndEdit();
                var baseDatos = cargardatos();
                guardarJson(baseDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrarTSM_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
            var baseDatos = cargardatos();
            guardarJson(baseDatos);
        }

        private void colorTSM_Click(object sender, EventArgs e)
        {
            if(colorD.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorD.Color;
            }
        }

        private void infoTSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por Bryam Joseph Jaramillo Sandoval","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
