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
int Picker(int min, int max)
{
    int insultValue = new Random().Next(min, max);
    return insultValue;
}

void Display(List<string> insults, int Random){
        Console.WriteLine($"{insults[Random]}");
}

// Console.WriteLine(insultList);
 

//make a list to add insults to

while(insultList.Count < 3){
    int insult1 = Picker(0, insults.Count - 1);
    if(!insultList.Contains(insult1))
    {
        insultList.Add(insult1);
    }
};

for(int i = 0; i < insultList.Count; i++)
{
    int index = insultList[i];

    Display(insults, index);
}

        }

 }
}