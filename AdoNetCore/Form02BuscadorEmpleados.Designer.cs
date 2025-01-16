namespace AdoNetCore
{
    partial class Form02BuscadorEmpleados
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
            txtSalario = new TextBox();
            btnBuscarEmpleados = new Button();
            label2 = new Label();
            lstEmpleados = new ListBox();
            btnOficio = new Button();
            txtOficio = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 35);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(57, 58);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(206, 30);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.Location = new Point(57, 103);
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.Size = new Size(206, 46);
            btnBuscarEmpleados.TabIndex = 2;
            btnBuscarEmpleados.Text = "Buscar Empleados";
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            btnBuscarEmpleados.Click += btnBuscarEmpleados_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 182);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 3;
            label2.Text = "Lista Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(57, 205);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(540, 264);
            lstEmpleados.TabIndex = 4;
            // 
            // btnOficio
            // 
            btnOficio.Location = new Point(357, 103);
            btnOficio.Name = "btnOficio";
            btnOficio.Size = new Size(206, 46);
            btnOficio.TabIndex = 7;
            btnOficio.Text = "Buscar Empleados";
            btnOficio.UseVisualStyleBackColor = true;
            btnOficio.Click += btnOficio_Click;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(357, 58);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(206, 30);
            txtOficio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 35);
            label3.Name = "label3";
            label3.Size = new Size(207, 20);
            label3.TabIndex = 5;
            label3.Text = "Introduzca Oficio:";
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 501);
            Controls.Add(btnOficio);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnBuscarEmpleados);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscarEmpleados;
        private Label label2;
        private ListBox lstEmpleados;
        private Button btnOficio;
        private TextBox txtOficio;
        private Label label3;
    }
}