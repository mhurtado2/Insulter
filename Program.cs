using System;
using System.Collections.Generic;
using System.Linq; //gives you methods bitch

namespace Insulter

{
class Program 
    {
        static void Main(string[] args)
        {



//make blank list to add things to
    List<int> insultList = new List<int>(){};

    //make a list of the insults 
    List<string> insults = new List<string>() {
     "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
 }; 

    //randomizer c#sharp function

    // you have a random function that picks a random number that will correspond to the index of the in insult list
    //gives you an int
    int Picker(int min, int max)
    {
        int insultValue = new Random().Next(min, max);
        return insultValue;
    }


//your program should spit out three insults at end 
//while insultlist(blank list) is less than three (list indexes also start at zero, so it will be two 0,1,2)

        while(insultList.Count < 3){
            //pick will pick a random int index of insults between 0, 6 there are 7
            //store this function in a variable
            int insult1 = Picker(0, insults.Count - 1);
            //if insult list does not include corresponding int insult list number
            if(!insultList.Contains(insult1))
            {
                //add that int index to insultlist
                insultList.Add(insult1);
                //so now you have three random numbers added on to insultlist
            }
        };

        //now you need to access the string of words, from its insultlist index
        //make a display function that will write out the string of words
        //give it a parameter of insults, and random

        void Display(List<string> insults, int Random){
                Console.WriteLine($"{insults[Random]}");
        }

        //now tie 
        for(int i = 0; i < insultList.Count; i++)
        {
            //int index assigned value will be a int
            int index = insultList[i];

        //display function will take that number and relate it back to the string lust of insults
            Display(insults, index);
        }
     }
   }
}