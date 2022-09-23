
namespace frmAlvarezProduccion
{
    partial class frmLocalidades
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
            this.btnCrearLocalidad = new System.Windows.Forms.Button();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.txtIdentificadorLocal = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearLocalidad
            // 
            this.btnCrearLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearLocalidad.Location = new System.Drawing.Point(124, 203);
            this.btnCrearLocalidad.Name = "btnCrearLocalidad";
            this.btnCrearLocalidad.Size = new System.Drawing.Size(115, 35);
            this.btnCrearLocalidad.TabIndex = 9;
            this.btnCrearLocalidad.Text = "Crear";
            this.btnCrearLocalidad.UseVisualStyleBackColor = true;
            this.btnCrearLocalidad.Click += new System.EventHandler(this.btnCrearLocalidad_Click);
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLocalidad.Location = new System.Drawing.Point(199, 98);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(140, 26);
            this.txtNombreLocalidad.TabIndex = 8;
            // 
            // txtIdentificadorLocal
            // 
            this.txtIdentificadorLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificadorLocal.Location = new System.Drawing.Point(199, 36);
            this.txtIdentificadorLocal.Name = "txtIdentificadorLocal";
            this.txtIdentificadorLocal.Size = new System.Drawing.Size(140, 26);
            this.txtIdentificadorLocal.TabIndex = 7;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificador.Location = new System.Drawing.Point(12, 38);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(124, 24);
            this.lblIdentificador.TabIndex = 6;
            this.lblIdentificador.Text = "Identificador";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(181, 24);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre Localidad";
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 264);
            this.Controls.Add(this.btnCrearLocalidad);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Controls.Add(this.txtIdentificadorLocal);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmLocalidades";
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.frmLocalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearLocalidad;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.TextBox txtIdentificadorLocal;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblNombre;
    }
}