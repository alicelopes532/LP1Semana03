using System;

namespace HeroPerk
{
    [Flags]
    public enum Perks
    {
        None = 0,
        WarpShift = 1,
        Stealth = 2,
        AutoHeal = 4,
        DoubleJump = 8
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
                return;
            }
            string input = args[0];
            Perks perks = Perks.None;

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w':
                        perks ^= Perks.WarpShift;
                        break;
                    case 'a':
                        perks ^= Perks.Stealth;
                        break;
                    case 's':
                        perks ^= Perks.AutoHeal;
                        break;
                    case 'd':
                        perks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }
            if (perks == Perks.None)
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
            }
            else
            {
                Console.WriteLine(GetPerkString(perks));

                if ((perks & Perks.Stealth) != 0 && (perks & Perks.DoubleJump) != 0)
                {
                    Console.WriteLine("!Silent jumper!");
                }
                if ((perks & Perks.AutoHeal) == 0)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }
        }
        static string GetPerkString(Perks perks)
        {
            var perkList = new System.Collections.Generic.List<string>();

            if ((perks & Perks.WarpShift) != 0)
                perkList.Add("WarpShift");
            if ((perks & Perks.Stealth) != 0)
                perkList.Add("Stealth");
            if ((perks & Perks.AutoHeal) != 0)
                perkList.Add("AutoHeal");
            if ((perks & Perks.DoubleJump) != 0)
                perkList.Add("DoubleJump");

            return string.Join(", ", perkList);
        }
    }
}