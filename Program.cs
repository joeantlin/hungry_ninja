using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet1 = new Buffet();
            Ninja ninja1 = new Ninja();
            // System.Console.WriteLine(buffet1.Serve().Name);
            ninja1.Eat(buffet1.Serve());
            ninja1.Eat(buffet1.Serve());
            ninja1.Eat(buffet1.Serve());
            ninja1.Eat(buffet1.Serve());
        }
    }
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
        public Food(string name, int cal, bool spice, bool sweet){
            Name = name;
            Calories = cal;
            IsSpicy = spice;
            IsSweet = sweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Crap", 645, true, true),
                new Food("Rice", 485, false, true),
                new Food("Pie", 347, false, true),
                new Food("Ice", 576, true, true),
                new Food("Dirt", 226, true, false),
                new Food("Pizza", 845, false, false),
                new Food("Cheese", 142, true, false)
            };
        }
        public Food Serve()
        {
            Random num = new Random();
            return Menu[num.Next(7)];
        }
    }
    class Ninja
    {
        private int CalorieIntake;
        public List<Food> FoodHistory;
        public Ninja()
        {
            CalorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        public bool IsFull
        {
            get
            {
                if (CalorieIntake >= 1200)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }
        public int ninjaCalories
        {
            get 
            {
                return CalorieIntake; 
            }
        }
        public void Eat(Food item)
        {
            if (IsFull)
            {
                System.Console.WriteLine("Sorry, too full to eat more.");
            }
            else
            {
                FoodHistory.Add(item);
                CalorieIntake += item.Calories;
                System.Console.WriteLine("Yum More Food!");
            }
        }
    }
}
