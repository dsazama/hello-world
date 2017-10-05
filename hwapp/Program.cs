using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var name = "Dave"; //This is my name
			string greeting = "Hola ";
			Console.WriteLine(greeting + name + "!");
			
			DateTime christmas = new DateTime(DateTime.Today.Year, 12, 25);
			TimeSpan duration = christmas - DateTime.Today;
			Console.WriteLine($"There are {duration.TotalDays} days left until Christmas!");
			
			var birthDay = new DateTime(1969,10,18);
			TimeSpan daysOld = DateTime.Today - birthDay;
			Console.WriteLine($"You are {daysOld.TotalDays} days old today!");
			var daysAge = daysOld.TotalDays;
			var daysToNextAnniversary = 10000 - (daysAge % 10000);
			Console.WriteLine($"Your next 10,000 day anniversary is in {daysToNextAnniversary} days!");
			
			 Console.WriteLine("What is the capital of Ohio?");
			var answer = Console.ReadLine();
			if (answer.ToLower() == "columbus")
			{
				Console.WriteLine("Correct!");
			}
			else
			{
				Console.WriteLine("Sorry, that's not the right answer.");
			} 
			Console.WriteLine("Guess a number between 1 and 3!");
			int correctNumber = new Random().Next(3) +1;
			int guessedNumber = int.Parse(Console.ReadLine());
			if (guessedNumber < correctNumber)
			{
				Console.WriteLine("You guessed too low!");
			}
			else if (guessedNumber > correctNumber)
			{
				Console.WriteLine("You guessed too high!");
			}
			else
			{
				Console.WriteLine("Correct!");
			}
			
			var currentTime = new DateTime(2017,09,22,23,0,0);
			var currentHour = currentTime.Hour;
			if (currentHour < 12)
			{
				Console.WriteLine("Good Morning!");
			}
						if (currentHour >= 12 && currentHour <= 17)
			{
				Console.WriteLine("Good Afternoon!");
			}
						if (currentHour > 17 && currentHour < 22)
			{
				Console.WriteLine("Good Evening!");
			}
						if (currentHour >= 22)
			{
				Console.WriteLine("Good Night!");
			}
			*/
			Console.WriteLine("Enter a number:");
			int number = int.Parse(Console.ReadLine());
			Console.Write("Factors: ");
			while (number > 1) // convert this to while
			{
				int candidateFactor = 2;
				while (candidateFactor <= number) // convert this to while
				{
					if (number % candidateFactor == 0) // found a factor
					{
						Console.Write(candidateFactor);
						// divide number by the factor you found and assign this back to number
						// print a comma if number is still greater than 1
					}
					// don't forget to increment factor!
				}
			}
			Console.WriteLine();
		}
    }
}
