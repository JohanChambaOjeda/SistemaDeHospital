namespace SistemaDeHospital.Views
{
    partial class frm_Doctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnBuscarDoctor = new System.Windows.Forms.Button();
            this.listBoxDoctores = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MES";
            // 
            // txtAno
            // 
            this.txtAno.AutoSize = true;
            this.txtAno.Location = new System.Drawing.Point(35, 94);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(30, 13);
            this.txtAno.TabIndex = 1;
            this.txtAno.Text = "AÑO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOCTORES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(131, 92);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(182, 20);
            this.txtEspecialidad.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(131, 66);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(182, 20);
            this.txtMes.TabIndex = 4;
            // 
            // btnBuscarDoctor
            // 
            this.btnBuscarDoctor.Location = new System.Drawing.Point(335, 64);
            this.btnBuscarDoctor.Name = "btnBuscarDoctor";
            this.btnBuscarDoctor.Size = new System.Drawing.Size(124, 23);
            this.btnBuscarDoctor.TabIndex = 5;
            this.btnBuscarDoctor.Text = "BUSCAR DOCTOR";
            this.btnBuscarDoctor.UseVisualStyleBackColor = true;
            // 
            // listBoxDoctores
            // 
            this.listBoxDoctores.FormattingEnabled = true;
            this.listBoxDoctores.Location = new System.Drawing.Point(38, 185);
            this.listBoxDoctores.Name = "listBoxDoctores";
            this.listBoxDoctores.Size = new System.Drawing.Size(275, 108);
            this.listBoxDoctores.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(35, 144);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(73, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "RESULTADO";
            // 
            // frm_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 389);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.listBoxDoctores);
            this.Controls.Add(this.btnBuscarDoctor);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label1);
            this.Name = "frm_Doctor";
            this.Text = "frm_Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Button btnBuscarDoctor;
        private System.Windows.Forms.ListBox listBoxDoctores;
        private System.Windows.Forms.Label lblResultado;
    }
}