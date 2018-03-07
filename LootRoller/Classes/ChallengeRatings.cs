using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootRoller.Classes
{
    class ChallengeRatings
    {
        //Magic Item Compendium page 266 - 267

        #region Coins
        /// <summary>
        /// Copper Pieces.
        /// </summary>
        private static string cp = "cp";
        /// <summary>
        /// Silver Pieces.
        /// </summary>
        private static string sp = "sp";
        /// <summary>
        /// Gold Pieces.
        /// </summary>
        private static string gp = "gp";
        /// <summary>
        /// Platinum Pieces.
        /// </summary>
        private static string pp = "pp";

        public string CoinsByLevel(int _level, int _rolled)
        {
            string result = "";
            switch (_level)
            {
                case 1: result = CrOneCoins(_rolled); break;
                case 2: result = CrTwoCoins(_rolled); break;
                case 3: result = CrThreeCoins(_rolled); break;
                case 4: result = CrFourCoins(_rolled); break;
                case 5: result = CrFiveCoins(_rolled); break;
                case 6: result = CrSixCoins(_rolled); break;
                case 7: result = CrSevenCoins(_rolled); break;
                case 8: result = CrEightCoins(_rolled); break;
                case 9: result = CrNineCoins(_rolled); break;
                case 10: result = CrTenCoins(_rolled); break;
                case 11: result = CrElevenCoins(_rolled); break;
                case 12: result = CrTwelveCoins(_rolled); break;
                case 13: result = CrThirteenCoins(_rolled); break;
                case 14: result = CrFourteenCoins(_rolled); break;
                case 15: result = CrFifteenCoins(_rolled); break;
                case 16: result = CrSixteenCoins(_rolled); break;
                case 17: result = CrSeventeenCoins(_rolled); break;
                case 18: result = CrEighteenCoins(_rolled); break;
                case 19: result = CrNineteenCoins(_rolled); break;
                case 20: result = CrTwentyCoins(_rolled); break;
                default:
                    break;
            }
            return result;
        }

        public string CrOneCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: break;
                case 2: amount = 1000 * D(4); cointype = cp; break;
                case 3: amount = 100 * D(4); cointype = sp; break;
                case 4: amount = 100 * (D(6) + D(6) + D(6)); cointype = sp; break;
                case 5: amount = 100 * (D(4) + D(4) + D(4) + D(4)); cointype = sp; break;
                case 6: amount = 10 * (D(8) + D(8)); cointype = gp; break;
                case 7: amount = 100 * (D(4) + D(4)); cointype = gp; break;
                case 8: amount = 100 * D(6); cointype = gp; break;
                case 9: amount = 100 * (D(4) + D(4)); cointype = gp; break;
                case 10: amount = 10 * D(12); cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrTwoCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = 1000 * (D(12) + D(12)); cointype = cp; break;
                case 2: amount = 100 * (D(6) + D(6) + D(6)); cointype = sp; break;
                case 3: amount = 100 * (D(4) + D(4)); cointype = sp; break;
                case 4: amount = 1000 * D(6); cointype = sp; break;
                case 5: amount = 1000 * D(4); cointype = sp; break;
                case 6: amount = 100 * D(4); cointype = gp; break;
                case 7: amount = 100 * D(10); cointype = gp; break;
                case 8: amount = 100 * D(10); cointype = gp; break;
                case 9: amount = 100 * D(12); cointype = gp; break;
                case 10: amount = 10 * (D(8) + D(8)); cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrThreeCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = 1000 * D(4); cointype = sp; break;
                case 2: amount = 1000 * D(4); cointype = sp; break;
                case 3: amount = 1000 * D(8); cointype = sp; break;
                case 4: amount = 1000 * D(6); cointype = sp; break;
                case 5: amount = 100 * D(8); cointype = sp; break;
                case 6: amount = 100 * D(12); cointype = gp; break;
                case 7: amount = 100 * D(12); cointype = gp; break;
                case 8: amount = 100 * D(12); cointype = gp; break;
                case 9: amount = 100 * D(12); cointype = gp; break;
                case 10: amount = 10 * D(12); cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrFourCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = 1000 * D(8); cointype = sp; break;
                case 2: amount = 1000 * D(6); cointype = sp; break;
                case 3: amount = 1000 * D(8); cointype = sp; break;
                case 4: amount = 1000 * D(10); cointype = sp; break;
                case 5: amount = 100 * D(8); cointype = sp; break;
                case 6: amount = 100 * D(8); cointype = gp; break;
                case 7: amount = 100 * D(12); cointype = gp; break;
                case 8: amount = 100 * D(12); cointype = gp; break;
                case 9: amount = 100 * D(12); cointype = gp; break;
                case 10: amount = 10 * D(12); cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrFiveCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = 1000 * D(12); cointype = sp; break;
                case 2: amount = 1000 * D(8); cointype = sp; break;
                case 3: amount = 1000 * D(10); cointype = sp; break;
                case 4: amount = 1000 * D(12); cointype = sp; break;
                case 5: amount = 1000 * D(6); cointype = sp; break;
                case 6: amount = 100 * D(6); cointype = gp; break;
                case 7: amount = 100 * D(12); cointype = gp; break;
                case 8: amount = 100 * D(12); cointype = gp; break;
                case 9: amount = 100 * D(6); cointype = gp; break;
                case 10: amount = 10 * D(12); cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrSixCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = D(10) * 1000; cointype = sp; break;
                case 2: amount = D(8) * 1000; cointype = sp; break;
                case 3: amount = D(12) * 1000; cointype = sp; break;
                case 4: amount = D(12) * 100; cointype = gp; break;
                case 5: amount = D(8) * 100; cointype = gp; break;
                case 6: amount = (D(6) + D(6)) * 100; cointype = gp; break;
                case 7: amount = (D(6) + D(6)) * 100; cointype = gp; break;
                case 8: amount = (D(8) + D(8)) * 100; cointype = gp; break;
                case 9: amount = D(12) * 100; cointype = gp; break;
                case 10: amount = D(12) * 10; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrSevenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(8) + D(8)) * 1000; cointype = sp; break;
                case 2: amount = (D(6) + D(6)) * 1000; cointype = sp; break;
                case 3: amount = (D(8) + D(8)) * 1000; cointype = sp; break;
                case 4: amount = (D(8) + D(8)) * 100; cointype = gp; break;
                case 5: amount = (D(4) + D(4) + D(4)) * 100; cointype = gp; break;
                case 6: amount = (D(8) + D(8)) * 100; cointype = gp; break;
                case 7: amount = (D(8) + D(8)) * 100; cointype = gp; break;
                case 8: amount = (D(8) + D(8)) * 100; cointype = gp; break;
                case 9: amount = (D(4) + D(4) + D(4)) * 100; cointype = gp; break;
                case 10: amount = (D(8) + D(8)) * 10; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrEightCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(10) + D(10)) * 1000; cointype = sp; break;
                case 2: amount = (D(8) + D(8)) * 1000; cointype = sp; break;
                case 3: amount = (D(8) + D(8)) * 100; cointype = gp; break;
                case 4: amount = (D(10) + D(10)) * 100; cointype = gp; break;
                case 5: amount = (D(4) + D(4) + D(4) + D(4)) * 100; cointype = gp; break;
                case 6: amount = (D(4) + D(4) + D(4) + D(4)) * 100; cointype = gp; break;
                case 7: amount = (D(4) + D(4) + D(4) + D(4)) * 100; cointype = gp; break;
                case 8: amount = (D(10) + D(10)) * 100; cointype = gp; break;
                case 9: amount = (D(10) + D(10)) * 10; cointype = pp; break;
                case 10: amount = (D(10) + D(10)) * 10; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrNineCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(12) + D(12)) * 1000; cointype = sp; break;
                case 2: amount = (D(10) + D(10)) * 1000; cointype = sp; break;
                case 3: amount = (D(10) + D(10)) * 100; cointype = gp; break;
                case 4: amount = (D(6) + D(6) + D(6) + D(6)) * 100; cointype = gp; break;
                case 5: amount = (D(12) + D(12)) * 100; cointype = gp; break;
                case 6: amount = (D(12) + D(12)) * 100; cointype = gp; break;
                case 7: amount = (D(10) + D(10) + D(10)) * 100; cointype = gp; break;
                case 8: amount = (D(10) + D(10) + D(10)) * 100; cointype = gp; break;
                case 9: amount = (D(6) + D(6) + D(6) + D(6)) * 10; cointype = pp; break;
                case 10: amount = (D(12) + D(12)) * 10; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrTenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(8) + D(8) + D(8)) * 1000; cointype = sp; break;
                case 2: amount = (D(12) + D(12)) * 1000; cointype = sp; break;
                case 3: amount = (D(8) + D(8) + D(8)) * 100; cointype = gp; break;
                case 4: amount = (D(4) + D(4) + D(4) + D(4) + D(4) + D(4)) * 100; cointype = gp; break;
                case 5: amount = (D(6) + D(6) + D(6) + D(6)) * 100; cointype = gp; break;
                case 6: amount = (D(6) + D(6) + D(6) + D(6)) * 100; cointype = gp; break;
                case 7: amount = (D(10) + D(10) + D(10)) * 100; cointype = gp; break;
                case 8: amount = (D(10) + D(10) + D(10)) * 10; cointype = pp; break;
                case 9: amount = (D(4) + D(4) + D(4) + D(4) + D(4) + D(4)) * 10; cointype = pp; break;
                case 10: amount = (D(10) + D(10) + D(10)) * 10; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrElevenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(4) + D(4) + D(4) + D(4) + D(4) + D(4)) * 1000; cointype = sp; break;
                case 2: amount = (D(6) + D(6) + D(6) + D(6)) * 1000; cointype = sp; break;
                case 3: amount = (D(6) + D(6) + D(6) + D(6)) * 100; cointype = gp; break;
                case 4: amount = (D(8) + D(8) + D(8) + D(8)) * 100; cointype = gp; break;
                case 5: amount = (D(4) + D(4) + D(4) + D(4) + D(4) + D(4)) * 100; cointype = gp; break;
                case 6: amount = (D(4) + D(4) + D(4) + D(4) + D(4) + D(4)) * 100; cointype = gp; break;
                case 7: amount = (D(10) + D(10) + D(10) + D(10)) * 100; cointype = gp; break;
                case 8: amount = (D(10) + D(10) + D(10) + D(10)) * 10; cointype = pp; break;
                case 9: amount = (D(10) + D(10) + D(10)) * 10; cointype = pp; break;
                case 10: amount = (D(10) + D(10) + D(10) + D(10)) * 10; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrTwelveCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(12) + D(12) + D(12)) * 1000; cointype = sp; break;
                case 2: amount = (D(8) + D(8) + D(8) + D(8)) * 1000; cointype = sp; break;
                case 3: amount = (D(12) + D(12) + D(12)) * 1000; cointype = sp; break;
                case 4: amount = (D(12) + D(12) + D(12)) * 100; cointype = gp; break;
                case 5: amount = D(4)* 1000; cointype = gp; break;
                case 6: amount = D(4) * 1000; cointype = gp; break;
                case 7: amount = D(6) * 1000; cointype = gp; break;
                case 8: amount = D(6) * 100; cointype = pp; break;
                case 9: amount = D(4) * 100; cointype = pp; break;
                case 10: amount = D(6) * 100; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrThirteenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(12) + D(12) + D(12) + D(12)) *100; cointype = gp; break;
                case 2: amount = D(4) * 1000; cointype = gp; break;
                case 3: amount = D(4) * 1000; cointype = gp; break;
                case 4: amount = D(8) * 1000; cointype = gp; break;
                case 5: amount = D(6) * 1000; cointype = gp; break;
                case 6: amount = D(6) * 1000; cointype = gp; break;
                case 7: amount = D(8) * 1000; cointype = gp; break;
                case 8: amount = D(8) * 100; cointype = pp; break;
                case 9: amount = D(6) * 100; cointype = pp; break;
                case 10: amount = D(8) * 100; cointype = pp; break;   
            }
            return amount + " " + cointype;
        }
        public string CrFourteenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = D(6) * 1000; cointype = gp; break;
                case 2: amount = D(6) * 1000; cointype = gp; break;
                case 3: amount = D(6) * 1000; cointype = gp; break;
                case 4: amount = (D(4) + D(4)) * 1000; cointype = gp; break;
                case 5: amount = D(8) * 1000; cointype = gp; break;
                case 6: amount = D(8) * 1000; cointype = gp; break;
                case 7: amount = (D(4) + D(4)) * 1000; cointype = gp; break;
                case 8: amount = (D(4) + D(4)) * 100; cointype = pp; break;
                case 9: amount = D(8) * 100; cointype = pp; break;
                case 10: amount = (D(4) + D(4)) * 100; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrFifteenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(4) + D(4)) * 1000; cointype = gp; break;
                case 2: amount = D(8) * 1000; cointype = gp; break;
                case 3: amount = D(8) * 1000; cointype = gp; break;
                case 4: amount = D(12) * 1000; cointype = gp; break;
                case 5: amount = D(10) * 1000; cointype = gp; break;
                case 6: amount = D(10) * 1000; cointype = gp; break;
                case 7: amount = (D(6) + D(6)) * 100; cointype = pp; break;
                case 8: amount = (D(6) + D(6)) * 100; cointype = pp; break;
                case 9: amount = D(12) * 100; cointype = pp; break;
                case 10: amount = D(12) * 100; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrSixteenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = D(12) * 1000; cointype = gp; break;
                case 2: amount = D(10) * 1000; cointype = gp; break;
                case 3: amount = D(10) * 1000; cointype = gp; break;
                case 4: amount = (D(4) + D(4) + D(4)) * 1000; cointype = gp; break;
                case 5: amount = D(12) * 1000; cointype = gp; break;
                case 6: amount = D(12) * 1000; cointype = gp; break;
                case 7: amount = (D(4) + D(4) + D(4)) * 100; cointype = pp; break;
                case 8: amount = (D(4) + D(4) + D(4)) * 100; cointype = pp; break;
                case 9: amount = (D(6) + D(6)) * 100; cointype = pp; break;
                case 10: amount = (D(4) + D(4) + D(4)) * 100; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrSeventeenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(4) + D(4) + D(4)) * 1000; cointype = gp; break;
                case 2: amount = D(12) * 1000; cointype = gp; break;
                case 3: amount = D(12) * 1000; cointype = gp; break;
                case 4: amount = (D(8) + D(8)) * 1000; cointype = gp; break;
                case 5: amount = (D(4) + D(4) + D(4)) * 1000; cointype = gp; break;
                case 6: amount = (D(4) + D(4) + D(4)) * 1000; cointype = gp; break;
                case 7: amount = (D(8) + D(8)) * 1000; cointype = gp; break;
                case 8: amount = (D(8) + D(8)) * 1000; cointype = gp; break;
                case 9: amount = (D(4) + D(4) + D(4)) * 1000; cointype = gp; break;
                case 10: amount = (D(8) + D(8)) * 1000; cointype = gp; break;
            }
            return amount + " " + cointype;
        }
        public string CrEighteenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(8) + D(8)) * 1000; cointype = gp; break;
                case 2: amount = (D(4) + D(4) + D(4)) * 1000; cointype = gp; break;
                case 3: amount = (D(4) + D(4) + D(4)) * 1000; cointype = gp; break;
                case 4: amount = (D(4) + D(4) + D(4) + D(4)) * 1000; cointype = gp; break;
                case 5: amount = (D(8) + D(8)) * 1000; cointype = gp; break;
                case 6: amount = (D(8) + D(8)) * 1000; cointype = gp; break;
                case 7: amount = (D(4) + D(4) + D(4) + D(4)) * 100; cointype = pp; break;
                case 8: amount = (D(4) + D(4) + D(4) + D(4)) * 100; cointype = pp; break;
                case 9: amount = (D(8) + D(8)) * 1000; cointype = pp; break;
                case 10: amount = (D(4) + D(4) + D(4) + D(4)) * 100; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrNineteenCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(6) + D(6) + D(6)) * 1000; cointype = gp; break;
                case 2: amount = (D(8) + D(8)) * 1000; cointype = gp; break;
                case 3: amount = (D(8) + D(8)) * 1000; cointype = gp; break;
                case 4: amount = (D(8) + D(8) + D(8)) * 1000; cointype = gp; break;
                case 5: amount = (D(10) + D(10)) * 1000; cointype = gp; break;
                case 6: amount = (D(10) + D(10)) * 100; cointype = pp; break;
                case 7: amount = (D(8) + D(8) + D(8)) * 100; cointype = pp; break;
                case 8: amount = (D(8) + D(8) + D(8)) * 100; cointype = pp; break;
                case 9: amount = (D(6) + D(6) + D(6)) * 100; cointype = pp; break;
                case 10: amount = (D(8) + D(8) + D(8)) * 100; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        public string CrTwentyCoins(int rolledRow)
        {
            string cointype = "";
            int amount = 0;
            switch (rolledRow)
            {
                case 1: amount = (D(12) + D(12)) * 1000; cointype = gp; break;
                case 2: amount = (D(10) + D(10)) * 1000; cointype = gp; break;
                case 3: amount = (D(10) + D(10)) * 1000; cointype = gp; break;
                case 4: amount = (D(6) + D(6) + D(6) + D(6)) * 1000; cointype = gp; break;
                case 5: amount = (D(12) + D(12)) * 1000; cointype = gp; break;
                case 6: amount = (D(12) + D(12)) * 100; cointype = pp; break;
                case 7: amount = (D(6) + D(6) + D(6) + D(6)) * 100; cointype = pp; break;
                case 8: amount = (D(6) + D(6) + D(6) + D(6)) * 100; cointype = pp; break;
                case 9: amount = (D(12) + D(12)) * 100; cointype = pp; break;
                case 10: amount = (D(12) + D(12)) * 100; cointype = pp; break;
                case 11: amount = (D(12) + D(12)) * 100; cointype = pp; break;
            }
            return amount + " " + cointype;
        }
        #endregion

        #region Goods
        public List<string> CrOneGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add(""); break;
                case 2: goods.Add(""); break;
                case 3: goods.Add(""); break;
                case 4: goods.Add("A"); break;
                case 5: goods.Add("B"); break;
                case 6: goods.Add("A"); break;
                case 7: goods.Add("A"); break;
                case 8: goods.Add("B"); break;
                case 9: goods.Add("A"); break;
                case 10: goods.Add("B"); break;
            }
            return goods;
        }
        public List<string> CrTwoGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add(""); break;
                case 2: goods.Add("A"); goods.Add("A"); break;
                case 3: goods.Add(""); break;
                case 4: goods.Add(""); break;
                case 5: goods.Add("A"); goods.Add("B"); break;
                case 6: goods.Add("B"); break;
                case 7: goods.Add("B"); break;
                case 8: goods.Add("A"); goods.Add("A"); break;
                case 9: goods.Add("B"); break;
                case 10: goods.Add("B"); break;
            }
            return goods;
        }
        public List<string> CrThreeGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add(""); break;
                case 2: goods.Add("B"); break;
                case 3: goods.Add(""); break;
                case 4: goods.Add("C"); break;
                case 5: goods.Add("C"); goods.Add("C"); break;
                case 6: goods.Add("B"); goods.Add("B"); break;
                case 7: goods.Add("C"); goods.Add("C"); break;
                case 8: goods.Add("C"); goods.Add("C"); break;
                case 9: goods.Add("C"); goods.Add("B"); goods.Add("B"); break;
                case 10: goods.Add("D"); goods.Add("B"); break;
            }
            return goods;
        }
        public List<string> CrFourGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add(""); break;
                case 2: goods.Add("C"); break;
                case 3: goods.Add(""); break;
                case 4: goods.Add("B"); goods.Add("C"); break;
                case 5: goods.Add("B"); goods.Add("D"); break;
                case 6: goods.Add("B"); goods.Add("C"); break;
                case 7: goods.Add("B"); goods.Add("D"); break;
                case 8: goods.Add("D"); break;
                case 9: goods.Add("C"); goods.Add("C"); goods.Add("C"); break;
                case 10: goods.Add("C"); goods.Add("D"); break;
            }
            return goods;
        }
        public List<string> CrFiveGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add(""); break;
                case 2: goods.Add("D"); break;
                case 3: goods.Add(""); break;
                case 4: goods.Add("B"); goods.Add("D"); break;
                case 5: goods.Add("C"); goods.Add("E"); break;
                case 6: goods.Add("B"); goods.Add("D"); break;
                case 7: goods.Add("C"); goods.Add("E"); break;
                case 8: goods.Add("B"); goods.Add("C"); goods.Add("D"); break;
                case 9: goods.Add("B"); goods.Add("B"); goods.Add("E"); break;
                case 10: goods.Add("C"); goods.Add("E"); break;
            }
            return goods;
        }
        public List<string> CrSixGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add(""); break;
                case 2: goods.Add("D"); goods.Add("B"); break;
                case 3: goods.Add("C"); goods.Add("C"); break;
                case 4: goods.Add("C"); goods.Add("D"); break;
                case 5: goods.Add("B"); goods.Add("D"); goods.Add("E"); break;
                case 6: goods.Add("C"); goods.Add("D"); break;
                case 7: goods.Add("E"); goods.Add("F"); break;
                case 8: goods.Add("D"); goods.Add("E"); break;
                case 9: goods.Add("E"); goods.Add("F"); break;
                case 10: goods.Add("B"); goods.Add("D"); goods.Add("E"); break;
            }
            return goods;
        }
        public List<string> CrSevenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add(""); break;
                case 2: goods.Add("D"); goods.Add("C"); break;
                case 3: goods.Add("D"); break;
                case 4: goods.Add("E"); break;
                case 5: goods.Add("E"); goods.Add("D"); goods.Add("C"); break;
                case 6: goods.Add("E"); break;
                case 7: goods.Add("E"); goods.Add("D"); break;
                case 8: goods.Add("E"); break;
                case 9: goods.Add("E"); goods.Add("D"); break;
                case 10: goods.Add("E"); goods.Add("D"); break;
            }
            return goods;
        }
        public List<string> CrEightGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("D"); break;
                case 2: goods.Add("E"); break;
                case 3: goods.Add("D"); goods.Add("C"); break;
                case 4: goods.Add("E"); goods.Add("C"); break;
                case 5: goods.Add("E"); goods.Add("D"); goods.Add("D"); break;
                case 6: goods.Add("E"); goods.Add("C"); break;
                case 7: goods.Add("F"); goods.Add("C"); break;
                case 8: goods.Add("F"); break;
                case 9: goods.Add("F"); goods.Add("C"); break;
                case 10: goods.Add("F"); goods.Add("C"); break;
            }
            return goods;
        }
        public List<string> CrNineGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("D"); goods.Add("C"); break;
                case 2: goods.Add("E"); goods.Add("C"); break;
                case 3: goods.Add("E"); break;
                case 4: goods.Add("F"); break;
                case 5: goods.Add("F"); goods.Add("D"); break;
                case 6: goods.Add("F"); break;
                case 7: goods.Add("F"); goods.Add("D"); break;
                case 8: goods.Add("F"); break;
                case 9: goods.Add("F"); goods.Add("D"); break;
                case 10: goods.Add("F"); goods.Add("D"); break;
            }
            return goods;
        }
        public List<string> CrTenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("E"); break;
                case 2: goods.Add("F"); break;
                case 3: goods.Add("E"); goods.Add("D"); break;
                case 4: goods.Add("F"); goods.Add("E"); break;
                case 5: goods.Add("F"); goods.Add("F"); break;
                case 6: goods.Add("F"); goods.Add("E"); goods.Add("D"); break;
                case 7: goods.Add("F"); goods.Add("F"); goods.Add("D"); break;
                case 8: goods.Add("F"); goods.Add("F"); break;
                case 9: goods.Add("F"); goods.Add("F"); goods.Add("D"); break;
                case 10: goods.Add("F"); goods.Add("D"); goods.Add("D"); break;
            }
            return goods;
        }
        public List<string> CrElevenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("F"); break;
                case 2: goods.Add("F"); goods.Add("E"); break;
                case 3: goods.Add("F"); break;
                case 4: goods.Add("F"); goods.Add("F"); break;
                case 5: goods.Add("G"); break;
                case 6: goods.Add("F"); goods.Add("F"); goods.Add("D"); break;
                case 7: goods.Add("G"); goods.Add("F"); break;
                case 8: goods.Add("G"); goods.Add("E"); break;
                case 9: goods.Add("G"); goods.Add("F"); break;
                case 10: goods.Add("G"); goods.Add("F"); break;
            }
            return goods;
        }
        public List<string> CrTwelveGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("F"); break;
                case 2: goods.Add("F"); goods.Add("D"); goods.Add("C"); break;
                case 3: goods.Add("F"); break;
                case 4: goods.Add("G"); break;
                case 5: goods.Add("G"); goods.Add("E"); break;
                case 6: goods.Add("G"); break;
                case 7: goods.Add("H"); break;
                case 8: goods.Add("G"); goods.Add("F"); goods.Add("F"); break;
                case 9: goods.Add("H"); break;
                case 10: goods.Add("H"); break;
            }
            return goods;
        }
        public List<string> CrThirteenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("F"); break;
                case 2: goods.Add("F"); goods.Add("E"); goods.Add("C"); break;
                case 3: goods.Add("F"); goods.Add("C"); break;
                case 4: goods.Add("G"); goods.Add("D"); break;
                case 5: goods.Add("G"); goods.Add("F"); break;
                case 6: goods.Add("G"); goods.Add("E"); break;
                case 7: goods.Add("H"); goods.Add("E"); break;
                case 8: goods.Add("H"); break;
                case 9: goods.Add("H"); goods.Add("F"); break;
                case 10: goods.Add("H"); goods.Add("F"); break;
            }
            return goods;
        }
        public List<string> CrFourteenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("F"); goods.Add("D"); break;
                case 2: goods.Add("F"); goods.Add("E"); break;
                case 3: goods.Add("F"); goods.Add("D"); break;
                case 4: goods.Add("G"); goods.Add("F"); break;
                case 5: goods.Add("H"); break;
                case 6: goods.Add("G"); goods.Add("F"); break;
                case 7: goods.Add("H"); goods.Add("F"); break;
                case 8: goods.Add("H"); break;
                case 9: goods.Add("H"); goods.Add("G"); break;
                case 10: goods.Add("H"); goods.Add("G"); break;
            }
            return goods;
        }
        public List<string> CrFifteenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("G"); break;
                case 2: goods.Add("G"); goods.Add("F"); break;
                case 3: goods.Add("G"); goods.Add("E"); break;
                case 4: goods.Add("H"); goods.Add("F"); break;
                case 5: goods.Add("H"); goods.Add("G"); break;
                case 6: goods.Add("H"); goods.Add("F"); break;
                case 7: goods.Add("H"); goods.Add("G"); goods.Add("E"); break;
                case 8: goods.Add("H"); goods.Add("G"); break;
                case 9: goods.Add("H"); goods.Add("G"); goods.Add("F"); break;
                case 10: goods.Add("H"); goods.Add("G"); goods.Add("F"); break;
            }
            return goods;
        }
        public List<string> CrSixteenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("G"); goods.Add("E"); break;
                case 2: goods.Add("H"); break;
                case 3: goods.Add("G"); goods.Add("F"); break;
                case 4: goods.Add("H"); goods.Add("G"); break;
                case 5: goods.Add("I"); break;
                case 6: goods.Add("H"); goods.Add("G"); break;
                case 7: goods.Add("I"); goods.Add("F"); goods.Add("E"); break;
                case 8: goods.Add("I"); goods.Add("E"); break;
                case 9: goods.Add("I"); goods.Add("F"); goods.Add("E"); break;
                case 10: goods.Add("I"); goods.Add("F"); goods.Add("E"); break;
            }
            return goods;
        }
        public List<string> CrSeventeenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("H"); break;
                case 2: goods.Add("H"); goods.Add("F"); goods.Add("F"); break;
                case 3: goods.Add("H"); goods.Add("F"); break;
                case 4: goods.Add("I"); break;
                case 5: goods.Add("I"); goods.Add("G"); break;
                case 6: goods.Add("I"); break;
                case 7: goods.Add("I"); goods.Add("G"); break;
                case 8: goods.Add("I"); break;
                case 9: goods.Add("I"); goods.Add("G"); break;
                case 10: goods.Add("I"); goods.Add("G"); break;
            }
            return goods;
        }
        public List<string> CrEighteenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("H"); goods.Add("G"); break;
                case 2: goods.Add("I"); break;
                case 3: goods.Add("H"); goods.Add("G"); break;
                case 4: goods.Add("I"); break;
                case 5: goods.Add("I"); goods.Add("H"); break;
                case 6: goods.Add("I"); goods.Add("F"); break;
                case 7: goods.Add("I"); goods.Add("G"); break;
                case 8: goods.Add("I"); goods.Add("F"); break;
                case 9: goods.Add("I"); goods.Add("G"); break;
                case 10: goods.Add("I"); goods.Add("G"); break;
            }
            return goods;
        }
        public List<string> CrNineteenGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("I"); break;
                case 2: goods.Add("I"); goods.Add("F"); break;
                case 3: goods.Add("I"); break;
                case 4: goods.Add("I"); goods.Add("F"); break;
                case 5: goods.Add("I"); goods.Add("H"); break;
                case 6: goods.Add("I"); goods.Add("F"); break;
                case 7: goods.Add("I"); goods.Add("H"); break;
                case 8: goods.Add("I"); goods.Add("F"); break;
                case 9: goods.Add("I"); goods.Add("F"); break;
                case 10: goods.Add("I"); goods.Add("F"); break;
            }
            return goods;
        }
        public List<string> CrTwentyGoods(int rolledRow)
        {
            List<string> goods = new List<string>();
            switch (rolledRow)
            {
                case 1: goods.Add("I"); goods.Add("F"); goods.Add("F"); break;
                case 2: goods.Add("I"); goods.Add("H"); break;
                case 3: goods.Add("I"); goods.Add("F"); goods.Add("F"); break;
                case 4: goods.Add("I"); goods.Add("H"); break;
                case 5: goods.Add("I"); goods.Add("H"); goods.Add("G"); break;
                case 6: goods.Add("I"); goods.Add("H"); break;
                case 7: goods.Add("I"); goods.Add("H"); goods.Add("G"); break;
                case 8: goods.Add("I"); goods.Add("H"); break;
                case 9: goods.Add("I"); goods.Add("H"); goods.Add("G"); break;
                case 10: goods.Add("I"); goods.Add("H"); goods.Add("G"); break;
                case 11: goods.Add("I"); goods.Add("I"); break;
            }
            return goods;
        }
        
        #endregion

        #region Items
        public List<string> CrOneItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add(""); break;
                case 2: items.Add(""); break;
                case 3: items.Add("1/2"); break;
                case 4: items.Add("1"); break;
                case 5: items.Add("1"); break;
                case 6: items.Add("1"); items.Add("1/2"); break;
                case 7: items.Add(""); ; break;
                case 8: items.Add("1"); ; break;
                case 9: items.Add("1"); items.Add("1/2"); break;
                case 10: items.Add("1"); items.Add("1/2"); break;
            }
            return items;
        }
        public List<string> CrTwoItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add(""); break;
                case 2: items.Add(""); break;
                case 3: items.Add("1"); break;
                case 4: items.Add("1"); items.Add("1/2"); break;
                case 5: items.Add("1"); items.Add("1"); break;
                case 6: items.Add("1"); items.Add("1"); items.Add("1/2"); break;
                case 7: items.Add("1"); items.Add("1/2"); break;
                case 8: items.Add("1"); items.Add("1"); break;
                case 9: items.Add("2"); break;
                case 10: items.Add("2"); break;
            }
            return items;
        }
        public List<string> CrThreeItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("1"); break;
                case 2: items.Add("1"); break;
                case 3: items.Add("2"); break;
                case 4: items.Add("2"); break;
                case 5: items.Add("2"); break;
                case 6: items.Add("2"); items.Add("1"); break;
                case 7: items.Add("2"); items.Add("1/2"); break;
                case 8: items.Add("2"); items.Add("1"); break;
                case 9: items.Add("3"); break;
                case 10: items.Add("3"); break;
            }
            return items;
        }
        public List<string> CrFourItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("1"); items.Add("1/2"); break;
                case 2: items.Add("1"); items.Add("1"); break;
                case 3: items.Add("2"); items.Add("1"); break;
                case 4: items.Add("2"); items.Add("1"); break;
                case 5: items.Add("2"); items.Add("1"); break;
                case 6: items.Add("3"); break;
                case 7: items.Add("2"); items.Add("1"); break;
                case 8: items.Add("3"); break;
                case 9: items.Add("3"); items.Add("1"); break;
                case 10: items.Add("4"); break;
            }
            return items;
        }
        public List<string> CrFiveItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("2"); break;
                case 2: items.Add("2"); break;
                case 3: items.Add("3"); break;
                case 4: items.Add("3"); break;
                case 5: items.Add("3"); break;
                case 6: items.Add("4"); break;
                case 7: items.Add("3"); break;
                case 8: items.Add("4"); break;
                case 9: items.Add("5"); break;
                case 10: items.Add("5"); break;
            }
            return items;
        }
        public List<string> CrSixItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("3"); break;
                case 2: items.Add("3"); break;
                case 3: items.Add("3"); items.Add("1"); break;
                case 4: items.Add("3"); items.Add("1"); break;
                case 5: items.Add("3"); items.Add("1"); break;
                case 6: items.Add("4"); break;
                case 7: items.Add("3"); items.Add("1"); break;
                case 8: items.Add("4"); items.Add("2"); break;
                case 9: items.Add("5"); break;
                case 10: items.Add("6"); break;
            }
            return items;
        }
        public List<string> CrSevenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("3"); break;
                case 2: items.Add("3"); break;
                case 3: items.Add("3"); items.Add("1"); break;
                case 4: items.Add("4"); break;
                case 5: items.Add("4"); break;
                case 6: items.Add("4"); items.Add("2"); break;
                case 7: items.Add("4"); items.Add("2"); break;
                case 8: items.Add("5"); items.Add("1"); break;
                case 9: items.Add("6"); break;
                case 10: items.Add("7"); break;
            }
            return items;
        }
        public List<string> CrEightItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("4"); break;
                case 2: items.Add("4"); break;
                case 3: items.Add("4"); items.Add("1"); break;
                case 4: items.Add("5"); break;
                case 5: items.Add("5"); break;
                case 6: items.Add("6"); break;
                case 7: items.Add("6"); break;
                case 8: items.Add("6"); items.Add("3"); break;
                case 9: items.Add("7"); break;
                case 10: items.Add("8"); break;
            }
            return items;
        }
        public List<string> CrNineItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("4"); break;
                case 2: items.Add("4"); items.Add("1"); break;
                case 3: items.Add("5"); break;
                case 4: items.Add("5"); break;
                case 5: items.Add("6"); break;
                case 6: items.Add("6"); items.Add("3"); break;
                case 7: items.Add("6"); items.Add("2"); break;
                case 8: items.Add("7"); break;
                case 9: items.Add("8"); break;
                case 10: items.Add("9"); break;
            }
            return items;
        }
        public List<string> CrTenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("5"); break;
                case 2: items.Add("5"); break;
                case 3: items.Add("6"); break;
                case 4: items.Add("6"); items.Add("1"); break;
                case 5: items.Add("6"); items.Add("2"); break;
                case 6: items.Add("7"); break;
                case 7: items.Add("7"); break;
                case 8: items.Add("8"); break;
                case 9: items.Add("9"); break;
                case 10: items.Add("10"); break;
            }
            return items;
        }
        public List<string> CrElevenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("6"); break;
                case 2: items.Add("6"); break;
                case 3: items.Add("7"); break;
                case 4: items.Add("7"); break;
                case 5: items.Add("7"); items.Add("2"); break;
                case 6: items.Add("8"); break;
                case 7: items.Add("8"); break;
                case 8: items.Add("9"); break;
                case 9: items.Add("10"); break;
                case 10: items.Add("11"); break;
            }
            return items;
        }
        public List<string> CrTwelveItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("7"); break;
                case 2: items.Add("7"); break;
                case 3: items.Add("8"); break;
                case 4: items.Add("8"); break;
                case 5: items.Add("8"); break;
                case 6: items.Add("9"); break;
                case 7: items.Add("9"); break;
                case 8: items.Add("10"); break;
                case 9: items.Add("11"); break;
                case 10: items.Add("12"); break;
            }
            return items;
        }
        public List<string> CrThirteenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("8"); break;
                case 2: items.Add("8"); break;
                case 3: items.Add("9"); break;
                case 4: items.Add("9"); break;
                case 5: items.Add("10"); break;
                case 6: items.Add("10"); items.Add("5"); break;
                case 7: items.Add("11"); break;
                case 8: items.Add("11"); items.Add("5"); break;
                case 9: items.Add("12"); break;
                case 10: items.Add("13"); break;
            }
            return items;
        }
        public List<string> CrFourteenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("9"); break;
                case 2: items.Add("9"); break;
                case 3: items.Add("10"); break;
                case 4: items.Add("10"); items.Add("5"); break;
                case 5: items.Add("11"); break;
                case 6: items.Add("11"); items.Add("6"); break;
                case 7: items.Add("12"); break;
                case 8: items.Add("12"); items.Add("5"); break;
                case 9: items.Add("13"); break;
                case 10: items.Add("14"); break;
            }
            return items;
        }
        public List<string> CrFifteenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("10"); break;
                case 2: items.Add("10"); break;
                case 3: items.Add("11"); break;
                case 4: items.Add("11"); break;
                case 5: items.Add("12"); break;
                case 6: items.Add("12"); items.Add("8"); break;
                case 7: items.Add("13"); break;
                case 8: items.Add("13"); items.Add("6"); break;
                case 9: items.Add("14"); break;
                case 10: items.Add("15"); break;
            }
            return items;
        }
        public List<string> CrSixteenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("11"); break;
                case 2: items.Add("11"); break;
                case 3: items.Add("12"); break;
                case 4: items.Add("12"); items.Add("6"); break;
                case 5: items.Add("13"); break;
                case 6: items.Add("13"); items.Add("8"); break;
                case 7: items.Add("14"); break;
                case 8: items.Add("14"); items.Add("8"); break;
                case 9: items.Add("15"); break;
                case 10: items.Add("16"); break;
            }
            return items;
        }
        public List<string> CrSeventeenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("12"); break;
                case 2: items.Add("12"); break;
                case 3: items.Add("13"); break;
                case 4: items.Add("13"); break;
                case 5: items.Add("14"); break;
                case 6: items.Add("14"); items.Add("7"); break;
                case 7: items.Add("15"); break;
                case 8: items.Add("16"); break;
                case 9: items.Add("17"); break;
                case 10: items.Add("18"); break;
            }
            return items;
        }
        public List<string> CrEighteenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("13"); break;
                case 2: items.Add("14"); break;
                case 3: items.Add("14"); items.Add("9"); break;
                case 4: items.Add("15"); break;
                case 5: items.Add("15"); break;
                case 6: items.Add("16"); break;
                case 7: items.Add("17"); break;
                case 8: items.Add("18"); break;
                case 9: items.Add("19"); break;
                case 10: items.Add("20"); break;
            }
            return items;
        }
        public List<string> CrNineteenItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("14"); break;
                case 2: items.Add("15"); break;
                case 3: items.Add("15"); items.Add("7"); break;
                case 4: items.Add("16"); break;
                case 5: items.Add("16"); items.Add("10"); break;
                case 6: items.Add("17"); break;
                case 7: items.Add("18"); break;
                case 8: items.Add("19"); break;
                case 9: items.Add("20"); break;
                case 10: items.Add("21"); break;
            }
            return items;
        }
        public List<string> CrTwentyItems(int rolledRow)
        {
            List<string> items = new List<string>();
            switch (rolledRow)
            {
                case 1: items.Add("15"); break;
                case 2: items.Add("16"); break;
                case 3: items.Add("17"); break;
                case 4: items.Add("18"); break;
                case 5: items.Add("19"); break;
                case 6: items.Add("20"); break;
                case 7: items.Add("21"); break;
                case 8: items.Add("22"); break;
                case 9: items.Add("23"); break;
                case 10: items.Add("24"); break;
                case 11: items.Add("25"); break;
            }
            return items;
        }
        #endregion

        /// <summary>
        /// Dice roller. Input is the number of eyes the dice have.
        /// </summary>
        /// <param name="_eyes">Maximum number of eyes</param>
        /// <returns></returns>
        private int D(int _eyes)
        {
            return new Random().Next(1, _eyes + 1);
        }
    }
}
