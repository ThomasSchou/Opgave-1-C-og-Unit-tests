using System;

namespace Class_Library_og_Unit_Test
{
    public class FootBallPlayer
    {
        private static int _id = 1;
        private string _name;
        private double _price;
        private int _shirtNumber;

        public FootBallPlayer(string name, double price, int shirtNumber)
        {
            ID = _id++;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
        }

        public int ID
        {
            get => _id;
            set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException(); }

                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) { throw new ArgumentOutOfRangeException(); }

                _name = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException(); }
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 1 || value >= 100) { throw new ArgumentOutOfRangeException(); }

                _shirtNumber = value;
            }
        }
    }
}
