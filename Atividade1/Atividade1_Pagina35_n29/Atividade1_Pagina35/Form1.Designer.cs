
namespace Atividade1_Pagina35
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_veiculo = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cbx_codigo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(126, 205);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(234, 58);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_veiculo
            // 
            this.lbl_veiculo.AutoSize = true;
            this.lbl_veiculo.Location = new System.Drawing.Point(131, 118);
            this.lbl_veiculo.Name = "lbl_veiculo";
            this.lbl_veiculo.Size = new System.Drawing.Size(91, 15);
            this.lbl_veiculo.TabIndex = 1;
            this.lbl_veiculo.Text = "Valor do Veículo";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(126, 151);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(96, 15);
            this.lbl_codigo.TabIndex = 2;
            this.lbl_codigo.Text = "Código do Plano";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(260, 110);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 23);
            this.txt_valor.TabIndex = 3;
            // 
            // cbx_codigo
            // 
            this.cbx_codigo.FormattingEnabled = true;
            this.cbx_codigo.Items.AddRange(new object[] {
            "Plano A",
            "Plano B",
            "Plano C",
            "Plano D"});
            this.cbx_codigo.Location = new System.Drawing.Point(260, 143);
            this.cbx_codigo.Name = "cbx_codigo";
            this.cbx_codigo.Size = new System.Drawing.Size(100, 23);
            this.cbx_codigo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.cbx_codigo);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_veiculo);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_veiculo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cbx_codigo;
    }
}

