namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage = 1;


        public Buch(string autor, string titel)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
            string test = "abcdefghijklmnopqrstuvwxyz";

            for(int i = 0; i < autor.Length; i++)
            {
                if (test.Contains(autor[i]) == false)
                {
                    throw new ArgumentException("test");
                }
                
            } 
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
