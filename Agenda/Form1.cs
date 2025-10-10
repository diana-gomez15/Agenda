using Agenda.Clases;
using Newtonsoft.Json;

namespace Practica1_Agenda
{
    public partial class Form1 : Form
    {
        private BDJson baseDatos;
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
        }

        private void cargarRegistros(BDJson registros)
        {
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
            registros.TotalRegistros = registros.personas.Count;
            registros.UltimaActualizacion = DateTime.Now;
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
            File.WriteAllText(sfdJason.FileName, json);
        }

        private void dgvDatos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvDatos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
           
        }
        private void colorTSM_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorD.Color;
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
                    string json = File.ReadAllText(ofdJason.FileName);
                    var registros = JsonConvert.DeserializeObject<BDJson>(json);
                    CargarRegistros(registros);
                    ActualizarStatus(registros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
