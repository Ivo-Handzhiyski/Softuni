using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long entrance = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long rocks = 0;
            long money = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long amount = long.Parse(safe[i + 1]);

                string whatIsTheType = string.Empty;

                if (name.Length == 3)
                {
                    whatIsTheType = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    whatIsTheType = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    whatIsTheType = "Gold";
                }

                if (whatIsTheType == "")
                {
                    continue;
                }
                else if (entrance < bag.Values.Select(x => x.Values.Sum()).Sum() + amount)
                {
                    continue;
                }

                switch (whatIsTheType)
                {
                    case "Gem":
                        if (!bag.ContainsKey(whatIsTheType))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (amount > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[whatIsTheType].Values.Sum() + amount > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(whatIsTheType))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (amount > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[whatIsTheType].Values.Sum() + amount > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(whatIsTheType))
                {
                    bag[whatIsTheType] = new Dictionary<string, long>();
                }

                if (!bag[whatIsTheType].ContainsKey(name))
                {
                    bag[whatIsTheType][name] = 0;
                }

                bag[whatIsTheType][name] += amount;
                if (whatIsTheType == "Gold")
                {
                    gold += amount;
                }
                else if (whatIsTheType == "Gem")
                {
                    rocks += amount;
                }
                else if (whatIsTheType == "Cash")
                {
                    money += amount;
                }
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}