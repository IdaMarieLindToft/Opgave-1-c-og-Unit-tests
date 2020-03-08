using System;

namespace Opgave_1_Bog
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sideTal;
        private string _isbn13;

        public Bog(string titel, string forfatter, int sideTal, string isbn13)
        {
            titel = _titel;
            forfatter = _forfatter;
            sideTal = _sideTal;
            isbn13 = _isbn13;
        }

        public Bog() { }

        public string Titel
        {
            get { return _titel; }
            set { value = _titel; }
        }

        public string Forfatter
        {
            get { return _forfatter; }
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException("Længden på forfatteren skal være minimum 2 tegn langt");
                _forfatter = value;
            }
        }

        public int Sidetal
        {
            get { return _sideTal; }
            set
            {
                if (value <= 4 || value >= 1000 ) throw new ArgumentOutOfRangeException("Sidetal udenfor det tilladtea");
                _sideTal = value;
            }
        }

        public string Isbn13
        {
            get { return _isbn13; }
            set
            {
                if (value.Length >13 || value.Length <13) throw new  ArgumentOutOfRangeException("ISBN13 nummeret skal være på 13 tegn");
                {
                    _isbn13 = value;
                }
            }
        }



    }
}

