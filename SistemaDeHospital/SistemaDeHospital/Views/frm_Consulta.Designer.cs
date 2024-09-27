namespace SistemaDeHospital.Views
{
    partial class frm_Consulta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPacienteID = new System.Windows.Forms.TextBox();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.dateTimePickerConsulta = new System.Windows.Forms.DateTimePicker();
            this.listBoxConsultas = new System.Windows.Forms.ListBox();
            this.btnAgregarConsulta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PACIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA CONSULTA";
            // 
            // txtPacienteID
            // 
            this.txtPacienteID.Location = new System.Drawing.Point(137, 98);
            this.txtPacienteID.Name = "txtPacienteID";
            this.txtPacienteID.Size = new System.Drawing.Size(160, 20);
            this.txtPacienteID.TabIndex = 4;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(137, 68);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(160, 20);
            this.txtDoctorID.TabIndex = 5;
            // 
            // dateTimePickerConsulta
            // 
            this.dateTimePickerConsulta.Location = new System.Drawing.Point(140, 126);
            this.dateTimePickerConsulta.Name = "dateTimePickerConsulta";
            this.dateTimePickerConsulta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerConsulta.TabIndex = 6;
            // 
            // listBoxConsultas
            // 
            this.listBoxConsultas.FormattingEnabled = true;
            this.listBoxConsultas.Location = new System.Drawing.Point(34, 167);
            this.listBoxConsultas.Name = "listBoxConsultas";
            this.listBoxConsultas.Size = new System.Drawing.Size(306, 108);
            this.listBoxConsultas.TabIndex = 7;
            // 
            // btnAgregarConsulta
            // 
            this.btnAgregarConsulta.Location = new System.Drawing.Point(345, 68);
            this.btnAgregarConsulta.Name = "btnAgregarConsulta";
            this.btnAgregarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarConsulta.TabIndex = 8;
            this.btnAgregarConsulta.Text = "AGREGAR CONSULTA";
            this.btnAgregarConsulta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "CONSULTA";
            // 
            // frm_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 323);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarConsulta);
            this.Controls.Add(this.listBoxConsultas);
            this.Controls.Add(this.dateTimePickerConsulta);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.txtPacienteID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Consulta";
            this.Text = "frm_Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPacienteID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.DateTimePicker dateTimePickerConsulta;
        private System.Windows.Forms.ListBox listBoxConsultas;
        private System.Windows.Forms.Button btnAgregarConsulta;
        private System.Windows.Forms.Label label4;
    }
}