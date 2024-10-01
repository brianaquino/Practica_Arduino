
namespace Practica_Arduino
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
            this.btnencender = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnencender
            // 
            this.btnencender.Location = new System.Drawing.Point(280, 62);
            this.btnencender.Name = "btnencender";
            this.btnencender.Size = new System.Drawing.Size(174, 105);
            this.btnencender.TabIndex = 0;
            this.btnencender.Text = "Encender";
            this.btnencender.UseVisualStyleBackColor = true;
            this.btnencender.Click += new System.EventHandler(this.btnencender_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(280, 185);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(174, 105);
            this.btnapagar.TabIndex = 1;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.btnencender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CerrandoForm1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnencender;
        private System.Windows.Forms.Button btnapagar;
    }
}

