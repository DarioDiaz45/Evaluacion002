namespace Elipses.Windows
{
    partial class frmElipse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElipse));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbDetalles = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton8 = new ToolStripButton();
            pnlCantidad = new Panel();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            panel1 = new Panel();
            dgvDatos = new DataGridView();
            ColLadoMayor = new DataGridViewTextBoxColumn();
            ColLadoMenor = new DataGridViewTextBoxColumn();
            ColColor = new DataGridViewTextBoxColumn();
            ColBorde = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            pnlCantidad.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbDetalles, tsbFiltrar, tsbActualizar, tsbBuscar, toolStripSeparator2, toolStripButton8 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(647, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(23, 22);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(23, 22);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(23, 22);
            tsbEditar.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbDetalles
            // 
            tsbDetalles.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDetalles.Image = (Image)resources.GetObject("tsbDetalles.Image");
            tsbDetalles.ImageTransparentColor = Color.Magenta;
            tsbDetalles.Name = "tsbDetalles";
            tsbDetalles.Size = new Size(23, 22);
            tsbDetalles.Text = "Detalles";
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(23, 22);
            tsbFiltrar.Text = "Filtrar";
            // 
            // tsbActualizar
            // 
            tsbActualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(23, 22);
            tsbActualizar.Text = "Actualizar";
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(23, 22);
            tsbBuscar.Text = "Buscar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(23, 22);
            toolStripButton8.Text = "toolStripButton8";
            toolStripButton8.Click += toolStripButton8_Click;
            // 
            // pnlCantidad
            // 
            pnlCantidad.Controls.Add(txtCantidad);
            pnlCantidad.Controls.Add(lblCantidad);
            pnlCantidad.Dock = DockStyle.Bottom;
            pnlCantidad.Location = new Point(0, 339);
            pnlCantidad.Name = "pnlCantidad";
            pnlCantidad.Size = new Size(647, 54);
            pnlCantidad.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(84, 19);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(108, 23);
            txtCantidad.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(23, 22);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDatos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 314);
            panel1.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColLadoMayor, ColLadoMenor, ColColor, ColBorde });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(647, 314);
            dgvDatos.TabIndex = 0;
            // 
            // ColLadoMayor
            // 
            ColLadoMayor.HeaderText = "Lado Mayor";
            ColLadoMayor.Name = "ColLadoMayor";
            // 
            // ColLadoMenor
            // 
            ColLadoMenor.HeaderText = "Lado Menor";
            ColLadoMenor.Name = "ColLadoMenor";
            // 
            // ColColor
            // 
            ColColor.HeaderText = "Color";
            ColColor.Name = "ColColor";
            // 
            // ColBorde
            // 
            ColBorde.HeaderText = "Borde";
            ColBorde.Name = "ColBorde";
            // 
            // frmElipse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 393);
            Controls.Add(panel1);
            Controls.Add(pnlCantidad);
            Controls.Add(toolStrip1);
            Name = "frmElipse";
            Text = "frmElipse";
            Load += frmElipse_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlCantidad.ResumeLayout(false);
            pnlCantidad.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbDetalles;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripButton tsbBuscar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton8;
        private Panel pnlCantidad;
        private Panel panel1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColLadoMayor;
        private DataGridViewTextBoxColumn ColLadoMenor;
        private DataGridViewTextBoxColumn ColColor;
        private DataGridViewTextBoxColumn ColBorde;
        private TextBox txtCantidad;
        private Label lblCantidad;
    }
}