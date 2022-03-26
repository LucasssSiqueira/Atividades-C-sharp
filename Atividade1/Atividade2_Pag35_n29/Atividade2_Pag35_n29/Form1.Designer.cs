
namespace Atividade2_Pag35_n29
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_classe = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cbx__classe = new System.Windows.Forms.ComboBox();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(145, 37);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            // 
            // lbl_classe
            // 
            this.lbl_classe.AutoSize = true;
            this.lbl_classe.Location = new System.Drawing.Point(145, 149);
            this.lbl_classe.Name = "lbl_classe";
            this.lbl_classe.Size = new System.Drawing.Size(40, 15);
            this.lbl_classe.TabIndex = 1;
            this.lbl_classe.Text = "Classe";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(145, 93);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Location = new System.Drawing.Point(145, 205);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(102, 15);
            this.lbl_horas.TabIndex = 3;
            this.lbl_horas.Text = "Horas de Trabalho";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(145, 253);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(253, 48);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(258, 29);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 23);
            this.txt_codigo.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(258, 85);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 23);
            this.txt_nome.TabIndex = 6;
            // 
            // cbx__classe
            // 
            this.cbx__classe.FormattingEnabled = true;
            this.cbx__classe.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbx__classe.Location = new System.Drawing.Point(258, 141);
            this.cbx__classe.Name = "cbx__classe";
            this.cbx__classe.Size = new System.Drawing.Size(100, 23);
            this.cbx__classe.TabIndex = 7;
            // 
            // txt_horas
            // 
            this.txt_horas.Location = new System.Drawing.Point(258, 197);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(100, 23);
            this.txt_horas.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_horas);
            this.Controls.Add(this.cbx__classe);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_classe);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "Form1";
            this.Text = "Empresa Brightly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_classe;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cbx__classe;
        private System.Windows.Forms.TextBox txt_horas;
    }
}

