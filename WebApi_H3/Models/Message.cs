using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_H3.Models
{
    // Derived class - inherit from the SuperClass Joke!
    public class Message : Joke
    {
        // Call the base constructor!
        public Message(string jokeC, string jokeQ, string jokeA) : base(jokeC, jokeQ, jokeA)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
