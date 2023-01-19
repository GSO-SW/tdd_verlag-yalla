namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage = 1;


        public Buch(string autor, string titel)
        {
            if (autor == "" || autor.Contains("#") || autor.Contains(";") || autor.Contains("§") || autor.Contains("%") || autor == Convert.ToBase64String(null))
            {
                throw new ArgumentException("Name des Authors ist unzulässig");
            }
            else
            {
                this.autor = autor;
            }

            this.titel = titel;
            auflage = 1;
        }


        public Buch(string autor, string titel, int auflage) : this(autor, titel)
        {
            this.auflage = auflage;

        }


        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                this.autor = value;
            }
        }

        public string Titel
        {
            get
            {
                return titel;
            }
        }

        public int Auflage
        {
            get
            {
                return this.auflage;
            }
            set
            {

                this.auflage = value;
            }

        }

    }
}
