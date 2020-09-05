namespace ExpressaoLambda
{
    partial class FrmLambda
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
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.txbTexto1 = new System.Windows.Forms.TextBox();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.txbTexto2 = new System.Windows.Forms.TextBox();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(27, 30);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(43, 13);
            this.lblTexto1.TabIndex = 0;
            this.lblTexto1.Text = "Texto1:";
            // 
            // txbTexto1
            // 
            this.txbTexto1.Location = new System.Drawing.Point(77, 30);
            this.txbTexto1.Name = "txbTexto1";
            this.txbTexto1.Size = new System.Drawing.Size(244, 20);
            this.txbTexto1.TabIndex = 1;
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Location = new System.Drawing.Point(27, 76);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(43, 13);
            this.lblTexto2.TabIndex = 2;
            this.lblTexto2.Text = "Texto2:";
            // 
            // txbTexto2
            // 
            this.txbTexto2.Location = new System.Drawing.Point(77, 73);
            this.txbTexto2.Name = "txbTexto2";
            this.txbTexto2.Size = new System.Drawing.Size(244, 20);
            this.txbTexto2.TabIndex = 3;
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(77, 110);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(75, 23);
            this.btnConcatenar.TabIndex = 4;
            this.btnConcatenar.Text = "Concatenar!";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(76, 150);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(244, 20);
            this.txbResultado.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(15, 153);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmLambda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 190);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.txbTexto2);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.txbTexto1);
            this.Controls.Add(this.lblTexto1);
            this.Name = "FrmLambda";
            this.Text = "Lambda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.TextBox txbTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.TextBox txbTexto2;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}

