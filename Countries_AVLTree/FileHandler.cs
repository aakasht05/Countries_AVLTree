using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Countries_AVLTree
{
    class FileHandler
    {


        public static void readCSVIntoCountryArrayObject(string location, Country[] countryArray)
        {
            int i = 0;
            string[] headers = new string[6]; //column headers
            const int MAX_LINES_FILE = 50000;
            string[] AllLines = new string[MAX_LINES_FILE];

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(location);
            foreach (string line in AllLines)
            {
                if (line == null)
                    continue;
                if (line.StartsWith("Country")) //found first line - headers
                {
                    headers = line.Split(',');
                }
                else
                {
                    Country country = new Country();
                    //split data using commas
                    string[] columns = line.Split(',');
                    Console.Write(columns[0] + ","); //first string in line;
                    country.CountryName = columns[0];
                    Console.Write(columns[1] + ","); //2nd string in line;
                    country.GDPGrowth = float.Parse(columns[1]);
                    Console.Write(columns[2] + ",");
                    country.Inflation = float.Parse(columns[2]);
                    Console.Write(columns[3] + ",");
                    country.TradeBalance = float.Parse(columns[3]);
                    Console.Write(columns[4] + ",");
                    country.HDIRanking = float.Parse(columns[4]);

                    string[] partners = columns[5].Split(';', '[', ']');

                    partners = partners.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                    country.TradePartners = partners;

                    foreach (string tradePartner in partners)
                    {
                        if (tradePartner != "")
                        {
                            Console.Write(":" + tradePartner);

                        }
                    }
                    countryArray[i] = country;
                    i++;
                }
                Console.WriteLine();

            }
        }
    }
}
