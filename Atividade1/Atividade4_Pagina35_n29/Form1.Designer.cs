
namespace Atividade4_Pagina35_n29
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
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_horasTrabalhadas = new System.Windows.Forms.Label();
            this.lbl_horaExtra = new System.Windows.Forms.Label();
            this.lbl_salBruto = new System.Windows.Forms.Label();
            this.lbl_hExtra = new System.Windows.Forms.Label();
            this.lbl_inss = new System.Windows.Forms.Label();
            this.lbl_salLiq = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_hExtra = new System.Windows.Forms.TextBox();
            this.txt_hTrab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(119, 199);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(249, 45);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(24, 33);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(57, 15);
            this.lbl_matricula.TabIndex = 1;
            this.lbl_matricula.Text = "Matrícula";
            // 
            // lbl_horasTrabalhadas
            // 
            this.lbl_horasTrabalhadas.AutoSize = true;
            this.lbl_horasTrabalhadas.Location = new System.Drawing.Point(24, 88);
            this.lbl_horasTrabalhadas.Name = "lbl_horasTrabalhadas";
            this.lbl_horasTrabalhadas.Size = new System.Drawing.Size(102, 15);
            this.lbl_horasTrabalhadas.TabIndex = 2;
            this.lbl_horasTrabalhadas.Text = "Horas trabalhadas";
            // 
            // lbl_horaExtra
            // 
            this.lbl_horaExtra.AutoSize = true;
            this.lbl_horaExtra.Location = new System.Drawing.Point(24, 143);
            this.lbl_horaExtra.Name = "lbl_horaExtra";
            this.lbl_horaExtra.Size = new System.Drawing.Size(72, 15);
            this.lbl_horaExtra.TabIndex = 3;
            this.lbl_horaExtra.Text = "Horas Extras";
            // 
            // lbl_salBruto
            // 
            this.lbl_salBruto.AutoSize = true;
            this.lbl_salBruto.Location = new System.Drawing.Point(24, 253);
            this.lbl_salBruto.Name = "lbl_salBruto";
            this.lbl_salBruto.Size = new System.Drawing.Size(74, 15);
            this.lbl_salBruto.TabIndex = 4;
            this.lbl_salBruto.Text = "Sálario Bruto";
            // 
            // lbl_hExtra
            // 
            this.lbl_hExtra.AutoSize = true;
            this.lbl_hExtra.Location = new System.Drawing.Point(24, 308);
            this.lbl_hExtra.Name = "lbl_hExtra";
            this.lbl_hExtra.Size = new System.Drawing.Size(139, 15);
            this.lbl_hExtra.TabIndex = 5;
            this.lbl_hExtra.Text = "Adicional de horas extras";
            // 
            // lbl_inss
            // 
            this.lbl_inss.AutoSize = true;
            this.lbl_inss.Location = new System.Drawing.Point(24, 363);
            this.lbl_inss.Name = "lbl_inss";
            this.lbl_inss.Size = new System.Drawing.Size(84, 15);
            this.lbl_inss.TabIndex = 6;
            this.lbl_inss.Text = "Desconto INSS";
            // 
            // lbl_salLiq
            // 
            this.lbl_salLiq.AutoSize = true;
            this.lbl_salLiq.Location = new System.Drawing.Point(24, 419);
            this.lbl_salLiq.Name = "lbl_salLiq";
            this.lbl_salLiq.Size = new System.Drawing.Size(42, 15);
            this.lbl_salLiq.TabIndex = 7;
            this.lbl_salLiq.Text = "Sálario";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(331, 33);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 23);
            this.txt_matricula.TabIndex = 8;
            // 
            // txt_hExtra
            // 
            this.txt_hExtra.Location = new System.Drawing.Point(331, 143);
            this.txt_hExtra.Name = "txt_hExtra";
            this.txt_hExtra.Size = new System.Drawing.Size(100, 23);
            this.txt_hExtra.TabIndex = 9;
            // 
            // txt_hTrab
            // 
            this.txt_hTrab.Location = new System.Drawing.Point(331, 88);
            this.txt_hTrab.Name = "txt_hTrab";
            this.txt_hTrab.Size = new System.Drawing.Size(100, 23);
            this.txt_hTrab.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_hTrab);
            this.Controls.Add(this.txt_hExtra);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.lbl_salLiq);
            this.Controls.Add(this.lbl_inss);
            this.Controls.Add(this.lbl_hExtra);
            this.Controls.Add(this.lbl_salBruto);
            this.Controls.Add(this.lbl_horaExtra);
            this.Controls.Add(this.lbl_horasTrabalhadas);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_horasTrabalhadas;
        private System.Windows.Forms.Label lbl_horaExtra;
        private System.Windows.Forms.Label lbl_salBruto;
        private System.Windows.Forms.Label lbl_hExtra;
        private System.Windows.Forms.Label lbl_inss;
        private System.Windows.Forms.Label lbl_salLiq;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_hExtra;
        private System.Windows.Forms.TextBox txt_hTrab;
    }
}

