using System;

namespace HWIDSpoofer
{
    class Program
    {
        static void Main(string[] args)
        {
        begin:
            Console.Title = "Hwid Spoofer";
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("  ┌─────────────────────────────────────────┐");
            Console.WriteLine("  │ [1] Spoof HWID                          │");
            Console.WriteLine("  │ [2] Spoof Guid                          │");
            Console.WriteLine("  │ [3] Spoof your Computer Name            │");
            Console.WriteLine("  │ [4] Spoof ProductId                     │");
            Console.WriteLine("  │ [0] Quit                                │");
            Console.WriteLine("  └─────────────────────────────────────────┘");

            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                if (Spoofer.HWID.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.HWID.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.HWID.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "2")
            {
                Console.Clear();
                if (Spoofer.PCGuid.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.PCGuid.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.PCGuid.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "3")
            {
                Console.Clear();
                if (Spoofer.PCName.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.PCName.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.PCName.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "4")
            {
                Console.Clear();
                if (Spoofer.ProductId.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.ProductId.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.ProductId.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "0")
            {
                Environment.Exit(0);
            }
            else
            {
                goto begin;
            }
        }
    }
}
