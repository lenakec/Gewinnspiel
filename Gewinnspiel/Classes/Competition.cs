using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewinnspiel.Classes
{
    public class Competition
    {
        //Objektvariablen
        private int cId;
        private string name;
        private string prize;
        private double worth;
        private bool chosen;
        private List<Participant> participants;
        private string imagePath;

        //Klassenvariablen
        private static int autonum = 1001;
        private static int anzahl;


        //Konstruktoren
        public Competition() { }

        public Competition(string name, string prize)
        {
            cId = autonum;
            autonum++;

            this.name = name;
            this.prize = prize;
            worth = 0;
            chosen = false;
            participants = null;
            imagePath = null;
        }

        public Competition(string name, string prize, string imagePath)
        {
            cId = autonum;
            autonum++;

            this.name = name;
            this.prize = prize;
            this.imagePath = imagePath;
            worth = 0;
            chosen = false;
            participants = null;
        }

        public Competition(string name, string prize, double worth, List<Participant> participants, string imagePath)
        {
            cId = autonum;
            autonum++;

            this.name = name;
            this.prize = prize;
            this.worth = worth;
            this.participants = participants;
            this.imagePath = imagePath;
            chosen = false;
        }


        //Properties
        public int CId { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Prize
        {
            get { return prize; }
            set { prize = value; }
        }
        public double Worth { get; set; }

        public bool Chosen { get; set; }

        public List<Participant>Participants
        {
            get { return participants; }
            set { participants = value; }
        }
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }


        //Klassenproperties
        public static int Anzahl { get; set; }
        public static int Autonum { get; set; }


        //Methode
        public override string ToString()
        {
            return cId + "; " + name + "; " + prize + "; " + worth + "; " + chosen + "; " + imagePath;
        }
    }
}
