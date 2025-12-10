namespace examen
{
    partial class Form2
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
            lblDetallNom = new Label();
            txtDetallNom = new TextBox();
            lblDetallData = new Label();
            dtpDetallData = new DateTimePicker();
            lblDetallPreu = new Label();
            txtDetallPreu = new TextBox();
            lblDetallVIP = new Label();
            txtDetallVIP = new TextBox();
            btnTancar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblDetallNom
            // 
            lblDetallNom.AutoSize = true;
            lblDetallNom.Location = new Point(69, 88);
            lblDetallNom.Name = "lblDetallNom";
            lblDetallNom.Size = new Size(37, 15);
            lblDetallNom.TabIndex = 0;
            lblDetallNom.Text = "Nom:";
            // 
            // txtDetallNom
            // 
            txtDetallNom.Location = new Point(121, 85);
            txtDetallNom.Name = "txtDetallNom";
            txtDetallNom.Size = new Size(100, 23);
            txtDetallNom.TabIndex = 1;
            // 
            // lblDetallData
            // 
            lblDetallData.AutoSize = true;
            lblDetallData.Location = new Point(69, 122);
            lblDetallData.Name = "lblDetallData";
            lblDetallData.Size = new Size(34, 15);
            lblDetallData.TabIndex = 2;
            lblDetallData.Text = "Data:";
            // 
            // dtpDetallData
            // 
            dtpDetallData.Location = new Point(121, 116);
            dtpDetallData.Name = "dtpDetallData";
            dtpDetallData.Size = new Size(200, 23);
            dtpDetallData.TabIndex = 3;
            // 
            // lblDetallPreu
            // 
            lblDetallPreu.AutoSize = true;
            lblDetallPreu.Location = new Point(69, 152);
            lblDetallPreu.Name = "lblDetallPreu";
            lblDetallPreu.Size = new Size(34, 15);
            lblDetallPreu.TabIndex = 4;
            lblDetallPreu.Text = "Preu:";
            // 
            // txtDetallPreu
            // 
            txtDetallPreu.Location = new Point(121, 149);
            txtDetallPreu.Name = "txtDetallPreu";
            txtDetallPreu.Size = new Size(100, 23);
            txtDetallPreu.TabIndex = 5;
            // 
            // lblDetallVIP
            // 
            lblDetallVIP.AutoSize = true;
            lblDetallVIP.Location = new Point(50, 184);
            lblDetallVIP.Name = "lblDetallVIP";
            lblDetallVIP.Size = new Size(56, 15);
            lblDetallVIP.TabIndex = 6;
            lblDetallVIP.Text = "Extra Vip:";
            lblDetallVIP.Visible = false;
            // 
            // txtDetallVIP
            // 
            txtDetallVIP.Location = new Point(121, 178);
            txtDetallVIP.Name = "txtDetallVIP";
            txtDetallVIP.Size = new Size(100, 23);
            txtDetallVIP.TabIndex = 7;
            txtDetallVIP.Visible = false;
            // 
            // btnTancar
            // 
            btnTancar.Location = new Point(69, 222);
            btnTancar.Name = "btnTancar";
            btnTancar.Size = new Size(75, 23);
            btnTancar.TabIndex = 8;
            btnTancar.Text = "Tanca";
            btnTancar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(170, 222);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnTancar);
            Controls.Add(txtDetallVIP);
            Controls.Add(lblDetallVIP);
            Controls.Add(txtDetallPreu);
            Controls.Add(lblDetallPreu);
            Controls.Add(dtpDetallData);
            Controls.Add(lblDetallData);
            Controls.Add(txtDetallNom);
            Controls.Add(lblDetallNom);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDetallNom;
        private TextBox txtDetallNom;
        private Label lblDetallData;
        private DateTimePicker dtpDetallData;
        private Label lblDetallPreu;
        private TextBox txtDetallPreu;
        private Label lblDetallVIP;
        private TextBox txtDetallVIP;
        private Button btnTancar;
        private Button btnGuardar;
    }
}