namespace Ejercicio5
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
            this.TX_1 = new System.Windows.Forms.TextBox();
            this.LT_1 = new System.Windows.Forms.ListBox();
            this.BTN_1 = new System.Windows.Forms.Button();
            this.TX_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TX_1
            // 
            this.TX_1.Location = new System.Drawing.Point(196, 33);
            this.TX_1.Name = "TX_1";
            this.TX_1.Size = new System.Drawing.Size(100, 20);
            this.TX_1.TabIndex = 0;
            // 
            // LT_1
            // 
            this.LT_1.FormattingEnabled = true;
            this.LT_1.Location = new System.Drawing.Point(174, 141);
            this.LT_1.Name = "LT_1";
            this.LT_1.Size = new System.Drawing.Size(133, 173);
            this.LT_1.TabIndex = 1;
            // 
            // BTN_1
            // 
            this.BTN_1.Location = new System.Drawing.Point(207, 97);
            this.BTN_1.Name = "BTN_1";
            this.BTN_1.Size = new System.Drawing.Size(75, 23);
            this.BTN_1.TabIndex = 2;
            this.BTN_1.Text = "button1";
            this.BTN_1.UseVisualStyleBackColor = true;
            this.BTN_1.Click += new System.EventHandler(this.BTN_1_Click);
            // 
            // TX_2
            // 
            this.TX_2.Location = new System.Drawing.Point(196, 59);
            this.TX_2.Name = "TX_2";
            this.TX_2.Size = new System.Drawing.Size(100, 20);
            this.TX_2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TX_2);
            this.Controls.Add(this.BTN_1);
            this.Controls.Add(this.LT_1);
            this.Controls.Add(this.TX_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TX_1;
        private System.Windows.Forms.ListBox LT_1;
        private System.Windows.Forms.Button BTN_1;
        private System.Windows.Forms.TextBox TX_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

