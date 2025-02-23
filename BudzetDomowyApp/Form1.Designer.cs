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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEksport
            // 
            btnEksport.Location = new Point(551, 361);
            btnEksport.Name = "btnEksport";
            btnEksport.Size = new Size(237, 77);
            btnEksport.TabIndex = 0;
            btnEksport.Text = "Eksportuj do Excel";
            btnEksport.UseVisualStyleBackColor = true;
            btnEksport.Click += btnEksport_Click;
            // 
            // txtNazwa
            // 
            txtNazwa.Location = new Point(12, 12);
            txtNazwa.Name = "txtNazwa";
            txtNazwa.Size = new Size(200, 23);
            txtNazwa.TabIndex = 1;
            // 
            // txtKwota
            // 
            txtKwota.Location = new Point(12, 41);
            txtKwota.Name = "txtKwota";
            txtKwota.Size = new Size(200, 23);
            txtKwota.TabIndex = 2;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(12, 70);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(200, 23);
            txtOpis.TabIndex = 3;
            // 
            // cmbTyp
            // 
            cmbTyp.FormattingEnabled = true;
            cmbTyp.Location = new Point(12, 99);
            cmbTyp.Name = "cmbTyp";
            cmbTyp.Size = new Size(200, 23);
            cmbTyp.TabIndex = 4;
            // 
            // cmbKategoria
            // 
            cmbKategoria.FormattingEnabled = true;
            cmbKategoria.Location = new Point(12, 128);
            cmbKategoria.Name = "cmbKategoria";
            cmbKategoria.Size = new Size(200, 23);
            cmbKategoria.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // Dodaj_transakcje
            // 
            Dodaj_transakcje.Location = new Point(12, 186);
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
            dataGridView1.Location = new Point(342, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
