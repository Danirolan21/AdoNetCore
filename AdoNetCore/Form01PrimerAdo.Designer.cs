namespace AdoNetCore
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            label1 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            label2 = new Label();
            lstTiposDato = new ListBox();
            label3 = new Label();
            btnDesconectar = new Button();
            btnLeerDatos = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(34, 92);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(144, 70);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 72);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(215, 104);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(182, 244);
            lstApellidos.TabIndex = 4;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(425, 104);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(182, 244);
            lstColumnas.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 72);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Columnas";
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.Location = new Point(642, 104);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(182, 244);
            lstTiposDato.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 72);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 7;
            label3.Text = "Tipos Dato";
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(34, 168);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(144, 70);
            btnDesconectar.TabIndex = 9;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(34, 244);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(144, 70);
            btnLeerDatos.TabIndex = 10;
            btnLeerDatos.Text = "Leer datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(43, 390);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(119, 20);
            lblMensaje.TabIndex = 11;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 447);
            Controls.Add(lblMensaje);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnDesconectar);
            Controls.Add(lstTiposDato);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(label2);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Controls.Add(btnConectar);
            Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Label label1;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private Label label2;
        private ListBox lstTiposDato;
        private Label label3;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label lblMensaje;
    }
}