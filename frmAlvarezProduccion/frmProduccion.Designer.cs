
namespace frmAlvarezProduccion
{
    partial class frmProduccion
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbllocalidad = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblcultivonom = new System.Windows.Forms.Label();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nudTonelada = new System.Windows.Forms.NumericUpDown();
            this.cbLocalidades = new System.Windows.Forms.ComboBox();
            this.cbCultivos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTonelada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(213, 243);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 44);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbllocalidad
            // 
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllocalidad.Location = new System.Drawing.Point(13, 18);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(177, 20);
            this.lbllocalidad.TabIndex = 6;
            this.lbllocalidad.Text = "Nombre de localidad:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(12, 74);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(152, 20);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = "Seleccione fecha:";
            // 
            // lblcultivonom
            // 
            this.lblcultivonom.AutoSize = true;
            this.lblcultivonom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcultivonom.Location = new System.Drawing.Point(12, 128);
            this.lblcultivonom.Name = "lblcultivonom";
            this.lblcultivonom.Size = new System.Drawing.Size(166, 20);
            this.lblcultivonom.TabIndex = 10;
            this.lblcultivonom.Text = "Seleecione Cultivos";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToneladas.Location = new System.Drawing.Point(12, 185);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(181, 20);
            this.lblToneladas.TabIndex = 12;
            this.lblToneladas.Text = "Seleccione Tonelada:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(302, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // nudTonelada
            // 
            this.nudTonelada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTonelada.Location = new System.Drawing.Point(213, 183);
            this.nudTonelada.Name = "nudTonelada";
            this.nudTonelada.Size = new System.Drawing.Size(120, 26);
            this.nudTonelada.TabIndex = 16;
            // 
            // cbLocalidades
            // 
            this.cbLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocalidades.FormattingEnabled = true;
            this.cbLocalidades.Location = new System.Drawing.Point(213, 15);
            this.cbLocalidades.Name = "cbLocalidades";
            this.cbLocalidades.Size = new System.Drawing.Size(302, 28);
            this.cbLocalidades.TabIndex = 17;
            // 
            // cbCultivos
            // 
            this.cbCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCultivos.FormattingEnabled = true;
            this.cbCultivos.Location = new System.Drawing.Point(213, 125);
            this.cbCultivos.Name = "cbCultivos";
            this.cbCultivos.Size = new System.Drawing.Size(302, 28);
            this.cbCultivos.TabIndex = 18;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 309);
            this.Controls.Add(this.cbCultivos);
            this.Controls.Add(this.cbLocalidades);
            this.Controls.Add(this.nudTonelada);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblcultivonom);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbllocalidad);
            this.Controls.Add(this.lblfecha);
            this.Name = "frmProduccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTonelada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbllocalidad;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblcultivonom;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown nudTonelada;
        private System.Windows.Forms.ComboBox cbLocalidades;
        private System.Windows.Forms.ComboBox cbCultivos;
    }
}