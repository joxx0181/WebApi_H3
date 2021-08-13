using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WebApi_H3.Dal;
using WebApi_H3.Models;

namespace WebApi_H3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class JokeController : ControllerBase
    {
        // GET: api/<JokeController>
        [HttpGet]
        public IEnumerable<IJoke> Get(int age, string language)
        {
            // Create list for all the jokes!
            List<Joke> jokeList = new();

            // Create objects!
            Joke joke_1 = new JokeFactory().CreateJoke("joke1");
            Joke joke_2 = new JokeFactory().CreateJoke("joke2");
            Joke joke_3 = new JokeFactory().CreateJoke("joke3");
            Joke joke_4 = new JokeFactory().CreateJoke("joke4");
            Joke joke_5 = new JokeFactory().CreateJoke("joke5");
            Joke joke_6 = new JokeFactory().CreateJoke("joke6");
            Joke joke_7 = new JokeFactory().CreateJoke("joke7");
            Joke joke_8 = new JokeFactory().CreateJoke("joke8");
            Joke joke_9 = new JokeFactory().CreateJoke("joke9");
            Joke joke_10 = new JokeFactory().CreateJoke("joke10");
            Joke joke_11 = new JokeFactory().CreateJoke("joke11");
            Joke joke_12 = new JokeFactory().CreateJoke("joke12");
            Joke joke_message = new JokeFactory().CreateJoke("jokemessage");

            if (HttpContext.Session.GetString("jokesession") == null)
            {
                // Add jokes to list and set session!
                jokeList.Add(joke_1);
                jokeList.Add(joke_2);
                jokeList.Add(joke_3);
                jokeList.Add(joke_4);
                jokeList.Add(joke_5);
                jokeList.Add(joke_6);
                jokeList.Add(joke_7);
                jokeList.Add(joke_8);
                jokeList.Add(joke_9);
                jokeList.Add(joke_10);
                jokeList.Add(joke_11);
                jokeList.Add(joke_12);
                jokeList.Add(joke_message);
                HttpContext.Session.SetObjectAsJson("jokesession", jokeList);
            }
            else
            {
                // Get session, add jokes to list and set session!
                jokeList = HttpContext.Session.GetObjectFromJson<List<Joke>>("jokesession");
                jokeList.Add(joke_1);
                jokeList.Add(joke_2);
                jokeList.Add(joke_3);
                jokeList.Add(joke_4);
                jokeList.Add(joke_5);
                jokeList.Add(joke_6);
                jokeList.Add(joke_7);
                jokeList.Add(joke_8);
                jokeList.Add(joke_9);
                jokeList.Add(joke_10);
                jokeList.Add(joke_11);
                jokeList.Add(joke_12);
                jokeList.Add(joke_message);
                HttpContext.Session.SetObjectAsJson("jokesession", jokeList);
            }

                // Using statements for the availability of jokes depends on user choice!
                int userInput;
                if (age >= 18 && language.ToLower() == "dk") { userInput = 1; }
                else if (age >= 18 && language.ToLower() == "en") { userInput = 2; }
                else if (age <= 17 && language.ToLower() == "dk") { userInput = 3; }
                else if (age <= 17 && language.ToLower() == "en") { userInput = 4; }
                else { userInput = 5; }

                switch (userInput)
                {
                    case 1:
                        jokeList.RemoveAll(x => x.Category == "English Adult joke");
                        jokeList.RemoveAll(x => x.Category == "English Kids joke");
                        jokeList.RemoveAll(x => x.Category == "Importent Message");
                        break;
                    case 2:
                        jokeList.RemoveAll(x => x.Category == "Danish Adult joke");
                        jokeList.RemoveAll(x => x.Category == "Danish Kids joke");
                        jokeList.RemoveAll(x => x.Category == "Importent Message");
                    break;
                    case 3:
                        jokeList.RemoveAll(x => x.Category == "Danish Adult joke");
                        jokeList.RemoveAll(x => x.Category == "English Adult joke");
                        jokeList.RemoveAll(x => x.Category == "English Kids joke");
                        jokeList.RemoveAll(x => x.Category == "Importent Message");
                    break;
                    case 4:
                        jokeList.RemoveAll(x => x.Category == "English Adult joke");
                        jokeList.RemoveAll(x => x.Category == "Danish Adult joke");
                        jokeList.RemoveAll(x => x.Category == "Danish Kids joke");
                        jokeList.RemoveAll(x => x.Category == "Importent Message");
                    break;
                    case 5:
                        jokeList.RemoveAll(x => x.Category == "Danish Adult joke");
                        jokeList.RemoveAll(x => x.Category == "Danish Kids joke");
                        jokeList.RemoveAll(x => x.Category == "English Adult joke");
                        jokeList.RemoveAll(x => x.Category == "English Kids joke");
                        break;
                    default:
                        break;
                }

            // Using Random to generate random joke!
            Random ran = new Random();

            // Create list for random joke!
            List<Joke> randomJoke = new();

            for (int i = 0; i < 1; i++)
            {
                int index = ran.Next(jokeList.Count);

                randomJoke.Add(jokeList[index]);
            }
            return randomJoke;
        }
    }
}
