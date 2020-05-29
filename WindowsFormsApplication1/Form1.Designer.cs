namespace WindowsFormsApplication1
{
    partial class FrmSebbysCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSebbysCalculator));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtSinal = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.rdoSoma = new System.Windows.Forms.RadioButton();
            this.rdoSubtracao = new System.Windows.Forms.RadioButton();
            this.rdoMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdoDivisao = new System.Windows.Forms.RadioButton();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSebbysCalculator = new System.Windows.Forms.Label();
            this.chkVisivel = new System.Windows.Forms.CheckBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(12, 267);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 71);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular com Texto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(207, 307);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.BackColor = System.Drawing.Color.Transparent;
            this.lblValor1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(5, 126);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(61, 19);
            this.lblValor1.TabIndex = 2;
            this.lblValor1.Text = "Valor 1";
            this.lblValor1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BackColor = System.Drawing.Color.Transparent;
            this.lblSinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(5, 196);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(47, 19);
            this.lblSinal.TabIndex = 3;
            this.lblSinal.Text = "Sinal";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultado.Location = new System.Drawing.Point(165, 241);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(171, 37);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.BackColor = System.Drawing.Color.Transparent;
            this.lblValor2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.Location = new System.Drawing.Point(336, 126);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(61, 19);
            this.lblValor2.TabIndex = 6;
            this.lblValor2.Text = "Valor 2";
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.Color.White;
            this.txtValor1.Location = new System.Drawing.Point(67, 125);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(84, 20);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // txtSinal
            // 
            this.txtSinal.Location = new System.Drawing.Point(58, 195);
            this.txtSinal.Name = "txtSinal";
            this.txtSinal.Size = new System.Drawing.Size(42, 20);
            this.txtSinal.TabIndex = 1;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(397, 125);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(84, 20);
            this.txtValor2.TabIndex = 1;
            this.txtValor2.TextChanged += new System.EventHandler(this.txtValor2_TextChanged);
            // 
            // rdoSoma
            // 
            this.rdoSoma.AutoSize = true;
            this.rdoSoma.BackColor = System.Drawing.Color.Transparent;
            this.rdoSoma.Checked = true;
            this.rdoSoma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSoma.ForeColor = System.Drawing.Color.White;
            this.rdoSoma.Location = new System.Drawing.Point(375, 171);
            this.rdoSoma.Name = "rdoSoma";
            this.rdoSoma.Size = new System.Drawing.Size(71, 23);
            this.rdoSoma.TabIndex = 11;
            this.rdoSoma.TabStop = true;
            this.rdoSoma.Text = "Soma";
            this.rdoSoma.UseVisualStyleBackColor = false;
            this.rdoSoma.CheckedChanged += new System.EventHandler(this.rdoSoma_CheckedChanged);
            // 
            // rdoSubtracao
            // 
            this.rdoSubtracao.AutoSize = true;
            this.rdoSubtracao.BackColor = System.Drawing.Color.Transparent;
            this.rdoSubtracao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSubtracao.ForeColor = System.Drawing.Color.White;
            this.rdoSubtracao.Location = new System.Drawing.Point(375, 191);
            this.rdoSubtracao.Name = "rdoSubtracao";
            this.rdoSubtracao.Size = new System.Drawing.Size(106, 23);
            this.rdoSubtracao.TabIndex = 12;
            this.rdoSubtracao.Text = "Subtração";
            this.rdoSubtracao.UseVisualStyleBackColor = false;
            // 
            // rdoMultiplicacao
            // 
            this.rdoMultiplicacao.AutoSize = true;
            this.rdoMultiplicacao.BackColor = System.Drawing.Color.Transparent;
            this.rdoMultiplicacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMultiplicacao.ForeColor = System.Drawing.Color.White;
            this.rdoMultiplicacao.Location = new System.Drawing.Point(375, 212);
            this.rdoMultiplicacao.Name = "rdoMultiplicacao";
            this.rdoMultiplicacao.Size = new System.Drawing.Size(127, 23);
            this.rdoMultiplicacao.TabIndex = 13;
            this.rdoMultiplicacao.Text = "Multiplicação";
            this.rdoMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // rdoDivisao
            // 
            this.rdoDivisao.AutoSize = true;
            this.rdoDivisao.BackColor = System.Drawing.Color.Transparent;
            this.rdoDivisao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDivisao.ForeColor = System.Drawing.Color.White;
            this.rdoDivisao.Location = new System.Drawing.Point(375, 232);
            this.rdoDivisao.Name = "rdoDivisao";
            this.rdoDivisao.Size = new System.Drawing.Size(84, 23);
            this.rdoDivisao.TabIndex = 14;
            this.rdoDivisao.Text = "Divisão";
            this.rdoDivisao.UseVisualStyleBackColor = false;
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.BackColor = System.Drawing.Color.Black;
            this.btnCalcular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular2.ForeColor = System.Drawing.Color.White;
            this.btnCalcular2.Location = new System.Drawing.Point(371, 267);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(116, 71);
            this.btnCalcular2.TabIndex = 5;
            this.btnCalcular2.Text = "Calcular com alternativas";
            this.btnCalcular2.UseVisualStyleBackColor = false;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(198, 281);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 16;
            this.txtResultado.TabStop = false;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // lblSebbysCalculator
            // 
            this.lblSebbysCalculator.AutoSize = true;
            this.lblSebbysCalculator.BackColor = System.Drawing.Color.Transparent;
            this.lblSebbysCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSebbysCalculator.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSebbysCalculator.Location = new System.Drawing.Point(45, -1);
            this.lblSebbysCalculator.Name = "lblSebbysCalculator";
            this.lblSebbysCalculator.Size = new System.Drawing.Size(375, 73);
            this.lblSebbysCalculator.TabIndex = 17;
            this.lblSebbysCalculator.Text = "Calculadora";
            // 
            // chkVisivel
            // 
            this.chkVisivel.AutoSize = true;
            this.chkVisivel.BackColor = System.Drawing.Color.Transparent;
            this.chkVisivel.Checked = true;
            this.chkVisivel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisivel.Location = new System.Drawing.Point(409, 30);
            this.chkVisivel.Name = "chkVisivel";
            this.chkVisivel.Size = new System.Drawing.Size(78, 23);
            this.chkVisivel.TabIndex = 18;
            this.chkVisivel.Text = "Visivel";
            this.chkVisivel.UseVisualStyleBackColor = false;
            this.chkVisivel.CheckedChanged += new System.EventHandler(this.chkVisivel_CheckedChanged);
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitado.Checked = true;
            this.chkHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.Location = new System.Drawing.Point(397, 59);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(105, 23);
            this.chkHabilitado.TabIndex = 19;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = false;
            this.chkHabilitado.CheckedChanged += new System.EventHandler(this.chkHabilitado_CheckedChanged);
            // 
            // FrmSebbysCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(499, 377);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.chkVisivel);
            this.Controls.Add(this.lblSebbysCalculator);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular2);
            this.Controls.Add(this.rdoDivisao);
            this.Controls.Add(this.rdoMultiplicacao);
            this.Controls.Add(this.rdoSubtracao);
            this.Controls.Add(this.rdoSoma);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtSinal);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSebbysCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sebby\'s Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtSinal;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.RadioButton rdoSubtracao;
        private System.Windows.Forms.RadioButton rdoMultiplicacao;
        private System.Windows.Forms.RadioButton rdoDivisao;
        private System.Windows.Forms.Button btnCalcular2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSebbysCalculator;
        private System.Windows.Forms.RadioButton rdoSoma;
        private System.Windows.Forms.CheckBox chkVisivel;
        private System.Windows.Forms.CheckBox chkHabilitado;
    }
}

