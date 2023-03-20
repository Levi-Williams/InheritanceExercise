using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var penguin = new Bird();

            penguin.canFly = false;
            penguin.environmentsLived = "Arctic";
            penguin.eatsMeat = true;
            penguin.wingspan = 30;
            penguin.amountOfLegs = 2;

            Console.WriteLine($"Let me tell you some facts about the penguin! " +
                $"Can it fly?   {penguin.canFly}" +
                $"  Where does it live?     {penguin.environmentsLived}" +
                $"  Does it eat meat?   {penguin.eatsMeat}" +
                $"  What is its wingspan?   {penguin.wingspan}" +
                $"  Want to know how many legs it has?  {penguin.amountOfLegs}");

            Console.WriteLine("Finally, want to hear what it sounds like?");

            penguin.MakeBirdNnoises();


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var komodoDragon = new Reptile();
            komodoDragon.canSlither = false;
            komodoDragon.isWarmBlooded = false;
            komodoDragon.livesOnLand = true;
            komodoDragon.eatsMeat = true;
            komodoDragon.favoriteFood = "Deer";

            Console.WriteLine($"Let me tell you some facts about the Komodo Dragon now!" +
                $"Does it slither?  {komodoDragon.canSlither}" +
                $"  Is it warm blooded?     {komodoDragon.isWarmBlooded}" +
                $"  Does it live primarily on land?     {komodoDragon.livesOnLand}" +
                $"  Does it eat meat?   {komodoDragon.eatsMeat}" +
                $"  What is its favorite food?  {komodoDragon.favoriteFood}");
        }
    }
}
