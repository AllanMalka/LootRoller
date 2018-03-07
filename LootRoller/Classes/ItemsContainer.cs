using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootRoller.Classes
{

    class ItemsContainer
    {
        public string Items(string level)
        {
            string result = "";
            switch (level)
            {
                case "1/2": result = ItemLevelHalf(); break;
                case "1": result = ItemLevelOne(); break;
                case "2": result = ItemLevelTwo(); break;
                case "3": result = ItemLevelThree(); break;
                case "4": result = ItemLevelFour(); break;
                case "5": result = ItemLevelFive(); break;
                case "6": result = ItemLevelSix(); break;
                case "7": result = ItemLevelSeven(); break;
                case "8": result = ItemLevelEight(); break;
                case "9": result = ItemLevelNine(); break;
                case "10": result = ItemLevelTen(); break;
                case "11": result = ItemLevelEleven(); break;
                case "12": result = ItemLevelTwelve(); break;
                case "13": result = ItemLevelThirteen(); break;
                case "14": result = ItemLevelFourteen(); break;
                case "15": result = ItemLevelFifteen(); break;
                case "16": result = ItemLevelSixteen(); break;
                case "17": result = ItemLevelSeventeen(); break;
                case "18": result = ItemLevelEighteen(); break;
                case "19": result = ItemLevelNineteen(); break;
                case "20": result = ItemLevelTwenty(); break;
                case "21": result = ItemLevelTwentyOne(); break;
                case "22": result = ItemLevelTwentyTwo(); break;
                case "23": result = ItemLevelTwentyThree(); break;
                case "24": result = ItemLevelTwentyFour(); break;
                case "25": result = ItemLevelTwentyFive(); break;
                default: result = level + "No Item"; break;
            }
            return result;
        }

        /// <summary>
        /// Dice roller. Input is the number of eyes the dice have.
        /// </summary>
        /// <param name="_eyes">Maximum number of eyes</param>
        /// <returns></returns>
        private int D(int _eyes)
        {
            return new Random().Next(1, _eyes + 1);
        }
        /// <summary>
        /// Used to find out if it is of Arcane or Divine Heritage.
        /// </summary>
        /// <returns>Returns (A) for Arcane and (D) for Divine. With no prespacing.</returns>
        private string ArcaneOrDivine()
        {
            string result = "";

            if (D(4) <= 2) 
                result += "(A)"; 
            else 
                result += "(D)";

            return result;
        }
        /// <summary>
        /// Finds a weapon. Not magically or masterworked.
        /// </summary>
        /// <returns>String Weapon / type</returns>
        public string Weapon()
        {
            return new WeaponsContainer().RandomWeapon();
        }
        /// <summary>
        /// Finds an item or a shield. Not magically or masterworked.
        /// </summary>
        /// <returns>String Armor / type. Shield is a type.</returns>
        public string Protection()
        {
            return new ArmorContainer().RandomArmorOrShield();
        }
        /// <summary>
        /// Returns one of the alignments
        /// </summary>
        /// <returns></returns>
        public string AlignmentDetermination()
        {
            string result = "";
            int resd = D(4); 
            if (resd == 1) 
            {
                result = "chaos"; 
            } 
            else if (resd == 2) 
            {
                result = "evil"; 
            } 
            else if (resd == 3) 
            {
                result = "good";
            }
            else 
            {
                result = "law";
            }
            return result;
        }

        /// <summary>
        /// This is to find out how the enhancements are to be written out.
        /// </summary>
        /// <param name="type">This is int based since there is only two differences. Either 1 Armor or 2 Weapon</param>
        /// <param name="eLevel">This is the enhancement level going from 1 - 10.</param>
        /// <param name="item">Only insert the full item for the specific type of which has been chosen.</param>
        /// <returns></returns>
        public string Magic(int type, int eLevel, string item)
        {
            ArmorContainer arCon = new ArmorContainer();
            WeaponsContainer weCon = new WeaponsContainer();
            string res = item.Remove(item.LastIndexOf("/"));
            string matRes = SpecialMaterial(type);
            #region Adamantine
            if (matRes.Equals("Adamantine"))
            {
                #region Armor
                if (type == 1)
                {
                    if (item.Contains("Light"))
                    {
                        if (!item.Equals(arCon.ChainShirt) || !item.Equals(arCon.LightSteelShield))
                        {
                            matRes = "";
                        }
                    }
                    else if (item.Equals(arCon.Hide))
                    {
                        matRes = "";
                    }
                    else if (item.Contains("wood"))
                    {
                        matRes = "";
                    }
                }
                #endregion
                #region Weapon
                if (type == 2)
                {
                    if (item.Contains("Ammo dependent"))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Club))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Quarterstaff))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Sap))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Greatclub))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Lance))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Nunchaku))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Whip))
                    {
                        matRes = "";
                    }
                }
                #endregion
            }
            #endregion
            #region Darkwood
            if (matRes.Equals("Darkwood"))
            {
                #region Armor
                if (type == 1)
                {
                    if (!item.Contains("wood"))
                    {
                        matRes = "";
                    }
                }
                #endregion
                #region Weapon
                if (!item.Contains("Ammo dependent"))
                {
                    if (item.Equals(weCon.Bullets))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Club))
                    {
                    }
                    else if (item.Equals(weCon.Quarterstaff))
                    {
                    }
                    else if (item.Contains("spear"))
                    {
                    }
                    else if (item.Equals(weCon.Sap))
                    {
                    }
                    else if (item.Equals(weCon.Greatclub))
                    {
                    }
                    else if (item.Equals(weCon.Lance))
                    {
                    }
                    else if (item.Equals(weCon.Nunchaku))
                    {
                    }
                    else
                    {
                        matRes = "";
                    }
                }
                if (item.Equals(weCon.Net))
                {
                    matRes = "";
                }
                else if (item.Equals(weCon.Sling))
                {
                    matRes = "";
                }
                #endregion
            }
            #endregion
            #region Dragonhide
            //No special rule applies here for armor.
            #endregion
            #region Cold iron
            if (matRes.Equals("Cold iron"))
            {
                #region Weapon
                if (type == 2)
                {
                    if (item.Contains("Ammo dependent"))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Club))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Quarterstaff))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Sap))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Greatclub))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Lance))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Nunchaku))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Whip))
                    {
                        matRes = "";
                    }
                }
                #endregion
            }
            #endregion
            #region Mithral
            if (matRes.Equals("Mithral"))
            {
                if (item.Contains("wood"))
                {
                    matRes = "";
                }
                else if (item.Contains("Heavy"))
                {
                    if (!item.Contains("shield"))
                    {
                        item = item.Replace("Heavy", "Medium");
                    }
                }
                else if (item.Contains("Medium"))
                {
                    if (item.Equals(arCon.Hide))
                    {
                        matRes = "";
                    }
                    else
                    {
                        item = item.Replace("Medium", "Light");
                    }
                }
                else if (!item.Equals(arCon.ChainShirt) || !item.Equals(arCon.LightSteelShield) || !item.Equals(arCon.TowerShield))
                {
                    matRes = "";
                }
            }
            #endregion
            #region Silver
            if (matRes.Equals("Silver, alchemical"))
            {
                #region Weapon
                if (type == 2)
                {
                    if (item.Contains("Ammo dependent"))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Club))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Quarterstaff))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Sap))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Greatclub))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Lance))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Nunchaku))
                    {
                        matRes = "";
                    }
                    else if (item.Equals(weCon.Whip))
                    {
                        matRes = "";
                    }
                }
                #endregion
            }
            #endregion


            return matRes +  res + " " + new MagicGenerator().ProbertyStrength(type, eLevel, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_type">1 Armor, 2 Weapon</param>
        /// <returns></returns>
        public string SpecialMaterial(int _type)
        {
            int rolled = D(100);
            string result = "";
            if (rolled <= 5)
            {
                if (_type == 1)
                {
                    int roll = D(4);
                    switch (roll)
                    {
                        case 1: result = "Adamantine "; break;
                        case 2: result = "Darkwood "; break;
                        case 3: result = "Dragonhide "; break;
                        case 4: result = "Mithral "; break;
                        default: break;
                    }
                }
                else if (_type == 2)
                {
                    int roll = D(4);
                    switch (roll)
                    {
                        case 1: result = "Adamantine "; break;
                        case 2: result = "Darkwood "; break;
                        case 3: result = "Cold iron "; break;
                        case 4: result = "Silver, alchemical "; break;
                        default: break;
                    }
                }
            }
            return result;
        }

        private string ItemLevelHalf()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Acid"; break;
                case 2: case 3: item = "Lantern, bullseye"; break;
                case 4: item = "Scroll of caltrops (A)"; break;
                case 5: item = "Scroll of create water (D)"; break;
                case 6: item = "Scroll of dancing lights (A)"; break;
                case 7: item = "Scroll of dawnSC (D)"; break;
                case 8: item = "Scroll of detect magic " + ArcaneOrDivine(); break;
                case 9: item = "Scroll of light" + ArcaneOrDivine(); break;
                case 10: item = "Scroll of message (A)"; break;
                case 11: item = "Scroll of purify food and drink (D)"; break;
                case 12: case 13: item = "Alchemist’s fire"; break;
                case 14: case 15: case 16: item = "Rope, silk (100 ft.)"; break;
                case 17: case 18: item = "Smokesticks"; break;
                case 19: case 20: item = "Holy symbol, silver"; break;
                case 21: case 22: item = "Holy water"; break;
                case 23: item = "Scroll of aspect of the wolf (D)"; break;
                case 24: item = "Scroll of benign transposition(A)"; break;
                case 25: item = "Scroll of blessed aim (D)"; break;
                case 26: item = "Scroll of comprehend languages " + ArcaneOrDivine(); break;
                case 27: case 28: item = "Scroll of cure light wounds (D)"; break;
                case 29: item = "Scroll of disguise self (A)"; break;
                case 30: item = "Scroll of endure elements " + ArcaneOrDivine(); break;
                case 31: item = "Scroll of hail of stone (A)"; break;
                case 32: item = "Scroll of mount (A)"; break;
                case 33: item = "Scroll of protection from chaos" + ArcaneOrDivine(); break;
                case 34: item = "Scroll of protection from evil " + ArcaneOrDivine(); break;
                case 35: item = "Scroll of protection from good " + ArcaneOrDivine(); break;
                case 36: item = "Scroll of protection from law " + ArcaneOrDivine(); break;
                case 37: item = "Scroll of remove fear " + ArcaneOrDivine(); break;
                case 38: item = "Scroll of resurgence (D)"; break;
                case 39: item = "Scroll of sanctuary (D)"; break;
                case 40: item = "Scroll of sign(D)"; break;
                case 41: item = "Scroll of snake’s swiftness (D)"; break;
                case 42: item = "Scroll of speak with animals (D)"; break;
                case 43: item = "Scroll of lesser vigor (D)"; break;
                case 44: case 45: item = "Thunderstone"; break;
                case 46: case 47: item = "Antitoxin"; break;
                case 48: case 49: item = "Blessed bandage (5)"; break;
                case 50: case 51: item = "Disguise kit"; break;
                case 52: case 53: item = "Healer’s kit"; break;
                case 54: case 55: item = "Oil of magic weapon"; break;
                case 57: case 58: case 59: case 60: case 61: case 62: case 63: case 64: case 65: item = "Potion of cure light wounds"; break;
                case 66: case 67: case 68: item = "Potion of endure elements"; break;
                case 69: case 70: case 71: item = "Potion of enlarge person"; break;
                case 72: case 73: case 74: case 75: item = "Potion of mage armor"; break;
                case 76: case 77: case 78: item = "Potion of magic fang"; break;
                case 79: case 80: case 81: item = "Potion of protection from chaos/evil/good/law"; break;
                case 82: case 83: item = "Potion of remove fear"; break;
                case 84: case 85: item = "Potion of shield of faith +2"; break;
                case 86: case 87: case 88: item = "Potion of lesser vigor"; break;
                case 89: case 90: item = "Quaal’s feather token, anchor"; break;
                case 91: case 92: item = "Skill shard"; break;
                case 93: case 94: item = "Tanglefoot bag"; break;
                case 95: case 96: case 97: case 98: item = "Thieves’ tools, masterwork"; break;
                case 99: case 100: item = "Universal solvent"; break;
                default: item = "Error"; break;
            }
            

            return item;
        }
        private string ItemLevelOne()
        {
            
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: case 2: case 3: case 4: item = "Wand of detect magic (10 charges)"; break;
                case 5: case 6: case 7: item = "Wand of light (10 charges)"; break;
                case 8: case 9: case 10: item = "Wand of read magic (10 charges)"; break;
                case 11: item = "Climber’s kit"; break;
                case 12: case 13: case 14: item = "Chain shirt"; break;
                case 15: item = "Crystal of illumination, least"; break;
                case 16: item = "Sleep arrow"; break;
                case 17: case 18: item = "Oil of bless weapon"; break;
                case 19: item = "Scroll of bless weapon (D)"; break;
                case 20: case 21: item = "Everburning torch"; break;
                case 22: case 23: case 24: case 25: item = "Scroll of identify (A)"; break;
                case 26: item = "Daylight pellet"; break;
                case 27: item = "Elixir of love"; break;
                case 28: item = "Scroll of baleful transposition (A)"; break;
                case 29: case 30: item = "Scroll of bear’s endurance" + ArcaneOrDivine(); break;
                case 31: case 32: item = "Scroll of bull’s strength" + ArcaneOrDivine(); break;
                case 33: case 34: item = "Scroll of cat’s grace" + ArcaneOrDivine(); break;
                case 35: case 36: case 37: item = "Scroll of cure moderate wounds (D)"; break;
                case 38: item = "Scroll of darkvision (A)"; break;
                case 39: item = "Scroll of delay poison (D)"; break;
                case 40: item = "Scroll of earthbind" + ArcaneOrDivine(); break;
                case 41: item = "Scroll of find traps (D)"; break;
                case 42: item = "Scroll of ghost touch armor" + ArcaneOrDivine(); break;
                case 43: item = "Scroll of glitterdust (A)"; break;
                case 44: case 45: item = "Scroll of invisibility (A)"; break;
                case 46: case 47: case 48: case 49: item = "Scroll of knock (A)"; break;
                case 50: case 51: case 52: item = "Scroll of remove paralysis (D)"; break;
                case 53: case 54: case 55: item = "Scroll of resist energy" + ArcaneOrDivine(); break;
                case 56: case 57: item = "Scroll of lesser restoration (D)"; break;
                case 58: item = "Scroll of see invisibility (A)"; break;
                case 59: item = "Scroll of silence (D)"; break;
                case 60: item = "Unguent of timelessness"; break;
                case 61: item = "Wand of benign transpositionSC (10 charges)"; break;
                case 62: case 63: item = "Wand of bless (10 charges)"; break;
                case 64: case 65: case 66: case 67: case 68: case 69: case 70: case 71: item = "Wand of cure light wounds (10 charges)"; break;
                case 72: case 73: item = "Wand of enlarge person (10 charges)"; break;
                case 74: item = "Wand of lesser vigor (10 charges)"; break;
                case 75: case 76: case 77: case 78: item = "Wand of mage armor (10 charges)"; break;
                case 79: case 80: case 81: case 82: case 83: case 84: item = "Wand of magic missile (CL 1st, 10 charges)"; break;
                case 85: item = "Wand of ray of enfeeblement (10 charges)"; break;
                case 86: item = "Wand of repair light damageSC (10 charges)"; break;
                case 87: item = "Wand of resurgence (10 charges)"; break;
                case 88: case 89: item = "Wand of shield (10 charges)"; break;
                case 90: item = "Wand of snake’s swiftness (10 charges)"; break;
                case 91: item = "Light wooden shield, masterwork"; break;
                case 92: item = "Heavy wooden shield, masterwork"; break;
                case 93: item = "Light steel shield, masterwork"; break;
                case 94: item = "Buckler, masterwork"; break;
                case 95: item = "Leather, masterwork"; break;
                case 96: item = "Hide armor, masterwork"; break;
                case 97: item = "Heavy steel shield, masterwork"; break;
                case 98: item = "Studded leather, masterwork"; break;
                case 99: item = "Chainmail"; break;
                case 100: item = "Tower shield, masterwork"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelTwo()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Scroll of arcane lock (A)"; break;
                case 2: item = "Crystal of lifekeeping, least"; break;
                case 3: item = "Everfull mug"; break;
                case 4: item = "Quaal’s feather token, fan"; break;
                case 5: item = "Skill shard, greater"; break;
                case 6: item = "Tanglepatch"; break;
                case 7: item = "Chain shirt, masterwork"; break;
                case 8: item = "Darkwood shield"; break;
                case 9: item = "Darkwood buckler"; break;
                case 10: item = "Crystal of aquatic action, least"; break;
                case 11: item = "Dust of tracelessness"; break;
                case 12: item = "Elixir of hiding"; break;
                case 13: item = "Elixir of sneaking"; break;
                case 14: item = "Elixir of swimming"; break;
                case 15: item = "Elixir of vision"; break;
                case 16: item = "Incense of concentration"; break;
                case 17: item = "Jumping caltrops"; break;
                case 18: item = "Safewing emblem"; break;
                case 19: item = "Silversheen"; break;
                case 20: item = "Crystal of adamant armor, least"; break;
                case 21: item = "Crystal of adamant weaponry, least"; break;
                case 22: item = "Blight stone"; break;
                case 23: item = "Crystal of return, least"; break;
                case 24: item = "Crystal of security, least"; break;
                case 25: item = "Crystal of stamina, least"; break;
                case 26: item = "Elixir of flaming fists"; break;
                case 27: item = "Fountainhead arrow"; break;
                case 28: item = "Oil of darkness"; break;
                case 29: item = "Potion of barkskin +2"; break;
                case 30: item = "Potion of bear’s endurance"; break;
                case 31: item = "Potion of blur"; break;
                case 32: item = "Potion of bull’s strength"; break;
                case 33: item = "Potion of cat’s grace"; break;
                case 34: case 35: case 36: case 37: item = "Potion of cure moderate wounds"; break;
                case 38: item = "Potion of darkvision"; break;
                case 39: item = "Potion of delay poison"; break;
                case 40: item = "Potion of eagle’s splendor"; break;
                case 41: item = "Potion of fox’s cunning"; break;
                case 42: item = "Potion of invisibility"; break;
                case 43: case 44: item = "Potion of lesser restoration"; break;
                case 45: item = "Potion of levitate"; break;
                case 46: item = "Potion of owl’s wisdom"; break;
                case 47: case 48: item = "Potion of remove paralysis"; break;
                case 49: case 50: item = "Potion of resist energy (type) 10"; break;
                case 51: item = "Potion of shield of faith +3"; break;
                case 52: item = "Potion of spider climb"; break;
                case 53: item = "Quaal’s feather token, bird"; break;
                case 54: item = "Stench stone"; break;
                case 55: item = "Screaming bolt"; break;
                case 56: case 57: case 58: item = "Masterwork " + Weapon(); break;
                case 59: item = "Silver dagger, masterwork"; break;
                case 60: item = "Cold iron longsword, masterwork"; break;
                case 61: item = "Breastplate, masterwork"; break;
                case 62: case 63: item = "Everlasting rations"; break;
                case 64: item = "Scroll of create food and water (D)"; break;
                case 65: case 66: item = "Scroll of cure serious wounds (D)"; break;
                case 67: item = "Scroll of daylight " + ArcaneOrDivine(); break;
                case 68: item = "Scroll of dispel magic " + ArcaneOrDivine(); break;
                case 69: item = "Scroll of fireball (A)"; break;
                case 70: item = "Scroll of fly (A)"; break;
                case 71: item = "Scroll of haste (A)"; break;
                case 72: item = "Scroll of invisibility purge (D)"; break;
                case 73: item = "Scroll of lightning bolt (A)"; break;
                case 74: item = "Scroll of magic circle against chaos " + ArcaneOrDivine(); break;
                case 75: item = "Scroll of magic circle against evil " + ArcaneOrDivine(); break;
                case 76: item = "Scroll of magic circle against good " + ArcaneOrDivine(); break;
                case 77: item = "Scroll of magic circle against law " + ArcaneOrDivine(); break;
                case 78: item = "Scroll of neutralize poison (D)"; break;
                case 79: item = "Scroll of protection from energy " + ArcaneOrDivine(); break;
                case 80: item = "Scroll of remove blindness/deafness (D)"; break;
                case 81: item = "Scroll of remove curse (D)"; break;
                case 82: item = "Scroll of remove disease (D)"; break;
                case 83: item = "Scroll of mass snake’s swiftness (D)"; break;
                case 84: item = "Scroll of speak with dead (D)"; break;
                case 85: item = "Scroll of tongues (A)"; break;
                case 86: item = "Scroll of vigor (D)"; break;
                case 87: item = "Scroll of mass lesser vigor (D)"; break;
                case 88: item = "Scroll of water breathing " + ArcaneOrDivine(); break;
                case 89: item = "Amulet of toxin delay"; break;
                case 90: item = "Charm of countersong"; break;
                case 91: item = "Crystal of illumination, lesser"; break;
                case 92: item = "Crystal of life drinking, least"; break;
                case 93: item = "Crystal of screening, least"; break;
                case 94: case 95: item = "Electric eel elixir"; break;
                case 96: item = "Essentia jewel"; break;
                case 97: item = "Life ring"; break;
                case 98: case 99: item = "Quaal’s feather token, tree"; break;
                case 100: item = "Revelation crystal, least"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelThree()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Glitter stone"; break;
                case 2: item = "Quaal’s feather token, swan boat"; break;
                case 3: item = "Amber amulet of vermin, giant bee"; break;
                case 4: item = "Amulet of aquatic salvation"; break;
                case 5: item = "Arcanist’s gloves"; break;
                case 6: int dres = D(2); if (dres == 1) { item = "Arrow "; } else { item = "Bolt "; }; item += "of biting"; break;
                case 7: item = "Boots of landing"; break;
                case 8: item = "Brute gauntlets"; break;
                case 9: item = "Chronocharm of the celestial wanderer"; break;
                case 10: item = "Chronocharm of the fateweaver"; break;
                case 11: item = "Chronocharm of the grand master"; break;
                case 12: item = "Chronocharm of the horizon walker"; break;
                case 13: item = "Chronocharm of the laughing rogue"; break;
                case 14: item = "Chronocharm of the uncaring archmage"; break;
                case 15: item = "Crystal of energy assault, least"; break;
                case 16: item = "Clasp of energy protection, least"; break;
                case 17: item = "Crystal of adaptation, least"; break;
                case 18: item = "Crystal of arcane steel, least"; break;
                case 19: item = "Crystal of arrow deflection, least"; break;
                case 20: item = "Crystal of bent sight"; break;
                case 21: item = "Crystal of glancing blows, least"; break;
                case 22: item = "Crystal of mind cloaking, least"; break;
                case 23: item = "Dust of dispersion"; break;
                case 24: item = "Elixir of adamantine blood"; break;
                case 25: item = "Elixir of truth"; break;
                case 26: item = "Iron ward diamond, least"; break;
                case 27: item = "Magic bedroll"; break;
                case 28: item = "Phoenix ash threat, least"; break;
                case 29: item = "Quaal’s feather token, whip"; break;
                case 30: item = "Reach gauntlets"; break;
                case 31: item = "Restful crystal"; break;
                case 32: item = "Rubicund frenzy, least"; break;
                case 33: item = "Shiftweave"; break;
                case 34: item = "Symbol of transfiguration"; break;
                case 35: item = "Talisman of the disk"; break;
                case 36: item = "Troll gut rope"; break;
                case 37: item = "Watch lamp"; break;
                case 38: item = "Necklace of copper dragon scales"; break;
                case 39: item = "Boots of agile leaping"; break;
                case 40: item = "Boots of stomping"; break;
                case 41: item = "Lenses of bright vision"; break;
                case 42: item = "Pearl of speech"; break;
                case 43: item = "Potion of barkskin +3"; break;
                case 44: item = "Potion of shield of faith +4"; break;
                case 45: item = "Wink brooch"; break;
                case 46: item = "Amber amulet of vermin, giant praying mantis"; break;
                case 47: item = "Amber amulet of vermin, giant queen ant"; break;
                case 48: item = "Amber amulet of vermin, Huge monstrous centipede"; break;
                case 49: item = "Amber amulet of vermin, Huge monstrous scorpion"; break;
                case 50: item = "Amber amulet of vermin, Large monstrous spider"; break;
                case 51: item = "Potion of resist energy (type) 20 "; item += ArcaneOrDivine(); break;
                case 52: item = "Scroll of air walk (D)"; break;
                case 53: item = "Scroll of cure critical wounds (D)"; break;
                case 54: item = "Scroll of darkvision, mass (A)"; break;
                case 55: item = "Scroll of death ward (D)"; break;
                case 56: item = "Scroll of dimensional anchor" ; item += ArcaneOrDivine(); break;
                case 57: item = "Scroll of dismissal (D)"; break;
                case 58: item = "Scroll of freedom of movement (D)"; break;
                case 59: item = "Scroll of ice storm (A)"; break;
                case 60: item = "Scroll of greater invisibility (A)"; break;
                case 61: item = "Scroll of know vulnerabilities (A)"; break;
                case 62: item = "Scroll of Leomund’s secure shelter (A)"; break;
                case 63: item = "Scroll of panacea (D)"; break;
                case 64: item = "Scroll of remove curse"; item += ArcaneOrDivine(); break;
                case 65: item = "Scroll of revenance (D)"; break;
                case 66: item = "Scroll of sending (D)"; break;
                case 67: item = "Scroll of tongues (D)"; break;
                case 68: item = "Soulvoid orb"; break;
                case 69: item = "Crest of bravery"; break;
                case 70: item = "Healing belt"; break;
                case 71: item = "Oil of greater magic weapon +1"; break;
                case 72: item = "Oil of keen edge"; break;
                case 73: item = "Oil of magic vestment +1"; break;
                case 74: case 75: item = "Potion of cure serious wounds"; break;
                case 76: item = "Potion of displacement"; break;
                case 77: item = "Potion of fly"; break;
                case 78: item = "Potion of gaseous form"; break;
                case 79: item = "Potion of greater magic fang +1"; break;
                case 80: item = "Potion of haste"; break;
                case 81: item = "Potion of heroism"; break;
                case 82: item = "Potion of magic circle against "; AlignmentDetermination(); break;
                case 83: item = "Potion of neutralize poison"; break;
                case 84: item = "Potion of protection from energy"; break;
                case 85: item = "Potion of remove blindness/deafness"; break;
                case 86: item = "Potion of remove curse"; break;
                case 87: item = "Potion of remove disease"; break;
                case 88: item = "Potion of vigor"; break;
                case 89: item = "Potion of water breathing"; break;
                case 90: item = "Powder of the black veil"; break;
                case 91: item = "Scrying beacon"; break;
                case 92: item = "Wand of magic missile (CL 5th, 10 charges)"; break;
                case 93: item = "Amber amulet of vermin, giant wasp"; break;
                case 94: item = "Bag of endless caltrops"; break;
                case 95: item = "Everlasting feedbag"; break;
                case 96: item = "Armband of elusive action"; break;
                case 97: item = "Ephod of authority"; break;
                case 98: item = "Porcupine elixir"; break;
                case 99: item = "Rope of stone"; break;
                case 100: item = "Scroll of restoration (D)"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelFour()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Eternal wand of cure light wounds"; break;
                case 2: item = "Eternal wand of enlarge person"; break;
                case 3: item = "Eternal wand of mage armor"; break;
                case 4: item = "Eternal wand of magic missile"; break;
                case 5: item = "Eternal wand of protection from "; AlignmentDetermination(); break;
                case 6: item = "Eternal wand of ray of enfeeblement"; break;
                case 7: item = "Eternal wand of repair light damage"; break;
                case 8: item = "Eternal wand of shield"; break;
                case 9: item = "Dust of dryness"; break;
                case 10: item = "Acrobat boots"; break;
                case 11: item = "Bag of tricks, gray"; break;
                case 12: item = "Blast disk"; break;
                case 13: item = "Crystal of stamina, lesser"; break;
                case 14: item = "Hand of the mage"; break;
                case 15: item = "Pearl of brain lock"; break;
                case 16: item = "Piercer cloak"; break;
                case 17: item = "Potion of barkskin +4"; break;
                case 18: item = "Wand of bear’s endurance (10 charges)"; break;
                case 19: item = "Wand of blur (10 charges)"; break;
                case 20: item = "Wand of bull’s strength (10 charges)"; break;
                case 21: item = "Wand of cat’s grace (10 charges)"; break;
                case 22: item = "Wand of cure moderate wounds (10 charges)"; break;
                case 23: item = "Wand of delay poison (10 charges)"; break;
                case 24: item = "Wand of invisibility (10 charges)"; break;
                case 25: item = "Wand of knock (10 charges)"; break;
                case 26: item = "Wand of mirror image (10 charges)"; break;
                case 27: item = "Wand of repair moderate damage (10 charges)"; break;
                case 28: item = "Wand of scorching ray (10 charges)"; break;
                case 29: item = "Wand of see invisibility (10 charges)"; break;
                case 30: item = "Scroll of stoneskin (A)"; break;
                case 31: item = "Bracers of armor +1"; break;
                case 32: item = "Brawler’s gauntlets"; break;
                case 33: item = "Brooch of stability"; break;
                case 34: item = "Burning veil"; break;
                case 35: item = "Cloak of elemental protection"; break;
                case 36: item = "Cloak of resistance +1"; break;
                case 37: item = "Cognizance crystal, 1 point"; break;
                case 38: item = "Crystal of aquatic action, lesser"; break;
                case 39: item = "Crystal of illumination, greater"; break;
                case 40: item = "Crystal of lifekeeping, lesser"; break;
                case 41: item = "Crystal of return, lesser"; break;
                case 42: item = "Crystal of screening, lesser"; break;
                case 43: item = "Crystal of security, lesser"; break;
                case 44: item = "Demolition crystal, least"; break;
                case 45: item = "Dispelling cord"; break;
                case 46: item = "Drums of marching"; break;
                case 47: item = "Eagle claw talisman"; break;
                case 48: item = "Fiendslayer crystal, least"; break;
                case 49: item = "Gauntlets of energy transformation"; break;
                case 50: item = "Gloves of spell disruption"; break;
                case 51: item = "Gloves of the starry sky"; break;
                case 52: item = "Glyph seal"; break;
                case 53: item = "Lightning gauntlets"; break;
                case 54: item = "Pearl of power, 1st-level spell"; break;
                case 55: item = "Phylactery of faithfulness"; break;
                case 56: item = "Reliquary holy symbol"; break;
                case 57: item = "Replenishing skin"; break;
                case 58: item = "Revelation crystal, lesser"; break;
                case 59: item = "Ring of brief blessing"; break;
                case 60: item = "Salve of slipperiness"; break;
                case 61: item = "Third eye improvisation"; break;
                case 62: item = "Truedeath crystal, least"; break;
                case 63: item = "Vest of resistance +1"; break;
                case 64: case 65: case 66: case 67: case 68: case 69: case 70: case 71: case 72: case 73: item =  Magic(1, 1, Protection()); break;
                case 74: item = "Mithral heavy shield"; break;
                case 75: item = "Potion of good hope"; break;
                case 76: item = "Mithral shirt"; break;
                case 77: item = "Elixir of fire breath"; break;
                case 78: item = "Potion of resist energy (type) 30"; break;
                case 79: item = "Scroll of break enchantment (A)"; break;
                case 80: item = "Scroll of contact other plane (A)"; break;
                case 81: item = "Scroll of greater dimension door (A)"; break;
                case 82: item = "Scroll of dismissal (A)"; break;
                case 83: item = "Scroll of disrupting weapon (D)"; break;
                case 84: item = "Scroll of fire shield, mass (A)"; break;
                case 85: item = "Scroll of mass fly (A)"; break;
                case 86: item = "Scroll of Mordenkainen’s private sanctum (A)"; break;
                case 87: item = "Scroll of plane shift (D)"; break;
                case 88: item = "Scroll of sending (A)"; break;
                case 89: item = "Scroll of teleport (A)"; break;
                case 90: item = "Scroll of vigorous circle (D)"; break;
                case 91: item = "Pipes of the sewers"; break;
                case 92: item = "Amber amulet of vermin, giant stag beetle"; break;
                case 93: item = "Dragon’s draught, brass"; break;
                case 94: item = "Dragon’s draught, white"; break;
                case 95: item = "Dust of illusion"; break;
                case 96: item = "Oil of greater magic weapon +2"; break;
                case 97: item = "Oil of magic vestment +2"; break;
                case 98: item = "Potion of barkskin +5"; break;
                case 99: item = "Potion of greater magic fang +2"; break;
                case 100: item = "Goggles of minute seeing"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelFive()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Beetle elixir"; break;
                case 2: item = "Fochlucan bandore"; break;
                case 3: item = "Medal of gallantry"; break;
                case 4: item = "Salve of minor spell resistance"; break;
                case 5: item = "Scrying shard"; break;
                case 6: item = "Snakeblood tooth"; break;
                case 7: item = "Wand of magic missile (CL 9th, 10 charges)"; break;
                case 8: item = "Wyrmfang amulet"; break;
                case 9: item = "Scroll of true seeing (D)"; break;
                case 10: item = "Crystal of adamant armor, lesser"; break;
                case 11: item = "Crystal of adamant weaponry, lesser"; break;
                case 12: item = "Anklet of translocation"; break;
                case 13: item = "Arcane thieves’ tools"; break;
                case 14: item = "Armband of confrontation"; break;
                case 15: item = "Badge of valor"; break;
                case 16: item = "Bag of boulders"; break;
                case 17: item = "Blighter’s hex-eye"; break;
                case 18: item = "Bracers of quick strike"; break;
                case 19: item = "Cloak of predatory vigor"; break;
                case 20: item = "Cobra straps"; break;
                case 21: item = "Ehlonna’s seed pouch"; break;
                case 22: item = "Lenses of revelation"; break;
                case 23: item = "Rod of frost"; break;
                case 24: item = "Rod of sliding"; break;
                case 25: case 26: item = "Sending stones (pair)"; break;
                case 27: item = "Spool of endless rope"; break;
                case 28: item = "Standard of valor"; break;
                case 29: item = "Steadfast boots"; break;
                case 30: item = "Aroma of dreams"; break;
                case 31: item = "Bracers of great collision"; break;
                case 32: item = "Brooch of shielding"; break;
                case 33: item = "Camouflage paint"; break;
                case 34: item = "Clasp of energy protection, lesser"; break;
                case 35: item = "Crystal of adaptation, lesser"; break;
                case 36: item = "Crystal of life drinking, lesser"; break;
                case 37: item = "Empowered spellshard, 1st-level spell"; break;
                case 38: item = "Enduring amulet"; break;
                case 39: item = "Exploding spike"; break;
                case 40: item = " Hammersphere"; break;
                case 41: item = "Inquisitor bracers"; break;
                case 42: item = "Javelin of lightning"; break;
                case 43: item = "Medal of steadfast honor"; break;
                case 44: item = "Memento magica, 1st-level spell"; break;
                case 45: item = "Artificer’s monocle"; break;
                case 46: item = "Bear helm"; break;
                case 47: item = "Belt of one mighty blow"; break;
                case 48: case 49: item = "Boots of dragonstriding"; break;
                case 50: case 51: item = "Boots of the mountain king"; break;
                case 52: case 53: item = "Tome of worldly memory"; break;
                case 54: case 55: item = "Headband of the lorebinder"; break;
                case 56: case 57: item = "Rhino elixir"; break;
                case 58: case 59: item = "Full plate, masterwork"; break;
                case 60: case 61: item = "Necklace of fireballs type I"; break;
                case 62: item = "Scroll of blade barrier (D)"; break;
                case 63: item = "Scroll of chain lightning (A)"; break;
                case 64: item = " Scroll of cloak of the sea (A)"; break;
                case 65: case 66: case 67: item = "Scroll of disintegrate (A)"; break;
                case 68: case 69: case 70: item = "Scroll of greater dispel magic " + ArcaneOrDivine(); break;
                case 71: item = "Scroll of energy immunity (D)"; break;
                case 72: item = "Scroll of find the path (D)"; break;
                case 73: item = "Scroll of ghost trap (D)"; break;
                case 74: case 75: case 76: item = "Scroll of harm (D)"; break;
                case 77: case 78: case 79: case 80: item = "Scroll of heal (D)"; break;
                case 81: item = "Scroll of shadow walk (A)"; break;
                case 82: case 83: item = "Scroll of stone to flesh (A)"; break;
                case 84: case 85: item = "Scroll of wind walk (D)"; break;
                case 86: case 87: item = "Dust of appearance"; break;
                case 88: item = "Githborn talisman"; break;
                case 89: item = "Hat of disguise"; break;
                case 90: case 91: case 92: item = "Oil of greater magic weapon +3"; break;
                case 93: case 94: item = "Oil of magic vestment +3"; break;
                case 95: item = " Pipes of sounding"; break;
                case 96: case 97: item = "Potion of greater magic fang +3"; break;
                case 98: case 99: item = "Quiver of Ehlonna"; break;
                case 100: item = "Sphere of awakening"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelSix()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Adamantine mind blade gauntlets"; break;
                case 2: item = "Amulet of natural armor +1"; break;
                case 3: item = "Amulet of retributive healing"; break;
                case 4: item = "Amulet of teamwork"; break;
                case 5: item = "Belt of theft-healing"; break;
                case 6: item = "Boots of the battle charger"; break;
                case 7: item = "Bracers of the entangling blast"; break;
                case 8: item = "Caduceus bracers"; break;
                case 9: item = "Cape of the viper"; break;
                case 10: item = "Caustic veil"; break;
                case 11: item = "Crystal of arcane steel, lesser"; break;
                case 12: item = "Devastation gauntlets"; break;
                case 13: item = "Dimension stride boots"; break;
                case 14: item = "Dragon spirit amulet"; break;
                case 15: item = "Dragon spirit cincture"; break;
                case 16: item = "Field provisions box"; break;
                case 17: item = "Gauntlets of arrow reflection"; break;
                case 18: item = "Gauntlets of extended range"; break;
                case 19: item = "Gauntlets of giantfelling"; break;
                case 20: item = "Gauntlets of throwing"; break;
                case 21: item = "Gloves of fortunate striking"; break;
                case 22: item = "Gloves of lightning"; break;
                case 23: item = "Goggles of lifesight"; break;
                case 24: item = "Goodberry bracelet"; break;
                case 25: item = "Greatreach bracers"; break;
                case 26: item = "Headband of conscious effort"; break;
                case 27: item = "Helm of battle"; break;
                case 28: item = "Helm of tactics"; break;
                case 29: item = "Heward’s handy haversack"; break;
                case 30: item = "Horn of fog"; break;
                case 31: item = "Iron ward diamond, lesser"; break;
                case 32: item = "Mask of sweet air"; break;
                case 33: item = "Orb of environmental adaptation"; break;
                case 34: item = "Pearl of breath crisis"; break;
                case 35: item = "Phoenix ash threat, lesser"; break;
                case 36: item = "Rearguard’s cape"; break;
                case 37: item = "Ring of communication"; break;
                case 38: item = "Ring of floating"; break;
                case 39: item = "Ring of four winds"; break;
                case 40: item = "Ring of piercing spells"; break;
                case 41: item = "Ring of protection +1"; break;
                case 42: item = "Ring of the darkhidden"; break;
                case 43: item = "Ring of silent spells"; break;
                case 44: item = "Rock boots"; break;
                case 45: item = "Rod of grievous wounds"; break;
                case 46: item = "Rod of viscid globs"; break;
                case 47: item = "Rubicund frenzy, lesser"; break;
                case 48: item = "Sepulchral vest"; break;
                case 49: item = "Silkslick belt"; break;
                case 50: item = "Slashing sand"; break;
                case 51: item = "Spellsink scarab"; break;
                case 52: item = "Torc of displacement"; break;
                case 53: item = "Vest of defense"; break;
                case 54: case 55: case 56: case 57: case 58: case 59: case 60: item = Magic(2, 1, Weapon()); break;
                case 61: item = "Amulet of incarnum shielding"; break;
                case 62: item = "Enemy spirit pouch"; break;
                case 63: item = "Mac-Fuirmidh cithern"; break;
                case 64: item = "Third eye surge"; break;
                case 65: item = "Scroll of revivify (D)"; break;
                case 66: item = "Shield of mercy"; break;
                case 67: item = "Gloves of agile striking"; break;
                case 68: item = "Ring of feather falling"; break;
                case 69: item = "Elemental gem"; break;
                case 70: item = "Healing salve"; break;
                case 71: item = "Wand of call lightning (10 charges)"; break;
                case 72: item = "Wand of cure serious wounds (10 charges)"; break;
                case 73: item = "Wand of dispel magic (10 charges)"; break;
                case 74: item = "Wand of displacement (10 charges)"; break;
                case 75: item = "Wand of fireball (10 charges)"; break;
                case 76: item = "Wand of fly (10 charges)"; break;
                case 77: item = "Wand of haste (10 charges)"; break;
                case 78: item = "Wand of invisibility sphere (10 charges)"; break;
                case 79: item = "Wand of lightning bolt (10 charges)"; break;
                case 80: item = "Wand of mass lesser vigor (10 charges)"; break;
                case 81: item = "Wand of repair serious damage (10 charges)"; break;
                case 82: item = "Wand of vigor (10 charges)"; break;
                case 83: item = "Scroll of banishment (A)"; break;
                case 84: item = "Scroll of energy immunity (A)"; break;
                case 85: item = "Scroll of ethereal jaunt " + ArcaneOrDivine(); break;
                case 86: item = "Scroll of invisibility, mass (A)"; break;
                case 87: item = "Scroll of Mordenkainen’s magnificent mansion (A)"; break;
                case 88: item = "Scroll of regenerate (D)"; break;
                case 89: item = "Scroll of spell turning (A)"; break;
                case 90: item = "Scroll of sunbeam (D)"; break;
                case 91: item = "Scroll of teleport, greater (A)"; break;
                case 92: item = "Slaying arrow"; break;
                case 93: item = "Amulet of tears"; break;
                case 94: item = "Bracers of arcane freedom"; break;
                case 95: item = "Bracers of opportunity"; break;
                case 96: item = "Brute ring"; break;
                case 97: item = "Cloak of weaponry"; break;
                case 98: item = "Rod of fumbling"; break;
                case 99: item = "Repelling gauntlets"; break;
                case 100: item = "Sandals of sprinting"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelSeven()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Scroll of restoration, mass (D)"; break;
                case 2: item = "Dragon’s draught, black"; break;
                case 3: item = "Dragon’s draught, copper"; break;
                case 4: item = "Oil of greater magic weapon +4"; break;
                case 5: item = "Oil of magic vestment +4"; break;
                case 6: item = "Potion of greater magic fang +4"; break;
                case 7: item = "Robe of bones"; break;
                case 8: item = "Scroll of revenance (A)"; break;
                case 9: item = "Sovereign glue"; break;
                case 10: item = "Bag of holding type I"; break;
                case 11: item = "Boots of elvenkind"; break;
                case 12: item = "Boots of jumping"; break;
                case 13: item = "Boots of the winterlands"; break;
                case 14: item = "Candle of truth"; break;
                case 15: item = "Censer of the last breath"; break;
                case 16: item = "Cloak of elvenkind"; break;
                case 17: item = "Cloak of quills"; break;
                case 18: item = "Counterstrike bracers"; break;
                case 19: item = "Crystal anchor of alertness"; break;
                case 20: item = "Crystal mask of knowledge"; break;
                case 21: item = "Crystal mask of languages"; break;
                case 22: item = "Crystal of arrow deflection, lesser"; break;
                case 23: item = "Eyes of the eagle"; break;
                case 24: item = "Gloves of eldritch admixture"; break;
                case 25: item = "Goggles of foefinding"; break;
                case 26: item = "Golembane scarab"; break;
                case 27: item = "Icy strand of the north"; break;
                case 28: item = "Ring of climbing"; break;
                case 29: item = "Ring of jumping"; break;
                case 30: item = "Ring of sustenance"; break;
                case 31: item = "Ring of swimming"; break;
                case 32: item = "Spellsight spectacles"; break;
                case 33: item = "Third eye dampening"; break;
                case 34: item = "Third eye expose"; break;
                case 35: item = "Tunic of steady spellcasting"; break;
                case 36: item = "Vanisher cloak"; break;
                case 37: item = "Bands of blood rage"; break;
                case 38: item = "Third eye freedom"; break;
                case 39: item = "Crystal of energy assault, lesser"; break;
                case 40: item = "Crystal of stamina, greater"; break;
                case 41: item = "Metamagic rod, Substitution, lesser"; break;
                case 42: item = "Necklace of fireballs type II"; break;
                case 43: item = "Panther mask"; break;
                case 44: item = "Stone of alarm"; break;
                case 45: item = "Wand of searing light (CL 6th, 10 charges)"; break;
                case 46: item = "Aberrant sphere"; break;
                case 47: item = "Boots of desperation"; break;
                case 48: item = "Infinite scrollcase"; break;
                case 49: item = "Meteoric knife"; break;
                case 50: item = "Bag of tricks, rust"; break;
                case 51: item = "Bead of force"; break;
                case 52: item = "Belt of growth"; break;
                case 53: item = "Burnoose of 1,001 thorns"; break;
                case 54: item = "Chime of opening"; break;
                case 55: item = "Circlet of solace"; break;
                case 56: item = "Clasp of energy protection, greater"; break;
                case 57: item = "Contact medallion"; break;
                case 58: item = "Cord of favor"; break;
                case 59: item = "Corsair’s eye patch"; break;
                case 60: item = "Crystal of adaptation, greater"; break;
                case 61: item = "Crystal of aquatic action, greater"; break;
                case 62: item = "Crystal of glancing blows, lesser"; break;
                case 63: item = "Crystal of screening, greater"; break;
                case 64: item = "Crystal of security, greater"; break;
                case 65: item = "Demolition crystal, lesser"; break;
                case 66: item = "Empowered spellshard, 2nd-level spell"; break;
                case 67: item = "Essentia helm"; break;
                case 68: item = "Fiendslayer crystal, lesser"; break;
                case 69: item = "Gloves of manual prowess"; break;
                case 70: item = "Gloves of object reading"; break;
                case 71: item = "Heartseeking amulet"; break;
                case 72: item = "Horseshoes of speed"; break;
                case 73: item = "Metamagic rod, Enlarge, lesser"; break;
                case 74: item = "Metamagic rod, Extend, lesser"; break;
                case 75: item = "Metamagic rod, Sculpting, lesser"; break;
                case 76: item = "Metamagic rod, Silent, lesser"; break;
                case 77: item = "Oil of greater magic weapon +5"; break;
                case 78: item = "Oil of magic vestment +5"; break;
                case 79: item = "Potion of greater magic fang +5"; break;
                case 80: item = "Rope of climbing"; break;
                case 81: item = "Scroll of brilliant aura (D)"; break;
                case 82: item = "Scroll of cure critical wounds, mass (D)"; break;
                case 83: item = "Scroll of death ward, mass (D)"; break;
                case 84: item = "Scroll of dimensional lock " + ArcaneOrDivine(); break;
                case 85: item = "Scroll of discern location (D)"; break;
                case 86: item = "Scroll of earthquake (D)"; break;
                case 87: item = "Scroll of fire storm (D)"; break;
                case 88: item = "Scroll of ghostform (A)"; break;
                case 89: item = "Scroll of horrid wilting (A)"; break;
                case 90: item = "Scroll of invisibility, superior (A)"; break;
                case 91: item = "Scroll of iron body (A)"; break;
                case 92: item = "Scroll of mind blank (A)"; break;
                case 93: item = "Scroll of greater plane shift (A)"; break;
                case 94: item = "Scroll of polar ray (A)"; break;
                case 95: item = "Scroll of sunburst (D)"; break;
                case 96: item = "Soulsmite gauntlets"; break;
                case 97: item = "Talisman of undead mastery"; break;
                case 98: item = "Third eye clarity"; break;
                case 99: item = "Adamantine dagger"; break;
                case 100: item = "Adamantine battleaxe"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelEight()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Brooch of avoidance"; break;
                case 2: item = "Caster’s shield"; break;
                case 3: item = "Chime of harmonic agony"; break;
                case 4: item = "Gloves of the uldra savant"; break;
                case 5: item = "Hexbands"; break;
                case 6: item = "Orb of mental renewal"; break;
                case 7: item = "Pipes of frenzied revelry"; break;
                case 8: item = "Rapidstrike bracers"; break;
                case 9: item = "Rod of bodily restoration"; break;
                case 10: item = "Summoner’s totem"; break;
                case 11: item = "Vanguard treads"; break;
                case 12: item = "Bracers of the blast barrier"; break;
                case 13: item = "Eyes of expanded vision"; break;
                case 14: item = "Formless vest"; break;
                case 15: item = "Hellcat gauntlets"; break;
                case 16: item = "Rags of restraint"; break;
                case 17: item = "Skirmisher boots"; break;
                case 18: item = "Domain draught"; break;
                case 19: item = "Mask of blood"; break;
                case 20: item = "Reins of ascension"; break;
                case 21: item = "Spellmight bracers"; break;
                case 22: item = "Survival pouch"; break;
                case 23: item = "Torc of the titans"; break;
                case 24: item = "Dragonhide plate"; break;
                case 25: item = "Crystal of adamant armor, greater"; break;
                case 26: item = "Crystal of adamant weaponry, greater"; break;
                case 27: item = "Badge of glory"; break;
                case 28: item = "Bow of the wintermoon"; break;
                case 29: item = "Hair shirt of suffering"; break;
                case 30: item = "Scout’s headband"; break;
                case 31: item = "Mithralmist shirt"; break;
                case 32: item = "Bag of flames"; break;
                case 33: item = "Crystal of alacrity"; break;
                case 34: item = "Dragon’s draught, bronze"; break;
                case 35: item = "Dragon’s draught, green"; break;
                case 36: item = "Dust of disappearance"; break;
                case 37: item = "Finned gauntlets"; break;
                case 38: item = "Lens of detection"; break;
                case 39: item = "Lockpicking ring"; break;
                case 40: item = "Mask of mastery"; break;
                case 41: item = "Quicksilver boots"; break;
                case 42: item = "Radiant sphere"; break;
                case 43: item = "Raptor’s mask"; break;
                case 44: item = "Ring of mystic healing"; break;
                case 45: item = "Rod of escape"; break;
                case 46: item = "Shard of the sun"; break;
                case 47: item = "Sleeping spike"; break;
                case 48: item = "True strike gauntlets"; break;
                case 49: item = "Belt of ultimate athleticism"; break;
                case 50: item = "Enveloping pit"; break;
                case 51: item = "Mirror of suggestion"; break;
                case 52: item = "Mithral bells"; break;
                case 53: item = "Rending gauntlets"; break;
                case 54: item = "Shadow maniple"; break;
                case 55: item = "Figurine of wondrous power, silver raven"; break;
                case 56: item = "Scroll of freedom (A)"; break;
                case 57: item = "Scroll of heal, mass (D)"; break;
                case 58: item = "Amulet of health +2"; break;
                case 59: item = "Boots of the unending journey"; break;
                case 60: item = "Bracers of accuracy"; break;
                case 61: item = "Bracers of armor +2"; break;
                case 62: item = "Bracers of repulsion"; break;
                case 63: item = "Cloak of Charisma +2"; break;
                case 64: item = "Cloak of resistance +2"; break;
                case 65: item = "Cognizance crystal, 3 points"; break;
                case 66: item = "Crystal of mind cloaking, lesser"; break;
                case 67: item = "Crystal of return, greater"; break;
                case 68: item = "Dragon mask"; break;
                case 69: item = "Gauntlets of ghost fighting"; break;
                case 70: item = "Gauntlets of ogre power"; break;
                case 71: item = "Gauntlets of the talon"; break;
                case 72: item = "Gloves of arrow snaring"; break;
                case 73: item = "Gloves of Dexterity +2"; break;
                case 74: item = "Glyph seal, greater"; break;
                case 75: item = "Goggles of the golden sun"; break;
                case 76: item = "Headband of intellect +2"; break;
                case 77: item = "Ioun stone, clear spindle"; break;
                case 78: item = "Keoghtom’s ointment"; break;
                case 79: item = "Mask of mental armor"; break;
                case 80: item = "Mask of the tiger"; break;
                case 81: item = "Necklace of warning"; break;
                case 82: item = "Nolzur’s marvelous pigments"; break;
                case 83: item = "Pearl of power, 2nd-level spell"; break;
                case 84: item = "Pendant of joy"; break;
                case 85: item = "Periapt of Wisdom +2"; break;
                case 86: item = "Ring of counterspells"; break;
                case 87: item = "Rod of silence"; break;
                case 88: item = "Rod of sure striking"; break;
                case 89: item = "Scry shroud"; break;
                case 90: item = "Stone salve"; break;
                case 91: item = "Stormfire ring"; break;
                case 92: item = "Surcoat of valor"; break;
                case 93: item = "Torc of power preservation"; break;
                case 94: item = "Veil of storms"; break;
                case 95: item = "Vest of resistance +2"; break;
                case 96: item = "Wilding clasp"; break;
                case 97: case 98: case 99: case 100: item = Magic(1, 2, Protection()); break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelNine()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Slaying arrow, greater"; break;
                case 2: item = "Armbands of might"; break;
                case 3: item = "Doss lute"; break;
                case 4: item = "Crystal echoblade"; break;
                case 5: item = "Elven chain"; break;
                case 6: item = "Barricade buckler"; break;
                case 7: item = "Circlet of wild surging"; break;
                case 8: case 9: item = "Wand of cure critical wounds (10 charges)"; break;
                case 10: item = "Wand of death ward (10 charges)"; break;
                case 11: item = "Wand of freedom of movement (10 charges)"; break;
                case 12: item = "Wand of greater invisibility (10 charges)"; break;
                case 13: item = "Wand of ice storm (10 charges)"; break;
                case 14: item = "Wand of repair critical damage (10 charges)"; break;
                case 15: item = "White cloak of the spider"; break;
                case 16: item = "Shatterspike"; break;
                case 17: item = "Living chain"; break;
                case 18: item = "Necklace of fireballs type III"; break;
                case 19: item = "Strand of lightning"; break;
                case 20: item = "Sacred scabbard"; break;
                case 21: item = "Thorn pouch"; break;
                case 22: item = "Eternal wand of blur"; break;
                case 23: item = "Eternal wand of cure moderate wounds"; break;
                case 24: item = "Eternal wand of invisibility"; break;
                case 25: item = "Eternal wand of mirror image"; break;
                case 26: item = "Eternal wand of repair moderate damage"; break;
                case 27: item = "Eternal wand of see invisibility"; break;
                case 28: item = "Eternal wand of snake’s swiftness"; break;
                case 29: item = "Eternal wand of web"; break;
                case 30: item = "Scroll of greater restoration (D)"; break;
                case 31: item = "Aroma of curdled death"; break;
                case 32: item = "Barbs of retribution"; break;
                case 33: item = "Belt of the champion"; break;
                case 34: item = "Circlet of persuasion"; break;
                case 35: item = "Dragon’s draught, blue"; break;
                case 36: item = "Dragon’s draught, silver"; break;
                case 37: item = "Gem of the glitterdepth"; break;
                case 38: item = "Goggles of day"; break;
                case 39: item = "Helm of the purple plume"; break;
                case 40: item = "Mask of lies"; break;
                case 41: item = "Ring of vengeance"; break;
                case 42: case 43: item = "Wand of dispel magic (CL 10th, 10 charges)"; break;
                case 44: case 45: item = "Wand of fireball (CL 10th, 10 charges)"; break;
                case 46: case 47: item = "Wand of lightning bolt (CL 10th, 10 charges)"; break;
                case 48: item = "Wand of searing light (CL 10th, 10 charges)"; break;
                case 49: item = "Shield of the severed hand"; break;
                case 50: item = "Bowstaff"; break;
                case 51: item = "Personal oasis"; break;
                case 52: item = "Bladed crossbow"; break;
                case 53: item = "Slippers of spider climbing"; break;
                case 54: item = "Scroll of teleportation circle (A)"; break;
                case 55: item = "Incense of meditation"; break;
                case 56: item = "Amulet of fortune prevailing"; break;
                case 57: item = "Bag of holding type II"; break;
                case 58: item = "Belt of hidden pouches"; break;
                case 59: item = "Bolt shirt"; break;
                case 60: item = "Boots of swift passage"; break;
                case 61: item = "Boots of tremorsense"; break;
                case 62: item = "Bracers of aerial combat"; break;
                case 63: item = "Bracers of archery, lesser"; break;
                case 64: item = "Bracers of blinding strike"; break;
                case 65: item = "Bracers of retaliation"; break;
                case 66: item = "Circlet of mages"; break;
                case 67: item = "Cloak of soulbound resistance"; break;
                case 68: item = "Collar of healing"; break;
                case 69: item = "Crimson dragonhide bracers"; break;
                case 70: item = "Crystal of arrow deflection, greater"; break;
                case 71: item = "Crystal of glancing blows, greater"; break;
                case 72: item = "Crystal of lifekeeping, greater"; break;
                case 73: item = "Truedeath crystal, lesser"; break;
                case 74: item = "Deathstrike bracers"; break;
                case 75: item = "Diamondskin decanter"; break;
                case 76: item = "Dragonscale cloak"; break;
                case 77: item = "Fiendslayer crystal, greater"; break;
                case 78: item = "Fiery tunic"; break;
                case 79: item = "Gauntlets of eldritch energy"; break;
                case 80: item = "Gauntlets of lassitude"; break;
                case 81: item = "Ghost shroud"; break;
                case 82: item = "Hand of the oak father"; break;
                case 83: item = "Helm of gazes"; break;
                case 84: item = "Horn of resilience"; break;
                case 85: item = "Immovable rod"; break;
                case 86: item = "Ioun stone, dusty rose prism"; break;
                case 87: item = "Ki straps"; break;
                case 88: item = "Mask of silent trickery"; break;
                case 89: item = "Noble pennon"; break;
                case 90: item = "Orb of blinding"; break;
                case 91: item = "Platinum helm"; break;
                case 92: item = "Portable foxhole"; break;
                case 93: item = "Reciprocal bracers"; break;
                case 94: item = "Revelation crystal, greater"; break;
                case 95: item = "Ring of arming"; break;
                case 96: item = "Ring of master artifice, lesser"; break;
                case 97: item = "Spider fang"; break;
                case 98: item = "Vampire torc"; break;
                case 99: item = "Vestments of ebonsilk"; break;
                case 100: item = "Witchlight reservoir"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelTen()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Raptor arrow"; break;
                case 2: item = "Ring of the forcewall"; break;
                case 3: item = "Gauntlets of the blood-lord"; break;
                case 4: item = "Hooked hammer of the hearthfire"; break;
                case 5: item = "Rhino hide"; break;
                case 6: item = "Helm of comprehend languages and read magic"; break;
                case 7: item = "Map of unseen lands"; break;
                case 8: item = "Vest of escape"; break;
                case 9: item = "Galeb duhr hammer"; break;
                case 10: item = "Assassin whip"; break;
                case 11: item = "Trident of serenity"; break;
                case 12: item = "Manticore greatsword"; break;
                case 13: item = "Eversmoking bottle"; break;
                case 14: item = "Murlynd’s spoon"; break;
                case 15: item = "Necklace of fireballs type IV"; break;
                case 16: item = "Boots of striding and springing"; break;
                case 17: item = "Dragon’s draught, gold"; break;
                case 18: item = "Dragon’s draught, red"; break;
                case 19: item = "Eyes of truth"; break;
                case 20: item = "Rope of climbing, superior"; break;
                case 21: item = "Tabard of the great crusade"; break;
                case 22: item = "Tome of ancient lore"; break;
                case 23: item = "Wind fan"; break;
                case 24: item = "Shield of the resolute"; break;
                case 25: item = "Spined shield"; break;
                case 26: item = "Helm of glorious recovery"; break;
                case 27: item = "Helm of heroes"; break;
                case 28: item = "Staff of the unyielding oak"; break;
                case 29: item = "Claw gloves"; break;
                case 30: item = "Necklace of fireballs type V"; break;
                case 31: item = "Amulet of emergency healing"; break;
                case 32: item = "Amulet of mighty fists +1"; break;
                case 33: item = "Amulet of wordtwisting"; break;
                case 34: item = "Belt of priestly might"; break;
                case 35: item = "Boots of big stepping"; break;
                case 36: item = "Boots of sidestepping"; break;
                case 37: item = "Cloak of the salamander"; break;
                case 38: item = "Conduit rod"; break;
                case 39: item = "Cornucopia of the needful"; break;
                case 40: item = "Crystal of arcane steel, greater"; break;
                case 41: item = "Crystal of life drinking, greater"; break;
                case 42: item = "Deathguardian bracers"; break;
                case 43: item = "Empowered spellshard, 3rd-level spell"; break;
                case 44: item = "Executioner’s hood"; break;
                case 45: item = "Farspeaking amulet"; break;
                case 46: item = "Gauntlets of weaponry arcane"; break;
                case 47: item = "Globe of sunlight"; break;
                case 48: item = "Gwaeron’s boots"; break;
                case 49: item = "Horseshoes of a zephyr"; break;
                case 50: item = "Memento magica, 2nd-level spell"; break;
                case 51: item = "Periapt of the sullen sea"; break;
                case 52: item = "Crystal of energy assault, greater"; break;
                case 53: item = "Demolition crystal, greater"; break;
                case 54: item = "Phoenix ash threat, greater"; break;
                case 55: item = "Pipes of haunting"; break;
                case 56: item = "Psychoactive skin of the celestial"; break;
                case 57: item = "Psychoactive skin of ectoplasmic armor"; break;
                case 58: item = "Psychoactive skin of the fiend"; break;
                case 59: item = "Ring of adamantine touch"; break;
                case 60: item = "Ring of essentia"; break;
                case 61: item = "Ring of thunderclaps"; break;
                case 62: item = "Ring of water breathing"; break;
                case 63: item = "Rod of surprises"; break;
                case 64: item = "Rod of transposition"; break;
                case 65: item = "Rubicund frenzy, greater"; break;
                case 66: item = "Shackles of silence"; break;
                case 67: item = "Shirt of wraith stalking"; break;
                case 68: item = "Spectral dagger"; break;
                case 69: item = "Strongarm bracers"; break;
                case 70: item = "Tabard of the disembodied"; break;
                case 71: item = "Torc of heroic sacrifice"; break;
                case 72: item = "Toxic gloves"; break;
                case 73: item = "Transposer cloak"; break;
                case 74: item = "Unicorn pendant"; break;
                case 75: case 76: case 77: item = "Scroll of raise dead (D)"; break;
                case 78: item = "Shield of vigor"; break;
                case 79: item = "Wrapped tower"; break;
                case 80: item = "Skull plaque"; break;
                case 81: item = "Gloves of swimming and climbing"; break;
                case 82: item = "Bag of tricks, tan"; break;
                case 83: item = "Gauntlets of the blazing arc"; break;
                case 84: item = "Whip of webs"; break;
                case 85: item = "Dagger of defiance"; break;
                case 86: item = "Scorpion kama"; break;
                case 87: item = "Viperblade"; break;
                case 88: item = "Death spike"; break;
                case 89: item = "Stonereaver"; break;
                case 90: item = "Swordbow, light"; break;
                case 91: item = "Swordbow"; break;
                case 92: item = "Circlet of blasting, minor"; break;
                case 93: item = "Gauntlet of infinite blades"; break;
                case 94: item = "Greater piwafwi"; break;
                case 95: item = "Helm of wounding sight"; break;
                case 96: item = "Horn of goodness/evil"; break;
                case 97: item = "Monocle of perusal"; break;
                case 98: item = "Phoenix helm"; break;
                case 99: item = "Phylactery of virtue"; break;
                case 100: item = "Robe of retaliation"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelEleven()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Gauntlets of destruction"; break;
                case 2: case 3: item = "Wand of stoneskin (10 charges)"; break;
                case 4: item = "Swordbow, great"; break;
                case 5: item = "Boots of skating"; break;
                case 6: item = "Gloves of endless javelins"; break;
                case 7: item = "Gloves of flame"; break;
                case 8: item = "Robe of useful items"; break;
                case 9: item = "Tomebound eye of Boccob"; break;
                case 10: item = "Veil of whispers"; break;
                case 11: item = "The fist"; break;
                case 12: item = "Armband of maximized healing"; break;
                case 13: item = "Folding boat"; break;
                case 14: item = "Cloak of the manta ray"; break;
                case 15: item = "Bottle of air"; break;
                case 16: item = "Morningstar of the many"; break;
                case 17: item = "Rod of defiance"; break;
                case 18: item = "Stunshot sling"; break;
                case 19: item = "Bag of holding type III"; break;
                case 20: item = "Periapt of health"; break;
                case 21: item = "Boots of levitation"; break;
                case 22: item = "Dreaming blindfold"; break;
                case 23: item = "Harp of charming"; break;
                case 24: item = "Lore gem"; break;
                case 25: item = "Ring of mystic defiance"; break;
                case 26: item = "Ring of mystic fire"; break;
                case 27: item = "Ring of mystic lightning"; break;
                case 28: item = "Tome of the stilled tongue"; break;
                case 29: case 30: case 31: item = "Amulet of natural armor +2"; break;
                case 32: item = "Belt of the wide earth"; break;
                case 33: item = "Blast globes"; break;
                case 34: item = "Chasuble of fell power"; break;
                case 35: item = "Cloak of stone"; break;
                case 36: item = "Crystal of energy assault, greater"; break;
                case 37: item = "Flesh ring of scorn"; break;
                case 38: item = "Gauntlet of Gruumsh"; break;
                case 39: item = "Ghost net"; break;
                case 40: item = "Gloves of the balanced hand"; break;
                case 41: item = "Gloves of incarnum theft"; break;
                case 42: item = "Golem manual, flesh"; break;
                case 43: item = "Hand of glory"; break;
                case 44: item = "Horned helm"; break;
                case 45: case 46: case 47: item = "Ioun stone, deep red sphere"; break;
                case 48: case 49: case 50: item = "Ioun stone, incandescent blue sphere"; break;
                case 51: case 52: case 53: item = "Ioun stone, pale blue rhomboid"; break;
                case 54: case 55: case 56: item = "Ioun stone, pink and green sphere"; break;
                case 57: case 58: case 59: item = "Ioun stone, pink rhomboid"; break;
                case 60: case 61: case 62: item = "Ioun stone, scarlet and blue sphere"; break;
                case 63: item = "Iron ward diamond, greater"; break;
                case 64: item = "Lightning tunic"; break;
                case 65: item = "Mantle of the predator"; break;
                case 66: item = "Medallion of aerial defense"; break;
                case 67: item = "Mesmerist’s gloves"; break;
                case 68: item = "Mindvault"; break;
                case 69: item = "Psionatrix"; break;
                case 70: item = "Ring of antivenom"; break;
                case 71: item = "Ring of entropic deflection"; break;
                case 72: item = "Ring of mind shielding"; break;
                case 73: case 74: case 75: case 76: item = "Ring of protection +2"; break;
                case 77: item = "Runestaff of charming"; break;
                case 78: item = "Scentblinder"; break;
                case 79: item = "Scrolls of uncertain provenance"; break;
                case 80: item = "Shirt of the leech"; break;
                case 81: item = "Talisman of undying fortitude"; break;
                case 82: item = "Third eye penetrate"; break;
                case 83: item = "Vambraces of warding"; break;
                case 84: case 85: case 86: case 87: case 88: case 89: case 90: case 91: case 92: case 93: case 94: case 95: case 96: case 97: case 98: case 99: case 100: item = Magic(2, 2, Weapon()); break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelTwelve()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Canaith mandolin"; break;
                case 2: item = "Deck of illusions"; break;
                case 3: item = "Necklace of fireballs type VI"; break;
                case 4: item = "Mace of the dark children"; break;
                case 5: item = "Millennial chainmail"; break;
                case 6: item = "Dragonfang gauntlets"; break;
                case 7: item = "Owlfeather armor"; break;
                case 8: item = "Fanged mask"; break;
                case 9: item = "Dagger of venom"; break;
                case 10: item = "Warlock’s scepter"; break;
                case 11: item = "Blazing skylance"; break;
                case 12: item = "Forceful skylance"; break;
                case 13: item = "Axe of ancestral virtue"; break;
                case 14: item = "Candle of invocation"; break;
                case 15: item = "Runestaff of fire"; break;
                case 16: item = "Crown of flames"; break;
                case 17: item = "Ring of force shield"; break;
                case 18: item = "Ring of the ram"; break;
                case 19: item = "Necklace of fireballs type VII"; break;
                case 20: item = "Ankh of ascension"; break;
                case 21: item = "Battle bridle"; break;
                case 22: item = "Blindfold of true darkness"; break;
                case 23: item = "Bracers of armor +3"; break;
                case 24: item = "Cat’s-eye brooch"; break;
                case 25: item = "Cloak of resistance +3"; break;
                case 26: item = "Cognizance crystal, 5 points"; break;
                case 27: item = "Daern’s instant tent"; break;
                case 28: item = "Decanter of endless water"; break;
                case 29: item = "Helm of the hunter"; break;
                case 30: item = "Metamagic rod, Empower, lesser"; break;
                case 31: item = "Metamagic rod, Reach, lesser"; break;
                case 32: item = "Mirror of time hop"; break;
                case 33: item = "Necklace of adaptation"; break;
                case 34: item = "Pearl of power, 3rd-level spell"; break;
                case 35: item = "Retributive amulet"; break;
                case 36: item = "Rod of the recluse"; break;
                case 37: item = "Sandals of the light step"; break;
                case 38: item = "Scepter of the netherworld"; break;
                case 39: item = "Shirt of bone"; break;
                case 40: item = "Shirt of chains"; break;
                case 41: item = "Shirt of the treant"; break;
                case 42: item = "Stunning spike"; break;
                case 43: item = "Vest of resistance +3"; break;
                case 44: case 45: case 46: item = Magic(1, 3, Protection()); break;
                case 47: item = "Dwarf crusher"; break;
                case 48: item = "Figurine of wondrous power, serpentine owl"; break;
                case 49: item = "Wight hide shield"; break;
                case 50: item = "Lion’s shield"; break;
                case 51: item = "Skewer-of-gnomes"; break;
                case 52: item = "Spear of retribution"; break;
                case 53: item = "Dawnstar"; break;
                case 54: item = "Pick of piercing"; break;
                case 55: item = "Sword of virtue beyond reproach"; break;
                case 56: item = "Rapier of desperate measures"; break;
                case 57: item = "Rapier of unerring direction"; break;
                case 58: item = "Sword of mighty thews"; break;
                case 59: item = "Strand of prayer beads, lesser"; break;
                case 60: item = "Angelhelm"; break;
                case 61: item = "Runestaff of the assassin"; break;
                case 62: item = "Bag of holding type IV"; break;
                case 63: item = "Bracers of wind"; break;
                case 64: item = "Crystal mask of detection"; break;
                case 65: item = "Crystal mask of discernment"; break;
                case 66: item = "Crystal mask of dread"; break;
                case 67: item = "Crystal mask of mindarmor"; break;
                case 68: item = "Crystal mask of psionic craft"; break;
                case 69: item = "Crystal mask of visual insight"; break;
                case 70: item = "Crystal of mind cloaking, greater"; break;
                case 71: item = "Druid’s vestment"; break;
                case 72: item = "Eyes of power leech"; break;
                case 73: item = "Fiendhelm"; break;
                case 74: item = "Figurine of wondrous power, bronze griffon"; break;
                case 75: item = "Figurine of wondrous power, ebony fly"; break;
                case 76: item = "Ghoul gauntlets"; break;
                case 77: item = "Glove of storing"; break;
                case 78: item = "Ioun stone, dark blue rhomboid"; break;
                case 79: item = "Lenses of true form"; break;
                case 80: item = "Mind blade gauntlet, lesser"; break;
                case 81: item = "Psychoactive skin of power damping"; break;
                case 82: item = "Ring of avoidance"; break;
                case 83: item = "Ring of improved climbing"; break;
                case 84: item = "Ring of improved jumping"; break;
                case 85: item = "Ring of improved swimming"; break;
                case 86: item = "Ring of self-sufficiency"; break;
                case 87: item = "Ring of soulbound protection"; break;
                case 88: item = "Robe of mysterious conjuration"; break;
                case 89: item = "Rod of reversal"; break;
                case 90: item = "Rod of undead mastery"; break;
                case 91: item = "Sandals of springing"; break;
                case 92: item = "Soul anchor"; break;
                case 93: item = "Soulstone"; break;
                case 94: item = "Stone horse, courser"; break;
                case 95: item = "Third eye aware"; break;
                case 96: item = "Third eye concentrate"; break;
                case 97: item = "Third eye gather"; break;
                case 98: item = "Third eye powerthieve"; break;
                case 99: item = "Truedeath crystal, greater"; break;
                case 100: item = "Vest of the master evoker"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelThirteen()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Cape of the mountebank"; break;
                case 2: item = "Trident of warning"; break;
                case 3: case 4: item = "Foxhide armor"; break;
                case 5: item = "Ghoul shell armor"; break;
                case 6: case 7: item = "Adamantine breastplate"; break;
                case 8: item = "Talon scepter"; break;
                case 9: item = "Axe of the sea reavers"; break;
                case 10: item = "Metamagic rod, Substitution"; break;
                case 11: item = "Rod of metal and mineral detection"; break;
                case 12: item = "Rod of cats"; break;
                case 13: case 14: item = "Storm gauntlets"; break;
                case 15: item = "Strand of acid pearls"; break;
                case 16: case 17: case 18: case 19: item = "Eternal wand of cure serious wounds"; break;
                case 20: item = "Eternal wand of displacement"; break;
                case 21: case 22: item = "Eternal wand of invisibility sphere"; break;
                case 23: case 24: case 25: item = "Eternal wand of lightning bolt"; break;
                case 26: item = "Eternal wand of mass snake’s swiftness"; break;
                case 27: item = "Eternal wand of repair serious damage"; break;
                case 28: item = "Ring of animal friendship"; break;
                case 29: item = "Amulet of inviolate form"; break;
                case 30: case 31: item = "Boots of tracklessness"; break;
                case 32: item = "Bracers of lightning"; break;
                case 33: item = "Cloak of turn resistance"; break;
                case 34: item = "Gauntlets of mindfire"; break;
                case 35: item = "Metamagic rod, Enlarge"; break;
                case 36: item = "Metamagic rod, Extend"; break;
                case 37: item = "Metamagic rod, Sculpting"; break;
                case 38: item = "Metamagic rod, Silent"; break;
                case 39: item = "Phylactery of undead turning"; break;
                case 40: item = "Rod of cancellation"; break;
                case 41: case 42: item = "Runestaff of eyes"; break;
                case 43: item = "Veil of doors"; break;
                case 44: item = "Gauntlet of rust"; break;
                case 45: case 46: item = "Ring of lightning flashes"; break;
                case 47: case 48: item = "Belt of battle"; break;
                case 49: item = "Blood claw choker"; break;
                case 50: case 51: item = "Boots of speed"; break;
                case 52: item = "Dove’s harp"; break;
                case 53: item = "Flesheater"; break;
                case 54: item = "Goggles of night"; break;
                case 55: item = "Golem manual, clay"; break;
                case 56: item = "Horn of plenty"; break;
                case 57: item = "Mantle of second chances"; break;
                case 58: item = "Medallion of thoughts"; break;
                case 59: item = "Pipes of pain"; break;
                case 60: item = "Psychoactive skin of the claw"; break;
                case 61: item = "Riding boots"; break;
                case 62: case 63: case 64: item = "Ring of energy resistance, minor"; break;
                case 65: case 66: item = "Ring of spell-battle"; break;
                case 67: case 68: item = "Rod of wonder"; break;
                case 69: item = "Ruby cincture of immutability"; break;
                case 70: item = "Runestaff of entrapment"; break;
                case 71: item = "Runestaff of size alteration"; break;
                case 72: item = "Shirt of resilience"; break;
                case 73: item = "Spare hand"; break;
                case 74: case 75: item = "Vest of free movement"; break;
                case 76: item = "Wand bracelet"; break;
                case 77: item = "Water cloak"; break;
                case 78: case 79: item = "Winged vest"; break;
                case 80: item = "Serpent armor"; break;
                case 81: item = "Hawkfeather armor"; break;
                case 82: case 83: case 84: item = "Scroll of resurrection (D)"; break;
                case 85: item = "Chromatic rod"; break;
                case 86: item = "Rogue blade"; break;
                case 87: item = "Bow of songs"; break;
                case 88: item = "Boccob’s blessed book"; break;
                case 89: item = "Hat of anonymity"; break;
                case 90: case 91: item = "Ring of chameleon power"; break;
                case 92: item = "Shifter’s sorrow"; break;
                case 93: item = "Cannith goggles"; break;
                case 94: item = "Cloak of soulbound resistance, greater"; break;
                case 95: item = "Fireflower pendant"; break;
                case 96: item = "Gem of brightness"; break;
                case 97: item = "Lyre of building"; break;
                case 98: case 99: item = "Monk’s belt"; break;
                case 100: item = "Python rod"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelFourteen()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Kyton armor"; break;
                case 2: item = "Breastplate of terror"; break;
                case 3: item = "Memento magica, 3rd-level spell"; break;
                case 4: item = "Choker of life protection"; break;
                case 5: item = "Cloak of arachnida"; break;
                case 6: item = "Gloves of the titan’s grip"; break;
                case 7: item = "Harrow rod"; break;
                case 8: item = "Metamagic rod, Chaining, lesser"; break;
                case 9: item = "Metamagic rod, Maximize, lesser"; break;
                case 10: item = "Runestaff of night"; break;
                case 11: item = "Tentacle rod"; break;
                case 12: item = "Veil of allure"; break;
                case 13: item = "Electric eel hide"; break;
                case 14: item = "Wight armor"; break;
                case 15: item = "Bearskin armor"; break;
                case 16: item = "Stone horse, destrier"; break;
                case 17: item = "Belt of dwarvenkind"; break;
                case 18: item = "Badge of the svirfneblin"; break;
                case 19: item = "Banner of the storm’s eye"; break;
                case 20: item = "Blindhelm"; break;
                case 21: item = "Circlet of rapid casting"; break;
                case 22: item = "Desperation chain"; break;
                case 23: item = "Incarnum focus (DM’s choice)"; break;
                case 24: item = "Moonstone mask"; break;
                case 25: item = "Periapt of wound closure"; break;
                case 26: item = "Psychoactive skin of nimbleness"; break;
                case 27: item = "Psychoactive skin of the chameleon"; break;
                case 28: item = "Quiver of energy"; break;
                case 29: item = "Ring of water walking"; break;
                case 30: item = "Rod of flame extinguishing"; break;
                case 31: item = "Rod of whips"; break;
                case 32: item = "Runestaff of opening"; break;
                case 33: item = "Shirt of angels"; break;
                case 34: item = "Shirt of demonskin"; break;
                case 35: item = "Shirt of the fey"; break;
                case 36: item = "Shirt of the inevitable"; break;
                case 37: item = "Shirt of ironskin"; break;
                case 38: item = "Shirt of slaadskin"; break;
                case 39: item = "Shirt of the moon"; break;
                case 40: item = "Spider rod"; break;
                case 41: item = "Third eye repudiate"; break;
                case 42: item = "Horn of the tritons"; break;
                case 43: item = "Pearl of the sirines"; break;
                case 44: item = "Figurine of wondrous power, onyx dog"; break;
                case 45: item = "Amulet of catapsi"; break;
                case 46: item = "Amulet of health +4"; break;
                case 47: item = "Belt of giant strength +4"; break;
                case 48: item = "Bracers of armor +4"; break;
                case 49: item = "Cloak of Charisma +4"; break;
                case 50: item = "Cloak of resistance +4"; break;
                case 51: item = "Cognizance crystal, 7 points"; break;
                case 52: item = "Gloves of Dexterity +4"; break;
                case 53: item = "Goggles of draconic vision"; break;
                case 54: item = "Headband of intellect +4"; break;
                case 55: item = "Pearl of power, 4th-level spell"; break;
                case 56: item = "Periapt of Wisdom +4"; break;
                case 57: item = "Ring of dragon friendship"; break;
                case 58: item = "Ring of greater counterspells"; break;
                case 59: item = "Runestaff of the undying"; break;
                case 60: item = "Runestaff of vision"; break;
                case 61: item = "Scabbard of keen edges"; break;
                case 62: item = "Serpent veil"; break;
                case 63: item = "Shadow veil"; break;
                case 64: item = "Vest of resistance +4"; break;
                case 65: item = "War wizard cloak"; break;
                case 66: item = "Winged boots"; break;
                case 67: case 68: case 69: case 70: item = Magic(1, 4, Protection()); break;
                case 71: item = "Zombie hide armor"; break;
                case 72: item = "Figurine of wondrous power, golden lions"; break;
                case 73: item = "Dwarven plate"; break;
                case 74: item = "Staff of charming"; break;
                case 75: item = "Chime of interruption"; break;
                case 76: item = "Armor of the fallen leaves"; break;
                case 77: item = "Broom of flying"; break;
                case 78: item = "Figurine of wondrous power, marble elephant"; break;
                case 79: item = "Tigerskin armor"; break;
                case 80: item = "Winged shield"; break;
                case 81: item = "Amulet of natural armor +3"; break;
                case 82: item = "Chasuble of fell power, greater"; break;
                case 83: item = "Dragondoom scepter"; break;
                case 84: item = "Goggles of the ebon hunter"; break;
                case 85: item = "Ioun stone, iridescent spindle"; break;
                case 86: item = "Ring of divergence"; break;
                case 87: item = "Ring of the icy soul"; break;
                case 88: item = "Ring of protection +3"; break;
                case 89: item = "Ring of spell storing, minor"; break;
                case 90: item = "Rogue’s vest"; break;
                case 91: item = "Runestaff of forced happiness"; break;
                case 92: item = "Surge crystal"; break;
                case 93: case 94: case 95: case 96: case 97: case 98: case 99: case 100: item = Magic(2, 3, Weapon()); break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelFifteen()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Assassin’s dagger"; break;
                case 2: item = "Cli lyre"; break;
                case 3: item = "Dragonrider armor"; break;
                case 4: item = "Rod of enervating strike"; break;
                case 5: item = "Rod of freedom"; break;
                case 6: item = "Trident of fish command"; break;
                case 7: item = "Banded mail of luck"; break;
                case 8: item = "Bracelet of friends"; break;
                case 9: item = "Runestaff of illusion"; break;
                case 10: item = "Runestaff of transportation"; break;
                case 11: item = "Viper rod"; break;
                case 12: item = "Beholder crown"; break;
                case 13: item = "Bone ring"; break;
                case 14: case 15: item = "Carpet of flying, 5 ft. by 5 ft."; break;
                case 16: case 17: item = "Casting glove"; break;
                case 18: item = "Crystal mask of insight"; break;
                case 19: item = "Eyes of power leech, vampiric"; break;
                case 20: item = "Horn of blasting"; break;
                case 21: case 22: item = "Ioun stone, pale lavender ellipsoid"; break;
                case 23: case 24: item = "Ioun stone, pearly white spindle"; break;
                case 25: item = "Lens of the desert"; break;
                case 26: case 27: item = "Portable hole"; break;
                case 28: item = "Ring of arcane might"; break;
                case 29: item = "Ring of invisibility"; break;
                case 30: item = "Ring of wizardry I"; break;
                case 31: item = "Runestaff of frost"; break;
                case 32: item = "Scarab of stabilization"; break;
                case 33: item = "Stone of good luck"; break;
                case 34: item = "Water whip"; break;
                case 35: item = "Dagger of denial"; break;
                case 36: item = "Ruby blade"; break;
                case 37: item = "Cudgel that never forgets"; break;
                case 38: item = "Chain of obeisance"; break;
                case 39: item = "Flame tongue"; break;
                case 40: item = "Figurine of wondrous power, ivory goats"; break;
                case 41: item = "Gwaeron’s belt"; break;
                case 42: item = "Robe of arcane might"; break;
                case 43: item = "Rope of entanglement"; break;
                case 44: item = "Runestaff of divination"; break;
                case 45: item = "Exoskeleton armor"; break;
                case 46: item = "Boots of the mountain king, greater"; break;
                case 47: item = "Cloak of battle"; break;
                case 48: item = "Golem manual, stone"; break;
                case 49: item = "Mask of the skull"; break;
                case 50: item = "Turquoise veil"; break;
                case 51: item = "Luck blade (0 wishes)"; break;
                case 52: item = "Lash of sands"; break;
                case 53: item = "Sword of subtlety"; break;
                case 54: item = "Sword of the planes"; break;
                case 55: item = "Celestial armor"; break;
                case 56: item = "Runestaff of the artisan"; break;
                case 57: item = "Nine lives stealer"; break;
                case 58: item = "Mattock of the titans"; break;
                case 59: item = "Rod of enemy detection"; break;
                case 60: item = "Circlet of blasting, major"; break;
                case 61: item = "Amulet of mighty fists +2"; break;
                case 62: item = "Cloak of displacement, minor"; break;
                case 63: item = "Helm of underwater action"; break;
                case 64: item = "Memento magica, 4th-level spell"; break;
                case 65: item = "Mind blade gauntlet"; break;
                case 66: item = "Psychoactive skin of celestial embrace"; break;
                case 67: item = "Psychoactive skin of fiendish embrace"; break;
                case 68: item = "Runestaff of earth and stone"; break;
                case 69: item = "Shroud of scales"; break;
                case 70: item = "Third eye sense"; break;
                case 71: item = "Overhead shield"; break;
                case 72: item = "Metamagic rod, Substitution, greater"; break;
                case 73: item = "Metamagic rod, Enlarge, greater"; break;
                case 74: item = "Metamagic rod, Extend, greater"; break;
                case 75: item = "Metamagic rod, Sculpting, greater"; break;
                case 76: item = "Metamagic rod, Silent, greater"; break;
                case 77: item = "Quarterstaff of battle"; break;
                case 78: item = "Plate armor of the deep"; break;
                case 79: item = "Staff of swarming insects"; break;
                case 80: item = "Bracers of archery, greater"; break;
                case 81: item = "Bracers of armor +5"; break;
                case 82: case 83: item = "Cloak of resistance +5"; break;
                case 84: item = "Cognizance crystal, 9 points"; break;
                case 85: item = "Eyes of doom"; break;
                case 86: item = "Magic siphon"; break;
                case 87: item = "Pearl of power, 5th-level spell"; break;
                case 88: item = "Ring of evasion"; break;
                case 89: item = "Ring of master artifice"; break;
                case 90: item = "Ring of X-ray vision"; break;
                case 91: item = "Rod of splendor"; break;
                case 92: item = "Rod of withering"; break;
                case 93: item = "Runestaff of conjuration"; break;
                case 94: item = "Runestaff of evocation"; break;
                case 95: item = "Runestaff of transmutation"; break;
                case 96: item = "Vest of resistance +5"; break;
                case 97: case 98: case 99: case 100: item = Magic(1, 5, Protection()); break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelSixteen()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Maul of the titans"; break;
                case 2: item = "Breastplate of command"; break;
                case 3: item = "Oathbow"; break;
                case 4: item = "Sword of life stealing"; break;
                case 5: item = "Bracers of dawn"; break;
                case 6: item = "Cloak of the bat"; break;
                case 7: item = "Cloak of thorns"; break;
                case 8: item = "Iron bands of Bilarro"; break;
                case 9: item = "Ring of soulbound protection, greater"; break;
                case 10: item = "Runestaff of cacophony"; break;
                case 11: item = "Scourge of pain"; break;
                case 12: item = "Mithral full plate of speed"; break;
                case 13: item = "Cube of frost resistance"; break;
                case 14: item = "Helm of telepathy"; break;
                case 15: item = "Periapt of proof against poison"; break;
                case 16: item = "Ring of blinking"; break;
                case 17: item = "Robe of scintillating colors"; break;
                case 18: item = "Runestaff of destruction"; break;
                case 19: case 20: item = "Manual of bodily health +1"; break;
                case 21: case 22: item = "Manual of gainful exercise +1"; break;
                case 23: case 24: item = "Manual of quickness in action +1"; break;
                case 25: case 26: item = "Tome of clear thought +1"; break;
                case 27: case 28: item = "Tome of leadership and influence +1"; break;
                case 29: case 30: item = "Tome of understanding +1"; break;
                case 31: case 32: item = "Staff of healing"; break;
                case 33: item = "Dimensional shackles"; break;
                case 34: case 35: item = "Ring of energy resistance, major"; break;
                case 36: item = "Figurine of wondrous power, obsidian steed"; break;
                case 37: case 38: item = "Staff of fire"; break;
                case 39: case 40: case 41: case 42: case 43: case 44: case 45: item = "Scroll of true resurrection (D)"; break;
                case 46: item = "Staff of size alteration"; break;
                case 47: item = "Drums of panic"; break;
                case 48: case 49: item = "Ioun stone, orange prism"; break;
                case 50: case 51: item = "Ioun stone, pale green prism"; break;
                case 52: case 53: item = "Lantern of revealing"; break;
                case 54: item = "Ring of vanishing"; break;
                case 55: case 56: item = "Rings of force armor (pair)"; break;
                case 57: item = "Robe of blending"; break;
                case 58: item = "Runestaff of the architect"; break;
                case 59: item = "Runestaff of ethereal action"; break;
                case 60: case 61: case 62: item = "Amulet of natural armor +4"; break;
                case 63: item = "Psychoactive skin of the defender"; break;
                case 64: case 65: case 66: item = "Ring of protection +4"; break;
                case 67: item = "Runestaff of abjuration"; break;
                case 68: item = "Runestaff of enchantment"; break;
                case 69: item = "Runestaff of necromancy"; break;
                case 70: case 71: case 72: case 73: case 74: case 75: case 76: case 77: case 78: case 79: case 80: case 81: case 82: case 83: case 84: case 85: case 86: case 87: item = Magic(2, 4, Weapon()); break;
                case 88: item = "Anstruth harp"; break;
                case 89: item = "Metamagic rod, Empower"; break;
                case 90: item = "Metamagic rod, Reach"; break;
                case 91: item = "Rod of thunder and lightning"; break;
                case 92: item = "Impervious vestment"; break;
                case 93: item = "Runestaff of illumination"; break;
                case 94: item = "Amulet of proof against detection and location"; break;
                case 95: case 96: item = "Carpet of flying, 5 ft. by 10 ft."; break;
                case 97: item = "Golem manual, iron"; break;
                case 98: item = "Metamagic rod, Quicken, lesser"; break;
                case 99: case 100: item = "Runestaff of time"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelSeventeen()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: case 2: case 3: item = "Amulet of health +6"; break;
                case 4: case 5: case 6: item = "Belt of giant strength +6"; break;
                case 7: case 8: item = "Bracers of armor +6"; break;
                case 9: case 10: case 11: item = "Cloak of Charisma +6"; break;
                case 12: item = "Cloak of the salamander, greater"; break;
                case 13: item = "Cognizance crystal, 11 points"; break;
                case 14: case 15: case 16: item = "Gloves of Dexterity +6"; break;
                case 17: case 18: case 19: item = "Headband of intellect +6"; break;
                case 20: item = "Ioun stone, vibrant purple prism"; break;
                case 21: case 22: item = "Pearl of power, 6th-level spell"; break;
                case 23: case 24: case 25: item = "Periapt of Wisdom +6"; break;
                case 26: case 27: item = "Ring of negative protection"; break;
                case 28: case 29: item = "Ring of positive protection"; break;
                case 30: item = "Truelight lantern"; break;
                case 31: case 32: case 33: case 34: case 35: case 36: case 37: case 38: case 39: item = Magic(1, 6, Protection()); break;
                case 40: item = "Vampire hide armor"; break;
                case 41: item = "Robe of the inferno"; break;
                case 42: case 43: item = "Rod of negation"; break;
                case 44: case 45: item = "Runestaff of the undead slayer"; break;
                case 46: case 47: item = "Memento magica, 5th-level spell"; break;
                case 48: case 49: item = "Robe of thunder"; break;
                case 50: case 51: item = "Scarab of protection"; break;
                case 52: item = "Explosive sling"; break;
                case 53: case 54: item = "Runestaff of power"; break;
                case 55: item = "Mace of terror"; break;
                case 56: case 57: item = "Rod of celestial might"; break;
                case 58: case 59: item = "Amulet of second chances"; break;
                case 60: case 61: case 62: item = "Ioun stone, lavender and green ellipsoid"; break;
                case 63: item = "Psychoactive skin of iron"; break;
                case 64: item = "Psychoactive skin of the spider"; break;
                case 65: item = "Ring gates"; break;
                case 66: case 67: case 68: case 69: case 70: case 71: item = "Ring of freedom of movement"; break;
                case 72: case 73: item = "Ring of wizardry II"; break;
                case 74: case 75: item = "Scarab of invulnerability"; break;
                case 76: item = "Life-drinker"; break;
                case 77: case 78: item = "Earthplate armor"; break;
                case 79: item = "Crystal ball"; break;
                case 80: item = "Mind blade gauntlet, greater"; break;
                case 81: case 82: item = "Boots of temporal acceleration"; break;
                case 83: item = "Golem manual, greater stone"; break;
                case 84: case 85: case 86: case 87: case 88: item = "Ring of energy resistance, greater"; break;
                case 89: case 90: item = "Ring of nine lives"; break;
                case 91: case 92: item = "Strand of prayer beads"; break;
                case 93: case 94: case 95: item = "Runestaff of insanity"; break;
                case 96: case 97: item = "Sylvan scimitar"; break;
                case 98: item = "Orb of storms"; break;
                case 99: item = "Runestaff of fiendish darkness"; break;
                case 100: item = "Tentacle rod, greater"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelEighteen()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: item = "Staff of illumination"; break;
                case 2: item = "Boots of teleportation"; break;
                case 3: case 4: case 5: item = "Bracers of armor +7"; break;
                case 6: item = "Cognizance crystal, 13 points"; break;
                case 7: item = "Pearl of power, 7th-level spell"; break;
                case 8: case 9: case 10: case 11: case 12: case 13: item = Magic(1, 7, Protection()); break;
                case 14: item = "Amulet of natural armor +5"; break;
                case 15: item = "Cloak of displacement, major"; break;
                case 16: item = "Cloudwalker anklets"; break;
                case 17: item = "Crystal ball with see invisibility"; break;
                case 18: item = "Horn of Valhalla"; break;
                case 19: item = "Phoenix cloak"; break;
                case 20: item = "Ring of friend shield (pair)"; break;
                case 21: case 22: case 23: case 24: item = "Ring of protection +5"; break;
                case 25: item = "Ring of shooting stars"; break;
                case 26: item = "Ring of spell storing"; break;
                case 27: item = "Rod of absorption"; break;
                case 28: item = "Rod of flailing"; break;
                case 29: case 30: case 31: case 32: case 33: case 34: case 35: case 36: case 37: case 38: case 39: case 40: case 41: case 42: item = Magic(2, 5, Weapon()); break;
                case 43: item = "Ollamh harp"; break;
                case 44: item = "Absorbing shield"; break;
                case 45: item = "Rapier of puncturing"; break;
                case 46: item = "Sun blade"; break;
                case 47: item = "Crystal ball with detect thoughts"; break;
                case 48: item = "Demon armor"; break;
                case 49: item = "Amulet of mighty fists +3"; break;
                case 50: item = "Memento magica, 6th-level spell"; break;
                case 51: item = "Metamagic rod, Chaining"; break;
                case 52: case 53: item = "Metamagic rod, Maximize"; break;
                case 54: item = "Wings of flying"; break;
                case 55: item = "Frost brand"; break;
                case 56: item = "Cloak of etherealness"; break;
                case 57: item = "Daern’s instant fortress"; break;
                case 58: item = "Dragon’s eye amulet"; break;
                case 59: case 60: item = "Manual of bodily health +2"; break;
                case 61: case 62: item = "Manual of gainful exercise +2"; break;
                case 63: case 64: item = "Manual of quickness in action +2"; break;
                case 65: case 66: item = "Tome of clear thought +2"; break;
                case 67: case 68: item = "Tome of leadership and influence +2"; break;
                case 69: case 70: item = "Tome of understanding +2"; break;
                case 71: item = "Eyes of charming"; break;
                case 72: item = "Staff of frost"; break;
                case 73: item = "Robe of stars"; break;
                case 74: item = "Staff of defense"; break;
                case 75: case 76: item = "Carpet of flying, 10 ft. by 10 ft."; break;
                case 77: item = "Darkskull"; break;
                case 78: item = "Psychoactive skin of fiery response"; break;
                case 79: case 80: case 81: item = "Ring of universal energy resistance, minor"; break;
                case 82: item = "Rod of force"; break;
                case 83: item = "Rod of rulership"; break;
                case 84: item = "Dwarven thrower"; break;
                case 85: item = "Psychoactive skin of the troll"; break;
                case 86: item = "Ring of master artifice, greater"; break;
                case 87: item = "Rod of security"; break;
                case 88: item = "Cube of force"; break;
                case 89: item = "Luck blade (1 wish)"; break;
                case 90: case 91: case 92: case 93: item = "Bracers of armor +8"; break;
                case 94: item = "Cognizance crystal, 15 points"; break;
                case 95: item = "Pearl of power, 8th-level spell"; break;
                case 96: case 97: case 98: case 99: case 100: item = Magic(1, 8, Protection()); break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelNineteen()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: case 2: case 3: item = "Staff of abjuration"; break;
                case 4: case 5: case 6: item = "Staff of conjuration"; break;
                case 7: case 8: case 9: item = "Staff of enchantment"; break;
                case 10: case 11: case 12: item = "Staff of evocation"; break;
                case 13: case 14: case 15: item = "Staff of illusion"; break;
                case 16: case 17: case 18: item = "Staff of necromancy"; break;
                case 19: case 20: case 21: item = "Staff of transmutation"; break;
                case 22: case 23: item = "Crystal ball with telepathy"; break;
                case 24: case 25: item = "Horn of blasting, greater"; break;
                case 26: case 27: case 28: item = "Pearl of power, two spells"; break;
                case 29: case 30: case 31: case 32: item = "Ring of wizardry III"; break;
                case 33: case 34: case 35: case 36: item = "Rod of lordly might"; break;
                case 37: case 38: case 39: case 40: case 41: case 42: case 43: case 44: case 45: case 46: case 47: case 48: case 49: case 50: case 51: case 52: item = Magic(2, 6, Weapon()); break;
                case 53: case 54: case 55: case 56: item = "Metamagic rod, Empower, greater"; break;
                case 57: case 58: case 59: case 60: item = "Metamagic rod, Reach, greater"; break;
                case 61: case 62: item = "Helm of teleportation"; break;
                case 63: case 64: case 65: case 66: item = "Memento magica, 7th-level spell"; break;
                case 67: case 68: case 69: case 70: item = "Staff of divination"; break;
                case 71: case 72: case 73: item = "Gem of seeing"; break;
                case 74: case 75: case 76: case 77: item = "Ring of telekinesis"; break;
                case 78: case 79: case 80: case 81: item = "Robe of the archmagi"; break;
                case 82: case 83: case 84: case 85: item = "Runestaff of passage"; break;
                case 86: case 87: item = "Mace of smiting"; break;
                case 88: case 89: case 90: case 91: item = "Metamagic rod, Quicken"; break;
                case 92: case 93: case 94: item = "Mantle of faith"; break;
                case 95: case 96: item = "Psychoactive skin of the hero"; break;
                case 97: case 98: case 99: case 100: item = "Crystal ball with true seeing"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelTwenty()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: case 2: case 3: item = "Staff of earth and stone"; break;
                case 4: case 5: item = "Cognizance crystal, 17 points"; break;
                case 6: case 7: case 8: item = "Pearl of power, 9th-level spell"; break;
                case 9: case 10: case 11: case 12: case 13: case 14: item = Magic(1, 9, Protection()); break;
                case 15: item = "Well of many worlds"; break;
                case 16: case 17: case 18: case 19: item = "Manual of bodily health +3"; break;
                case 20: case 21: case 22: case 23: item = "Manual of gainful exercise +3"; break;
                case 24: case 25: case 26: case 27: item = "Manual of quickness in action +3"; break;
                case 28: case 29: case 30: case 31: item = "Tome of clear thought +3"; break;
                case 32: case 33: case 34: case 35: item = "Tome of leadership and influence +3"; break;
                case 36: case 37: case 38: case 39: item = "Tome of understanding +3"; break;
                case 40: case 41: case 42: item = "Rod of alertness"; break;
                case 43: item = "Apparatus of Kwalish"; break;
                case 44: case 45: case 46: case 47: item = "Mantle of spell resistance"; break;
                case 48: case 49: item = "Psychoactive skin of the psion"; break;
                case 50: case 51: case 52: case 53: item = "Ring of regeneration"; break;
                case 54: case 55: item = "Mirror of opposition"; break;
                case 56: case 57: item = "Strand of prayer beads, greater"; break;
                case 58: case 59: item = "Amulet of mighty fists +4"; break;
                case 60: case 61: item = "Memento magica, 8th-level spell"; break;
                case 62: case 63: case 64: case 65: item = "Ring of three wishes"; break;
                case 66: case 67: item = "Eyes of petrification"; break;
                case 68: case 69: case 70: case 71: case 72: case 73: case 74: case 75: case 76: case 77: case 78: case 79: case 80: case 81: case 82: item = Magic(2, 7, Weapon()); break;
                case 83: case 84: item = "Ring of spell turning"; break;
                case 85: case 86: item = "Bowl of commanding water elementals"; break;
                case 87: case 88: item = "Brazier of commanding fire elementals"; break;
                case 89: case 90: item = "Censer of controlling air elementals"; break;
                case 91: case 92: item = "Ring of wizardry IV"; break;
                case 93: case 94: item = "Stone of controlling earth elementals"; break;
                case 95: case 96: case 97: case 98: case 99: case 100: item = Magic(1, 10, Protection()); break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelTwentyOne()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: case 2: case 3: case 4: case 5: case 6: item = "Staff of the woodlands"; break;
                case 7: case 8: case 9: case 10: case 11: case 12: case 13: case 14: item = "Luck blade (2 wishes)"; break;
                case 15: case 16: case 17: case 18: case 19: case 20: case 21: case 22: case 23: item = "Manual of bodily health +4"; break;
                case 24: case 25: case 26: case 27: case 28: case 29: case 30: case 31: case 32: item = "Manual of gainful exercise +4"; break;
                case 33: case 34: case 35: case 36: case 37: case 38: case 39: case 40: case 41: item = "Manual of quickness in action +4"; break;
                case 42: case 43: case 44: case 45: case 46: case 47: case 48: case 49: case 50: item = "Tome of clear thought +4"; break;
                case 51: case 52: case 53: case 54: case 55: case 56: case 57: case 58: case 59: item = "Tome of leadership and influence +4"; break;
                case 60: case 61: case 62: case 63: case 64: case 65: case 66: case 67: case 68: item = "Tome of understanding +4"; break;
                case 69: case 70: case 71: case 72: case 73: case 74: item = "Amulet of the planes"; break;
                case 75: case 76: case 77: case 78: case 79: case 80: case 81: case 82: case 83: item = "Ring of universal energy resistance, major"; break;
                case 84: case 85: case 86: case 87: case 88: case 90: item = "Robe of eyes"; break;
                case 91: case 92: case 93: case 94: case 95: item = "Third eye conceal"; break;
                case 96: case 97: case 98: case 99: case 100: item = "Third eye dominate"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelTwentyTwo()
        {
            int result = D(100);
            string item = "";
            switch (result)
            {
                case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: case 10: item = "Holy avenger"; break;
                case 11: case 12: case 13: case 14: case 15: item = "Memento magica, 9th-level spell"; break;
                case 16: case 17: case 18: case 19: case 20: item = "Metamagic rod, Chaining, greater"; break;
                case 21: case 22: case 23: case 24: case 25: item = "Metamagic rod, Maximize, greater"; break;
                case 26: case 27: case 28: case 29: item = "Helm of brilliance"; break;
                case 30: case 31: case 32: case 33: item = "Ring of djinni calling"; break;
                case 34: case 35: case 36: case 37: case 38: case 39: case 40: case 41: case 42: case 43: case 44: case 45: case 46: case 47: case 48: case 49: case 50: case 51: case 52: case 53: case 54: case 55: case 56: case 57: case 58: item = Magic(2, 8, Weapon()); break;
                case 59: case 60: case 61: case 62: case 63: case 64: case 65: item = "Manual of bodily health +5"; break;
                case 66: case 67: case 68: case 69: case 70: case 71: case 72: item = "Manual of gainful exercise +5"; break;
                case 73: case 74: case 75: case 76: case 77: case 78: case 79: item = "Manual of quickness in action +5"; break;
                case 80: case 81: case 82: case 83: case 84: case 85: case 86: item = "Tome of clear thought +5"; break;
                case 87: case 88: case 89: case 90: case 91: case 92: case 93: item = "Tome of leadership and influence +5"; break;
                case 94: case 95: case 96: case 97: case 98: case 99: case 100: item = "Tome of understanding +5"; break;
                default: item = "Error"; break;
            }
            return item;
        }
        private string ItemLevelTwentyThree()
        {
            int result = D(100);
            string item = "";
            if (result <= 25)
            {
                item = "Luck blade (3 wishes)";
            }
            else if (result <= 43)
            {
                item = "Efreeti bottle";
            }
            else if (result <= 63)
            {
                item = "Amulet of mighty fists +5";
            }
            else if (result <= 83)
            {
                item = "Staff of life";
            }
            else
            {
                item = "Chaos diamond";
            }
            return item;
        }
        private string ItemLevelTwentyFour()
        {
            int result = D(100);
            string item = "";
            if (result <= 30)
            {
                item = Magic(2, 9, Weapon());
            }
            else if (result <= 40)
            {
                item = "Cubic gate";
            }
            else if (result <= 51)
            {
                item = "Iron flask";
            }
            else if (result <= 61)
            {
                item = "Metamagic rod, Quicken, greater";
            }
            else if (result <= 73)
            {
                item = "Staff of passage";
            }
            else if (result <= 81)
            {
                item = "Mirror of mental prowess";
            }
            else
            {
                item = "Ring of universal energy resistance, greater";
            }
            return item;
        }
        private string ItemLevelTwentyFive()
        {
            int result = D(100);
            string item = "";
            if (result <= 8)
            {
                item = "Mirror of life trapping";
            }
            else if (result <= 16)
            {
                item = "Ring of elemental command (air)";
            }
            else if (result <= 24)
            {
                item = "Ring of elemental command (earth)";
            }
            else if (result <= 32)
            {
                item = "Ring of elemental command (fire)";
            }
            else if (result <= 40)
            {
                item = "Ring of elemental command (water)";
            }
            else if (result <= 50)
            {
                item = "Ring of spell storing, major";
            }
            else if (result <= 58)
            {
                item = "Vest of the archmagi";
            }
            else if (result <= 88)
            {
                item = Magic(2, 10, Weapon());
            }
            else
            {
                item = "Staff of power";
            }
            return item;
        }
    }
}
