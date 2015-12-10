using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GalacticGPS
{
    struct Location
    {

        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude,Planets planets)
            :this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planets = planets;

        }

        public double Latitude
        { 
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < -180 || value > 180 )
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }

                this.longitude = value;
            }
        }

        public Planets Planets { get; set; }

        public override string ToString()
        {
            string result;

            result =  string.Format("{0},{1},{2}",this.Latitude,this.Longitude,this.Planets);

            return result;
        }
        

    }
}
