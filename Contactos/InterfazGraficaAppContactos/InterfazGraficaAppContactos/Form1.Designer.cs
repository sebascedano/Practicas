namespace InterfazContactos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTelefono;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // listBox1
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(50, 80);
            this.listBox1.Size = new System.Drawing.Size(500, 300);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);

            // label1
            this.label1.Text = "Gestor de Contactos";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(250, 20);
            this.label1.Size = new System.Drawing.Size(300, 40);

            // labelNombre
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Location = new System.Drawing.Point(600, 80);
            this.labelNombre.Size = new System.Drawing.Size(200, 30);

            // labelTelefono
            this.labelTelefono.Text = "Teléfono:";
            this.labelTelefono.Location = new System.Drawing.Point(600, 120);
            this.labelTelefono.Size = new System.Drawing.Size(200, 30);

            // buttonAgregar
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.Location = new System.Drawing.Point(600, 160);
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);

            // buttonActualizar
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.Location = new System.Drawing.Point(600, 200);
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);

            // buttonBuscar
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.Location = new System.Drawing.Point(600, 240);
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);

            // buttonEliminar
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.Location = new System.Drawing.Point(600, 280);
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);

            // buttonSalir
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.Location = new System.Drawing.Point(600, 320);
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);

            // Form1
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonSalir);
            this.Text = "Gestor de Contactos";
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.ResumeLayout(false);
        }
    }
}