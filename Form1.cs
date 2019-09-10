using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reward_pointsssssss
{
    public partial class Form1 : Form
    {

        List<MovieViewing> movieList = new List<MovieViewing>();
        List<Members> memberList = new List<Members>(5000);
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string movieName = textBoxMovie.Text;
            bool is3D = checkBox3D.Checked;
            bool isDelux = checkBoxDelux.Checked;
            DateTime date = DateTime.Parse(dateTimePicker1.Text);
            string expired = "true";
            int points ;
            
            MovieViewing movie = new MovieViewing(movieName,  date, is3D, isDelux);

            if(movie.Expired(date) == true)
            {
                expired = "Is expired";
            }
            else
            {
                expired = "Is not expired";
            }

            points = movie.Point;
            listBoxViewing.Items.Add("Movie Name".PadRight(20) + "Date".PadRight(15) + "Points".PadRight(10) + "is expired");
            listBoxViewing.Items.Add(movie.ToString() + "                 " + expired);
        }


        public int numberOfPoints(int id)
        {
            int points =0;
            foreach (Members m in memberList)
            {
                if(m.Id == id)
                {
                    for(int i = 0; i<m.listOfMovies.Count; i++)
                    {
                        if(m.listOfMovies[i].Expired(m.listOfMovies[i].Date) == true)
                        {
                            points += m.listOfMovies[i].Point;
                        }
                       
                    }
                }
            }
            return points;
        }


        public bool isInList(int id)
        {
            bool isInList = false;

            foreach (Members m in memberList)
            {
                if (m.Id == id)
                {
                    isInList = true;
                }
                count++;
            }
            return isInList;
        }

        public int findIndex (int id)
        {
            for(int I=0; I <memberList.Count; I++)
            {
                if (memberList[I].Id == id)
                {
                    return I;
                }
            }
            return -1;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = "";
            string[] csvArray;
            StreamReader reader;
            openFileDialog1.Filter = "text file|*.txt|all files|*.*";
            string movieMane = "";
            DateTime time;
            int id = 0;
            bool isInLisT;
            bool d3;
            bool dedlux;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                

                reader = File.OpenText(openFileDialog1.FileName);
                reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    csvArray= line.Split(',');
                    id = int.Parse(csvArray[0]);
                    movieMane = csvArray[2];
                    time = DateTime.Parse(csvArray[1]);
                    d3 = bool.Parse(csvArray[4]);
                    dedlux = bool.Parse(csvArray[5]);
                    int index = findIndex(id);

                    MovieViewing movie = new MovieViewing(movieMane, time, d3, dedlux);
                    movieList.Add(movie);
                    
                 

                    if (index == -1)
                    {
                        Members m = new Members(id);
                        memberList.Add(m);
                        m.AddViewing(movie);

                    }
                    else
                    {
                        memberList[index].AddViewing(movie);

                    }
                       
                   
                  





                }
            }
            for(int i=0; i< movieList.Count; i++)
            {
                if(movieList[i].Expired(movieList[i].Date) ==true)
                {
                    listBoxViewing.Items.Add(movieList[i].ToString() + "Expired");
                    
                }
                else
                {
                    listBoxViewing.Items.Add(movieList[i].ToString() + "Not Expired");
                }
            }
            for(int i = 0; i<memberList.Count; i++) 
            {
                int p = numberOfPoints(memberList[i].Id);
                listBoxSummary.Items.Add(memberList[i].Id.ToString().PadRight(15) + p.ToString());
            }

            reader.Close();
        }
    }
}
