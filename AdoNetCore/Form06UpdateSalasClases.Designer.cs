namespace AdoNetCore
{
    partial class Form06UpdateSalasClases
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
            btnModificarSalas = new Button();
            txtNuevaSala = new TextBox();
            label2 = new Label();
            lstSalas = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.Location = new Point(572, 246);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(263, 85);
            btnModificarSalas.TabIndex = 9;
            btnModificarSalas.Text = "Modificar Salas";
            btnModificarSalas.UseVisualStyleBackColor = true;
            btnModificarSalas.Click += btnModificarSalas_Click;
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(572, 189);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(263, 30);
            txtNuevaSala.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 166);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 7;
            label2.Text = "Nueva Sala";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(83, 106);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(371, 304);
            lstSalas.TabIndex = 6;
            lstSalas.SelectedIndexChanged += lstSalas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 83);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Salas";
            // 
            // Form06UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(918, 492);
            Controls.Add(btnModificarSalas);
            Controls.Add(txtNuevaSala);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form06UpdateSalasClases";
            Text = "Form06UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarSalas;
        private TextBox txtNuevaSala;
        private Label label2;
        private ListBox lstSalas;
        private Label label1;
    }
}