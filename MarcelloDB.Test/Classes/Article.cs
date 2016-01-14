﻿using System;

namespace MarcelloDB.Test.Classes
{
    public class Article
    {
        public Article ()
        {
        }

        public string Name{ get; set;}

        public string Description { get; set; }

        public int ID{ get; set;}

        public static Article ToiletPaper
        {
            get{ return new Article(){ ID = 1, Name = "Toilet Paper", Description = "The finest paper money can buy" }; }
        }

        public static Article SpinalTapDvd
        {
            get{ return new Article(){ ID=2, Name = "DVD: This is Spinal Tap", Description = "Best dvd ever" }; }
        }

        public static Article BarbieDoll
        {
            get{ return new Article(){ ID=3, Name = "Barbie Doll", Description = "Some doll" }; }
        }
    }

    public class Food : Article
    {
        public DateTime Expires {get;set;}

        public static Food Bread
        {
            get{ return new Food{ ID = 4, Expires = DateTime.Now.AddDays(2), Name = "Bread" };}
        }
    }
}

