﻿namespace FizzBuzz
{
    public class Kalkylator
    {
        public static string FizzBuzzKalkyl(int nummer)
        {
            if (nummer % 3 == 0) return "FIZZ";
            else if (nummer % 5 == 0) return "BUZZ";
            else if (nummer % 5 == 0 && nummer % 3 == 0) return "FIZZBUZZ";
            return nummer.ToString();

          
        }
        
        
    }
}