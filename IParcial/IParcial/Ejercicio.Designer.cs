namespace IParcial
{
    partial class Ejercicio
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
            this.Numero1Text = new System.Windows.Forms.Label();
            this.Numero2Text = new System.Windows.Forms.Label();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.SumarButton = new System.Windows.Forms.Button();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero1Text
            // 
            this.Numero1Text.AutoSize = true;
            this.Numero1Text.Location = new System.Drawing.Point(49, 65);
            this.Numero1Text.Name = "Numero1Text";
            this.Numero1Text.Size = new System.Drawing.Size(56, 13);
            this.Numero1Text.TabIndex = 0;
            this.Numero1Text.Text = "Numero 1:";
            // 
            // Numero2Text
            // 
            this.Numero2Text.AutoSize = true;
            this.Numero2Text.Location = new System.Drawing.Point(49, 124);
            this.Numero2Text.Name = "Numero2Text";
            this.Numero2Text.Size = new System.Drawing.Size(56, 13);
            this.Numero2Text.TabIndex = 2;
            this.Numero2Text.Text = "Numero 2:";
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(130, 62);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(136, 20);
            this.Numero1textBox.TabIndex = 3;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(130, 117);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(136, 20);
            this.Numero2textBox.TabIndex = 4;
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(162, 157);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(76, 28);
            this.SumarButton.TabIndex = 5;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Location = new System.Drawing.Point(172, 207);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.ResultadoLabel.TabIndex = 6;
            this.ResultadoLabel.Text = "Resultado";
            // 
            // Ejercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 271);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.Numero2Text);
            this.Controls.Add(this.Numero1Text);
            this.Name = "Ejercicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1Text;
        private System.Windows.Forms.Label Numero2Text;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.Label ResultadoLabel;
    }
}

