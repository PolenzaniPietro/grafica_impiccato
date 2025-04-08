namespace interfaccia_impiccato
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inserimento_lettera = new TextBox();
            inserimento_parola = new TextBox();
            invia = new Button();
            suggerimento = new Button();
            trattino = new Label();
            numero_lettere = new Label();
            label7 = new Label();
            diffolta = new ComboBox();
            categoria = new ComboBox();
            label6 = new Label();
            tentativi_rimanenti = new Label();
            termina_gioco = new Button();
            annunci = new Label();
            label4 = new Label();
            label5 = new Label();
            indizi_rimanenti = new Label();
            lista = new ListBox();
            nuova_parola = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            parole_indovinate = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 203);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "inserisci lettera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 203);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "inserisci parola";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(319, 68);
            label3.Name = "label3";
            label3.Size = new Size(209, 17);
            label3.TabIndex = 2;
            label3.Text = "PAROLA DA INDOVINARE";
            // 
            // inserimento_lettera
            // 
            inserimento_lettera.Location = new Point(460, 221);
            inserimento_lettera.Name = "inserimento_lettera";
            inserimento_lettera.Size = new Size(92, 23);
            inserimento_lettera.TabIndex = 3;
            inserimento_lettera.TextChanged += inserimento_lettera_TextChanged;
            // 
            // inserimento_parola
            // 
            inserimento_parola.Location = new Point(319, 221);
            inserimento_parola.Name = "inserimento_parola";
            inserimento_parola.Size = new Size(92, 23);
            inserimento_parola.TabIndex = 4;
            inserimento_parola.TextChanged += inserimento_parola_TextChanged;
            // 
            // invia
            // 
            invia.Location = new Point(594, 213);
            invia.Name = "invia";
            invia.Size = new Size(78, 36);
            invia.TabIndex = 5;
            invia.Text = "INVIA";
            invia.UseVisualStyleBackColor = true;
            invia.Click += invia_Click;
            // 
            // suggerimento
            // 
            suggerimento.Location = new Point(381, 259);
            suggerimento.Name = "suggerimento";
            suggerimento.Size = new Size(108, 46);
            suggerimento.TabIndex = 6;
            suggerimento.Text = "SUGGERIMENTO";
            suggerimento.UseVisualStyleBackColor = true;
            suggerimento.Click += suggerimento_Click;
            // 
            // trattino
            // 
            trattino.AutoSize = true;
            trattino.Location = new Point(381, 132);
            trattino.Name = "trattino";
            trattino.Size = new Size(0, 15);
            trattino.TabIndex = 7;
            trattino.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numero_lettere
            // 
            numero_lettere.AutoSize = true;
            numero_lettere.Location = new Point(494, 132);
            numero_lettere.Name = "numero_lettere";
            numero_lettere.Size = new Size(0, 15);
            numero_lettere.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(162, 9);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 10;
            // 
            // diffolta
            // 
            diffolta.FormattingEnabled = true;
            diffolta.Items.AddRange(new object[] { "facile", "medio ", "difficile", "impossibile" });
            diffolta.Location = new Point(32, 149);
            diffolta.Name = "diffolta";
            diffolta.Size = new Size(130, 23);
            diffolta.TabIndex = 14;
            diffolta.Text = "seleziona difficoltà";
            diffolta.SelectedIndexChanged += diffolta_SelectedIndexChanged;
            // 
            // categoria
            // 
            categoria.FormattingEnabled = true;
            categoria.Items.AddRange(new object[] { "parti del corpo", "natura", "videogiochi", "animali" });
            categoria.Location = new Point(32, 221);
            categoria.Name = "categoria";
            categoria.Size = new Size(130, 23);
            categoria.TabIndex = 15;
            categoria.Text = "seleziona categoria";
            categoria.SelectedIndexChanged += categoria_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Snap ITC", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(143, 9);
            label6.Name = "label6";
            label6.Size = new Size(485, 42);
            label6.TabIndex = 16;
            label6.Text = "GIOCO DELL'IMPICCATO";
            // 
            // tentativi_rimanenti
            // 
            tentativi_rimanenti.AutoSize = true;
            tentativi_rimanenti.Location = new Point(690, 92);
            tentativi_rimanenti.Name = "tentativi_rimanenti";
            tentativi_rimanenti.Size = new Size(0, 15);
            tentativi_rimanenti.TabIndex = 17;
            // 
            // termina_gioco
            // 
            termina_gioco.Location = new Point(594, 353);
            termina_gioco.Name = "termina_gioco";
            termina_gioco.Size = new Size(78, 51);
            termina_gioco.TabIndex = 18;
            termina_gioco.Text = "TERMINA GIOCO";
            termina_gioco.UseVisualStyleBackColor = true;
            termina_gioco.Click += termina_gioco_Click;
            // 
            // annunci
            // 
            annunci.AutoSize = true;
            annunci.Font = new Font("Open Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            annunci.Location = new Point(319, 407);
            annunci.Name = "annunci";
            annunci.Size = new Size(0, 26);
            annunci.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(577, 92);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 20;
            label4.Text = "tentativi rimanenti:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(577, 117);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 21;
            label5.Text = "indizi rimanenti:";
            // 
            // indizi_rimanenti
            // 
            indizi_rimanenti.AutoSize = true;
            indizi_rimanenti.Location = new Point(690, 117);
            indizi_rimanenti.Name = "indizi_rimanenti";
            indizi_rimanenti.Size = new Size(0, 15);
            indizi_rimanenti.TabIndex = 22;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(32, 301);
            lista.Name = "lista";
            lista.Size = new Size(101, 64);
            lista.TabIndex = 23;
            // 
            // nuova_parola
            // 
            nuova_parola.Location = new Point(594, 277);
            nuova_parola.Name = "nuova_parola";
            nuova_parola.Size = new Size(78, 51);
            nuova_parola.TabIndex = 24;
            nuova_parola.Text = "NUOVA PAROLA";
            nuova_parola.UseVisualStyleBackColor = true;
            nuova_parola.Click += nuova_parola_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 283);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 25;
            label8.Text = "lettere inserite";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(162, 283);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 26;
            label9.Text = "parole indovinate";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(162, 313);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 27;
            // 
            // parole_indovinate
            // 
            parole_indovinate.FormattingEnabled = true;
            parole_indovinate.ItemHeight = 15;
            parole_indovinate.Location = new Point(162, 301);
            parole_indovinate.Name = "parole_indovinate";
            parole_indovinate.Size = new Size(101, 64);
            parole_indovinate.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(759, 445);
            Controls.Add(parole_indovinate);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(nuova_parola);
            Controls.Add(lista);
            Controls.Add(indizi_rimanenti);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(annunci);
            Controls.Add(termina_gioco);
            Controls.Add(tentativi_rimanenti);
            Controls.Add(label6);
            Controls.Add(categoria);
            Controls.Add(diffolta);
            Controls.Add(label7);
            Controls.Add(numero_lettere);
            Controls.Add(trattino);
            Controls.Add(suggerimento);
            Controls.Add(invia);
            Controls.Add(inserimento_parola);
            Controls.Add(inserimento_lettera);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inserimento_lettera;
        private TextBox inserimento_parola;
        private Button invia;
        private Button suggerimento;
        private Label trattino;
        private Label numero_lettere;
        private Label label7;
        private ComboBox diffolta;
        private ComboBox categoria;
        private Label label6;
        private Label tentativi_rimanenti;
        private Button termina_gioco;
        private Label annunci;
        private Label label4;
        private Label label5;
        private Label indizi_rimanenti;
        private ListBox lista;
        private Button nuova_parola;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox parole_indovinate;
    }
}
