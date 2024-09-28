namespace Max
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
            this.bt_suma = new System.Windows.Forms.Button();
            this.tb_suma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_resta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_multip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_div = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_suma
            // 
            this.bt_suma.Location = new System.Drawing.Point(353, 348);
            this.bt_suma.Name = "bt_suma";
            this.bt_suma.Size = new System.Drawing.Size(132, 41);
            this.bt_suma.TabIndex = 0;
            this.bt_suma.Text = "Calcular";
            this.bt_suma.UseVisualStyleBackColor = true;
            this.bt_suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_suma
            // 
            this.tb_suma.Location = new System.Drawing.Point(94, 31);
            this.tb_suma.Name = "tb_suma";
            this.tb_suma.Size = new System.Drawing.Size(168, 26);
            this.tb_suma.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado de la suma";
            // 
            // tb_resta
            // 
            this.tb_resta.Location = new System.Drawing.Point(94, 80);
            this.tb_resta.Name = "tb_resta";
            this.tb_resta.Size = new System.Drawing.Size(168, 26);
            this.tb_resta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado de la resta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado de la multiplicacion";
            // 
            // tb_multip
            // 
            this.tb_multip.Location = new System.Drawing.Point(94, 129);
            this.tb_multip.Name = "tb_multip";
            this.tb_multip.Size = new System.Drawing.Size(168, 26);
            this.tb_multip.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado de la division";
            // 
            // tb_div
            // 
            this.tb_div.Location = new System.Drawing.Point(94, 184);
            this.tb_div.Name = "tb_div";
            this.tb_div.Size = new System.Drawing.Size(168, 26);
            this.tb_div.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_div);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_multip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_resta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_suma);
            this.Controls.Add(this.bt_suma);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_suma;
        private System.Windows.Forms.TextBox tb_suma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_resta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_multip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_div;
    }
}

