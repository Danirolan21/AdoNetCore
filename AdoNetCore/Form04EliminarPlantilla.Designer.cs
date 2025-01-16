namespace AdoNetCore
{
    partial class Form04EliminarPlantilla
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
            lstPlantilla = new ListBox();
            label2 = new Label();
            txtIdEmpleado = new TextBox();
            btnEliminar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(394, 85);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(467, 364);
            lstPlantilla.TabIndex = 9;
            lstPlantilla.SelectedIndexChanged += lstEnfermos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 44);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 8;
            label2.Text = "Enfermos";
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(58, 67);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(220, 30);
            txtIdEmpleado.TabIndex = 7;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(58, 128);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(220, 57);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Enfermo";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 44);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 5;
            label1.Text = "ID Empleado";
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 492);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(txtIdEmpleado);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPlantilla;
        private Label label2;
        private TextBox txtIdEmpleado;
        private Button btnEliminar;
        private Label label1;
    }
}