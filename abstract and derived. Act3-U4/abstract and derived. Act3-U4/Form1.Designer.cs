namespace abstract_and_derived.Act3_U4
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
            this.TxtSide = new System.Windows.Forms.TextBox();
            this.TxtRadius = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSide
            // 
            this.TxtSide.Location = new System.Drawing.Point(196, 92);
            this.TxtSide.Name = "TxtSide";
            this.TxtSide.Size = new System.Drawing.Size(100, 22);
            this.TxtSide.TabIndex = 0;
            this.TxtSide.Text = "side of square";
            // 
            // TxtRadius
            // 
            this.TxtRadius.Location = new System.Drawing.Point(196, 146);
            this.TxtRadius.Name = "TxtRadius";
            this.TxtRadius.Size = new System.Drawing.Size(100, 22);
            this.TxtRadius.TabIndex = 1;
            this.TxtRadius.Text = " radius of the circle";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(207, 208);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "Calculate Area";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(207, 265);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(45, 16);
            this.LblResult.TabIndex = 3;
            this.LblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtRadius);
            this.Controls.Add(this.TxtSide);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSide;
        private System.Windows.Forms.TextBox TxtRadius;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label LblResult;
    }
}

