
namespace repeticao_06_n29
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltx_imprimir = new System.Windows.Forms.ListBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.lbl_n = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltx_imprimir
            // 
            this.ltx_imprimir.FormattingEnabled = true;
            this.ltx_imprimir.ItemHeight = 15;
            this.ltx_imprimir.Location = new System.Drawing.Point(44, 76);
            this.ltx_imprimir.Name = "ltx_imprimir";
            this.ltx_imprimir.Size = new System.Drawing.Size(275, 274);
            this.ltx_imprimir.TabIndex = 0;
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(219, 32);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(100, 23);
            this.txt_n.TabIndex = 1;
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Location = new System.Drawing.Point(99, 39);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(45, 15);
            this.lbl_n.TabIndex = 2;
            this.lbl_n.Text = "Valor N";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(59, 356);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(245, 46);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.ltx_imprimir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sequência de Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltx_imprimir;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.Button btn_calcular;
    }
}

