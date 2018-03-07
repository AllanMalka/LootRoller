using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootRoller.Classes
{
    class MagicArmorProperties
    {

        /// <summary>
        /// Dice roller. Input is the number of eyes the dice have.
        /// </summary>
        /// <param name="_eyes">Maximum number of eyes</param>
        /// <returns></returns>
        private int D(int _eyes)
        {
            return new Random().Next(1, _eyes + 1);
        }

        #region Armor
        public string MagicArmorPlusOne()
        {
            int rolled = D(100);
            string result = "";
            switch (rolled)
            {
                case 1: case 2: result = "Agility"; break;
                case 3: case 4: result = "Stamina"; break;
                case 5: case 6: result = "Blueshine"; break;
                case 7: case 8: result = "Easy travel"; break;
                case 9: case 10: case 11: result = "Called"; break;
                case 12: case 13: case 14: result = "Commander"; break;
                case 15: case 16: case 17: result = "Glamered"; break;
                case 18: case 19: case 20:  result = "Daylight"; break;
                case 21: case 22: case 23: case 24: result = "Mindarmor"; break;
                case 25: case 26: case 27: result = "Acidic"; break;
                case 28: case 29: case 30: case 31: result = "Anchoring"; break;
                case 32: case 33: case 34: case 35: result = "Blurring"; break;
                case 36: case 37: case 38: result = "Death ward"; break;
                case 39: case 40: case 41: result = "Displacement"; break;
                case 42: case 43: case 44: result = "Dragondodger"; break;
                case 45: case 46: case 47: result = "Ectoplasmic feedback"; break;
                case 48: case 49: case 50: result = "Fortification, light"; break;
                case 51: case 52: case 53: case 54: result = "Ghost ward"; break;
                case 55: case 56: case 57: case 58: result = "Mobility"; break;
                case 59: case 60: case 61: case 62: result = "Nimbleness"; break;
                case 63: case 64: result = "Soulbound"; break;
                case 65: case 66: case 67: result = "Styptic"; break;
                case 68: case 69: case 70: result = "Twillight"; break;
                case 71: case 72: case 73: result = "Balance"; break;
                case 74: case 75: case 76: case 77: result = "Shadow"; break;
                case 78: case 79: case 80: case 81: result = "Silent moves"; break;
                case 82: case 83: case 84: case 85: result = "Slick"; break;
                case 86: case 87: case 88: result = "Buoyant"; break;
                case 89: case 90: case 91: result = "Landing"; break;
                case 92: case 93: case 94: result = "Agility, improved"; break;
                case 95: case 96: case 97: result = "Stamina, improved"; break;
                case 98: case 99: case 100: result = "Quickness"; break;
                default: result = "Error"; break;
            }
            return result;
        }
        public string MagicArmorPlusTwo()
        {
            int rolled = D(100);
            string result = "";
            switch (rolled)
            {
                case 1: case 2: case 3: result = "Gilled"; break;
                case 4: case 5: case 6: case 7: case 8: result = "Linked"; break;
                case 9: case 10: case 11: case 12: case 13: case 14: case 15: case 16: case 17: result = "Speed"; break;
                case 18: case 19: case 20: case 21: case 22: case 23: case 24: case 25: result = "Healing"; break;
                case 26: case 27: case 28: case 29: case 30: case 31: case 32: result = "Anchoring, greater"; break;
                case 33: case 34: case 35: case 36: case 37: case 38: case 39: result = "Axeblock"; break;
                case 40: case 41: case 42: case 43: result = "Beastskin"; break;
                case 44: case 45: case 46: case 47: case 48: case 49: case 50: case 51: result = "Energy defense"; break;
                case 52: case 53: case 54: case 55: case 56: case 57: case 58: case 59: case 60: result = "Energy immunity"; break;
                case 61: case 62: case 63: case 64: case 65: case 66: case 67: result = "Hammerblock"; break;
                case 68: case 69: case 70: case 71: case 72: case 73: result = "Retaliation"; break;
                case 74: case 75: case 76: case 77: case 78: case 79: case 80: result = "Spearblock"; break;
                case 81: case 82: case 83: case 84: case 85: case 86: case 87: case 88: result = "Spell resistance (13)"; break;
                case 89: case 90: case 91: case 92: case 93: result = "Woodwalking"; break;
                case 94: case 95: case 96: case 97: case 98: case 99: case 100: result = "Magic-eating"; break;
                default: result = "Error"; break;
            }
            return result;
        }
        public string MagicArmorPlusThree()
        {
            int rolled = D(100);
            string result = "";
            switch (rolled)
            {
                case 1: result = "Deepdweller"; break;
                case 2: case 3: case 4: case 5: result = "Balance, improved"; break;
                case 6: case 7: case 8: case 9: result = "Agility, greater"; break;
                case 10: case 11: case 12: case 13: result = "Stamina, greater"; break;
                case 14: case 15: case 16: case 17: result = "Bane blind"; break;
                case 18: case 19: case 20: case 21: case 22: result = "Blinking"; break;
                case 23: case 24: case 25: case 26: result = "Fearsome"; break;
                case 27: case 28: case 29: case 30: case 31: result = "Shadow, improved"; break;
                case 32: case 34: case 35: case 36: case 37: result = "Silent moves, improved"; break;
                case 38: case 39: case 40: case 41: case 42: result = "Slick, improved"; break;
                case 43: case 44: case 45: case 46: result = "Blurring, greater"; break;
                case 47: case 48: case 49: case 50: case 51: result = "Fortification, moderate"; break;
                case 52: case 53: case 54: case 55: result = "Ghost touch"; break;
                case 56: case 57: case 58: case 59: result = "Invulnerability"; break;
                case 60: case 61: case 62: result = "Roaring"; break;
                case 63: case 64: result = "Soulbound, greater"; break;
                case 65: case 66: case 67: case 68: case 69: result = "Spell resistance (15)"; break;
                case 70: case 71: case 72: case 73: result = "Vanishing"; break;
                case 74: case 75: case 76: result = "Wild"; break;
                case 77: case 78: case 79: case 80: case 81: result = "Acid resistance"; break;
                case 82: case 83: case 84: case 85: case 86: result = "Cold resistance"; break;
                case 87: case 88: case 89: case 90: case 91: result = "Electricity resistance"; break;
                case 92: case 93: case 94: case 95: case 96: result = "Fire resistance"; break;
                case 97: case 98: case 99: result = "Sonc resistance"; break;
                case 100: result = MagicArmorPlusTwo() + " " + MagicArmorPlusOne(); break;
                default: result = "Error"; break;
            }
            return result;
        }
        public string MagicArmorPlusFour()
        {
            int rolled = D(100);
            string result = "";
            switch (rolled)
            {
                case 1: case 2: case 3: case 4: case 5: case 6: case 7: result = "Radiant"; break;
                case 8: case 9: case 10: case 11: case 12: case 13: case 14: case 15: case 16: case 17: case 18: case 19: result = "Spell resistance(17)"; break;
                case 20: case 21: case 22: case 23: case 24: case 25: case 26: case 27: case 28: result = "Menacing"; break;
                case 29: case 30: case 31: case 32: case 33: case 34: case 35: case 36: case 37: case 38: result = "Healing, greater"; break;
                case 39: case 40: case 41: case 42: case 43: case 44: case 45: case 46: case 47: case 48: result = "Balance, greater"; break;
                case 49: case 50: case 51: case 52: case 53: case 54: case 55: case 56: case 57: case 58: result = "Shadow, greater"; break;
                case 59: case 60: case 61: case 62: case 63: case 64: case 65: case 66: case 67: case 68: case 69:  result = "Silent moves, greater"; break;
                case 70: case 71: case 72: case 73: case 74: case 75: case 76: case 77: case 78: result = "Slick, greater"; break;
                case 79: case 80: case 81: case 82: case 83: case 84: case 85: case 86: case 87: case 88: case 89: result = MagicArmorPlusThree() + " " + MagicArmorPlusOne(); break;
                case 90: case 91: case 92: case 93: case 94: case 95: case 96: case 97: case 98: case 99: case 100: result = MagicArmorPlusTwo() + " " + MagicArmorPlusTwo(); break;
                default: result = "Error"; break;
            }
            return result;
        }
        public string MagicArmorPlusFive()
        {
            int rolled = D(100);
            string result = "";
            switch (rolled)
            {
                case 1: case 2: case 3: case 4: result = "Fortification, heavy"; break;
                case 5: case 6: case 7: case 8: case 9: result = "Freedom"; break;
                case 10: case 11: case 12: case 13: case 14: case 15: result = "Spell resistance (19)"; break;
                case 16: case 17: case 18: case 19: result = "Aporter"; break;
                case 20: case 21: case 22: case 23: case 24: result = "Masking"; break;
                case 25: case 26: case 27: case 28: case 29: case 30: case 31: case 32: result = "Acid reistance, improved"; break;
                case 33: case 34: case 35: case 36: case 37: case 38: case 39: case 40: result = "Cold reistance, improved"; break;
                case 41: case 42: case 43: case 44: case 45: case 46: case 47: case 48: result = "Electricity reistance, improved"; break;
                case 49: case 50: case 51: case 52: case 53: case 54: case 55: case 56: result = "Fire reistance, improved"; break;
                case 57: case 58: case 59: case 60: case 61: case 62: case 63: result = "Sonic reistance, improved"; break;
                case 64: case 65: case 66: case 67: case 68: result = "Etherealness"; break;
                case 69: case 70: result = "Undead controlling"; break;
                case 71: case 72: case 73: case 74: case 75: case 76: result = "Acid reistance, greater"; break;
                case 77: case 78: case 79: case 80: case 81: case 82: result = "Cold reistance, greater"; break;
                case 83: case 84: case 85: case 86: case 87: case 88: result = "Electricity reistance, greater"; break;
                case 89: case 90: case 91: case 92: case 93: case 94: result = "Fire reistance, greater"; break;
                case 95: case 96: case 97: case 98: result = "Sonic reistance, greater"; break;
                case 99: result = MagicArmorPlusFour() + " " + MagicArmorPlusOne(); break;
                case 100: result = MagicArmorPlusThree() + " " + MagicArmorPlusTwo(); break;
                default: result = "Error"; break;
            }
            return result;
        }
        #endregion

        #region Shield
        public string MagicShieldPlusOne()
        {
            int rolled = D(100);
            string result = "";
            switch (rolled)
            {
                case 1: case 2: case 3: case 4: case 5: case 7: result = "Heartening"; break;
                case 8: case 9: case 10: case 11: case 12: case 13: case 14: result = "Called"; break;
                case 15: case 16: case 17: result = "Commander"; break;
                case 18: case 19: case 20: case 21: case 22: case 23: result = "Daylight"; break;
                case 24: case 25: case 26: case 27: case 28: case 29: result = "Mindarmor"; break;
                case 30: case 31: case 32: result = "Acidic"; break;
                case 33: case 34: case 35: case 36: result = "Anchoring"; break;
                case 37: case 38: case 39: case 40:  result = "Arrow catching"; break;
                case 41: case 42: case 43: case 44: case 45: case 46: case 47: case 48: result = "Bashing"; break;
                case 49: case 50: case 51: case 52: case 53: case 54: case 55: case 56: result = "Blinding"; break;
                case 57: case 58: case 59: result = "Death ward"; break;
                case 60: case 61: case 62: case 63: case 64: case 65: case 66: case 67: case 68: result = "Fortification, light"; break;
                case 69: case 70: case 71: case 72: case 73: case 74: case 75: case 76: result = "Ghost ward"; break;
                case 77: case 78: case 79: case 80: case 81: case 82: case 83: case 84: result = "Ranged"; break;
                case 85: case 86: case 87: case 88: case 89: result = "Soulbound"; break;
                case 90: case 91: case 92: case 93: case 94:  case 95: case 96: case 97: case 98: case 99:case 100: result = "Variable"; break;
                default: result = "Error"; break;
            }
            return result;
        }
        public string MagicShieldPlusTwo()
        {
            int rolled = D(100);
            string result = "";
            switch (rolled)
            {
                case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: result = "Linked"; break;
                case 9: case 10: case 11: case 12: case 13: result = "Manifester"; break;
                case 14: case 15: case 16: case 17: case 18: case 19: case 20: result = "Speed"; break;
                case 21: case 22: case 23: case 24: result = "Anchoring, greater"; break;
                case 25: case 26: case 27: case 28: case 29: case 30: case 31: case 32: case 33: result = "Animated"; break;
                case 34: case 35: case 36: case 37: case 38: case 39: case 40: case 41: result = "Arrow deflection"; break;
                case 42: case 43: case 44: case 45: case 46: case 47: case 48: case 49: result = "Axeblock"; break;
                case 50: case 51: case 52: case 53: case 54: case 55: case 56: case 57: result = "Ectoplasmic wall"; break;
                case 58: case 59: case 60: case 61: case 62: case 63: case 64: case 65: case 66: result = "Energy defense"; break;
                case 67: case 68: case 69: case 70: case 71: case 72: case 73: case 74: case 75: result = "Energy immunity"; break;
                case 76: case 77: case 78: case 79: case 80: case 81: case 82: case 83: result = "Hammerblock"; break;
                case 84: case 85: case 86: case 87: case 88: case 89: case 90: case 91: result = "Spearblock"; break;
                case 92: case 93: case 94: case 95: case 96: case 97: case 98: case 99: case 100: result = "Spell resistance (13)"; break;
                default: result = "Error"; break;
            }
            return result;
        }
        public string MagicShieldPlusThree()
        {
            int rolled = D(100);
            string result = "";
            switch (rolled)
            {
                case 1: case 2: case 3: case 4: case 5: case 6: case 7: result = "Fearsome"; break;
                case 8: case 9: case 10: case 11: case 12: case 13: case 14: result = "Averter"; break;
                case 15: case 16: case 17: case 18: case 19: case 20: case 21: case 22: result = "Fortification, moderate"; break;
                case 23: case 24: case 25: case 26: case 27: case 28: case 29: case 30: result = "Ghost touch"; break;
                case 31: case 32: case 33: result = "Soulbound, greater"; break;
                case 34: case 35: case 36: case 37: case 38: case 39: case 40: case 41: case 42: result = "Spell resistance (15)"; break;
                case 43: case 44: case 45: case 46: case 47: case 48: case 49: result = "Vanishing"; break;
                case 50: case 51: case 52: case 53: case 54: result = "Wild"; break;
                case 55: case 56: case 57: case 58: case 59: case 60: case 61: case 62: case 63: result = "Acid resistance"; break;
                case 64: case 65: case 66: case 67: case 68: case 69: case 70: case 71: case 72: result = "Cold resistance"; break;
                case 73: case 74: case 75: case 76: case 77: case 78: case 79: case 80: case 81: result = "Electricity resistance"; break;
                case 82: case 83: case 84: case 85: case 86: case 87: case 88: case 89: case 90: result = "Fire resistance"; break;
                case 91: case 92: case 93: case 94: case 95: case 96: case 97: case 98: result = "Sonic resistance"; break;
                case 99: case 100: result = MagicShieldPlusTwo() + " " + MagicShieldPlusOne(); break;
                default: result = "Error"; break;
            }
            return result;
        }
        public string MagicShieldPlusFour()
        {
            int rolled = D(100);
            string result = "";
            if (rolled <= 37)
            {
                result = "Spell resistance(17)";
            }
            else if(rolled <= 62)
            {
                result = MagicShieldPlusThree() + " " + MagicShieldPlusOne();
            }
            else 
            {
                result = MagicShieldPlusTwo() + " " + MagicShieldPlusTwo();
            }
            return result;
        }
        public string MagicShieldPlusFive()
        {
            int rolled = D(100);
            string result = "";
            switch (rolled)
            {
                case 1: case 2: case 3: case 4: result = "Fortification, heavy"; break;
                case 5: case 6: case 7: case 8: case 9: case 10: case 11: result = "Reflecting"; break;
                case 12: case 13: case 14: case 15: case 16: case 17: case 18: result = "Spell resistance(19)"; break;
                case 19: case 20: case 21: case 22: case 23: case 24: result = "Time buttress"; break;
                case 25: case 26: case 27: case 28: result = "Aborter"; break;
                case 29: case 30: case 31: case 32: case 33: case 34: case 35: case 36: result = "Acid resistance, improved"; break;
                case 37: case 38: case 39: case 40: case 41: case 42: case 43: case 44: result = "Cold resistance, improved"; break;
                case 45: case 46: case 47: case 48: case 49: case 50: case 51: case 52: result = "Electricity resistance, improved"; break;
                case 53: case 54: case 55: case 56: case 57: case 58: case 59: case 60: result = "Fire resistance, improved"; break;
                case 61: case 62: case 63: case 64: case 65: case 66: case 67: result = "Sonic resistance, improved"; break;
                case 68: case 69: result = "Undead controlling"; break;
                case 70: case 71: case 72: case 73: case 74: case 75: result = "Acid resistance, greater"; break;
                case 76: case 77: case 78: case 79: case 80: case 81: result = "Cold resistance, greater"; break;
                case 82: case 83: case 84: case 85: case 86: case 87: result = "Electricity resistance, greater"; break;
                case 88: case 89: case 90: case 91: case 92: case 93: result = "Fire resistance, greater"; break;
                case 94: case 95: case 96: case 97: case 98: result = "Sonic resistance, greater"; break;
                case 99: result = MagicShieldPlusFour() + " " + MagicShieldPlusOne(); break;
                case 100: result = MagicShieldPlusThree() + " " + MagicShieldPlusTwo(); break;
                default: result = "Error"; break;
            }
            return result;
        }
        #endregion

    }
}
