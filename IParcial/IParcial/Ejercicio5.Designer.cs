namespace IParcial
{
    partial class Ejercicio5
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
            this.HornearButton = new System.Windows.Forms.Button();
            this.HornearAsincronoButton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.Numero1Label = new System.Windows.Forms.Label();
            this.Numero2Llabel = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HornearButton
            // 
            this.HornearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HornearButton.Location = new System.Drawing.Point(133, 49);
            this.HornearButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HornearButton.Name = "HornearButton";
            this.HornearButton.Size = new System.Drawing.Size(250, 94);
            this.HornearButton.TabIndex = 0;
            this.HornearButton.Text = "Hornear Pizza";
            this.HornearButton.UseVisualStyleBackColor = true;
            this.HornearButton.Click += new System.EventHandler(this.HornearButton_Click);
            // 
            // HornearAsincronoButton
            // 
            this.HornearAsincronoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HornearAsincronoButton.Location = new System.Drawing.Point(433, 49);
            this.HornearAsincronoButton.Margin = new System.Windows.Forms.Padding(5);
            this.HornearAsincronoButton.Name = "HornearAsincronoButton";
            this.HornearAsincronoButton.Size = new System.Drawing.Size(250, 94);
            this.HornearAsincronoButton.TabIndex = 1;
            this.HornearAsincronoButton.Text = "Hornear Pizza Asincrono";
            this.HornearAsincronoButton.UseVisualStyleBackColor = true;
            this.HornearAsincronoButton.Click += new System.EventHandler(this.HornearAsincronoButton_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(281, 203);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(141, 65);
            this.CalcularButton.TabIndex = 2;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Numero1Label
            // 
            this.Numero1Label.AutoSize = true;
            this.Numero1Label.Location = new System.Drawing.Point(44, 203);
            this.Numero1Label.Name = "Numero1Label";
            this.Numero1Label.Size = new System.Drawing.Size(82, 20);
            this.Numero1Label.TabIndex = 3;
            this.Numero1Label.Text = "Número 1:";
            // 
            // Numero2Llabel
            // 
            this.Numero2Llabel.AutoSize = true;
            this.Numero2Llabel.Location = new System.Drawing.Point(44, 258);
            this.Numero2Llabel.Name = "Numero2Llabel";
            this.Numero2Llabel.Size = new System.Drawing.Size(82, 20);
            this.Numero2Llabel.TabIndex = 4;
            this.Numero2Llabel.Text = "Número 2:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(133, 197);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(100, 26);
            this.Numero1TextBox.TabIndex = 5;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(133, 252);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(100, 26);
            this.Numero2TextBox.TabIndex = 6;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 397);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.Numero2Llabel);
            this.Controls.Add(this.Numero1Label);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.HornearAsincronoButton);
            this.Controls.Add(this.HornearButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HornearButton;
        private System.Windows.Forms.Button HornearAsincronoButton;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label Numero1Label;
        private System.Windows.Forms.Label Numero2Llabel;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.TextBox Numero2TextBox;
    }
}