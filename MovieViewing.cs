using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reward_pointsssssss
{
    class MovieViewing
    {
        private string _MovieName;
        private int _Points;
        private DateTime _Date;

        public MovieViewing(string movieName, DateTime date, bool movie3D, bool isDelux)
        {
            _MovieName = movieName;

            _Date = date;

            if (movie3D == true)
            {
                _Points = +2;
            }
            if (isDelux == true)
            {
                _Points += 4;
            }
        }
        public int Point
        {
            get { return _Points; }

        }
        public DateTime Date
        {
            get { return _Date; }
        }

        public bool Expired(DateTime newDate)
        {
            if (DateTime.Today >= newDate.AddYears(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return _MovieName.PadRight(50) + _Date.ToString().PadRight(40) + Point.ToString().PadRight(20) ;
        }


    }
    }

