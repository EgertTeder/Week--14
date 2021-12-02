using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Frozen
{
    class Program
    {
        static void Main(string[] args)
        {
            string name
            string item;
            string number

            public Movie (string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }
            public string Name
            {
            get { return name; }
            +}

        public string Number
        {
            get { return number; }
        }

        public string Year
        {
            get { return year; }
        }

        public static string rating { get; private set; }
    }

    static void Main(string[] args)
    {
        List<string> FrozenListFromFile = getFrozenFromFile().ToList();
        List<Frozen> ListOfFrozen = new List<Frozen>();

        foreach (string Frozenthing in FrozenListFromFile)
        {
            string[] tempArray = Frozen.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            Frozen newFrozen = new Frozen(tempArray[0], tempArray[1], tempArray[2]);

            ListOfFrozen.Add(newFrozen);




        }
        foreach (Frozen frozen in ListOfFrozen)
        {
            Console.WriteLine($"Title: {Frozen.Title} - Rating: {Frozen.Rating} - Year: {Frozen.Year}");
        }

    }
}

