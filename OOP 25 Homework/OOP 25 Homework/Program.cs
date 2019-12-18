using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_25_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundTable<Knight> RTK = new RoundTable<Knight>();

            RTK.Add(new Knight("amik varze", "falador", "sir"));
            RTK.Add(new Knight("yharim", "lihzhardia", "tyrant"));
            RTK.Add(new Knight("kumstance", "varrock", "sir"));
            RTK.Add(new Knight("yharim", "jerusalem", "guard"));
            RTK.InsertAt(3, new Knight("artorias", "lordran", "knight"));

            RoundTable<Wizard> RTW = new RoundTable<Wizard>();

            RTW.Add(new Wizard("harry potter", "under the stairs", "avada kedavra"));
            RTW.Add(new Wizard("griggs", "vinheim", "soul arrow"));
            RTW.Add(new Wizard("wise old man", "draynor village", "telegrab"));
            RTW.Add(new Wizard("obi wan", "far far away", "force push")); // do space wizards count?

            List<Knight> roundedKnights = RTK.GetRounded(9);

            foreach (Knight item in roundedKnights)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine(RTK["artorias"]);
            Console.WriteLine(RTW["obi wan"]);
            Console.WriteLine(RTK[3]);
            Console.WriteLine(RTW[2]);

            Console.WriteLine("------------------------------");

            List<Wizard> roundedWizards = RTW.GetRounded(36);
            roundedWizards.ForEach(w => Console.WriteLine(w));
        }
    }
}
