using SportsBet247.Data;
using System;

namespace SportsBet247.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SportsBet247DbContext();
            db.Database.EnsureCreated();
        }
    }
}
