﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class MainScreen
    {

        public static void Main()
        {

            Console.WriteLine("Hello world!");
            //project:
            //wordle
            //game mechanics: choose a word length then "generate" word. let user try different words. mark green letters in correct place, mark yellow 
            //correct letters but incorrect placement. Number of attempts = number of letters+1.

            //step 1: create a group of words with different letters.
            //step 2: create main game loop.
            //step 2.1: let user choose number of letters. if incorrect repeat the question.
            //step 2.2: 

            WordGenerator generate = new WordGenerator();

            string gen = generate.ThreeLetters();

            Console.WriteLine($"{gen} was generated!");

        }


    }
}