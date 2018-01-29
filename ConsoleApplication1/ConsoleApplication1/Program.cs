using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeechLib;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            SpVoice voice = new SpVoice();
            voice.Volume = 15;
            voice.Speak("please wait", SpeechVoiceSpeakFlags.SVSFlagsAsync);

            Console.WriteLine("yohoho");
            string answer = String.Empty;
            answer = Console.ReadLine();

            for (int i = 1; i <= 100; ++i)
            {
                drawTextProgressBar(i, 100);
                //Thread.Sleep()
                System.Threading.Thread.Sleep(20);
            }

            Console.WriteLine(" ");
            Console.WriteLine("No comprende :" + answer);
            answer = Console.ReadLine();
        }

        //public async Task MyMethodAsync()
        //{
        //    Task<int> longRunningTask = LongRunningOperationAsync();
        //    // independent work which doesn't need the result of LongRunningOperationAsync can be done here

        //    //and now we call await on the task
        //    int result = await longRunningTask;
        //    //use the result
        //    Console.WriteLine(result);
        //}

        //public async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation
        //{
        //    await Task.Delay(1000); // 1 second delay
        //    return 1;
        //}

        private static void drawTextProgressBar(int progress, int total)
        {
            //draw empty progress bar
            Console.CursorLeft = 0;
            Console.Write("["); //start
            Console.CursorLeft = 32;
            Console.Write("]"); //end
            Console.CursorLeft = 1;
            float onechunk = 30.0f / total;

            //draw filled part
            int position = 1;
            for (int i = 0; i < onechunk * progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw unfilled part
            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            ////draw totals
            Console.CursorLeft = 35;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}