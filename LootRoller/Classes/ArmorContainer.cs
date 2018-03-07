using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootRoller.Classes
{
    class ArmorContainer
    {
        /// <summary>
        /// The three types of item and shield.
        /// </summary>
        private static string[] _type = { "Light", "Medium", "Heavy", "Shield" };

        public string RandomArmorOrShield()
        {
            string result = "";
            int dice = new Random().Next(1, 101);
            if (dice <= 2)
            {
                result = Padded;
            }
            else if (dice <= 6)
            {
                result = Leather;
            }
            else if (dice <=21)
            {
                result = StuddedLeather;
            }
            else if (dice <= 37)
            {
                result = ChainShirt;
            }
            else if (dice <= 52)
            {
                result = Hide;
            }
            else if (dice <= 55)
            {
                result = ScaleMail;
            }
            else if (dice <= 59)
            {
                result = ChainMail;
            }
            else if (dice <= 74)
            {
                result = BreastPlate;
            }
            else if (dice <= 77)
            {
                result = SplintMail;
            }
            else if (dice <= 81)
            {
                result = BandedMail;
            }
            else if (dice <= 85)
            {
                result = HalfPlate;
            }
            else if (dice <= 92)
            {
                result = FullPlate;
            }
            else if (dice == 93)
            {
                result = Buckler;
            }
            else if (dice <= 95)
            {
                result = LightWoodShield;
            }
            else if (dice == 96)
            {
                result = LightSteelShield;
            }
            else if (dice <= 98)
            {
                result = HeavyWoodShield;
            }
            else if (dice == 99)
            {
                result = HeavySteelShield;
            }
            else if (dice == 100)
            {
                result = TowerShield;
            }

            return result;
        }

        public string[] AllProtection()
        {
            return new string[] { Padded, Leather, StuddedLeather, ChainShirt, Hide, ScaleMail, ChainMail, BreastPlate, SplintMail, BandedMail,
                HalfPlate, FullPlate, Buckler, LightWoodShield, LightSteelShield, HeavyWoodShield, HeavySteelShield, TowerShield, "Light", "Medium", "Heavy", "Shield" };
        }

        #region Armor
        public string Padded
        {
            get
            {
                return "Padded/" + _type[0];
            }
        }
        public string Leather
        {
            get
            {
                return "Leather/" + _type[0];
            }
        }
        public string StuddedLeather
        {
            get
            {
                return "Studded leather/" + _type[0];
            }
        }
        public string ChainShirt
        {
            get
            {
                return "Chain shirt/" + _type[0];
            }
        }
        public string Hide
        {
            get
            {
                return "Hide/" + _type[1];
            }
        }
        public string ScaleMail
        {
            get
            {
                return "Scale mail/" + _type[1];
            }
        }
        public string ChainMail
        {
            get
            {
                return "Chain mail/" + _type[1];
            }
        }
        public string BreastPlate
        {
            get
            {
                return "Breast plate/" + _type[1];
            }
        }
        public string SplintMail
        {
            get
            {
                return "Splint mail/" + _type[2];
            }
        }
        public string BandedMail
        {
            get
            {
                return "Banded mail/" + _type[2];
            }
        }
        public string HalfPlate
        {
            get
            {
                return "Half-plate/" + _type[2];
            }
        }
        public string FullPlate
        {
            get
            {
                return "Full plate/" + _type[2];
            }
        }
        #endregion

        #region Shield
        public string Buckler
        {
            get
            {
                return "Buckler/" + _type[3];
            }
        }
        public string LightWoodShield
        {
            get
            {
                return "Shield, light wooden/" + _type[3];
            }
        }
        public string LightSteelShield
        {
            get
            {
                return "Shield, light steel/" + _type[3];
            }
        }
        public string HeavyWoodShield
        {
            get
            {
                return "Shield, heavy wooden/" + _type[3];
            }
        }
        public string HeavySteelShield
        {
            get
            {
                return "Shield, heavy steel/" + _type[3];
            }
        }
        public string TowerShield
        {
            get
            {
                return "Shield, tower/" + _type[3];
            }
        }
        #endregion

    }
}
