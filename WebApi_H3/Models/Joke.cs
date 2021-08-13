using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_H3.Models
{
    // Abstract base class (Super class)!
    public abstract class Joke : IJoke
    {
        // Create auto implemented properties with get and set accesor!
        public string Category { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        // Constructor declaration with parameters!
        public Joke (string jokeC, string jokeQ, string jokeA)
        {
            Category = jokeC;
            Question = jokeQ;
            Answer = jokeA;
        }

        // Overriding!
        public override string ToString()
        {
            return "\nCategory: " + Category + "\nThe Question: " + Question + "\nThe Answer: " + Answer;
        }
    }
}
