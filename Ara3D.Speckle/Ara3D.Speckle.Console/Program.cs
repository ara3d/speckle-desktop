using Ara3D.Speckle.Data;
using Speckle.Core.Models;

namespace Ara3D.Speckle.Console
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //SpeckleDemo.Main(args);
            SpeckleDemo.ReadFromDisk();
            System.Console.WriteLine($"Press any key to continue ...");
            System.Console.ReadKey();
        }
    }
}
