using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Little feel good app made to cheer people up, it sucks though.
/// 2019-11-10
/// </summary>
namespace uhhhhhhhhhh
{
    class Happiness 
    {
        public const int FEW_FRIENDS = 4;
        public const int OK_FRIENDS = 8;
        public const int MAX_COFFEE = 2;
        public const int BAD_NOTES = 40;
        public const int OK_NOTES = 75;

        public string favFood, bestFriendName;
        public string amountOfFriends, coffeeDrunkInADay;
        public string highestNoteInSchool;

        public Happiness(string favFood, string bestFriendName, string amountOfFriends, string coffeeDrunkInADay, string highestNoteInSchool)
        {
            this.favFood = favFood;
            this.bestFriendName = bestFriendName;
            this.amountOfFriends = amountOfFriends;
            this.coffeeDrunkInADay = coffeeDrunkInADay;
            this.highestNoteInSchool = highestNoteInSchool;
        }

        public void WhyAreYouHappy()
        {
            // Favorite food message
            Console.WriteLine("So your favorite food is: {0}! That's cool! You should eat that soon, it will cheer you up <3", favFood);
            Console.ReadKey();

            // Best Friend message
            Console.WriteLine("Your best friend is: {0}! I'm sure they love you as much as you do <3", bestFriendName);
            Console.ReadKey();

            // How many friends message

            bool hasWorked = Int32.TryParse(amountOfFriends, out int nbFriends);
            while (!hasWorked)
            {
                Console.WriteLine("Why are you trying to break my game </3");
                Console.WriteLine("Please enter something valid now <3");
                amountOfFriends = Console.ReadLine();
                hasWorked = Int32.TryParse(amountOfFriends, out nbFriends);
            }
                
           
            if (nbFriends < FEW_FRIENDS)
            {
                Console.WriteLine("Only {0} friends? That's pretty sad :(. I know making friends is hard but you should maybe try a bit more or change how you behave :(", nbFriends);
            }
            else if (nbFriends < OK_FRIENDS)
            {
                Console.WriteLine("{0} friends? Thats plenty to keep anyone satisfied! You're doing great <3", nbFriends);
            }
            else
            {
                Console.WriteLine("{0} friends? Woah that's a lot! Good work, I hope you love them all equally <3", nbFriends);
            }
                  
            Console.ReadKey();

            hasWorked = Int32.TryParse(coffeeDrunkInADay, out int coffee);
            while (!hasWorked)
            {
                Console.WriteLine("Why are you trying to break my game </3");
                Console.WriteLine("Please enter something valid now <3");
                coffeeDrunkInADay = Console.ReadLine();
                hasWorked = Int32.TryParse(coffeeDrunkInADay, out coffee);
            }

            if (coffee < MAX_COFFEE)
            {
                Console.WriteLine("{0} cup of coffee? That is reasonable! The fewer you take the better (Except if it's end of semester working time, then I get your struggle)", coffee);
            }
            else
            {
                Console.WriteLine("{0} cups of coffee? WOAH! You really should lower your coffee intake :( (Except if it's end of semester working time, then I get your struggle)", coffee);
            }
                     
            Console.ReadKey();

            // Notes message

            hasWorked = Int32.TryParse(highestNoteInSchool, out int result);
            while (!hasWorked)
            {
                Console.WriteLine("Why are you trying to break my game </3");
                Console.WriteLine("Please enter something valid now <3");
                highestNoteInSchool = Console.ReadLine();
                hasWorked = Int32.TryParse(highestNoteInSchool, out result);
            }
            if (result < BAD_NOTES)
            {
                Console.WriteLine("{0}% ? WOAH! That's very low :(. I'm sure you can claw it back though :)", result);
            }
            else if (result < OK_NOTES)
            {
                Console.WriteLine("{0}% ? WOAH! That's fair, but I'm certain you can do even better! :)", result);
            }
            else
            {
                Console.WriteLine("{0}% ? GOOD JOB <3. You're doing pretty great and should be proud of yourself :) ", result);
            }
                      
            Console.ReadKey();
        }
    }
    class HappyDetails
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is favorite food");
            string favfood = Console.ReadLine();
            Console.WriteLine("Who is your best friend?");
            string bestFriendName = Console.ReadLine();
            Console.WriteLine("How many friends do you have");
            string amountOfFriends = Console.ReadLine();
            Console.WriteLine("How many cups of coffee did you drink this morning?");
            string coffeeDrunkInADay = Console.ReadLine();
            Console.WriteLine("What was you highest grade this semester (in %) ?");
            string highestNoteInSchool = Console.ReadLine();
            Happiness smile1 = new Happiness(favfood, bestFriendName, amountOfFriends, coffeeDrunkInADay, highestNoteInSchool);
            

            smile1.WhyAreYouHappy();
            Console.ReadKey();
        }
    }
}
