namespace Ejercicio_5
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
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilatextBox = new System.Windows.Forms.TextBox();
            this.ColumnatextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejecutarbutton.Location = new System.Drawing.Point(174, 116);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(144, 68);
            this.Ejecutarbutton.TabIndex = 0;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese valor de fila matriz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese valor de columna matriz :";
            // 
            // FilatextBox
            // 
            this.FilatextBox.Location = new System.Drawing.Point(203, 25);
            this.FilatextBox.Name = "FilatextBox";
            this.FilatextBox.Size = new System.Drawing.Size(100, 20);
            this.FilatextBox.TabIndex = 3;
            // 
            // ColumnatextBox
            // 
            this.ColumnatextBox.Location = new System.Drawing.Point(203, 66);
            this.ColumnatextBox.Name = "ColumnatextBox";
            this.ColumnatextBox.Size = new System.Drawing.Size(100, 20);
            this.ColumnatextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 356);
            this.Controls.Add(this.ColumnatextBox);
            this.Controls.Add(this.FilatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ejecutarbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilatextBox;
        private System.Windows.Forms.TextBox ColumnatextBox;
    }
}

