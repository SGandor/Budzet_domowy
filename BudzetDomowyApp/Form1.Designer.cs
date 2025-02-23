namespace BudzetDomowyApp
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
            btnEksport = new Button();
            txtNazwa = new TextBox();
            txtKwota = new TextBox();
            txtOpis = new TextBox();
            cmbTyp = new ComboBox();
            cmbKategoria = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            Dodaj_transakcje = new Button();
            dataGridView1 = new DataGridView();
            lblBilans = new Label();
            lblPrzychody = new Label();
            lblWydatki = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEksport
            // 
            btnEksport.Location = new Point(12, 368);
            btnEksport.Name = "btnEksport";
            btnEksport.Size = new Size(263, 80);
            btnEksport.TabIndex = 0;
            btnEksport.Text = "Eksportuj do Excel";
            btnEksport.UseVisualStyleBackColor = true;
            btnEksport.Click += btnEksport_Click;
            // 
            // txtNazwa
            // 
            txtNazwa.Location = new Point(75, 9);
            txtNazwa.Name = "txtNazwa";
            txtNazwa.Size = new Size(200, 23);
            txtNazwa.TabIndex = 1;
            // 
            // txtKwota
            // 
            txtKwota.Location = new Point(75, 38);
            txtKwota.Name = "txtKwota";
            txtKwota.Size = new Size(200, 23);
            txtKwota.TabIndex = 2;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(75, 67);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(200, 23);
            txtOpis.TabIndex = 3;
            // 
            // cmbTyp
            // 
            cmbTyp.FormattingEnabled = true;
            cmbTyp.Location = new Point(75, 96);
            cmbTyp.Name = "cmbTyp";
            cmbTyp.Size = new Size(200, 23);
            cmbTyp.TabIndex = 4;
            // 
            // cmbKategoria
            // 
            cmbKategoria.FormattingEnabled = true;
            cmbKategoria.Location = new Point(75, 125);
            cmbKategoria.Name = "cmbKategoria";
            cmbKategoria.Size = new Size(200, 23);
            cmbKategoria.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 154);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // Dodaj_transakcje
            // 
            Dodaj_transakcje.Location = new Point(75, 183);
            Dodaj_transakcje.Name = "Dodaj_transakcje";
            Dodaj_transakcje.Size = new Size(200, 37);
            Dodaj_transakcje.TabIndex = 7;
            Dodaj_transakcje.Text = "Dodaj transakcję";
            Dodaj_transakcje.UseVisualStyleBackColor = true;
            Dodaj_transakcje.Click += Dodaj_transakcje_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(281, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(507, 439);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblBilans
            // 
            lblBilans.AutoSize = true;
            lblBilans.Location = new Point(75, 223);
            lblBilans.Name = "lblBilans";
            lblBilans.Size = new Size(38, 15);
            lblBilans.TabIndex = 9;
            lblBilans.Text = "Bilans";
            lblBilans.Click += label1_Click;
            // 
            // lblPrzychody
            // 
            lblPrzychody.AutoSize = true;
            lblPrzychody.Location = new Point(75, 238);
            lblPrzychody.Name = "lblPrzychody";
            lblPrzychody.Size = new Size(62, 15);
            lblPrzychody.TabIndex = 10;
            lblPrzychody.Text = "Przychody";
            // 
            // lblWydatki
            // 
            lblWydatki.AutoSize = true;
            lblWydatki.Location = new Point(75, 253);
            lblWydatki.Name = "lblWydatki";
            lblWydatki.Size = new Size(50, 15);
            lblWydatki.TabIndex = 11;
            lblWydatki.Text = "Wydatki";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 12);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 12;
            label1.Text = "Nazwa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 41);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 13;
            label2.Text = "Kwota";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 70);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 14;
            label3.Text = "Opis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 99);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 15;
            label4.Text = "Typ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 16;
            label5.Text = "Kategoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 160);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 17;
            label6.Text = "Data";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblWydatki);
            Controls.Add(lblPrzychody);
            Controls.Add(lblBilans);
            Controls.Add(dataGridView1);
            Controls.Add(Dodaj_transakcje);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbKategoria);
            Controls.Add(cmbTyp);
            Controls.Add(txtOpis);
            Controls.Add(txtKwota);
            Controls.Add(txtNazwa);
            Controls.Add(btnEksport);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button btnEksport;
        private TextBox txtNazwa;
        private TextBox txtKwota;
        private TextBox txtOpis;
        private ComboBox cmbTyp;
        private ComboBox cmbKategoria;
        private DateTimePicker dateTimePicker1;
        private Button Dodaj_transakcje;
        private DataGridView dataGridView1;
        private Label lblBilans;
        private Label lblPrzychody;
        private Label lblWydatki;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
