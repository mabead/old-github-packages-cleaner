using System;
using System.Threading.Tasks;

namespace OldGitHubPackagesCleaner
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello GitHub actions!");
            foreach (var arg in args)
            {
                Console.WriteLine($"  arg: {arg}");
                await Task.Delay(50);
            }
        }
    }
}
