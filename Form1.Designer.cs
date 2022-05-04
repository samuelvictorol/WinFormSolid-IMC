namespace AulaQuadrado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.lb_res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F);
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite sua Altura:";
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_calc.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F);
            this.btn_calc.Location = new System.Drawing.Point(212, 106);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(109, 59);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(31, 61);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(144, 22);
            this.txt_peso.TabIndex = 3;
            this.txt_peso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(31, 222);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(143, 22);
            this.txt_altura.TabIndex = 4;
            // 
            // lb_res
            // 
            this.lb_res.AutoSize = true;
            this.lb_res.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F);
            this.lb_res.Location = new System.Drawing.Point(399, 123);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(96, 24);
            this.lb_res.TabIndex = 5;
            this.lb_res.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 313);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_calc;
        public System.Windows.Forms.TextBox txt_peso;
        public System.Windows.Forms.TextBox txt_altura;
        public System.Windows.Forms.Label lb_res;
    }
}

