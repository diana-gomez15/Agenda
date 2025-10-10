using Agenda.Clases;
using Newtonsoft.Json;

namespace Practica1_Agenda
{
    public partial class Form1 : Form
    {
        private BDJson baseDatos;
        private string rutaArchivoActual = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarAutomaticamente();
            this.Close();
        }       
        private BDJson cargardatos()
        {
            var registros = new BDJson();
            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue;


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
            registros.TotalRegistros = registros.personas.Count;
            registros.UltimaActualizacion = DateTime.Now;
            return registros;
        }

        private void guardarJson(BDJson lista, string ruta)
        {
            var caracteristicas = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore,
            };
            string json = JsonConvert.SerializeObject(lista, caracteristicas);
            File.WriteAllText(ruta, json);
        }
        private void GuardarAutomaticamente()
        {
            if (!string.IsNullOrEmpty(rutaArchivoActual) && dgvDatos.Rows.Count > 0)
            {
                try
                {
                    var datos = cargardatos();
                    guardarJson(datos, rutaArchivoActual);
                    ActualizarStatus(datos);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al autoguardar: {ex.Message}");
                }
            }
        }
        private void dgvDatos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            GuardarAutomaticamente();
        }

        private void dgvDatos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            GuardarAutomaticamente();
        }

        private void colorTSM_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorD.Color;
            }
        }
        private void CargarRegistros(BDJson registros)
        {
            dgvDatos.Rows.Clear();
            foreach (var contacto in registros.personas)
            {
                dgvDatos.Rows.Add(new object[]
                { contacto.nombre, contacto.apPat, contacto.apMat, contacto.direccion, contacto.telefono, contacto.correo });
            }
        }
        private void ActualizarStatus(BDJson registros)
        {
            SLRegistros.Text = $"Registros: {registros.TotalRegistros}";
            SLFecha.Text = $"Última actualización: {registros.UltimaActualizacion:dd/MM/yyyy HH:mm:ss}";
        }

        private void butCargar_Click(object sender, EventArgs e)
        {

            if (ofdJason.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaArchivoActual = ofdJason.FileName;
                    string json = File.ReadAllText(ofdJason.FileName);
                    var registros = JsonConvert.DeserializeObject<BDJson>(json);
                    CargarRegistros(registros);
                    ActualizarStatus(registros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sfdJason.ShowDialog() == DialogResult.OK)
            {             
                    rutaArchivoActual = sfdJason.FileName;
                    var datos = cargardatos();
                    guardarJson(datos, rutaArchivoActual);
                    ActualizarStatus(datos);
  
            }



        }
    }
}
