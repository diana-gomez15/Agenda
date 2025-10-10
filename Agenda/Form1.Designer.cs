namespace Practica1_Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            salirTSM = new ToolStripMenuItem();
            variosToolStripMenuItem = new ToolStripMenuItem();
            colorTSM = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            SLRegistros = new ToolStripStatusLabel();
            SLFecha = new ToolStripStatusLabel();
            colorD = new ColorDialog();
            dgvDatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            ApellidoP = new DataGridViewTextBoxColumn();
            ApellidoM = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            butCargar = new Button();
            sfdJason = new SaveFileDialog();
            ofdJason = new OpenFileDialog();
            butNombrar = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, variosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(862, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirTSM });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // salirTSM
            // 
            salirTSM.Name = "salirTSM";
            salirTSM.Size = new Size(121, 26);
            salirTSM.Text = "Salir";
            salirTSM.Click += salirToolStripMenuItem_Click;
            // 
            // variosToolStripMenuItem
            // 
            variosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorTSM });
            variosToolStripMenuItem.Name = "variosToolStripMenuItem";
            variosToolStripMenuItem.Size = new Size(106, 24);
            variosToolStripMenuItem.Text = "Propiedades";
            // 
            // colorTSM
            // 
            colorTSM.Name = "colorTSM";
            colorTSM.Size = new Size(195, 26);
            colorTSM.Text = "Color de Fondo";
            colorTSM.Click += colorTSM_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ActiveCaption;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { SLRegistros, SLFecha });
            statusStrip1.Location = new Point(0, 545);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(862, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // SLRegistros
            // 
            SLRegistros.Name = "SLRegistros";
            SLRegistros.Size = new Size(149, 20);
            SLRegistros.Text = "Numero de Registros";
            // 
            // SLFecha
            // 
            SLFecha.Name = "SLFecha";
            SLFecha.Size = new Size(146, 20);
            SLFecha.Text = "Ultima Actualizacion";
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, ApellidoP, ApellidoM, Direccion, Tel, Correo });
            dgvDatos.Location = new Point(3, 73);
            dgvDatos.Margin = new Padding(4, 5, 4, 5);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(811, 360);
            dgvDatos.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 130;
            // 
            // ApellidoP
            // 
            ApellidoP.HeaderText = "Apellido Paternio";
            ApellidoP.MinimumWidth = 6;
            ApellidoP.Name = "ApellidoP";
            ApellidoP.Width = 125;
            // 
            // ApellidoM
            // 
            ApellidoM.HeaderText = "Apellido Materno";
            ApellidoM.MinimumWidth = 6;
            ApellidoM.Name = "ApellidoM";
            ApellidoM.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 125;
            // 
            // Tel
            // 
            Tel.HeaderText = "Telefono";
            Tel.MinimumWidth = 6;
            Tel.Name = "Tel";
            Tel.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo Electronico";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // butCargar
            // 
            butCargar.Location = new Point(426, 455);
            butCargar.Name = "butCargar";
            butCargar.Size = new Size(147, 60);
            butCargar.TabIndex = 4;
            butCargar.Text = "Cargar";
            butCargar.UseVisualStyleBackColor = true;
            butCargar.Click += butCargar_Click;
            // 
            // ofdJason
            // 
            ofdJason.FileName = "openFileDialog1";
            // 
            // butNombrar
            // 
            butNombrar.Location = new Point(251, 455);
            butNombrar.Name = "butNombrar";
            butNombrar.Size = new Size(147, 60);
            butNombrar.TabIndex = 5;
            butNombrar.Text = "Nombrar Archivo";
            butNombrar.UseVisualStyleBackColor = true;
            butNombrar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(862, 571);
            Controls.Add(butNombrar);
            Controls.Add(butCargar);
            Controls.Add(statusStrip1);
            Controls.Add(dgvDatos);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Agenda";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirTSM;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SLRegistros;
        private System.Windows.Forms.ToolStripStatusLabel SLFecha;
        private System.Windows.Forms.ToolStripMenuItem variosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorTSM;
        private System.Windows.Forms.ColorDialog colorD;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ApellidoP;
        private DataGridViewTextBoxColumn ApellidoM;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Tel;
        private DataGridViewTextBoxColumn Correo;
        private Button butCargar;
        private SaveFileDialog sfdJason;
        private OpenFileDialog ofdJason;
        private Button butNombrar;
    }
}

