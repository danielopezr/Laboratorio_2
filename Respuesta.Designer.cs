namespace Laboratorio_2
{
    partial class Respuesta
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.etiqRespuesta = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkRed;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(615, 313);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 37);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // etiqRespuesta
            // 
            this.etiqRespuesta.AutoSize = true;
            this.etiqRespuesta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqRespuesta.Location = new System.Drawing.Point(109, 118);
            this.etiqRespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiqRespuesta.Name = "etiqRespuesta";
            this.etiqRespuesta.Size = new System.Drawing.Size(482, 27);
            this.etiqRespuesta.TabIndex = 1;
            this.etiqRespuesta.Text = " El punto de cruce entre las dos lineas es: ";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRespuesta.BackColor = System.Drawing.Color.Linen;
            this.txtRespuesta.Enabled = false;
            this.txtRespuesta.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtRespuesta.Location = new System.Drawing.Point(154, 171);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(400, 25);
            this.txtRespuesta.TabIndex = 2;
            this.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Respuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(702, 362);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.etiqRespuesta);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Respuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respuesta";
            this.Load += new System.EventHandler(this.Respuesta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label etiqRespuesta;
        public System.Windows.Forms.TextBox txtRespuesta;
    }
}