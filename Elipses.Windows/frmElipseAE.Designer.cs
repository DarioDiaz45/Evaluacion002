namespace Elipses.Windows
{
    partial class frmElipseAE
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
            components = new System.ComponentModel.Container();
            lblLadoMayor = new Label();
            lblEjeMenor = new Label();
            txtEjeMayor = new TextBox();
            txtLadoMenor = new TextBox();
            lblColor = new Label();
            lblBorde = new Label();
            txtColor = new TextBox();
            txtBorde = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblLadoMayor
            // 
            lblLadoMayor.AutoSize = true;
            lblLadoMayor.Location = new Point(13, 21);
            lblLadoMayor.Name = "lblLadoMayor";
            lblLadoMayor.Size = new Size(59, 15);
            lblLadoMayor.TabIndex = 0;
            lblLadoMayor.Text = "Eje Mayor";
            // 
            // lblEjeMenor
            // 
            lblEjeMenor.AutoSize = true;
            lblEjeMenor.Location = new Point(13, 52);
            lblEjeMenor.Name = "lblEjeMenor";
            lblEjeMenor.Size = new Size(60, 15);
            lblEjeMenor.TabIndex = 0;
            lblEjeMenor.Text = "Eje Menor";
            // 
            // txtEjeMayor
            // 
            txtEjeMayor.Location = new Point(78, 18);
            txtEjeMayor.Name = "txtEjeMayor";
            txtEjeMayor.Size = new Size(102, 23);
            txtEjeMayor.TabIndex = 1;
            // 
            // txtLadoMenor
            // 
            txtLadoMenor.Location = new Point(78, 44);
            txtLadoMenor.Name = "txtLadoMenor";
            txtLadoMenor.Size = new Size(102, 23);
            txtLadoMenor.TabIndex = 1;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(12, 89);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 0;
            lblColor.Text = "Color";
            // 
            // lblBorde
            // 
            lblBorde.AutoSize = true;
            lblBorde.Location = new Point(13, 129);
            lblBorde.Name = "lblBorde";
            lblBorde.Size = new Size(38, 15);
            lblBorde.TabIndex = 0;
            lblBorde.Text = "Borde";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(79, 84);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(102, 23);
            txtColor.TabIndex = 1;
            // 
            // txtBorde
            // 
            txtBorde.Location = new Point(79, 126);
            txtBorde.Name = "txtBorde";
            txtBorde.Size = new Size(102, 23);
            txtBorde.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(70, 246);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 73);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(252, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 62);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmElipseAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 384);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtBorde);
            Controls.Add(txtColor);
            Controls.Add(txtLadoMenor);
            Controls.Add(txtEjeMayor);
            Controls.Add(lblBorde);
            Controls.Add(lblColor);
            Controls.Add(lblEjeMenor);
            Controls.Add(lblLadoMayor);
            Name = "frmElipseAE";
            Text = "frmElipseAE";
            Load += frmElipseAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLadoMayor;
        private Label lblEjeMenor;
        private TextBox txtEjeMayor;
        private TextBox txtLadoMenor;
        private Label lblColor;
        private Label lblBorde;
        private TextBox txtColor;
        private TextBox txtBorde;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}