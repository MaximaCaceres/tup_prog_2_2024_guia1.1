
namespace Ej1ConcesionariaMotos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbAñoCalcu = new System.Windows.Forms.Label();
            this.lbValorFbri = new System.Windows.Forms.Label();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.tbxValFabri = new System.Windows.Forms.TextBox();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbTasa = new System.Windows.Forms.Label();
            this.lbVidaU = new System.Windows.Forms.Label();
            this.tbxTasa = new System.Windows.Forms.TextBox();
            this.tbxVida = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dupdModelo = new System.Windows.Forms.NumericUpDown();
            this.dupdAñoCalcu = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dupdModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupdAñoCalcu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(26, 35);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 0;
            this.lbMarca.Text = "Marca";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(26, 75);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(67, 13);
            this.lbModelo.TabIndex = 1;
            this.lbModelo.Text = "Modelo(Año)";
            // 
            // lbAñoCalcu
            // 
            this.lbAñoCalcu.AutoSize = true;
            this.lbAñoCalcu.Location = new System.Drawing.Point(26, 116);
            this.lbAñoCalcu.Name = "lbAñoCalcu";
            this.lbAñoCalcu.Size = new System.Drawing.Size(75, 13);
            this.lbAñoCalcu.TabIndex = 2;
            this.lbAñoCalcu.Text = "Año a calcular";
            // 
            // lbValorFbri
            // 
            this.lbValorFbri.AutoSize = true;
            this.lbValorFbri.Location = new System.Drawing.Point(26, 161);
            this.lbValorFbri.Name = "lbValorFbri";
            this.lbValorFbri.Size = new System.Drawing.Size(110, 13);
            this.lbValorFbri.TabIndex = 3;
            this.lbValorFbri.Text = "Valor de fabricacion $";
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(133, 28);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(100, 20);
            this.tbxMarca.TabIndex = 4;
            // 
            // tbxValFabri
            // 
            this.tbxValFabri.Location = new System.Drawing.Point(133, 154);
            this.tbxValFabri.Name = "tbxValFabri";
            this.tbxValFabri.Size = new System.Drawing.Size(100, 20);
            this.tbxValFabri.TabIndex = 5;
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCalcularCosto.Location = new System.Drawing.Point(29, 195);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(101, 37);
            this.btnCalcularCosto.TabIndex = 8;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(159, 195);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(101, 37);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lbTasa
            // 
            this.lbTasa.AutoSize = true;
            this.lbTasa.Location = new System.Drawing.Point(3, 15);
            this.lbTasa.Name = "lbTasa";
            this.lbTasa.Size = new System.Drawing.Size(113, 13);
            this.lbTasa.TabIndex = 10;
            this.lbTasa.Text = "Tasa de depreciacion:";
            // 
            // lbVidaU
            // 
            this.lbVidaU.AutoSize = true;
            this.lbVidaU.Location = new System.Drawing.Point(37, 63);
            this.lbVidaU.Name = "lbVidaU";
            this.lbVidaU.Size = new System.Drawing.Size(79, 13);
            this.lbVidaU.TabIndex = 11;
            this.lbVidaU.Text = "Vida Util(Años):";
            this.lbVidaU.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbxTasa
            // 
            this.tbxTasa.Location = new System.Drawing.Point(122, 12);
            this.tbxTasa.Name = "tbxTasa";
            this.tbxTasa.Size = new System.Drawing.Size(67, 20);
            this.tbxTasa.TabIndex = 12;
            // 
            // tbxVida
            // 
            this.tbxVida.Location = new System.Drawing.Point(122, 56);
            this.tbxVida.Name = "tbxVida";
            this.tbxVida.Size = new System.Drawing.Size(67, 20);
            this.tbxVida.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxVida);
            this.panel1.Controls.Add(this.tbxTasa);
            this.panel1.Controls.Add(this.lbVidaU);
            this.panel1.Controls.Add(this.lbTasa);
            this.panel1.Location = new System.Drawing.Point(300, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 113);
            this.panel1.TabIndex = 14;
            // 
            // dupdModelo
            // 
            this.dupdModelo.Location = new System.Drawing.Point(133, 77);
            this.dupdModelo.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.dupdModelo.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.dupdModelo.Name = "dupdModelo";
            this.dupdModelo.Size = new System.Drawing.Size(100, 20);
            this.dupdModelo.TabIndex = 15;
            this.dupdModelo.Value = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            // 
            // dupdAñoCalcu
            // 
            this.dupdAñoCalcu.Location = new System.Drawing.Point(133, 109);
            this.dupdAñoCalcu.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.dupdAñoCalcu.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.dupdAñoCalcu.Name = "dupdAñoCalcu";
            this.dupdAñoCalcu.Size = new System.Drawing.Size(100, 20);
            this.dupdAñoCalcu.TabIndex = 16;
            this.dupdAñoCalcu.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 238);
            this.Controls.Add(this.dupdAñoCalcu);
            this.Controls.Add(this.dupdModelo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.tbxValFabri);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.lbValorFbri);
            this.Controls.Add(this.lbAñoCalcu);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.lbMarca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dupdModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupdAñoCalcu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbAñoCalcu;
        private System.Windows.Forms.Label lbValorFbri;
        public System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Label lbTasa;
        private System.Windows.Forms.Label lbVidaU;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbxValFabri;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox tbxTasa;
        public System.Windows.Forms.TextBox tbxVida;
        private System.Windows.Forms.NumericUpDown dupdModelo;
        private System.Windows.Forms.NumericUpDown dupdAñoCalcu;
    }
}

