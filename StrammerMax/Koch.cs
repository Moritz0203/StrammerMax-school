using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrammerMax
{

    class Koch// Definiere der Klasse Koch
    {
        string name;
        public string Name
        {
            set { System.Windows.MessageBox.Show("Man kann mich nicht in " + value + " umbenennen."); }// setzten von name und erstellen einer mesage box
            get {return name; }// gibt denn wert der in name steht an denn aufrufer der funktion 
        }
        
        Random geheimnis;// Erstellt eine Variable vom typ random

        public Koch(string Name) {
            geheimnis = new Random();
            name = Name;
        }

        public Gericht Kochen()
        {
            Gericht neuesGericht = new Gericht();
            UInt16 random = 0;

            //Programmieren Sie ein zufälliges Gericht

            random = (UInt16)geheimnis.Next(0, 5);// generit ein zahl von 0-5
            neuesGericht.Fleischsorte = (Fleisch)random;// nimmt denn wert der in fleisch für die zahl steht 

            random = (UInt16)geheimnis.Next(0, 6);
            neuesGericht.Soßensorte = (Soße)random; 
            
            random = (UInt16)geheimnis.Next(0, 6);
            neuesGericht.Brotsorte = (Brot)random;

            return neuesGericht;// gibt das neue gericht zurück
        }
    }
 }
