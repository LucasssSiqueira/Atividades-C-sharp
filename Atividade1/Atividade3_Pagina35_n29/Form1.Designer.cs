
namespace Atividade3_Pagina35_n29
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
            this.btnn_calcular = new System.Windows.Forms.Button();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.cbx_codigo = new System.Windows.Forms.ComboBox();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnn_calcular
            // 
            this.btnn_calcular.Location = new System.Drawing.Point(148, 228);
            this.btnn_calcular.Name = "btnn_calcular";
            this.btnn_calcular.Size = new System.Drawing.Size(187, 44);
            this.btnn_calcular.TabIndex = 0;
            this.btnn_calcular.Text = "Calcular";
            this.btnn_calcular.UseVisualStyleBackColor = true;
            this.btnn_calcular.Click += new System.EventHandler(this.btnn_calcular_Click);
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(235, 162);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(100, 23);
            this.txt_qtd.TabIndex = 1;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(148, 112);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 2;
            this.lbl_codigo.Text = "Código";
            // 
            // cbx_codigo
            // 
            this.cbx_codigo.FormattingEnabled = true;
            this.cbx_codigo.Items.AddRange(new object[] {
            "AUTO",
            "MOTO",
            "BIKE",
            "KLWE",
            "WPDD"});
            this.cbx_codigo.Location = new System.Drawing.Point(235, 111);
            this.cbx_codigo.Name = "cbx_codigo";
            this.cbx_codigo.Size = new System.Drawing.Size(100, 23);
            this.cbx_codigo.TabIndex = 3;
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Location = new System.Drawing.Point(68, 165);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(126, 15);
            this.lbl_qtd.TabIndex = 4;
            this.lbl_qtd.Text = "Quantidade comprada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.cbx_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.btnn_calcular);
            this.Name = "Form1";
            this.Text = "Cálculo do Preço Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnn_calcular;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.ComboBox cbx_codigo;
        private System.Windows.Forms.Label lbl_qtd;
    }
}

