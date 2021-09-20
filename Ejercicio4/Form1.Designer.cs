
namespace Ejercicio4
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
            this.label2 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el segundo valor";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(292, 50);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(145, 20);
            this.valor1.TabIndex = 2;
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(292, 138);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(145, 20);
            this.valor2.TabIndex = 3;
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(348, 76);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(37, 23);
            this.sumar.TabIndex = 4;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(292, 76);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(37, 23);
            this.restar.TabIndex = 5;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(400, 76);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(37, 23);
            this.multiplicar.TabIndex = 6;
            this.multiplicar.Text = "x";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(292, 105);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(37, 23);
            this.dividir.TabIndex = 7;
            this.dividir.Text = "%";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // potencia
            // 
            this.potencia.Location = new System.Drawing.Point(348, 105);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(37, 23);
            this.potencia.TabIndex = 8;
            this.potencia.Text = "^";
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // raiz
            // 
            this.raiz.Location = new System.Drawing.Point(400, 105);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(37, 23);
            this.raiz.TabIndex = 9;
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(292, 181);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(145, 20);
            this.Resultado.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

