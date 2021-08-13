using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_H3.Models
{
    // Create a factory class!
    public class JokeFactory
    {
        // Factory method - create and instantiate objects!
        public Joke CreateJoke(string lol)
        {
            switch (lol)
            {
                case "joke1": return new AdultJoke("Danish Adult joke", "Hvad er ligheden med matematik og sex ?", "Du tilføjer sengen, trækker tøjet fra, deler benene op og håber på at regnestykket, ikke fordobler sig.");
                case "joke2": return new AdultJoke("Danish Adult joke", "Hvorfor får mænd gode ideer i sengen ?", "Fordi de er tilsluttet til et geni.");
                case "joke3": return new AdultJoke("Danish Adult joke", "Hvad er forskellen mellem en kvinde og en bog ?", "En bog kan klappe i.");
                case "joke4": return new AdultJoke("English Adult joke", "What did the penis say to the condom ?", "Cover Me, I’m Going in.");
                case "joke5": return new AdultJoke("English Adult joke", "What kind of bees make milk ?", "Boo-Bees.");
                case "joke6": return new AdultJoke("English Adult joke", "What did the elephant say to the naked man ?", "How do you breathe through that tiny thing.");
                case "joke7": return new KidsJoke("Danish Kids joke", "Hvordan får man en fisk til at grine ?", "Man putter den i kildevand.");
                case "joke8": return new KidsJoke("Danish Kids joke", "Hvad koster en hjort ?", "Den er Rådyr.");
                case "joke9": return new KidsJoke("Danish Kids joke", "Hvad får man hvis man parrer Kaj og Andrea ?", "Fuglefrø.");
                case "joke10": return new KidsJoke("English Kids joke", "How do you get a squirrel to like you ?", "Act like a nut.");
                case "joke11": return new KidsJoke("English Kids joke", "What’s worse than finding a worm in your apple ?", "Finding half a worm.");
                case "joke12": return new KidsJoke("English Kids joke", "What is brown, hairy and wears sunglasses ?", "A coconut on vacation.");
                case "jokemessage": return new Message("Importent Message", "What went wrong ?", "This site does not support your language - jokes only available in the following languages: da(Danish) or en(English).");
                default:
                    return null;
            }
        }
    }
}
