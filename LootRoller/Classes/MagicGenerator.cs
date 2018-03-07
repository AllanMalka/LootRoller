using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootRoller.Classes
{
    class MagicGenerator
    {
        #region Checking for Armor
        /// <summary>
        /// By default is metal.
        /// </summary>
        /// <param name="item">Only the given item.</param>
        /// <returns></returns>
        private bool isMetal(string armor)
        {
            bool canDo = true;

            if (armor.ToLower().Equals("padded"))
                canDo = false;
            else if (armor.ToLower().Equals("leather"))
                canDo = false;
            else if (armor.ToLower().Equals("studded leather"))
                canDo = false;
            else if (armor.ToLower().Equals("hide"))
                canDo = false;

            return canDo;
        }
        /// <summary>
        /// By default is not light.
        /// </summary>
        /// <param name="type">Only the given type.</param>
        /// <returns></returns>
        private bool isLightArmor(string type)
        {
            bool canDo = false;
            if (type.ToLower().Equals("light"))
                canDo = true;
            return canDo;
        }
        /// <summary>
        /// By default is not a Tower shield
        /// </summary>
        /// <param name="shield">Only the given shield.</param>
        /// <returns></returns>
        private bool isTower(string shield)
        {
            bool canDo = false;
            if (shield.ToLower().Equals("shield, tower"))
                canDo = true;
            return canDo;
        }
        #endregion

        #region Checking for Weapons
        /// <summary>
        /// By default returns that it is not a crossbow.
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        private bool isCrossBow(string weapon)
        {
            bool canDo = false;
            if (weapon.ToLower().Contains("crossbow"))
                canDo = true;
            return canDo;
        }
        /// <summary>
        /// By default returns that it is not a bow.
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        private bool isBow(string weapon)
        {
            bool canDo = false;
            if (weapon.ToLower().Contains("bow"))
                canDo = true;
            return canDo;
        }
        /// <summary>
        /// Is by default false if it is a spear.
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        private bool isSpear(string weapon)
        {
            bool canDo = false;
            if (weapon.ToLower().Contains("spear"))
                canDo = true;
            return canDo;
        }
        /// <summary>
        /// By default is not a two handed.
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        private bool isTwohanded(string weight)
        {
            bool canDo = false;
            if (weight.ToLower().Equals("two handed"))
                canDo = true;
            return canDo;
        }
        /// <summary>
        /// is by default not a bludgeoning.
        /// </summary>
        /// <param name="damage"></param>
        /// <returns></returns>
        private bool isBludgeoning(string damage)
        {
            bool canDo = false;
            if (damage.ToLower().Equals("bludgeoning"))
                canDo = true;
            return canDo;
        }
        /// <summary>
        /// is by default not a piercing.
        /// </summary>
        /// <param name="damage"></param>
        /// <returns></returns>
        private bool isPiercing(string damage)
        {
            bool canDo = false;
            if (damage.ToLower().Equals("piercing"))
                canDo = true;
            return canDo;
        }
        /// <summary>
        /// is by default not a slashing.
        /// </summary>
        /// <param name="damage"></param>
        /// <returns></returns>
        private bool isSlashing(string damage)
        {
            bool canDo = false;
            if (damage.ToLower().Equals("slashing"))
                canDo = true;
            return canDo;
        }
        /// <summary>
        /// Is by default not a throwing weapon
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        private bool isThrowing(string weight)
        {
            bool canDo = false;
            if (weight.ToLower().Equals("thrown"))
                canDo = true;
            return canDo;
        }
        /// <summary>
        /// Is by default not a light weapon
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        private bool isLightWeapon(string weight)
        {
            bool canDo = false;
            if (weight.ToLower().Equals("light"))
                canDo = true;
            return canDo;
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

        /// <summary>
        /// This is to find out how the enhancements are to be written out.
        /// </summary>
        /// <param name="type">This is int based since there is only two differences. Either 1 Armor or 2 Weapon</param>
        /// <param name="eLevel">This is the enhancement level going from 1 - 5.</param>
        /// <param name="item">Only insert the full item for the specific type of which has been chosen.</param>
        /// <returns></returns>
        public string ProbertyStrength(int type, int eLevel, string item)
        {
            string result = "";
            int rolled = D(100);
            switch (eLevel)
            {
                #region +1 Bonus
                case 1: result = "+1 enhancement"; break;
                #endregion
                #region +2 Bonus
                case 2:
                    if (rolled <= 62)
                    {
                        result = "+2 enhancement";
                    }
                    else
                    {
                        result = "+1 enhancement" + " " + MagicType(type, 1, item);
                    };
                    break;
                #endregion
                #region +3 Bonus
                case 3:
                    if (rolled <= 44)
                    {
                        result = "+3 enhancement";
                    }
                    else if (rolled <= 79)
                    {
                        result = "+2 enhancement" + " " + MagicType(type, 1, item);
                    }
                    else if (rolled <= 91)
                    {
                        result = "+1 enhancement" + " " + MagicType(type, 2, item);
                    }
                    else
                    {
                        result = "+1 enhancement" + " " + Comparer(type, 1, item);
                    };
                    break;
                #endregion
                #region +4 Bonus
                case 4:
                    if (rolled <= 44)
                    {
                        result = "+4 enhancement";
                    }
                    else if (rolled <=79)
                    {
                        result = "+3 enhancement" + " " + MagicType(type, 1, item);
                    }
                    else if (rolled <= 91)
                    {
                        result = "+2 enhancement" + " " + MagicType(type, 2, item);
                    }
                    else
                    {
                        result = "+1 enhancement" + " " + MagicType(type, 3, item);
                    }
                    break;
                #endregion
                #region +5 Bonus
                case 5:
                    if (rolled <= 40)
                    {
                        result = "+5 enhancement";
                    }
                    else if (rolled <= 75)
                    {
                        result = "+4 enhancement" + " " + MagicType(type, 1, item);
                    }
                    else if (rolled <= 88)
                    {
                        result = "+3 enhancement" + " " + MagicType(type, 2, item);
                    }
                    else if (rolled <= 95)
                    {
                        result = "+2 enhancement" + " " + MagicType(type, 3, item);
                    }
                    else
                    {
                        result = "+1 enhancement" + " " + MagicType(type, 4, item);
                    }
                    break;
                #endregion
                #region +6 Bonus
                case 6:
                    if (rolled <= 43)
                    {
                        result = "+5 enhancement" + " " + MagicType(type, 1, item);
                    }
                    else if (rolled <= 77)
                    {
                        result = "+4 enhancement" + " " + MagicType(type, 2, item);
                    }
                    else if (rolled <= 89)
                    {
                        result = "+3 enhancement" + " " + MagicType(type, 3, item);
                    }
                    else if (rolled <= 95)
                    {
                        result = "+2 enhancement" + " " + MagicType(type, 4, item);
                    }
                    else
                    {
                        result = "+1 enhancement" + " " + MagicType(type, 5, item);
                    }
                    break;
                #endregion
                #region +7 Bonus
                case 7:
                    if (rolled <= 47)
                    {
                        result = "+5 enhancement" + " " + MagicType(type, 2, item);
                    }
                    else if (rolled <= 79)
                    {
                        result = "+4 enhancement" + " " + MagicType(type, 3, item);
                    }
                    else if (rolled <= 92)
                    {
                        result = "+3 enhancement" + " " + MagicType(type, 4, item);
                    }
                    else
                    {
                        result = "+2 enhancement" + " " + MagicType(type, 5, item);
                    }
                    break;
                #endregion
                #region +8 Bonus
                case 8:
                    if (rolled <= 52)
                    {
                        result = "+5 enhancement" + " " + MagicType(type, 3, item);
                    }
                    else if (rolled <= 85)
                    {
                        result = "+4 enhancement" + " " + MagicType(type, 4, item);
                    }
                    else
                    {
                        result = "+3 enhancement" + " " + MagicType(type, 5, item);
                    }
                    break;
                #endregion
                #region +9 Bonus
                case 9:
                    if (rolled <= 52)
                    {
                        result = "+5 enhancement" + " " + MagicType(type, 4, item);
                    }
                    else if (rolled <= 85)
                    {
                        result = "+4 enhancement" + " " + MagicType(type, 3, item) + " " + MagicType(type, 2, item);
                    }
                    else
                    {
                        result = "+4 enhancement" + " " + MagicType(type, 5, item);
                    }
                    break;
                #endregion
                #region +10 Bonus
                case 10:
                    if (rolled <= 50)
                    {
                        result = "+5 enhancement" + " " + MagicType(type, 3, item) + " " + MagicType(type, 2, item);
                    }
                    else if (rolled <= 85)
                    {
                        result = "+5 enhancement" + " " + MagicType(type, 5, item);
                    }
                    else
                    {
                        result = "+4 enhancement" + " " + MagicType(type, 3, item) + " " + MagicType(type, 3, item);
                    }
                    break;
                #endregion
                default:
                    break;
            }

            return result;
        }

        private string Comparer(int type, int enchant, string item)
        {
            string res = "";
            string x = "Null";
            string y = "Null";
            do
            {
                x = MagicType(type, enchant, item);
                y = MagicType(type, enchant, item);

            } while (x.Equals(y));
            res = x + " " + y;
            return res;
        }

        /// <summary>
        /// Returns a magic property for either a armor enchantment or weapon enchantment.
        /// </summary>
        /// <param name="type">This is int based since there is only two differences. Either 1 Armor or 2 Weapon</param>
        /// <param name="eLevel">This is the enhancement level going from 1 - 5.</param>
        /// <param name="item">Only insert the full item for the specific type of which has been chosen.</param>
        /// <returns></returns>
        private string MagicType(int type, int eLevel, string item)
        {
            string result = "";
            switch (type)
            {
                case 1: result = MagicArmorProperty(eLevel, item); break;
                case 2: result = MagicWeaponProperty(eLevel, item); break;
                default:
                    break;
            }


            return result;
        }

        /// <summary>
        /// Finds a property, and checks to make sure the item can use it or if it is a shield.
        /// </summary>
        /// <param name="eLevel">The enhancement level.</param>
        /// <param name="item">The chosen item/shield.</param>
        /// <returns>The given magic property</returns>
        public string MagicArmorProperty(int eLevel, string armor)
        {
            string result = "";
            string magicProp = "";
            MagicArmorProperties mAP = new MagicArmorProperties();
            result = armor;
            string item = result.Remove(result.LastIndexOf("/"));
            string type = result.Substring(result.LastIndexOf("/") + 1);
            if (type.Equals("Shield"))
            {
                #region Shield Enhancements
                switch (eLevel)
                {
                    case 1:
                        magicProp = mAP.MagicShieldPlusOne();
                        if (magicProp.Equals("Ranged"))
                        {
                            if (isTower(item))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        break;
                    case 2: magicProp = mAP.MagicShieldPlusTwo(); break;
                    case 3:
                        magicProp = mAP.MagicShieldPlusThree();
                        if (magicProp.Contains("Ranged"))
                        {
                            if (isTower(item))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        break;
                    case 4:
                        magicProp = mAP.MagicShieldPlusFour();
                        if (magicProp.Contains("Ranged"))
                        {
                            if (isTower(item))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        break;
                    case 5:
                        magicProp = mAP.MagicShieldPlusFive();
                        if (magicProp.Contains("Ranged"))
                        {
                            if (isTower(item))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        break;
                    default: break;
                }
                #endregion
            }
            else
            {
                #region Armor Enhancements
                switch (eLevel)
                {
                    case 1:
                        magicProp = mAP.MagicArmorPlusOne();
                        if (magicProp.Equals("Blueshine"))
                        {
                            if (!isMetal(item))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        if (magicProp.Equals("Dragondodger"))
                        {
                            if (!isLightArmor(type))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        if (magicProp.Equals("Mobility"))
                        {
                            if (!isLightArmor(type))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        break;
                    case 2: magicProp = mAP.MagicArmorPlusTwo(); break;
                    case 3:
                        magicProp = mAP.MagicArmorPlusThree();
                        if (magicProp.Contains("Blueshine"))
                        {
                            if (!isMetal(item))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        if (magicProp.Contains("Dragondodger"))
                        {
                            if (!isLightArmor(type))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        if (magicProp.Contains("Mobility"))
                        {
                            if (!isLightArmor(type))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        break;
                    case 4:
                        magicProp = mAP.MagicArmorPlusFour();
                        if (magicProp.Contains("Blueshine"))
                        {
                            if (!isMetal(item))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        if (magicProp.Contains("Dragondodger"))
                        {
                            if (!isLightArmor(type))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        if (magicProp.Contains("Mobility"))
                        {
                            if (!isLightArmor(type))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        break;
                    case 5:
                        magicProp = mAP.MagicArmorPlusFive();
                        if (magicProp.Contains("Blueshine"))
                        {
                            if (!isMetal(item))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        if (magicProp.Contains("Dragondodger"))
                        {
                            if (!isLightArmor(type))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        if (magicProp.Contains("Mobility"))
                        {
                            if (!isLightArmor(type))
                            {
                                return MagicArmorProperty(eLevel, result);
                            }
                        }
                        break;
                    default: break;
                }
                #endregion
            }
            return magicProp;
        }

        /// <summary>
        /// Finds a property, and checks to make sure the item can use it.
        /// </summary>
        /// <param name="eLevel">The enhancement level.</param>
        /// <param name="item">The chosen Weapon.</param>
        /// <returns>The given magic property</returns>
        public string MagicWeaponProperty(int eLevel, string weapon)
        {
            string result = "";
            string magicProp = "";
            MagicWeaponProperties mWP = new MagicWeaponProperties();
            result = weapon;
            string item = result.Remove(result.LastIndexOf("/"));
            string type = result.Substring(result.LastIndexOf("/") + 1);
            type = type.Remove(type.LastIndexOf("-"));
            string weight = result.Substring(result.LastIndexOf("-") + 1);
            weight = weight.Remove(weight.LastIndexOf("#"));
            string damage = result.Substring(result.LastIndexOf("#") + 1);
            if (type.Equals("Ranged"))
            {
                #region Ranged Enchancements
                switch (eLevel)
                {
                    #region +1
                    case 1: 
                        magicProp = mWP.MagicRangedPlusOne();
                        if (magicProp.Contains("Arcane might") && isBow(item) && !isCrossBow(item))
                        {
                        }
                        else
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Quick loading") && !isCrossBow(item))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Morphing") && !isThrowing(weight))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        break;
                    #endregion
                    #region +2
                    case 2:
                        magicProp = mWP.MagicRangedPlusTwo();
                        if (magicProp.Contains("Arcane might") && isBow(item) && !isCrossBow(item))
                        {
                        }
                        else
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Quick loading") && !isCrossBow(item))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        break;
                    #endregion
                    #region +3
                    case 3:
                        magicProp = mWP.MagicRangedPlusThree();
                        if (magicProp.Contains("Arcane might") && isBow(item) && !isCrossBow(item))
                        {
                        }
                        else
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Quick loading") && !isCrossBow(item))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        break;
                    #endregion
                    #region +4
                    case 4:
                        magicProp = mWP.MagicRangedPlusFour();
                        if (magicProp.Contains("Arcane might") && isBow(item) && !isCrossBow(item))
                        {
                        }
                        else
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Quick loading") && !isCrossBow(item))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        break;
                    #endregion
                    #region +5
                    case 5:
                        magicProp = mWP.MagicRangedPlusFive();
                        if (magicProp.Contains("Arcane might") && isBow(item) && !isCrossBow(item))
                        {
                        }
                        else
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        if (magicProp.Contains("Quick loading") && !isCrossBow(item))
                        {
                            return MagicWeaponProperty(eLevel, weapon);
                        }
                        break;
                    #endregion
                    default:
                        break;
                }
                #endregion
            }
            else
            {
                #region Melee Enhancements
                switch (eLevel)
                {
                    #region +1
                        case 1:
                            magicProp = mWP.MagicMeleePlusOne();
                            if (magicProp.Contains("Changeling") && !isSpear(item))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Berserker") && !isTwohanded(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impaling") && !isPiercing(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Keen") && isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Shielding") && !isLightWeapon(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            break;
                    #endregion
                    #region +2
                        case 2:
                            magicProp = mWP.MagicMeleePlusTwo();
                            if (magicProp.Contains("Changeling") && !isSpear(item))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Berserker") && !isTwohanded(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impaling") && !isPiercing(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Keen") && isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Shielding") && !isLightWeapon(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Disruption") && !isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Fleshgrinding") && isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            break;
                    #endregion
                    #region +3
                        case 3: magicProp = mWP.MagicMeleePlusThree();
                            if (magicProp.Contains("Changeling") && !isSpear(item))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Berserker") && !isTwohanded(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impaling") && !isPiercing(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Keen") && isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Shielding") && !isLightWeapon(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Disruption") && !isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Fleshgrinding") && isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            break;
                    #endregion
                    #region +4
                        case 4: mWP.MagicMeleePlusFour();
                        
                            if (magicProp.Contains("Changeling") && !isSpear(item))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Berserker") && !isTwohanded(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impaling") && !isPiercing(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Keen") && isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Shielding") && !isLightWeapon(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Disruption") && !isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Fleshgrinding") && isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            break;
                    #endregion
                    #region +5
                        case 5: magicProp = mWP.MagicMeleePlusFive();
                            if (magicProp.Contains("Changeling") && !isSpear(item))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Berserker") && !isTwohanded(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impact") && !isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Impaling") && !isPiercing(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Keen") && isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Shielding") && !isLightWeapon(weight))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Disruption") && !isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Fleshgrinding") && isBludgeoning(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            if (magicProp.Contains("Vorpal") && !isSlashing(damage))
                            {
                                return MagicWeaponProperty(eLevel, weapon);
                            }
                            break;
                    #endregion
                    default:
                        break;
                }
                #endregion
            }
            return magicProp;
        }
    }
}
