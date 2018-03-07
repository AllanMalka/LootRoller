using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LootRoller
{
    public partial class Default : Form
    {
        private Random randRes;
        private Classes.ChallengeRatings cr;
        private Classes.GoodsContainer goCon;
        private Classes.ItemsContainer itCon;
        private Classes.MagicGenerator maGen;
        private Classes.ArmorContainer arCon;
        private Classes.WeaponsContainer weaCon;
        private int selectedIndex;

        public Default()
        {
            selectedIndex = 0;
            InitializeComponent();
            randRes = new Random();
            cr = new Classes.ChallengeRatings();
            goCon = new Classes.GoodsContainer();
            itCon = new Classes.ItemsContainer();
            maGen = new Classes.MagicGenerator();
            arCon = new Classes.ArmorContainer();
            weaCon = new Classes.WeaponsContainer();
            lblStatus.Text = "";

            ddbProtection.Enabled = false;
            List<String> protData = new List<string>();
            protData.Add("Random");
            foreach (string item in arCon.AllProtection())
            {
                string res = item;
                if (item.Contains("/"))
                {
                     res = item.Remove(item.LastIndexOf("/"));
                }
                protData.Add(res);
            }
            ddbProtection.DataSource = protData;

            ddbWeapons.Enabled = false;
            List<String> weapData = new List<string>();
            weapData.Add("Random");
            foreach (string item in weaCon.AllWeapons())
            {
                string res = item;
                if (item.Contains("/"))
                {
                    res = item.Remove(item.LastIndexOf("/"));
                }
                weapData.Add(res);
            }
            ddbWeapons.DataSource = weapData;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult.Visible = true;
            SelectedFinds();
            
        }

        private void SelectedFinds()
        {
            string indicator = txtIndicator.Text;
            switch (selectedIndex)
            {
                case 1: FindCR(Convert.ToInt32(indicator)); break;
                case 2: FindGoods(indicator.ToUpper()); break;
                case 3: FindItem(indicator); break;
                case 4: FindCoins(Convert.ToInt32(indicator)); break;
                case 5: GenerateProtection(Convert.ToInt32(txtIndicator.Text), FindProtection(ddbProtection.SelectedValue.ToString())); break;
                case 6: GenerateWeapon(Convert.ToInt32(txtIndicator.Text), FindWeapon(ddbWeapons.SelectedValue.ToString())); break;
                default: break;
            }
        }

        private void FindCR(int _cr)
        {
            try
            {
                int row = 0;
                if (_cr == 20)
                {
                    row = TableRollingTwenty(randRes.Next(1, 101));
                    txtResult.Text = CrTwenty(row);
                }
                else
                {
                    row = TableRolling(randRes.Next(1, 101));
                    switch (_cr)
                    {
                        #region Cases 1 - 20
                        case 1: txtResult.Text = CrOne(row); break;
                        case 2: txtResult.Text = CrTwo(row); break;
                        case 3: txtResult.Text = CrThree(row); break;
                        case 4: txtResult.Text = CrFour(row); break;
                        case 5: txtResult.Text = CrFive(row); break;
                        case 6: txtResult.Text = CrSix(row); break;
                        case 7: txtResult.Text = CrSeven(row); break;
                        case 8: txtResult.Text = CrEight(row); break;
                        case 9: txtResult.Text = CrNine(row); break;
                        case 10: txtResult.Text = CrTen(row); break;
                        case 11: txtResult.Text = CrEleven(row); break;
                        case 12: txtResult.Text = CrTwelve(row); break;
                        case 13: txtResult.Text = CrThirteen(row); break;
                        case 14: txtResult.Text = CrFourteen(row); break;
                        case 15: txtResult.Text = CrFifteen(row); break;
                        case 16: txtResult.Text = CrSixteen(row); break;
                        case 17: txtResult.Text = CrSeventeen(row); break;
                        case 18: txtResult.Text = CrEighteen(row); break;
                        case 19: txtResult.Text = CrNineteen(row); break;
                        #endregion
                        default: MessageBox.Show(ErrorMessage(_cr)); break;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("It needs number input and not text! Try and type " + new Random().Next(1, 21) + " instead of " + _cr + "!");
            }

        }

        private void FindGoods(string _indicator)
        {
            try
            {
                txtResult.Text = goCon.Goods(_indicator);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FindItem(string _indicator)
        {
            try
            {
                if (_indicator.Equals("½"))
                {
                    _indicator = "1/2";
                }
                txtResult.Text = itCon.Items(_indicator);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FindCoins(int _level)
        {
            try
            {
                txtResult.Text = cr.CoinsByLevel(_level, new Random().Next(1, 11));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GenerateProtection(int _enhancement, string _protection)
        {
            try
            {
                txtResult.Text = _protection.Remove(_protection.LastIndexOf("/")) + " " + maGen.ProbertyStrength(1, _enhancement, _protection);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GenerateWeapon(int _enhancement, string _weapon)
        {
            try
            {
                txtResult.Text = _weapon.Remove(_weapon.LastIndexOf("/")) + " " + maGen.ProbertyStrength(2, _enhancement, _weapon);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string FindProtection(string _protection)
        {
            string result = "";
            string[] allProt = arCon.AllProtection();
            if (_protection.Equals("Random"))
            {
                result = arCon.RandomArmorOrShield();
            }
            else if (_protection.Equals("Light"))
            {
                while (!result.Contains("Light"))
                {
                    result = arCon.RandomArmorOrShield();
                }
            }
            else if (_protection.Equals("Medium"))
            {
                while (!result.Contains("Medium"))
                {
                    result = arCon.RandomArmorOrShield();
                }
            }
            else if (_protection.Equals("Heavy"))
            {
                while (!result.Contains("Heavy"))
                {
                    result = arCon.RandomArmorOrShield();
                }
            }
            else if (_protection.Equals("Shield"))
            {
                while (!result.Contains("Shield"))
                {
                    result = arCon.RandomArmorOrShield();
                }
            }
            else
            {
                for (int i = 0; i < allProt.Count(); i++)
                {
                    string temp = allProt.GetValue(i).ToString();
                    if (temp.Remove(temp.LastIndexOf("/")).Equals(_protection))
                    {
                        result = temp;
                        break;
                    }
                }
            }
            return result;
        }

        private string FindWeapon(string _weapon)
        {
            string result = "";
            string[] allWeap = weaCon.AllWeapons();

            if (_weapon.Equals("Random"))
            {
                result = weaCon.RandomWeapon();
            }
            #region Types
            else if (_weapon.Equals("Ranged"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string type = result.Substring(result.LastIndexOf("/") + 1);
                    type = type.Remove(type.LastIndexOf("-"));
                    if (type.Equals("Ranged"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Melee"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string type = result.Substring(result.LastIndexOf("/") + 1);
                    type = type.Remove(type.LastIndexOf("-"));
                    if (type.Equals("Melee"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Light"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string weight = result.Substring(result.LastIndexOf("-") + 1);
                    weight = weight.Remove(weight.LastIndexOf("#"));
                    if (weight.Equals("Light"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("One handed"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string weight = result.Substring(result.LastIndexOf("-") + 1);
                    weight = weight.Remove(weight.LastIndexOf("#"));
                    if (weight.Equals("One handed"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Two handed"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string weight = result.Substring(result.LastIndexOf("-") + 1);
                    weight = weight.Remove(weight.LastIndexOf("#"));
                    if (weight.Equals("Two handed"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Ammunition"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string weight = result.Substring(result.LastIndexOf("-") + 1);
                    weight = weight.Remove(weight.LastIndexOf("#"));
                    if (weight.Equals("Ammunition"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Thrown"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string weight = result.Substring(result.LastIndexOf("-") + 1);
                    weight = weight.Remove(weight.LastIndexOf("#"));
                    if (weight.Equals("Thrown"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Ranged weapon"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string weight = result.Substring(result.LastIndexOf("-") + 1);
                    weight = weight.Remove(weight.LastIndexOf("#"));
                    if (weight.Equals("Ranged weapon"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Bludgeoning"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string damage = result.Substring(result.LastIndexOf("#") + 1);
                    if (damage.Equals("Bludgeoning"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Piercing"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string damage = result.Substring(result.LastIndexOf("#") + 1);
                    if (damage.Equals("Piercing"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Slashing"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string damage = result.Substring(result.LastIndexOf("#") + 1);
                    if (damage.Equals("Slashing"))
                    {
                        isGood = true;
                    }
                }
            }
            else if (_weapon.Equals("Ammo dependent"))
            {
                bool isGood = false;
                while (!isGood)
                {
                    result = weaCon.RandomWeapon();
                    string damage = result.Substring(result.LastIndexOf("#") + 1);
                    if (damage.Equals("Ammo dependent"))
                    {
                        isGood = true;
                    }
                }
            }
#endregion
            else
            {
                for (int i = 0; i < allWeap.Count(); i++)
                {
                    string temp = allWeap.GetValue(i).ToString();
                    if (temp.Remove(temp.LastIndexOf("/")).Equals(_weapon))
                    {
                        result = temp;
                        break;
                    }
                }
            }

            return result;
        }

        private string ErrorMessage(int row)
        {
            string mess = "";
            if (row > 20)
            {
                mess = "Challenge rating is to epic for this chest!";
            }
            else if (row < 1)
            {
                mess = "Challenge rating is to low class for this chest!";
            }
            return mess;
        }

        private int TableRolling(int result)
        {
            int row = 0;
            if (result >= 1 && result <= 7)
            {
                row = 1;
            }
            else if (result >= 8 && result <= 10)
            {
                row = 2;
            }
            else if (result >= 11 && result <= 21)
            {
                row = 3;
            }
            else if (result >= 22 && result <= 44)
            {
                row = 4;
            }
            else if (result >= 45 && result <= 60)
            {
                row = 5;
            }
            else if (result >= 61 && result <= 78)
            {
                row = 6;
            }
            else if (result >= 79 && result <= 83)
            {
                row = 7;
            }
            else if (result >= 84 && result <= 91)
            {
                row = 8;
            }
            else if (result >= 92 && result <= 99)
            {
                row = 9;
            }
            else if (result == 100)
            {
                row = 10;
            }
            return row;
        }
        private int TableRollingTwenty(int result)
        {
            int row = 0;
            if (result >= 1 && result <= 7)
            {
                row = 1;
            }
            else if (result >= 8 && result <= 10)
            {
                row = 2;
            }
            else if (result >= 11 && result <= 21)
            {
                row = 3;
            }
            else if (result >= 22 && result <= 44)
            {
                row = 4;
            }
            else if (result >= 45 && result <= 60)
            {
                row = 5;
            }
            else if (result >= 61 && result <= 78)
            {
                row = 6;
            }
            else if (result >= 79 && result <= 83)
            {
                row = 7;
            }
            else if (result >= 84 && result <= 91)
            {
                row = 8;
            }
            else if (result >= 92 && result <= 95)
            {
                row = 9;
            }
            else if (result >= 96 && result <= 98)
            {
                row = 10;
            }
            else if (result >= 99 && result <= 100)
            {
                row = 11;
            }
            return row;
        }

        #region Challenge Ratings
        private string CrOne(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrOneItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrOneGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrOneCoins(row) + goods + items;
        }
        private string CrTwo(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrTwoItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrTwoGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrTwoCoins(row) + goods + items;
        }
        private string CrThree(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrThreeItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrThreeGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrThreeCoins(row) + goods + items;
        }
        private string CrFour(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrFourItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrThreeGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrFourCoins(row) + goods + items;
        }
        private string CrFive(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrFiveItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrFiveGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrFiveCoins(row) + goods + items;
        }
        private string CrSix(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrSixItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrSixGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrSixCoins(row) + goods + items;
        }
        private string CrSeven(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrSevenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrSevenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrSevenCoins(row) + goods + items;
        }
        private string CrEight(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrEightItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrEightGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrEightCoins(row) + goods + items;
        }
        private string CrNine(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrNineItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrNineGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrNineCoins(row) + goods + items;
        }
        private string CrTen(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrTenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrTenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrTenCoins(row) + goods + items;
        }
        private string CrEleven(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrElevenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrElevenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrElevenCoins(row) + goods + items;
        }
        private string CrTwelve(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrTwelveItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrTwelveGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrTwelveCoins(row) + goods + items;
        }
        private string CrThirteen(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrThirteenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrThirteenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrThirteenCoins(row) + goods + items;
        }
        private string CrFourteen(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrFourteenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrFourteenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrFourteenCoins(row) + goods + items;
        }
        private string CrFifteen(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrFifteenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrFifteenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrFifteenCoins(row) + goods + items;
        }
        private string CrSixteen(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrSixteenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrSixteenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrSixteenCoins(row) + goods + items;
        }
        private string CrSeventeen(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrSeventeenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrSeventeenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrSeventeenCoins(row) + goods + items;
        }
        private string CrEighteen(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrEighteenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrEighteenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrEighteenCoins(row) + goods + items;
        }
        private string CrNineteen(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrNineteenItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrNineteenGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrNineteenCoins(row) + goods + items;
        }
        private string CrTwenty(int row)
        {
            string items = "";
            string goods = "";
            foreach (string i in cr.CrTwentyItems(row))
            {
                items += "\r\n" + itCon.Items(i);
            }
            foreach (string g in cr.CrTwentyGoods(row))
            {
                goods += "\r\n" + goCon.Goods(g);
            }
            return "You find: \r\n" + cr.CrTwentyCoins(row) + goods + items;
        }
        #endregion

        private void rbCr_CheckedChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "What challenge rating has your adventures bested?\r\nMinimum 1; Maximum 20:";
            selectedIndex = 1;
        }

        private void rbGoods_CheckedChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Should we reward your adventures with a random goods?\r\nGoods ranges from the letter A - I. \r\nOnly one Goods will be found.";
            selectedIndex = 2;
        }

        private void rbItems_CheckedChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Should we reward your adventures with a random item?\r\nItems ranges from the Item level ½ - 25. \r\nOnly one Item will be found.";
            selectedIndex = 3;
        }

        private void rbCoins_CheckedChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Should we reward your adventures with a random amount of coins?\r\nCoins ranges from level 1 - 20. \r\nOnly one amount of coins will be found.";
            selectedIndex = 4;
        }

        private void rbProtection_CheckedChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Either select a specific piece of  armor/shield or type for your\r\nadventures or pick a specific. Enhancement ranges from 1-10.\r\nOnly one piece will be found.";
            selectedIndex = 5;
            if (ddbProtection.Enabled)
                ddbProtection.Enabled = false;
            else
                ddbProtection.Enabled = true;
        }

        private void rbWeapons_CheckedChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Either select a specific piece of  weapon or type for your\r\nadventures or pick a specific. Enhancement ranges from 1-10.\r\nOnly one piece will be found.";
            selectedIndex = 6;
            if (ddbWeapons.Enabled)
                ddbWeapons.Enabled = false;
            else
                ddbWeapons.Enabled = true;
        }

        private void ddbProtection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddbWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
