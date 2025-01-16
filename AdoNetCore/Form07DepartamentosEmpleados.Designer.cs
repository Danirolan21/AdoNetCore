namespace AdoNetCore
{
    partial class Form07DepartamentosEmpleados
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
            lstDepartamentos = new ListBox();
            lstEmpleados = new ListBox();
            label2 = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 40);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(63, 63);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(241, 384);
            lstDepartamentos.TabIndex = 1;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(368, 63);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(241, 384);
            lstEmpleados.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 40);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(687, 136);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(167, 77);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form07DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 492);
            Controls.Add(btnEliminar);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form07DepartamentosEmpleados";
            Text = "Form07DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private ListBox lstEmpleados;
        private Label label2;
        private Button btnEliminar;
    }
}