namespace AdoNetCore
{
    partial class Form05UpdateSalas
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
            lstSalas = new ListBox();
            label2 = new Label();
            txtNuevaSala = new TextBox();
            btnModificarSalas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(66, 73);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(371, 304);
            lstSalas.TabIndex = 1;
            lstSalas.SelectedIndexChanged += lstSalas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 133);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 2;
            label2.Text = "Nueva Sala";
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(555, 156);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(263, 30);
            txtNuevaSala.TabIndex = 3;
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.Location = new Point(555, 213);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(263, 85);
            btnModificarSalas.TabIndex = 4;
            btnModificarSalas.Text = "Modificar Salas";
            btnModificarSalas.UseVisualStyleBackColor = true;
            btnModificarSalas.Click += btnModificarSalas_Click;
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 492);
            Controls.Add(btnModificarSalas);
            Controls.Add(txtNuevaSala);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstSalas;
        private Label label2;
        private TextBox txtNuevaSala;
        private Button btnModificarSalas;
    }
}