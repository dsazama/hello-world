﻿using System;
using System.Collections.Generic;
namespace hwapp
{
    /*public class Address
	{
		public string StreetAddress { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string State { get; set; } = string.Empty;
		public string PostalCode { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
	}
	public class Person
	{
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public Address ShippingAddress { get; set; }
	}
	public class Company
	{
		public string Name { get; set; } = string.Empty;
		public Address ShippingAddress { get; set; }
	}*/
	class Person
	{
		public string name;
		public Person(string s)
		{
			this.name = s;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Person> newPersonList = new List<Person>();
			newPersonList.Add(new Person("Dave"));
			// PersonList.Add(new Person.LastName("Sazama"));
			// PersonList.Add(new listPerson.ShippingAddress.StreetAddress("910 Gazell Trail"));
			// PersonList.Add(new listPerson.ShippingAddress.City("Winter Springs"));
			// PersonList.Add(new listPerson.ShippingAddress.State("FL"));
			// PersonList.Add(new listPerson.ShippingAddress.PostalCode("32708"));
			// PersonList.Add(new listPerson.ShippingAddress.Country("USA"));
			foreach(Person entry in newPersonList)
			{
				System.Console.WriteLine(entry.name);
				// System.Console.WriteLine(entry.ShippingAddress.StreetAddress);
				// System.Console.WriteLine(entry.ShippingAddress.City);
				// System.Console.WriteLine(entry.ShippingAddress.State);
				// System.Console.WriteLine(entry.ShippingAddress.PostalCode);
				// System.Console.WriteLine(entry.ShippingAddress.Country);
			}
		}
	}
	/*
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Dave"; //This is my name
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
						number = number/candidateFactor; // divide number by the factor you found and assign this back to number
						if (number > 1)
						{
							Console.Write(", "); // print a comma if number is still greater than 1
						}
					}
					candidateFactor = candidateFactor +1;; // don't forget to increment factor!
				}
			}
			Console.WriteLine();

			List<string> gifts = new List<string>();
			Console.WriteLine("Dave's Gift List");
			while (true)
			{
				Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
				string listCommand = Console.ReadLine();
				if (listCommand == "--")
				{
					gifts.Clear();
					Console.WriteLine("Dave's Gift List has been cleared!  Awww shucks!");
				}
				if (listCommand.Substring(0,2) == "+ ")
				{
					string listAdd = listCommand.Substring(2);
					gifts.Add(listAdd);
					Console.WriteLine("You have added an item to the list! Here is the new list:");
					gifts.ForEach(Console.WriteLine);
				}
				if (listCommand.Substring(0,2) == "- ")
				{
					string listRemove = listCommand.Substring(2);
					gifts.Remove(listRemove);
					Console.WriteLine("You have removed an item from the list! Here is the new list:");
					gifts.ForEach(Console.WriteLine);
				}
			}
			var myList = new List<int>() { 2, 4, 6 };
			int mySum = 0;
			int myListIndex = 0;
			int myListValue = 0;
			Console.Write("Numbers: ");
			while (myListIndex < myList.Count)
			{
				myListValue = myList[myListIndex];
				Console.Write($"{myListValue} ");
				mySum = mySum + myListValue;
				myListIndex++;
			}
			Console.WriteLine();
			Console.WriteLine($"Sum: {mySum}");
			
			List<string> gifts = new List<string>();
			Console.WriteLine("Dave's Gift List");

			void ListClear()
			{
				gifts.Clear();
				Console.WriteLine("Dave's Gift List has been cleared! Aww Shucks!");
			}
			
			string ListAdd(string listAdd)
			{
				gifts.Add(listAdd);
				return($"You have added {listAdd} to the list!");
			}
			string ListRemove(string listRemove)
			{
				gifts.Remove(listRemove);
				return($"You have removed {listRemove} from the list!");
			}
			void ListShow()
			{
				Console.WriteLine("Here is the current gift list:");
				gifts.ForEach(Console.WriteLine);
			}

			while(true)
			{
				Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
				string listCommand = Console.ReadLine();
				if (listCommand == "--")
				{
					ListClear();
					ListShow();
				}
				if (listCommand.Substring(0,2) == "+ ")
				{
					string listAdd = listCommand.Substring(2);
					Console.WriteLine(ListAdd(listAdd));
					ListShow();
				}
				if (listCommand.Substring(0,2) == "- ")
				{
					string listRemove = listCommand.Substring(2);
					Console.WriteLine(ListRemove(listRemove));
					ListShow();
				}
			}
		}
    }*/
}
