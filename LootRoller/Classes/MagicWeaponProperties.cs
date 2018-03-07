using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootRoller.Classes
{
    class MagicWeaponProperties
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

        #region Melee
        public string MagicMeleePlusOne()
        {
            string result = "";
            int rolled = D(100);
            switch (rolled)
            {
                case 1: result = "Illuminating"; break;
                case 2: result = "Aquatic"; break;
                case 3: case 4: result = "Changeling"; break;
                case 5: result = "Everbright"; break;
                case 6: result = "Hideaway"; break;
                case 7: result = "Shadowstrike"; break;
                case 8: case 9: result = "Sizing"; break;
                case 10: case 11: result = "Slow burst"; break;
                case 12: case 13: result = "Bane (roll on table in DMG)"; break;
                case 14: result = "Berserker"; break;
                case 15: result = "Binding"; break;
                case 16: result = "Blessed"; break;
                case 17: case 18: result = "Bloodfeeding"; break;
                case 19: result = "Bloodstone"; break;
                case 20: result = "Brash"; break;
                case 21: result = "Brutal surge"; break;
                case 22: result = "Chargebreaker"; break;
                case 23: result = "Charging"; break;
                case 24: case 25: result = "Corrosive"; break;
                case 26: result = "Deadly precision"; break;
                case 27: case 28: result = "Defending"; break;
                case 29: result = "Defensive surge"; break;
                case 30: result = "Dessicating"; break;
                case 31: case 32: result = "Dislocator"; break;
                case 33: result = "Dispelling"; break;
                case 34: result = "Divine wrath"; break;
                case 35: result = "Dragondoom"; break;
                case 36: case 37: result = "Eager"; break;
                case 38: case 39: case 40: result = "Flaming"; break;
                case 41: case 42: case 43: result = "Frost"; break;
                case 44: case 45: result = "Ghost touch"; break;
                case 46: result = "Harmonizing"; break;
                case 47: case 48: result = "Heavenly burst"; break;
                case 49: result = "Hunting"; break;
                case 50: result = "Illusion bane"; break;
                case 51: case 52: result = "Impact"; break;
                case 53: result = "Impaling"; break;
                case 54: case 55: case 56: case 57: result = "Keen"; break;
                case 58: result = "Ki focus"; break;
                case 59: result = "Knockback"; break;
                case 60: case 61: result = "Lucky"; break;
                case 62: result = "Magebane"; break;
                case 63: result = "Maiming"; break;
                case 64: result = "Merciful"; break;
                case 65: case 66: result = "Mighty cleaving"; break;
                case 67: result = "Mighty smiting"; break;
                case 68: result = "Mindfeeder"; break;
                case 69: case 70: result = "Morphing"; break;
                case 71: result = "Paralyzing"; break;
                case 72: result = "Power storing"; break;
                case 73: result = "Profane"; break;
                case 74: result = "Psychokinetic"; break;
                case 75: result = "Resounding"; break;
                case 76: result = "Revealing"; break;
                case 77: result = "Sacred"; break;
                case 78: result = "Screaming"; break;
                case 79: result = "Shattermantle"; break;
                case 80: result = "Shielding"; break;
                case 81: case 82: case 83: result = "Shock"; break;
                case 84: result = "Soulbound"; break;
                case 85: case 86: case 87: result = "Spell storing"; break;
                case 88: result = "Spellstrike"; break;
                case 89: result = "Stunning surge"; break;
                case 90: result = "Stygian"; break;
                case 91: result = "Sundering"; break;
                case 92: result = "Sweeping"; break;
                case 93: result = "Throwing"; break;
                case 94: result = "Thundering"; break;
                case 95: result = "Venomous"; break;
                case 96: case 97: result = "Vicious"; break;
                case 98: result = "Warning"; break;
                case 99: result = "Weakening"; break;
                case 100: result = "Whirling"; break;
                default: break;
            }
            return result;
        }
        public string MagicMeleePlusTwo()
        {
            string result = "";
            int rolled = D(100);
            switch (rolled)
            {
                case 1: result = "Vanishing"; break;
                case 2: result = "Manifester"; break;
                case 3: case 4: result = "Acidic burst"; break;
                case 5: case 6: result = "Anarchic"; break;
                case 7: result = "Aquan"; break;
                case 8: result = "Auran"; break;
                case 9: case 10: result = "Axiomatic"; break;
                case 11: case 12: result = "Banishing"; break;
                case 13: case 14: result = "Blindsighted"; break;
                case 15: case 16: result = "Blurstrike"; break;
                case 17: case 18: result = "Collision"; break;
                case 19: case 20: result = "Consumptive"; break;
                case 21: case 22: result = "Dessicating burst"; break;
                case 23: result = "Disarming"; break;
                case 24: case 25: result = "Dislocator, great"; break;
                case 26: case 27: result = "Dispelling, greater"; break;
                case 28: case 29: result = "Disruption"; break;
                case 30: case 31: result = "Domineering"; break;
                case 32: case 33: result = "Doom burst"; break;
                case 34: case 35: result = "Energy aura"; break;
                case 36: case 37: result = "Energy surge"; break;
                case 38: case 39: result = "Enervating"; break;
                case 40: case 41: result = "Fiercebane"; break;
                case 42: case 43: case 44: result = "Flaming burst"; break;
                case 45: case 46: result = "Fleshgrinding"; break;
                case 47: case 48: result = "Ghost strike"; break;
                case 49: case 50: case 51: result = "Holy"; break;
                case 52: case 53: case 54: result = "Icy burst"; break;
                case 55: result = "Ignan"; break;
                case 56: case 57: result = "Impedance"; break;
                case 58: case 59: result = "Incorporeal binding"; break;
                case 60: case 61: result = "Metalline"; break;
                case 62: case 63: result = "Mindcrusher"; break;
                case 64: case 65: result = "Paralytic burst"; break;
                case 66: case 67: result = "Parrying"; break;
                case 68: case 69: result = "Profane burst"; break;
                case 70: case 71: result = "Psibane"; break;
                case 72: case 73: result = "Psychic"; break;
                case 74: case 75: result = "Psychokinetic burst"; break;
                case 76: case 77: result = "Sacred burst"; break;
                case 78: case 79: result = "Screaming burst"; break;
                case 80: case 81: case 82: case 83: result = "Shocking burst"; break;
                case 84: case 85: case 86: result = "Stunning"; break;
                case 87: case 88: result = "Terran"; break;
                case 89: case 90: case 91: result = "Transmuting"; break;
                case 92: case 93: result = "Unholy"; break;
                case 94: case 95: result = "Vampiric"; break;
                case 96: case 97: case 98: result = "Wounding"; break;
                case 99:
                case 100:
                    string magicResultOne = MagicMeleePlusOne();
                    string magicResultTwo = MagicMeleePlusOne();

                    while (magicResultOne.Equals(magicResultTwo))
                    {
                        magicResultTwo = MagicMeleePlusOne();
                    }
                    result = magicResultOne + " " + magicResultTwo; break;
                default: break;
            }
            return result;
        }
        public string MagicMeleePlusThree()
        {
            string result = "";
            int rolled = D(100);
            switch (rolled)
            {
                case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: result = "Prismatic burst"; break;
                case 10: case 11: case 12: case 13: case 14: case 15: case 16: case 17: result = "Bodyfeeder"; break;
                case 18: case 19: case 20: case 21: case 22: case 23: case 24: case 25: result = "Cursespewing"; break;
                case 26: case 27: case 28: case 29: case 30: case 31: case 32: result = "Ethereal reaver"; break;
                case 33: case 34: case 35: case 36: case 37: case 38: case 39: result = "Holy surge"; break;
                case 40: case 41: case 42: case 43: case 44: case 45: case 46: case 47: result = "Implacable"; break;
                case 48: case 49: case 50: case 51: case 52: case 53: case 54: result = "Necrotic focus"; break;
                case 55: case 56: case 57: result = "Soulbound, greater"; break;
                case 58: case 59: case 60: case 61: result = "Soulbreaker"; break;
                case 62: case 63: case 64: case 65: case 66: result = "Souldrinking"; break;
                case 67: case 68: case 69: case 70: case 71: case 72: case 73: case 74: case 75: case 76: result = "Speed"; break;
                case 77: case 78: case 79: case 80: case 81: case 82: case 83: case 84: result = "Unholy surgeS"; break;
                case 85: case 86: case 87: case 88: case 89: case 90: case 91: case 92: result = "Illusion theftS"; break;
                case 93: case 94: case 95: case 96: case 97: case 98: case 99: case 100: result = MagicMeleePlusTwo() + " " + MagicMeleePlusOne(); break;
                default: break;
            }
            return result;
        }
        public string MagicMeleePlusFour()
        {
            string result = "";
            int rolled = D(100);
            if (rolled <= 19)
            {
                result = "Brilliant Energy";
            }
            else if (rolled <= 41)
            {
                result = "Dancing";
            }
            else if (rolled <= 64)
            {
                result = MagicMeleePlusThree() + " " + MagicMeleePlusOne();
            }
            else if (rolled <= 83)
            {
                result = MagicMeleePlusTwo() + " " + MagicMeleePlusTwo();
            }
            else if (rolled <= 100)
            {
                string magicResultOne = MagicMeleePlusOne();
                string magicResultTwo = MagicMeleePlusOne();

                while (magicResultOne.Equals(magicResultTwo))
                {
                    magicResultTwo = MagicMeleePlusOne();
                }
                result = MagicMeleePlusTwo() + " " + magicResultOne + " " + magicResultTwo;
            }
            return result;
        }
        public string MagicMeleePlusFive()
        {
            string result = "";
            int rolled = D(100);
            if (rolled <= 20)
            {
                result = "Vorpal";
            }
            else if (rolled <= 40)
            {
                result = MagicMeleePlusFour() + " " + MagicMeleePlusOne();
            }
            else if (rolled <= 60)
            {
                result = MagicMeleePlusThree() + " " + MagicMeleePlusTwo();
            }
            else if (rolled <= 80)
            {
                string magicResultOne = MagicMeleePlusTwo();
                string magicResultTwo = MagicMeleePlusTwo();

                while (magicResultOne.Equals(magicResultTwo))
                {
                    magicResultTwo = MagicMeleePlusTwo();
                }
                result = magicResultOne +" " + magicResultTwo +" " + MagicMeleePlusOne();
            }
            else if (rolled <= 100)
            {
                string mROne = MagicMeleePlusOne();
                string mRTwo = MagicMeleePlusOne();
                string mRThree = MagicMeleePlusOne();

                while (mROne.Equals(mRTwo) || mRTwo.Equals(mRThree) || mRThree.Equals(mROne))
                {
                    if (mROne.Equals(mRTwo))
                    {
                        mROne = MagicMeleePlusOne();
                    }
                    if (mRTwo.Equals(mRThree))
                    {
                        mRTwo = MagicMeleePlusOne();
                    }
                    if (mRThree.Equals(mROne))
                    {
                        mRThree = MagicMeleePlusOne();
                    }
                }

                result = MagicMeleePlusTwo() + " " + mROne + " " + mRTwo + " " + mRThree;
            }
            return result;
        }
        #endregion

        #region Ranged
        public string MagicRangedPlusOne()
        {
            string result = "";
            int rolled = D(100);
            switch (rolled)
            {
                case 1: result = "Illuminating"; break;
                case 2: result = "Aquatic"; break;
                case 3: result = "Everbright"; break;
                case 4: case 5: result = "Hideaway"; break;
                case 6: case 7: result = "Shadowstrike"; break;
                case 8: case 9: result = "Sizing"; break;
                case 10: case 11: result = "Slow burst"; break;
                case 12: case 13: result = "Arcane might"; break;
                case 14: case 15: result = "Bane (roll on table in DMG)"; break;
                case 16: result = "Binding"; break;
                case 17: case 18: result = "Blessed"; break;
                case 19: case 20: result = "Corrosive"; break;
                case 21: case 22: result = "Deadly precision"; break;
                case 23: case 24: result = "Dessicating"; break;
                case 25: result = "Dislocator"; break;
                case 26: case 27: result = "Dispelling"; break;
                case 28: case 29: result = "Distance"; break;
                case 30: case 31: result = "Divine wrath"; break;
                case 32: case 33: result = "Dragonhunter"; break;
                case 34: case 35: case 36: result = "Flaming"; break;
                case 37: case 38: case 39: result = "Frost"; break;
                case 40: case 41: result = "Heavenly burst"; break;
                case 42: case 43: result = "Hunting"; break;
                case 44: case 45: result = "Illusion bane"; break;
                case 46: case 47: result = "Impact"; break;
                case 48: case 49: result = "Knockback"; break;
                case 50: case 51: result = "Lucky"; break;
                case 52: case 53: result = "Magebane"; break;
                case 54: case 55: result = "Maiming"; break;
                case 56: result = "Merciful"; break;
                case 57: case 58: result = "Mindfeeder"; break;
                case 59: case 60: result = "Morphing"; break;
                case 61: result = "Power storing"; break;
                case 62: case 63: case 64: result = "Precise"; break;
                case 65: case 66: result = "Profane"; break;
                case 67: case 68: result = "Psychokinetic"; break;
                case 69: case 70: case 71: result = "Quick loading"; break;
                case 72: case 73: result = "Returning"; break;
                case 74: case 75: result = "Revealing"; break;
                case 76: case 77: result = "Sacred"; break;
                case 78: case 79: result = "Screaming"; break;
                case 80: case 81: result = "Seeking"; break;
                case 82: case 83: result = "Shattermantle"; break;
                case 84: case 85: result = "Shock"; break;
                case 86: result = "Soulbound"; break;
                case 87: result = "Spellstrike"; break;
                case 88: case 89: result = "Stunning surge"; break;
                case 90: case 91: result = "Stygian"; break;
                case 92: case 93: case 94: result = "Thundering"; break;
                case 95: case 96: result = "Venomous"; break;
                case 97: case 98: result = "Warning"; break;
                case 99: case 100: result = "Weakening"; break;
                default: break;
            }
            return result;
        }
        public string MagicRangedPlusTwo()
        {
            string result = "";
            int rolled = D(100);
            switch (rolled)
            {
                case 1: result = "Manifester"; break;
                case 2: case 3: case 4: result = "Acidic burst"; break;
                case 5: case 6: result = "Anarchic"; break;
                case 7: result = "Aquan"; break;
                case 8: result = "Auran"; break;
                case 9: case 10: result = "Axiomatic"; break;
                case 11: case 12: result = "Banishing"; break;
                case 13: case 14: case 15: result = "Blindsighted"; break;
                case 16: case 17: result = "Collision"; break;
                case 18: case 19: result = "Consumptive"; break;
                case 20: case 21: result = "Dessicating burst"; break;
                case 22: case 23: result = "Disarming"; break;
                case 24: case 25: case 26: result = "Dislocator, great"; break;
                case 27: case 28: result = "Dispelling, greater"; break;
                case 29: case 30: result = "Domineering"; break;
                case 31: case 32: case 33: result = "Doom burst"; break;
                case 34: case 35: case 36: result = "Energy aura"; break;
                case 37: case 38: result = "Enervating"; break;
                case 39: case 40: result = "Fiercebane"; break;
                case 41: case 42: case 43: case 44: case 45: result = "Flaming burst"; break;
                case 46: case 47: case 48: result = "Force"; break;
                case 49: case 50: case 51: result = "Holy"; break;
                case 52: case 53: case 54: case 55: case 56: result = "Icy burst"; break;
                case 57: result = "Ignan"; break;
                case 58: case 59: case 60: result = "Impedance"; break;
                case 61: case 62: case 63: result = "Metalline"; break;
                case 64: case 65: result = "Mindcrusher"; break;
                case 66: case 67: result = "Paralytic burst"; break;
                case 68: case 69: result = "Parrying"; break;
                case 70: case 71: result = "Profane burst"; break;
                case 72: case 73: result = "Psibane"; break;
                case 74: case 75: result = "Psychic"; break;
                case 76: case 77: result = "Psychokinetic burst"; break;
                case 78: case 79: result = "Sacred burst"; break;
                case 80: case 81: case 82: result = "Screaming burst"; break;
                case 83: case 84: case 85: case 86: case 87: case 88: result = "Shocking burst"; break;
                case 89: case 90: case 91: result = "Stunning"; break;
                case 92: result = "Terran"; break;
                case 93: case 94: case 95: case 96: result = "Transmuting"; break;
                case 97: case 98: result = "Unholy"; break;
                case 99:
                case 100:
                    string magicResultOne = MagicRangedPlusOne();
                    string magicResultTwo = MagicRangedPlusOne();

                    while (magicResultOne.Equals(magicResultTwo))
                    {
                        magicResultTwo = MagicRangedPlusOne();
                    }
                    result = magicResultOne + " " + magicResultTwo; break;
                default: break;
            }
            return result;
        }
        public string MagicRangedPlusThree()
        {
            string result = "";
            int rolled = D(100);
            switch (rolled)
            {
                case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: case 10: case 11: case 12: result = "Prismatic burst"; break;
                case 13: case 14: case 15: case 16: case 17: case 18: case 19: case 20: case 21: case 22: case 23: result = "Bodyfeeder"; break;
                case 24: case 25: case 26: case 27: case 28: case 29: case 30: case 31: case 32: result = "Cursespewing"; break;
                case 33: case 34: case 35: case 36: case 37: case 38: case 39: case 40: case 41: case 42: case 43: case 44: case 45: result = "Implacable"; break;
                case 46: case 47: case 48: case 49: case 50: case 51: case 52: case 53: result = "Soulbound, greater"; break;
                case 54: case 55: case 56: case 57: case 58: case 59: result = "Soulbreaker"; break;
                case 60: case 61: case 62: case 63: case 64: result = "Souldrinking"; break;
                case 65: case 66: case 67: case 68: case 69: case 70: case 71: case 72: case 73: case 74: case 75: case 76: case 77: case 78: result = "Speed"; break;
                case 79: case 80: case 81: case 82: case 83: case 84: case 85: case 86: case 87: case 88: case 89: result = "Illusion theftS"; break;
                case 90: case 91: case 92: case 93: case 94: case 95: case 96: case 97: case 98: case 99: case 100: result = MagicRangedPlusTwo() + " " + MagicRangedPlusOne(); break;
                default: break;
            }
            return result;
        }
        public string MagicRangedPlusFour()
        {
            string result = "";
            int rolled = D(100);
            if (rolled >= 31)
            {
                result = "Brilliant energy";
            }
            else if (rolled >= 61)
            {
                result = MagicRangedPlusThree() + " " + MagicRangedPlusOne();
            }
            else if (rolled >= 82)
            {
                result = MagicRangedPlusTwo() + " " + MagicRangedPlusTwo();
            }
            else
            {
                string magicResultOne = MagicRangedPlusOne();
                string magicResultTwo = MagicRangedPlusOne();

                while (magicResultOne.Equals(magicResultTwo))
                {
                    magicResultTwo = MagicRangedPlusOne();
                }
                result = MagicRangedPlusTwo() + " " + magicResultOne + " " + magicResultTwo;
            }
            return result;
        }
        public string MagicRangedPlusFive()
        {
            string result = "";
            int rolled = D(100);
            if (rolled >= 38)
            {
                result = MagicRangedPlusFour() + " " + MagicRangedPlusOne();
            }
            else if (rolled >=71)
            {
                result = MagicRangedPlusThree() + " " + MagicRangedPlusTwo();
            }
            else if (rolled >= 91)
            {

                string magicResultOne = MagicRangedPlusTwo();
                string magicResultTwo = MagicRangedPlusTwo();

                while (magicResultOne.Equals(magicResultTwo))
                {
                    magicResultTwo = MagicRangedPlusTwo();
                }
                result = MagicRangedPlusOne() + " " + magicResultOne + " " + magicResultTwo;
            }
            else
            {

                string mROne = MagicRangedPlusOne();
                string mRTwo = MagicRangedPlusOne();
                string mRThree = MagicRangedPlusOne();

                while (mROne.Equals(mRTwo) || mRTwo.Equals(mRThree) || mRThree.Equals(mROne))
                {
                    if (mROne.Equals(mRTwo))
                    {
                        mROne = MagicRangedPlusOne();
                    }
                    if (mRTwo.Equals(mRThree))
                    {
                        mRTwo = MagicRangedPlusOne();
                    }
                    if (mRThree.Equals(mROne))
                    {
                        mRThree = MagicRangedPlusOne();
                    }
                }

                result = MagicRangedPlusTwo() + " " + mROne + " " + mRTwo + " " + mRThree;
            }
            return result;
        }
        #endregion

    }
}
