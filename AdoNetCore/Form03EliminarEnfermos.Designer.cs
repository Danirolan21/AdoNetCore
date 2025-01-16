namespace AdoNetCore
{
    partial class Form03EliminarEnfermos
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
            btnEliminar = new Button();
            txtInscripcion = new TextBox();
            label2 = new Label();
            lstEnfermos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 40);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Inscripción";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(62, 124);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(220, 57);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Enfermo";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(62, 63);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(220, 30);
            txtInscripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 40);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.Location = new Point(398, 81);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(467, 364);
            lstEnfermos.TabIndex = 4;
            // 
            // Form03EliminarEnfermos
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 492);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(txtInscripcion);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form03EliminarEnfermos";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEliminar;
        private TextBox txtInscripcion;
        private Label label2;
        private ListBox lstEnfermos;
    }
}