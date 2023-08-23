using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrammerMax
{

    class Koch
    {
        string name;
        public string Name
        {
            set { System.Windows.MessageBox.Show("Man kann mich nicht in " + value + " umbenennen."); }
            get {return name;}
        }
        
        Random geheimnis;

        public Koch(string Name) {
            geheimnis = new Random();
            name = Name;
        }

        public Gericht Kochen()
        {
            Gericht neuesGericht = new Gericht();
            UInt16 random = 0;

            //Programmieren Sie ein zufälliges Gericht

            random = (UInt16)geheimnis.Next(0, 5);
            neuesGericht.Fleischsorte = (Fleisch)random;

            random = (UInt16)geheimnis.Next(0, 6);
            neuesGericht.Soßensorte = (Soße)random; 
            
            random = (UInt16)geheimnis.Next(0, 6);
            neuesGericht.Brotsorte = (Brot)random;

            return neuesGericht;
        }
    }
 }
