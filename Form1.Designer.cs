namespace examen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNom = new Label();
            txtNom = new TextBox();
            lbldata = new Label();
            dtpData = new DateTimePicker();
            lblPreu = new Label();
            txtPreu = new TextBox();
            lblZona = new Label();
            cmbZona = new ComboBox();
            lblTipus = new Label();
            cmbTipus = new ComboBox();
            lblVIP = new Label();
            txtVIP = new TextBox();
            listBox1 = new ListBox();
            btnVendre = new Button();
            btnVeure = new Button();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(76, 57);
            lblNom.Name = "lblNom";
            lblNom.RightToLeft = RightToLeft.No;
            lblNom.Size = new Size(80, 15);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom asistent:";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(162, 54);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 1;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // lbldata
            // 
            lbldata.AutoSize = true;
            lbldata.Location = new Point(76, 87);
            lbldata.Name = "lbldata";
            lbldata.RightToLeft = RightToLeft.No;
            lbldata.Size = new Size(79, 15);
            lbldata.TabIndex = 2;
            lbldata.Text = "Data Concert:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(161, 81);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 3;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // lblPreu
            // 
            lblPreu.AutoSize = true;
            lblPreu.Location = new Point(77, 113);
            lblPreu.Name = "lblPreu";
            lblPreu.RightToLeft = RightToLeft.No;
            lblPreu.Size = new Size(48, 15);
            lblPreu.TabIndex = 4;
            lblPreu.Text = "Preu (€)";
            // 
            // txtPreu
            // 
            txtPreu.Location = new Point(161, 110);
            txtPreu.Name = "txtPreu";
            txtPreu.Size = new Size(100, 23);
            txtPreu.TabIndex = 5;
            txtPreu.TextChanged += txtPreu_TextChanged;
            // 
            // lblZona
            // 
            lblZona.AutoSize = true;
            lblZona.Location = new Point(77, 141);
            lblZona.Name = "lblZona";
            lblZona.RightToLeft = RightToLeft.No;
            lblZona.Size = new Size(37, 15);
            lblZona.TabIndex = 6;
            lblZona.Text = "Zona:";
            // 
            // cmbZona
            // 
            cmbZona.FormattingEnabled = true;
            cmbZona.Items.AddRange(new object[] { "Pista", "Grada" });
            cmbZona.Location = new Point(161, 138);
            cmbZona.Name = "cmbZona";
            cmbZona.Size = new Size(121, 23);
            cmbZona.TabIndex = 7;
            cmbZona.SelectedIndexChanged += cmbZona_SelectedIndexChanged;
            // 
            // lblTipus
            // 
            lblTipus.AutoSize = true;
            lblTipus.Location = new Point(77, 171);
            lblTipus.Name = "lblTipus";
            lblTipus.RightToLeft = RightToLeft.No;
            lblTipus.Size = new Size(81, 15);
            lblTipus.TabIndex = 8;
            lblTipus.Text = "Tipus Entrada:";
            // 
            // cmbTipus
            // 
            cmbTipus.FormattingEnabled = true;
            cmbTipus.Items.AddRange(new object[] { "General", "Vip" });
            cmbTipus.Location = new Point(161, 167);
            cmbTipus.Name = "cmbTipus";
            cmbTipus.Size = new Size(121, 23);
            cmbTipus.TabIndex = 9;
            cmbTipus.SelectedIndexChanged += cmbTipus_SelectedIndexChanged;
            // 
            // lblVIP
            // 
            lblVIP.AutoSize = true;
            lblVIP.Location = new Point(77, 197);
            lblVIP.Name = "lblVIP";
            lblVIP.RightToLeft = RightToLeft.No;
            lblVIP.Size = new Size(72, 15);
            lblVIP.TabIndex = 10;
            lblVIP.Text = "Benefici VIP:";
            lblVIP.Visible = false;
            // 
            // txtVIP
            // 
            txtVIP.Location = new Point(161, 194);
            txtVIP.Name = "txtVIP";
            txtVIP.Size = new Size(100, 23);
            txtVIP.TabIndex = 11;
            txtVIP.Visible = false;
            txtVIP.TextChanged += txtVIP_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(446, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(186, 214);
            listBox1.TabIndex = 12;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnVendre
            // 
            btnVendre.Location = new Point(83, 247);
            btnVendre.Name = "btnVendre";
            btnVendre.Size = new Size(75, 23);
            btnVendre.TabIndex = 13;
            btnVendre.Text = "Vendre Entrada";
            btnVendre.UseVisualStyleBackColor = true;
            btnVendre.Click += btnVendre_Click;
            // 
            // btnVeure
            // 
            btnVeure.Location = new Point(187, 247);
            btnVeure.Name = "btnVeure";
            btnVeure.Size = new Size(75, 23);
            btnVeure.TabIndex = 14;
            btnVeure.Text = "Veure Tiquet";
            btnVeure.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVeure);
            Controls.Add(btnVendre);
            Controls.Add(listBox1);
            Controls.Add(txtVIP);
            Controls.Add(lblVIP);
            Controls.Add(cmbTipus);
            Controls.Add(lblTipus);
            Controls.Add(cmbZona);
            Controls.Add(lblZona);
            Controls.Add(txtPreu);
            Controls.Add(lblPreu);
            Controls.Add(dtpData);
            Controls.Add(lbldata);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private TextBox txtNom;
        private Label lbldata;
        private DateTimePicker dtpData;
        private Label lblPreu;
        private TextBox txtPreu;
        private Label lblZona;
        private ComboBox cmbZona;
        private Label lblTipus;
        private ComboBox cmbTipus;
        private Label lblVIP;
        private TextBox txtVIP;
        private ListBox listBox1;
        private Button btnVendre;
        private Button btnVeure;
    }
}
