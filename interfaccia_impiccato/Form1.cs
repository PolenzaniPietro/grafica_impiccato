namespace interfaccia_impiccato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string FilePath = " ", linguaScelta = "", categoriaScelta = "", sceltaProseguimento = "", lettereInserite = "";
        static int tentativi = 0, indizi = 0, paroleIndovinate = 0;
        static string parolaCasuale = "";
        char lettera;
        string parola = "";
        bool parolaTrovata = false, letteraTrovata = false;
        char[] trattini;
        char[] lettere_usate= new char[100];

        private void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            trattino.Text = "";
            int categoriaScelta = categoria.SelectedIndex;
            if (categoriaScelta == 0)
            {
                FilePath = "parti_del_corpo_italiano.txt";
            }
            else if (categoriaScelta == 1)
            {
                FilePath = "natura_italiano.txt";
            }
            else if (categoriaScelta == 2)
            {
                FilePath = "videogiochi.txt";
            }
            else if (categoriaScelta == 3)
            {
                FilePath = "animali_italiano.txt";
            }
            categoria.Enabled = false;
            Random rnd = new Random();
            string[] lines = File.ReadAllLines(FilePath);
            int casuale = rnd.Next(lines.Length);
            parolaCasuale = lines[casuale].ToLower();
            lista.Items.Clear();
            annunci.Text = "";
            for (int i = 0; i < parolaCasuale.Length; i++)
            {
                trattino.Text += "_";
            }
            trattini = trattino.Text.ToCharArray();
            numero_lettere.Text = parolaCasuale.Length.ToString();
        }



        private void suggerimento_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int indice = r.Next(trattino.Text.Length);
            trattini[indice] = parolaCasuale[indice];
            trattino.Text = new string(trattini[indice].ToString());
            indizi--;
            annunci.Text = "";
            indizi_rimanenti.Text = (indizi).ToString();
            
                if (!trattino.Text.Contains('_'))
                {
                    indice = r.Next(trattino.Text.Length);
                }

            if (indizi <= 0)
                {
                    suggerimento.Enabled = false;
                    annunci.Text = "INDIZI ESAURITI";
                }
                trattino.Text = new string(trattini);
            
        }

        private void diffolta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int difficoltà = diffolta.SelectedIndex;
            if (difficoltà == 0) // difficoltà facile
            {
                indizi = 3; tentativi = 10;
            }
            else if (difficoltà == 1) // difficoltà media
            {
                indizi = 2; tentativi = 5;
            }
            else if (difficoltà == 2) //difficoltà difficile 
            {
                indizi = 1; tentativi = 3;
            }
            else if (difficoltà == 3) //difficoltà impossibile
            {
                indizi = 0; tentativi = 1;
            }
            diffolta.Enabled = false;
            tentativi_rimanenti.Text = tentativi.ToString();
            indizi_rimanenti.Text = indizi.ToString();
            lista.Items.Clear();
            annunci.Text = "";
        }
        private void inserimento_lettera_TextChanged(object sender, EventArgs e)
        {
            lettera = char.Parse(inserimento_lettera.Text);
        }
        private void inserimento_parola_TextChanged(object sender, EventArgs e)
        {
            parola = inserimento_parola.Text;
        }
        void inserimentoParola(string parola)
        {
            parolaTrovata = false;
            if (parola == parolaCasuale)
            {
                parolaTrovata = true;

            }
        }
        void inserimentoLettera(char lettera)
        {
            letteraTrovata = false;
            for (int i = 0; i < parolaCasuale.Length; i++)
            {
                if (lettera == parolaCasuale[i])
                {
                    letteraTrovata = true;
                    trattini[i] = lettera;
                }
            }
            trattino.Text = new string(trattini);
            lista.Items.Add(lettera);
            for (int i = 0;i < lista.Items.Count; i++)
            {
                lettere_usate[i] = lettera;
            }
        }

        private void invia_Click(object sender, EventArgs e)
        {
            inserimentoLettera(lettera);
            inserimentoParola(parola);
            for (int i = 0; i < lista.Items.Count; i++) 
            {
                if (lettere_usate[i] == lettera)
                {
                    annunci.Text = "HAI GIA' INSERITO QUESTA LETTERA";
                }
            }
            if (parolaTrovata)
            {
                trattino.Text = parola;
                annunci.Text = "HAI INDOVINATO TUTTA LA PAROLA NASCOSTA!!";
                parole_indovinate.Items.Add(parola);
            }
            else if (letteraTrovata)
            {
                annunci.Text = "QUESTA LETTERA E' PRESENTE NELLA PAROLA NASCOSTA!!";
            }
            else
            {
                annunci.Text = "INSERIMENTO ERRATO.";
                tentativi_rimanenti.Text = (tentativi--).ToString();

            }

        }

        private void termina_gioco_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuova_parola_Click(object sender, EventArgs e)
        {
            categoria.Enabled = true;
            diffolta.Enabled = true;
            suggerimento.Enabled = true;
            lista.Items.Clear();
            annunci.Text = "SELEZIONA UNA NUOVA CATEGORIA E UNA NUOVA DIFFICOLTA'";
        }
    }
}
