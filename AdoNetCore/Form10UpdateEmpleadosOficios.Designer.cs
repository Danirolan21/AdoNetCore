namespace AdoNetCore
{
    partial class Form10UpdateEmpleadosOficios
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
            label1 = new Label();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            label2 = new Label();
            label3 = new Label();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalarial = new Label();
            txtIncremento = new TextBox();
            btnIncrementarSalarios = new Button();
            txtOficio = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(39, 49);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(257, 224);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(322, 49);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(295, 304);
            lstEmpleados.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 26);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(698, 162);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 4;
            label3.Text = "Incremento";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(39, 334);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(174, 20);
            lblSumaSalarial.TabIndex = 5;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(39, 386);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(185, 20);
            lblMediaSalarial.TabIndex = 6;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lblMaximoSalarial
            // 
            lblMaximoSalarial.AutoSize = true;
            lblMaximoSalarial.Location = new Point(39, 440);
            lblMaximoSalarial.Name = "lblMaximoSalarial";
            lblMaximoSalarial.Size = new Size(196, 20);
            lblMaximoSalarial.TabIndex = 7;
            lblMaximoSalarial.Text = "lblMaximoSalarial";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(698, 190);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(166, 30);
            txtIncremento.TabIndex = 8;
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(698, 263);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(166, 90);
            btnIncrementarSalarios.TabIndex = 9;
            btnIncrementarSalarios.Text = "Incrementar salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(698, 98);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(166, 30);
            txtOficio.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(698, 70);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 10;
            label7.Text = "Oficio";
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 492);
            Controls.Add(txtOficio);
            Controls.Add(label7);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(txtIncremento);
            Controls.Add(lblMaximoSalarial);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private Label label2;
        private Label label3;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalarial;
        private TextBox txtIncremento;
        private Button btnIncrementarSalarios;
        private TextBox txtOficio;
        private Label label7;
    }
}