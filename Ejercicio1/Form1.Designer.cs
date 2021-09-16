
namespace Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_primervalor = new System.Windows.Forms.TextBox();
            this.txt_SegundoValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero";
            // 
            // txt_primervalor
            // 
            this.txt_primervalor.Location = new System.Drawing.Point(290, 116);
            this.txt_primervalor.Name = "txt_primervalor";
            this.txt_primervalor.Size = new System.Drawing.Size(123, 20);
            this.txt_primervalor.TabIndex = 1;
            this.txt_primervalor.TextChanged += new System.EventHandler(this.txt_primervalor_TextChanged);
            // 
            // txt_SegundoValor
            // 
            this.txt_SegundoValor.Location = new System.Drawing.Point(290, 154);
            this.txt_SegundoValor.Name = "txt_SegundoValor";
            this.txt_SegundoValor.Size = new System.Drawing.Size(123, 20);
            this.txt_SegundoValor.TabIndex = 2;
            this.txt_SegundoValor.TextChanged += new System.EventHandler(this.txt_SegundoValor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese un numero";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(290, 193);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(123, 21);
            this.btnSumar.TabIndex = 4;
            this.btnSumar.Text = "Suma";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SegundoValor);
            this.Controls.Add(this.txt_primervalor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_primervalor;
        private System.Windows.Forms.TextBox txt_SegundoValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSumar;
    }
}

