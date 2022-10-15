namespace Dibujar_cosas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.gpoConfig = new System.Windows.Forms.GroupBox();
            this.radbtnVolumen = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCentro = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.lblDespY = new System.Windows.Forms.Label();
            this.lblDespX = new System.Windows.Forms.Label();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.lblMoverPlano = new System.Windows.Forms.Label();
            this.msktxtVectDMult = new System.Windows.Forms.MaskedTextBox();
            this.msktxtVectCMult = new System.Windows.Forms.MaskedTextBox();
            this.msktxtVectBMult = new System.Windows.Forms.MaskedTextBox();
            this.msktxtVectAMult = new System.Windows.Forms.MaskedTextBox();
            this.lblVectDMult = new System.Windows.Forms.Label();
            this.lblVectCMult = new System.Windows.Forms.Label();
            this.lblVectBMult = new System.Windows.Forms.Label();
            this.lblVectAMult = new System.Windows.Forms.Label();
            this.lblValorVectMult = new System.Windows.Forms.Label();
            this.rdbtnVecOrden2 = new System.Windows.Forms.RadioButton();
            this.rdbtnVecOrden1 = new System.Windows.Forms.RadioButton();
            this.lblConfigVects = new System.Windows.Forms.Label();
            this.tipPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.erroPrincipal = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblResultante = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gpoConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(97, 521);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(85, 32);
            this.btnDibujar.TabIndex = 0;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // gpoConfig
            // 
            this.gpoConfig.Controls.Add(this.radbtnVolumen);
            this.gpoConfig.Controls.Add(this.btnLimpiar);
            this.gpoConfig.Controls.Add(this.btnCentro);
            this.gpoConfig.Controls.Add(this.btnIzquierda);
            this.gpoConfig.Controls.Add(this.btnAbajo);
            this.gpoConfig.Controls.Add(this.btnDerecha);
            this.gpoConfig.Controls.Add(this.btnArriba);
            this.gpoConfig.Controls.Add(this.lblDespY);
            this.gpoConfig.Controls.Add(this.lblDespX);
            this.gpoConfig.Controls.Add(this.numY);
            this.gpoConfig.Controls.Add(this.numX);
            this.gpoConfig.Controls.Add(this.lblMoverPlano);
            this.gpoConfig.Controls.Add(this.msktxtVectDMult);
            this.gpoConfig.Controls.Add(this.msktxtVectCMult);
            this.gpoConfig.Controls.Add(this.msktxtVectBMult);
            this.gpoConfig.Controls.Add(this.msktxtVectAMult);
            this.gpoConfig.Controls.Add(this.lblVectDMult);
            this.gpoConfig.Controls.Add(this.lblVectCMult);
            this.gpoConfig.Controls.Add(this.lblVectBMult);
            this.gpoConfig.Controls.Add(this.lblVectAMult);
            this.gpoConfig.Controls.Add(this.lblValorVectMult);
            this.gpoConfig.Controls.Add(this.rdbtnVecOrden2);
            this.gpoConfig.Controls.Add(this.rdbtnVecOrden1);
            this.gpoConfig.Controls.Add(this.lblConfigVects);
            this.gpoConfig.Controls.Add(this.btnDibujar);
            this.gpoConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpoConfig.Location = new System.Drawing.Point(571, 0);
            this.gpoConfig.Name = "gpoConfig";
            this.gpoConfig.Size = new System.Drawing.Size(191, 565);
            this.gpoConfig.TabIndex = 1;
            this.gpoConfig.TabStop = false;
            this.gpoConfig.Text = "Configuración";
            // 
            // radbtnVolumen
            // 
            this.radbtnVolumen.AutoSize = true;
            this.radbtnVolumen.Location = new System.Drawing.Point(24, 106);
            this.radbtnVolumen.Name = "radbtnVolumen";
            this.radbtnVolumen.Size = new System.Drawing.Size(88, 24);
            this.radbtnVolumen.TabIndex = 24;
            this.radbtnVolumen.TabStop = true;
            this.radbtnVolumen.Text = "Volumen";
            this.tipPrincipal.SetToolTip(this.radbtnVolumen, "Calcula el volumen de un paralelepipedo y al ser volumen se utiliza ℝ³\r\n");
            this.radbtnVolumen.UseVisualStyleBackColor = true;
            this.radbtnVolumen.CheckedChanged += new System.EventHandler(this.radbtnVolumen_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(6, 521);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 32);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCentro
            // 
            this.btnCentro.Location = new System.Drawing.Point(68, 431);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(40, 34);
            this.btnCentro.TabIndex = 22;
            this.btnCentro.Text = "■";
            this.tipPrincipal.SetToolTip(this.btnCentro, "Llevar la vista al origen");
            this.btnCentro.UseVisualStyleBackColor = true;
            this.btnCentro.Click += new System.EventHandler(this.EnbtnMoverPlano);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(24, 431);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(40, 34);
            this.btnIzquierda.TabIndex = 21;
            this.btnIzquierda.Text = "◄";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.EnbtnMoverPlano);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(68, 471);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(40, 34);
            this.btnAbajo.TabIndex = 20;
            this.btnAbajo.Text = "▼";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.EnbtnMoverPlano);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(114, 431);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(40, 34);
            this.btnDerecha.TabIndex = 19;
            this.btnDerecha.Text = "►";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.EnbtnMoverPlano);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(68, 391);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(40, 34);
            this.btnArriba.TabIndex = 18;
            this.btnArriba.Text = "▲";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.EnbtnMoverPlano);
            // 
            // lblDespY
            // 
            this.lblDespY.AutoSize = true;
            this.lblDespY.Location = new System.Drawing.Point(24, 360);
            this.lblDespY.Name = "lblDespY";
            this.lblDespY.Size = new System.Drawing.Size(20, 20);
            this.lblDespY.TabIndex = 17;
            this.lblDespY.Text = "Y:";
            // 
            // lblDespX
            // 
            this.lblDespX.AutoSize = true;
            this.lblDespX.Location = new System.Drawing.Point(24, 327);
            this.lblDespX.Name = "lblDespX";
            this.lblDespX.Size = new System.Drawing.Size(21, 20);
            this.lblDespX.TabIndex = 16;
            this.lblDespX.Text = "X:";
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(52, 358);
            this.numY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(92, 27);
            this.numY.TabIndex = 15;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(51, 325);
            this.numX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(93, 27);
            this.numX.TabIndex = 14;
            // 
            // lblMoverPlano
            // 
            this.lblMoverPlano.AutoSize = true;
            this.lblMoverPlano.Location = new System.Drawing.Point(15, 302);
            this.lblMoverPlano.Name = "lblMoverPlano";
            this.lblMoverPlano.Size = new System.Drawing.Size(93, 20);
            this.lblMoverPlano.TabIndex = 13;
            this.lblMoverPlano.Text = "Mover plano";
            // 
            // msktxtVectDMult
            // 
            this.msktxtVectDMult.Location = new System.Drawing.Point(50, 262);
            this.msktxtVectDMult.Name = "msktxtVectDMult";
            this.msktxtVectDMult.Size = new System.Drawing.Size(94, 27);
            this.msktxtVectDMult.TabIndex = 12;
            this.msktxtVectDMult.Text = "1";
            this.msktxtVectDMult.TextChanged += new System.EventHandler(this.EnTexto3raDim);
            // 
            // msktxtVectCMult
            // 
            this.msktxtVectCMult.Location = new System.Drawing.Point(50, 229);
            this.msktxtVectCMult.Name = "msktxtVectCMult";
            this.msktxtVectCMult.Size = new System.Drawing.Size(94, 27);
            this.msktxtVectCMult.TabIndex = 11;
            this.msktxtVectCMult.Text = "1";
            this.msktxtVectCMult.ValidatingType = typeof(int);
            this.msktxtVectCMult.TextChanged += new System.EventHandler(this.EnTexto3raDim);
            // 
            // msktxtVectBMult
            // 
            this.msktxtVectBMult.Location = new System.Drawing.Point(50, 196);
            this.msktxtVectBMult.Name = "msktxtVectBMult";
            this.msktxtVectBMult.Size = new System.Drawing.Size(94, 27);
            this.msktxtVectBMult.TabIndex = 10;
            this.msktxtVectBMult.Text = "1";
            this.msktxtVectBMult.ValidatingType = typeof(int);
            this.msktxtVectBMult.TextChanged += new System.EventHandler(this.EnTexto3raDim);
            // 
            // msktxtVectAMult
            // 
            this.msktxtVectAMult.Location = new System.Drawing.Point(50, 163);
            this.msktxtVectAMult.Name = "msktxtVectAMult";
            this.msktxtVectAMult.Size = new System.Drawing.Size(94, 27);
            this.msktxtVectAMult.TabIndex = 9;
            this.msktxtVectAMult.Text = "1";
            this.msktxtVectAMult.TextChanged += new System.EventHandler(this.EnTexto3raDim);
            // 
            // lblVectDMult
            // 
            this.lblVectDMult.AutoSize = true;
            this.lblVectDMult.Location = new System.Drawing.Point(23, 265);
            this.lblVectDMult.Name = "lblVectDMult";
            this.lblVectDMult.Size = new System.Drawing.Size(21, 20);
            this.lblVectDMult.TabIndex = 8;
            this.lblVectDMult.Text = "d:";
            // 
            // lblVectCMult
            // 
            this.lblVectCMult.AutoSize = true;
            this.lblVectCMult.Location = new System.Drawing.Point(23, 232);
            this.lblVectCMult.Name = "lblVectCMult";
            this.lblVectCMult.Size = new System.Drawing.Size(19, 20);
            this.lblVectCMult.TabIndex = 7;
            this.lblVectCMult.Text = "c:";
            // 
            // lblVectBMult
            // 
            this.lblVectBMult.AutoSize = true;
            this.lblVectBMult.Location = new System.Drawing.Point(23, 199);
            this.lblVectBMult.Name = "lblVectBMult";
            this.lblVectBMult.Size = new System.Drawing.Size(21, 20);
            this.lblVectBMult.TabIndex = 6;
            this.lblVectBMult.Text = "b:";
            // 
            // lblVectAMult
            // 
            this.lblVectAMult.AutoSize = true;
            this.lblVectAMult.Location = new System.Drawing.Point(24, 166);
            this.lblVectAMult.Name = "lblVectAMult";
            this.lblVectAMult.Size = new System.Drawing.Size(20, 20);
            this.lblVectAMult.TabIndex = 5;
            this.lblVectAMult.Text = "a:";
            // 
            // lblValorVectMult
            // 
            this.lblValorVectMult.AutoSize = true;
            this.lblValorVectMult.Location = new System.Drawing.Point(15, 140);
            this.lblValorVectMult.Name = "lblValorVectMult";
            this.lblValorVectMult.Size = new System.Drawing.Size(57, 20);
            this.lblValorVectMult.TabIndex = 4;
            this.lblValorVectMult.Text = "Valores";
            // 
            // rdbtnVecOrden2
            // 
            this.rdbtnVecOrden2.AutoSize = true;
            this.rdbtnVecOrden2.Location = new System.Drawing.Point(24, 76);
            this.rdbtnVecOrden2.Name = "rdbtnVecOrden2";
            this.rdbtnVecOrden2.Size = new System.Drawing.Size(83, 24);
            this.rdbtnVecOrden2.TabIndex = 3;
            this.rdbtnVecOrden2.Text = "Orden 2";
            this.tipPrincipal.SetToolTip(this.rdbtnVecOrden2, "Calcular la resultante de 4 vectores en ℝ²");
            this.rdbtnVecOrden2.UseVisualStyleBackColor = true;
            this.rdbtnVecOrden2.CheckedChanged += new System.EventHandler(this.rdbtnVecOrden2_CheckedChanged);
            // 
            // rdbtnVecOrden1
            // 
            this.rdbtnVecOrden1.AutoSize = true;
            this.rdbtnVecOrden1.Checked = true;
            this.rdbtnVecOrden1.Location = new System.Drawing.Point(24, 46);
            this.rdbtnVecOrden1.Name = "rdbtnVecOrden1";
            this.rdbtnVecOrden1.Size = new System.Drawing.Size(83, 24);
            this.rdbtnVecOrden1.TabIndex = 2;
            this.rdbtnVecOrden1.TabStop = true;
            this.rdbtnVecOrden1.Text = "Orden 1";
            this.tipPrincipal.SetToolTip(this.rdbtnVecOrden1, "Calcular la resultante de 4 vectores en ℝ²");
            this.rdbtnVecOrden1.UseVisualStyleBackColor = true;
            this.rdbtnVecOrden1.CheckedChanged += new System.EventHandler(this.rdbtnVecOrden1_CheckedChanged);
            // 
            // lblConfigVects
            // 
            this.lblConfigVects.AutoSize = true;
            this.lblConfigVects.Location = new System.Drawing.Point(15, 23);
            this.lblConfigVects.Name = "lblConfigVects";
            this.lblConfigVects.Size = new System.Drawing.Size(166, 20);
            this.lblConfigVects.TabIndex = 1;
            this.lblConfigVects.Text = "Posicion de los vectores";
            // 
            // erroPrincipal
            // 
            this.erroPrincipal.ContainerControl = this;
            // 
            // lblResultante
            // 
            this.lblResultante.AutoSize = true;
            this.lblResultante.Location = new System.Drawing.Point(12, 510);
            this.lblResultante.Name = "lblResultante";
            this.lblResultante.Size = new System.Drawing.Size(35, 20);
            this.lblResultante.TabIndex = 2;
            this.lblResultante.Text = "R=?";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 530);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "R=?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 565);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblResultante);
            this.Controls.Add(this.gpoConfig);
            this.Name = "Form1";
            this.Text = "Trabajar con vectores";
            this.tipPrincipal.SetToolTip(this, "Realiza las operaciones");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.gpoConfig.ResumeLayout(false);
            this.gpoConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDibujar;
        private GroupBox gpoConfig;
        private MaskedTextBox msktxtVectDMult;
        private MaskedTextBox msktxtVectCMult;
        private MaskedTextBox msktxtVectBMult;
        private MaskedTextBox msktxtVectAMult;
        private Label lblVectDMult;
        private Label lblVectCMult;
        private Label lblVectBMult;
        private Label lblVectAMult;
        private Label lblValorVectMult;
        private RadioButton rdbtnVecOrden2;
        private RadioButton rdbtnVecOrden1;
        private Label lblConfigVects;
        private Label lblMoverPlano;
        private NumericUpDown numY;
        private NumericUpDown numX;
        private Label lblDespY;
        private Label lblDespX;
        private Button btnCentro;
        private Button btnLimpiar;
        private Button btnIzquierda;
        private Button btnAbajo;
        private Button btnDerecha;
        private Button btnArriba;
        private RadioButton radbtnVolumen;
        private ToolTip tipPrincipal;
        private ErrorProvider erroPrincipal;
        private Label lblResultante;
        private Label lblResultado;
    }
}