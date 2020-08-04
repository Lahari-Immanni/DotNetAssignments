using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInheritance
{
    public class Game
    {
        int noOfPlayers;
        String country;
        public int NoOfPlayers
        {
            get { return noOfPlayers; }
            set { noOfPlayers = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public Game()
        {
        }
        public Game(int _noOfPlayers, string _country)
        {
            noOfPlayers = _noOfPlayers;
            country = _country;

        }
        public void WorldCup(string country)
        {


            //onsole.Write();
            Console.Write("have");
            Console.Write("won");
            Console.Write("cricket world cup:");
            Console.Write(DateTime.Now);


        }

    }
    class Cricket : Game
    {
        string coachName;
        public string CoachName
        {
            get { return coachName; }
            set { coachName = value; }
        }
        public Cricket()
        {

        }
        public Cricket(int _noOfPlayers, string _country, string _coachName) : base(_noOfPlayers, _country)

        {
            coachName = _coachName;
        }
    }
    class FootBall : Game
    {
        string leaugeName;
        public string LeaugeName
        {
            get { return leaugeName; }
            set { leaugeName = value; }
        }
        public FootBall()
        {

        }
        public FootBall(int _noOfPlayers, string _country, string _leaugeName) : base(_noOfPlayers, _country)

        {
            leaugeName = _leaugeName;
        }
    }
    class ShowGameDetails
    {
        public void ShowCricketDetails()
        {
            Console.WriteLine();
        }
        public void ShowFootBallDetails()
        {
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Cricket c1 = new Cricket();
            Cricket c2 = new Cricket();

            c1.Country = "India";
            c1.NoOfPlayers = 11;
            c1.CoachName = "John Wright";
            Console.WriteLine("------------CRICKET INFORMATION---------------");
            Console.Write("Country:" + c1.Country);
            Console.Write(" No Of Players:" + c1.NoOfPlayers);
            Console.Write(" Coach Name:" + c1.CoachName);
            c2.Country = "Australia";
            c2.NoOfPlayers = 11;
            c2.CoachName = "John Buchanan";
            Console.Write("                                                                   Country:" + c2.Country);
            Console.Write(" No Of Players:" + c2.NoOfPlayers);
            Console.Write(" Coach Name:" + c2.CoachName);
            FootBall f1 = new FootBall();
            FootBall f2 = new FootBall();
            f1.Country = "spain";
            f1.NoOfPlayers = 14;
            f1.LeaugeName = "Spanish League";
            Console.WriteLine("                                                             ------------FOOTBALL INFORMATION---------------");
            Console.Write("Country:" + f1.Country);
            Console.Write(" No Of Players:" + f1.NoOfPlayers);
            Console.Write(" League Name:" + f1.LeaugeName);
            f2.Country = "England";
            f2.NoOfPlayers = 13;
            f2.LeaugeName = ("English Premiur League");
            Console.Write("                                                               Country:" + f2.Country);
            Console.Write(" No Of Players:" + f2.NoOfPlayers);
            Console.Write(" League Name:" + f2.LeaugeName);
            Game g = new Cricket();
            g.WorldCup("Australia");
            Console.Read();
        }
    }
}
