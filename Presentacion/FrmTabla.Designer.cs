namespace School_V_1.Presentacion
{
    partial class FrmTabla
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
            this.label2 = new System.Windows.Forms.Label();
            this.textApellidoNombre = new System.Windows.Forms.TextBox();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido y Nombre";
            // 
            // textApellidoNombre
            // 
            this.textApellidoNombre.Location = new System.Drawing.Point(234, 27);
            this.textApellidoNombre.Name = "textApellidoNombre";
            this.textApellidoNombre.Size = new System.Drawing.Size(297, 31);
            this.textApellidoNombre.TabIndex = 3;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Location = new System.Drawing.Point(234, 80);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(341, 31);
            this.dateNacimiento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.textApellidoNombre);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTabla";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Datos Alumno";
            this.Load += new System.EventHandler(this.FrmTabla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellidoNombre;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}