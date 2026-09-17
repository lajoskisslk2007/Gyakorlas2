using FilmpApp;
using System;
using static System.Net.WebRequestMethods;

namespace FilmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();
            film.cim = "A hobbit";
            film.hossz = 120;
            Console.WriteLine("A film címe: " + film.cim + ", És a hossza :" + film.hossz + " perc");
            Film film2 = new Film();
            film2.cim = "A hobbit 2";
            film2.hossz = 150;
            Console.WriteLine("A film címe: " + film2.cim + ", És a hossza :" + film2.hossz + " perc");
        }
    }
}
