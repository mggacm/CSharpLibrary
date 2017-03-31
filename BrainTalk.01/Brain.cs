using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace BrainTalk._01
{
    class Brain
    {
        public static void Counting()
        {
            int startingPoint = 0;
            for (int i = 0; i <= 200; i = i + 10)
            {
                startingPoint = i;

                if (i % 3 == 0)
                {
                    SpeechSynthesizer talk = new SpeechSynthesizer();
                    string toStr = i.ToString();
                    Console.WriteLine(i);
                    talk.Speak(toStr + " is divisible by 3");
                }
                else
                {
                    Console.WriteLine(startingPoint);
                }

                
            }

        }
    }
}
