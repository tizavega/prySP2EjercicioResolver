namespace prySP2EjercicioResolver
{
    partial class frmPrincipal
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
            grpDistancia = new GroupBox();
            rbCorta = new RadioButton();
            rbLarga = new RadioButton();
            btnRegistrar = new Button();
            dtpFecha = new DateTimePicker();
            txtCodigo = new TextBox();
            cboTipoBoleto = new ComboBox();
            lblFecha = new Label();
            lblCodigo = new Label();
            lblTipo = new Label();
            grpDistancia.SuspendLayout();
            SuspendLayout();
            // 
            // grpDistancia
            // 
            grpDistancia.Controls.Add(rbLarga);
            grpDistancia.Controls.Add(rbCorta);
            grpDistancia.Location = new Point(38, 185);
            grpDistancia.Name = "grpDistancia";
            grpDistancia.Size = new Size(200, 100);
            grpDistancia.TabIndex = 0;
            grpDistancia.TabStop = false;
            grpDistancia.Text = "Distancia";
            // 
            // rbCorta
            // 
            rbCorta.AutoSize = true;
            rbCorta.Location = new Point(31, 22);
            rbCorta.Name = "rbCorta";
            rbCorta.Size = new Size(54, 19);
            rbCorta.TabIndex = 0;
            rbCorta.TabStop = true;
            rbCorta.Text = "Corta";
            rbCorta.UseVisualStyleBackColor = true;
            // 
            // rbLarga
            // 
            rbLarga.AutoSize = true;
            rbLarga.Location = new Point(31, 57);
            rbLarga.Name = "rbLarga";
            rbLarga.Size = new Size(54, 19);
            rbLarga.TabIndex = 1;
            rbLarga.TabStop = true;
            rbLarga.Text = "Larga";
            rbLarga.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(202, 314);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(116, 35);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(161, 23);
            dtpFecha.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(116, 81);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(121, 23);
            txtCodigo.TabIndex = 3;
            // 
            // cboTipoBoleto
            // 
            cboTipoBoleto.FormattingEnabled = true;
            cboTipoBoleto.Location = new Point(116, 125);
            cboTipoBoleto.Name = "cboTipoBoleto";
            cboTipoBoleto.Size = new Size(121, 23);
            cboTipoBoleto.TabIndex = 4;
            cboTipoBoleto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(38, 41);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(38, 84);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(38, 125);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 357);
            Controls.Add(lblTipo);
            Controls.Add(lblCodigo);
            Controls.Add(lblFecha);
            Controls.Add(cboTipoBoleto);
            Controls.Add(txtCodigo);
            Controls.Add(dtpFecha);
            Controls.Add(btnRegistrar);
            Controls.Add(grpDistancia);
            Name = "frmPrincipal";
            Text = "Venta Boletería";
            grpDistancia.ResumeLayout(false);
            grpDistancia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDistancia;
        private RadioButton rbLarga;
        private RadioButton rbCorta;
        private Button btnRegistrar;
        private DateTimePicker dtpFecha;
        private TextBox txtCodigo;
        private ComboBox cboTipoBoleto;
        private Label lblFecha;
        private Label lblCodigo;
        private Label lblTipo;
    }
}