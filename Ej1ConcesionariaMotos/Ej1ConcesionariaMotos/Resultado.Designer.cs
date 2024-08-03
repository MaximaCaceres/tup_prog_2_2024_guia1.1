
namespace Ej1ConcesionariaMotos
{
    partial class Resultado
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
            this.gbxResult = new System.Windows.Forms.GroupBox();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxResult
            // 
            this.gbxResult.Controls.Add(this.lbxResult);
            this.gbxResult.Location = new System.Drawing.Point(12, 12);
            this.gbxResult.Name = "gbxResult";
            this.gbxResult.Size = new System.Drawing.Size(321, 153);
            this.gbxResult.TabIndex = 0;
            this.gbxResult.TabStop = false;
            this.gbxResult.Text = "Resultados";
            // 
            // lbxResult
            // 
            this.lbxResult.BackColor = System.Drawing.SystemColors.Info;
            this.lbxResult.FormattingEnabled = true;
            this.lbxResult.Location = new System.Drawing.Point(12, 19);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.Size = new System.Drawing.Size(303, 121);
            this.lbxResult.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(24, 171);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 219);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxResult);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.gbxResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.ListBox lbxResult;
    }
}