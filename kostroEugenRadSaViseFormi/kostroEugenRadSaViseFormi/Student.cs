using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenRadSaViseFormi
{
    public class Student
    {
        private string Ime;
        private string prezime;
        private string BrojIndeksa;
        private string smjer;
        private DateTime datumRodjenja;
        public Student()
        {
        }
        public string ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        public string Prezime
        { 
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        public string brojIndeksa
        {
            get
            {
                return brojIndeksa;
            }
            set
            {
                brojIndeksa = value;
            }
        }
        public string Smjer
        {
            get
            {
                return smjer;
            }
            set
            {
                smjer = value;
            }
        }
        public DateTime DatumRodjenja
        {
            get {
                return datumRodjenja;

            }
            set 
            {
                datumRodjenja = value;
            }
        }
        public override string ToString()
        {
            
            
                return ime + " " + prezime + " " + brojIndeksa + " " + datumRodjenja.ToShortDateString() + " " + smjer;
            
        }
        
    }
    
}
