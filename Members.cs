using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reward_pointsssssss
{
    class Members
    {
        List<MovieViewing> _movieList;
        private int _ID;

        public Members(int id)
        {
            _ID = id;
            _movieList = new List<MovieViewing>();
        }

        public void AddViewing(MovieViewing M)
        {
            _movieList.Add(M);
        }

        public int Id
        {
            get { return _ID; }

        }

        public List<MovieViewing> listOfMovies 
        {
            get { return _movieList; }
        }

       

    }
}
