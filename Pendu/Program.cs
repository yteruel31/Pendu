using PenduLib.Base;

namespace PenduConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PenduBase pendu = new PenduBase();
            while (pendu.TriesRemining < 9)
            {
                pendu.Create();
            }
        }
    }
}