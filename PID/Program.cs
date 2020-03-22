using System;
using System.Diagnostics;

namespace PID
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = Process.GetCurrentProcess();
            Console.WriteLine(process.Id);
            Console.ReadLine();
        }
    }
}
