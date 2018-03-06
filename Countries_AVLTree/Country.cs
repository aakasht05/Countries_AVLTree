using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries_AVLTree
{
    class Country : IComparable<Country>
    {
        private string countryName;
        private float gdpGrowth = 0;
        private float inflation = 0;
        private float tradeBalance = 0;
        private float hdiRanking = 0;
        private string[] tradePartners;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public float GDPGrowth
        {
            get { return gdpGrowth; }
            set { gdpGrowth = value; }
        }

        public float Inflation
        {
            get { return inflation; }
            set { inflation = value; }
        }

        public float TradeBalance
        {
            get { return tradeBalance; }
            set { tradeBalance = value; }
        }

        public float HDIRanking
        {
            get { return hdiRanking; }
            set { hdiRanking = value; }
        }

        public string[] TradePartners
        {
            get { return tradePartners; }
            set { tradePartners = value; }
        }

        public int CompareTo(Country obj)
        {
            return this.CountryName.CompareTo(obj.CountryName);
        }

        public override string ToString()
        {
            return this.CountryName;
        }
    }
}
