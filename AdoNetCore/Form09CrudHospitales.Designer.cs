namespace AdoNetCore
{
    partial class Form09CrudHospitales
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtHospitalCod = new TextBox();
            label2 = new Label();
            lstHospitales = new ListBox();
            label1 = new Label();
            txtNumCamas = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(662, 410);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 46);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.ForeColor = SystemColors.Highlight;
            btnModificar.Location = new Point(662, 358);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(169, 46);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.ForeColor = Color.LimeGreen;
            btnInsertar.Location = new Point(662, 306);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(169, 46);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(639, 203);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(192, 30);
            txtDireccion.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(639, 172);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 17;
            label4.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(639, 270);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 30);
            txtTelefono.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(639, 239);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 15;
            label3.Text = "Telefono";
            // 
            // txtHospitalCod
            // 
            txtHospitalCod.Location = new Point(639, 68);
            txtHospitalCod.Name = "txtHospitalCod";
            txtHospitalCod.Size = new Size(125, 30);
            txtHospitalCod.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(639, 39);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 13;
            label2.Text = "Codigo Hospital";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(58, 76);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(450, 324);
            lstHospitales.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 53);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // txtNumCamas
            // 
            txtNumCamas.Location = new Point(772, 270);
            txtNumCamas.Name = "txtNumCamas";
            txtNumCamas.Size = new Size(89, 30);
            txtNumCamas.TabIndex = 23;
            txtNumCamas.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(772, 239);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 22;
            label5.Text = "NºCamas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(639, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 30);
            txtNombre.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(640, 104);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 24;
            label6.Text = "Nombre";
            // 
            // Form09CrudHospitales
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 492);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(txtNumCamas);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtHospitalCod);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form09CrudHospitales";
            Text = "Form09CrudHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnInsertar;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtHospitalCod;
        private Label label2;
        private ListBox lstHospitales;
        private Label label1;
        private TextBox txtNumCamas;
        private Label label5;
        private TextBox txtNombre;
        private Label label6;
    }
}