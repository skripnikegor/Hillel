using HW11.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Models
{
    public class GreetingsGenerator : IGreetingsGenerator
    {
        private List<string> greetins = new List<string>(){
            "Hello!",
            "Hi!",
            "Hey!",
            "Greetings!",
            "Good morning!",
            "Good afternoon!",
            "Good evening!",
            "Howdy!",
            "Hi there!",
            "Hey there!",
            "Yo!",
            "Hiya!",
            "Hello there!",
            "Hey ya!",
            "Hi folks!",
            "Hello everyone!",
            "Hi friends!",
            "Hey buddies!",
            "Greetings and salutations!",
            "Welcome!"};
        public Random random = new Random();
        public string ReturnRandomGreeting()
        {
            return greetins[random.Next(0, greetins.Count())];
        }
    }
}
