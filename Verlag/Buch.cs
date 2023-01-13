using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
            private string autor;
            private string titel;
            private int auflage = 1;


            public Buch(string autor, string titel)
            {
                this.autor = autor;
                this.titel = titel;
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
