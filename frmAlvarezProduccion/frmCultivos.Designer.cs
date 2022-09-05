
namespace frmAlvarezProduccion
{
    partial class frmCultivos
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
            this.btnCrearCultivos = new System.Windows.Forms.Button();
            this.txtNombrecultivos = new System.Windows.Forms.TextBox();
            this.txtIdentificadorCultivos = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearCultivos
            // 
            this.btnCrearCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCultivos.Location = new System.Drawing.Point(153, 164);
            this.btnCrearCultivos.Name = "btnCrearCultivos";
            this.btnCrearCultivos.Size = new System.Drawing.Size(115, 35);
            this.btnCrearCultivos.TabIndex = 4;
            this.btnCrearCultivos.Text = "Crear";
            this.btnCrearCultivos.UseVisualStyleBackColor = true;
            this.btnCrearCultivos.Click += new System.EventHandler(this.btnCrearCultivos_Click);
            // 
            // txtNombrecultivos
            // 
            this.txtNombrecultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrecultivos.Location = new System.Drawing.Point(103, 101);
            this.txtNombrecultivos.Name = "txtNombrecultivos";
            this.txtNombrecultivos.Size = new System.Drawing.Size(261, 26);
            this.txtNombrecultivos.TabIndex = 12;
            // 
            // txtIdentificadorCultivos
            // 
            this.txtIdentificadorCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificadorCultivos.Location = new System.Drawing.Point(224, 28);
            this.txtIdentificadorCultivos.Name = "txtIdentificadorCultivos";
            this.txtIdentificadorCultivos.Size = new System.Drawing.Size(140, 26);
            this.txtIdentificadorCultivos.TabIndex = 11;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificador.Location = new System.Drawing.Point(12, 31);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(197, 24);
            this.lblIdentificador.TabIndex = 10;
            this.lblIdentificador.Text = "Codigo Identificador";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 24);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 217);
            this.Controls.Add(this.txtNombrecultivos);
            this.Controls.Add(this.txtIdentificadorCultivos);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCrearCultivos);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.Load += new System.EventHandler(this.frmCultivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrearCultivos;
        private System.Windows.Forms.TextBox txtNombrecultivos;
        private System.Windows.Forms.TextBox txtIdentificadorCultivos;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblNombre;
    }
}