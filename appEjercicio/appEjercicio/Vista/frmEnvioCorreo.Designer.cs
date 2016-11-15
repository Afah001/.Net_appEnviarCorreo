namespace appEjercicio.Vista
{
    partial class frmEnvioCorreo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngreseDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngresarEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // txtIngreseDocumento
            // 
            this.txtIngreseDocumento.Location = new System.Drawing.Point(141, 44);
            this.txtIngreseDocumento.Name = "txtIngreseDocumento";
            this.txtIngreseDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtIngreseDocumento.TabIndex = 2;
            this.txtIngreseDocumento.TextChanged += new System.EventHandler(this.txtIngreseDocumento_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el documento";
            // 
            // txtIngresarEmail
            // 
            this.txtIngresarEmail.Location = new System.Drawing.Point(141, 79);
            this.txtIngresarEmail.Name = "txtIngresarEmail";
            this.txtIngresarEmail.Size = new System.Drawing.Size(100, 20);
            this.txtIngresarEmail.TabIndex = 4;
            // 
            // frmEnvioCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 200);
            this.Controls.Add(this.txtIngresarEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIngreseDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmEnvioCorreo";
            this.Text = "frmEnvioCorreo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngreseDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngresarEmail;
    }
}