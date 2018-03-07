using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootRoller.Classes
{
    class WeaponsContainer
    {
        /// <summary>
        /// Two different types: 0 Ranged and 1 Melee.
        /// </summary>
        private static string[] _type = { "/Ranged", "/Melee" };
        /// <summary>
        /// If the weapon is 0 Light handed, 1 One-handed, 2 Two-handed, 3 Ammunition, 4 Thrown or 5 Ranged weapon.
        /// </summary>
        private static string[] _weight = { "-Light", "-One handed", "-Two handed", "-Ammunition", "-Thrown", "-Ranged weapon" };
        /// <summary>
        /// If the weapon is 0 Bludgeoning, 1 Piercing, 2 Slashing or 3 Ammo dependent.
        /// </summary>
        private static string[] _damageType = { "#Bludgeoning", "#Piercing", "#Slashing", "#Ammo dependent" };

        public string[] AllWeapons()
        {
            return new string[] { Arrows, OrcDoubleAxe, ThrownAxe, Battleaxe, Bolas, Bolts, SpikedChain, Club, HandCrossbow, HeavyCrossbow, LightCrossbow, HeavyRepeatingCrossbow,
                LightRepeatingCrossbow, Dagger, PunchingDagger, Dart, Falchion, DireFlail, HeavyFlail, LightFlail, Gauntlet, SpikedGauntlet, Glaive, Greataxe, Greatclub, Greatsword,
            Guisarme, Halberd, GnomeHammer, LightHammer, Handaxe, Javelin, Kama, Kukri, Lance, Longbow, CompositeLongbow0, CompositeLongbow1, CompositeLongbow2, CompositeLongbow3,
            CompositeLongbow4, CompositeLongbow5, Longspear, Longsword, HeavyMace, LightMace, Morningstar, Net, Nunchaku, HeavyPick, LightPick, Quarterstaff, Ranseur, Rapier, Sai,
            Sap, Scimitar, Scythe, Shortbow, CompositeShortbow0, CompositeShortbow1, CompositeShortbow2, CompositeShortbow3, CompositeShortbow4, CompositeShortbow5, Shortspear,
            Shuriken, Siangham, Sickle, Sling, Spear, BastardSword, ShortSword, TwoBladedSword, Trident, DwarvenUrgrosh, DwarvenWaraxe, Warhammer, Whip, "Ranged", "Melee", "Light", 
            "One handed", "Two handed", "Ammunition", "Thrown", "Ranged weapon", "Bludgeoning", "Piercing", "Slashing", "Ammo dependent" };
        }

        public string RandomWeapon()
        {
            string result = "";

            switch (new Random().Next(1,100))
            {
                case 1: case 2: result = Arrows; break;
                case 3: result = OrcDoubleAxe; break;
                case 4: result = OrcDoubleAxe; break;
                case 5: result = Battleaxe; break;
                case 6: result = Bolas; break;
                case 7: case 8: result = Bolts; break;
                case 9: case 10: result = Bullets; break;
                case 11: result = SpikedChain; break;
                case 12: result = Club; break;
                case 13: result = HandCrossbow; break;
                case 14: case 15: result = HeavyCrossbow; break;
                case 16: case 17: result = LightCrossbow; break;
                case 18: result = HeavyRepeatingCrossbow; break;
                case 19: result = LightRepeatingCrossbow; break;
                case 20: case 21: result = Dagger; break;
                case 22: result = PunchingDagger; break;
                case 23: result = Dart; break;
                case 24: result = Falchion; break;
                case 25: result = DireFlail; break;
                case 26: result = HeavyFlail; break;
                case 27: result = LightFlail; break;
                case 28: result = Gauntlet; break;
                case 29: result = SpikedGauntlet; break;
                case 30: result = Glaive; break;
                case 31: case 32: result = Greataxe; break;
                case 33: result = Greatclub; break;
                case 34: case 35: result = Greatsword; break;
                case 36: result = Guisarme; break;
                case 37: result = Halberd; break;
                case 38: result = GnomeHammer; break;
                case 39: result = LightHammer; break;
                case 40: result = Handaxe; break;
                case 41: result = Javelin; break;
                case 42: result = Kama; break;
                case 43: result = Kukri; break;
                case 44: result = Lance; break;
                case 45: case 46: result = Longbow; break;
                case 47: result = CompositeLongbow0; break;
                case 48: result = CompositeLongbow1; break;
                case 49: result = CompositeLongbow2; break;
                case 50: result = CompositeLongbow3; break;
                case 51: result = CompositeLongbow4; break;
                case 52: result = CompositeLongbow5; break;
                case 53: result = Longspear; break;
                case 54: case 55: result = Longsword; break;
                case 56: case 57: result = HeavyMace; break;
                case 58: result = LightMace; break;
                case 59: result = Morningstar; break;
                case 60: result = Net; break;
                case 61: result = Nunchaku; break;
                case 62: result = HeavyPick; break;
                case 63: result = LightPick; break;
                case 64: case 65: result = Quarterstaff; break;
                case 66: result = Ranseur; break;
                case 67: case 68: result = Rapier; break;
                case 69: result = Sai; break;
                case 70: result = Sap; break;
                case 71: case 72: result = Scimitar; break;
                case 73: result = Scythe; break;
                case 74: case 75: result = Shortbow; break;
                case 76: result = CompositeShortbow0; break;
                case 77: result = CompositeShortbow1; break;
                case 78: result = CompositeShortbow2; break;
                case 79: result = CompositeShortbow3; break;
                case 80: result = CompositeShortbow4; break;
                case 81: result = CompositeShortbow5; break;
                case 82: case 83: result = Shortspear; break;
                case 84: result = Shuriken; break;
                case 85: result = Siangham; break;
                case 86: result = Sickle; break;
                case 87: case 88: result = Sling; break;
                case 89: result = Spear; break;
                case 90: case 91: result = BastardSword; break;
                case 92: case 93: result = ShortSword; break;
                case 94: result = TwoBladedSword; break;
                case 95: result = Trident; break;
                case 96: result = DwarvenUrgrosh; break;
                case 97: result = DwarvenWaraxe; break;
                case 98: result = Warhammer; break;
                case 99: result = Whip; break;
                case 100: result = "Other/DM's choice"; break;
                default: break;
            }

            return result;
        }

        #region Weapons
        public string Arrows
        {
            get { return "Arrows (50)" + _type[0] + _weight[3] + _damageType[1]; }
        }
        public string OrcDoubleAxe
        {
            get { return "Axe, orc double" + _type[1] + _weight[2] + _damageType[2]; }
        }
        public string ThrownAxe
        {
            get { return "Axe, throwing" + _type[1] + _weight[0] + _damageType[2]; }
        }
        public string Battleaxe
        {
            get { return "Battleaxe" + _type[1] + _weight[1] + _damageType[2]; }
        }
        public string Bolas
        {
            get { return "Bolas" + _type[0] + _weight[4] + _damageType[0]; }
        }
        public string Bolts
        {
            get { return "Bolts, crossbow(50)" + _type[0] + _weight[3] + _damageType[1]; }
        }
        public string Bullets
        {
            get { return  "Bullets, sling(50)" + _type[0] + _weight[3] + _damageType[0]; }
        }
        public string SpikedChain
        {
            get { return "Chain, spiked" + _type[1] + _weight[2] + _damageType[1]; }
        }
        public string Club
        {
            get { return "Club" + _type[1] + _weight[1] + _damageType[0]; }
        }
        public string HandCrossbow
        {
            get { return  "Crossbow, hand" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string HeavyCrossbow
        {
            get { return "Crossbow, heavy" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string LightCrossbow
        {
            get { return "Crossbow, light" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string HeavyRepeatingCrossbow
        {
            get { return "Crossbow, repeating heavy" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string LightRepeatingCrossbow
        {
            get { return "Crossbow, repeating light" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string Dagger
        {
            get { return "Dagger" + _type[1] + _weight[0] + _damageType[1] + " or " + _damageType[2]; }
        }
        public string PunchingDagger
        {
            get { return "Dagger, punching" + _type[1] + _weight[0] + _damageType[1]; }
        }
        public string Dart
        {
            get { return "Dart" + _type[0] + _weight[4] + _damageType[1]; }
        }
        public string Falchion
        {
            get { return "Falchion" + _type[1] + _weight[2] + _damageType[2]; }
        }
        public string DireFlail
        {
            get { return "Flail, dire" + _type[1] + _weight[2] + _damageType[0]; }
        }
        public string HeavyFlail
        {
            get { return "Flail, heavy" + _type[1] + _weight[2] + _damageType[0]; }
        }
        public string LightFlail
        {
            get { return "Flail, light" + _type[1] + _weight[1] + _damageType[0]; }
        }
        public string Gauntlet
        {
            get { return "Gauntlet" + _type[1] + _weight[0] + _damageType[0]; }
        }
        public string SpikedGauntlet
        {
            get { return "Gauntlet, spiked" + _type[1] + _weight[0] + _damageType[1]; }
        }
        public string Glaive
        {
            get { return "Glaive" + _type[1] + _weight[2] + _damageType[2]; }
        }
        public string Greataxe
        {
            get { return "Greataxe" + _type[1] + _weight[2] + _damageType[2]; }
        }
        public string Greatclub
        {
            get { return "Greatclub" + _type[1] + _weight[2] + _damageType[0]; }
        }
        public string Greatsword
        {
            get { return "Greatsword" + _type[1] + _weight[2] + _damageType[2]; }
        }
        public string Guisarme
        {
            get { return "Guisarme" + _type[1] + _weight[2] + _damageType[2]; }
        }
        public string Halberd
        {
            get { return "Halberd" + _type[1] + _weight[2] + _damageType[1] + " or " + _damageType[2]; }
        }
        public string GnomeHammer
        {
            get { return "Hammer, gnome hooked" + _type[1] + _weight[2] + _damageType[0] + " and " + _damageType[1]; }
        }
        public string LightHammer
        {
            get { return "Hammer, light" + _type[1] + _weight[0] + _damageType[0]; }
        }
        public string Handaxe
        {
            get { return "Handaxe" + _type[1] + _weight[0] + _damageType[2]; }
        }
        public string Javelin
        {
            get { return "Javelin" + _type[0] + _weight[4] + _damageType[1]; }
        }
        public string Kama
        {
            get { return "Kama" + _type[1] + _weight[0] + _damageType[2]; }
        }
        public string Kukri
        {
            get { return "Kukri" + _type[1] + _weight[0] + _damageType[2]; }
        }
        public string Lance
        {
            get { return "Lance" + _type[1] + _weight[2] + _damageType[1]; }
        }
        public string Longbow
        {
            get { return "Longbow" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeLongbow0
        {
            get { return "Longbow, Composite (+0 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeLongbow1
        {
            get { return "Longbow, Composite (+1 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeLongbow2
        {
            get { return "Longbow, Composite (+2 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeLongbow3
        {
            get { return "Longbow, Composite (+3 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeLongbow4
        {
            get { return "Longbow, Composite (+4 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeLongbow5
        {
            get { return "Longbow, Composite (+5 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string Longspear
        {
            get { return "Longspear" + _type[1] + _weight[2] + _damageType[1]; }
        }
        public string Longsword
        {
            get { return "Longsword" + _type[1] + _weight[1] + _damageType[2]; }
        }
        public string HeavyMace
        {
            get { return "Mace, heavy" + _type[1] + _weight[1] + _damageType[0]; }
        }
        public string LightMace
        {
            get { return "Mace, light" + _type[1] + _weight[1] + _damageType[0]; }
        }
        public string Morningstar
        {
            get { return "Morningstar" + _type[1] + _weight[1] + _damageType[0] + " and " + _damageType[1]; }
        }
        public string Net
        {
            get { return "Net" + _type[0] + _weight[4] + _damageType[3]; }
        }
        public string Nunchaku
        {
            get { return "Nunchaku" + _type[1] + _weight[0] + _damageType[0]; }
        }
        public string HeavyPick
        {
            get { return "Pick, heavy" + _type[1] + _weight[1] + _damageType[1]; }
        }
        public string LightPick
        {
            get { return "Pick, light" + _type[1] + _weight[0] + _damageType[1]; }
        }
        public string Quarterstaff
        {
            get { return "Quarterstaff" + _type[1] + _weight[2] + _damageType[0]; }
        }
        public string Ranseur
        {
            get { return "Ranseur" + _type[1] + _weight[2] + _damageType[1]; }
        }
        public string Rapier
        {
            get { return "Rapier" + _type[1] + _weight[1] + _damageType[1]; }
        }
        public string Sai
        {
            get { return "Sai" + _type[1] + _weight[0] + _damageType[0]; }
        }
        public string Sap
        {
            get { return "Sap" + _type[1] + _weight[0] + _damageType[0]; }
        }
        public string Scimitar
        {
            get { return "Scimitar" + _type[1] + _weight[1] + _damageType[2]; }
        }
        public string Scythe
        {
            get { return "Scythe" + _type[1] + _weight[2] + _damageType[1] + " or " + _damageType[2]; }
        }
        public string Shortbow
        {
            get { return "Shortbow" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeShortbow0
        {
            get { return "Shortbow, Composite (+0 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeShortbow1
        {
            get { return "Shortbow, Composite (+1 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeShortbow2
        {
            get { return "Shortbow, Composite (+2 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeShortbow3
        {
            get { return "Shortbow, Composite (+3 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeShortbow4
        {
            get { return "Shortbow, Composite (+4 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string CompositeShortbow5
        {
            get { return "Shortbow, Composite (+5 Str bonus)" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string Shortspear
        {
            get { return "Shortspear" + _type[1] + _weight[1] + _damageType[1]; }
        }
        public string Shuriken
        {
            get { return "Shuriken" + _type[0] + _weight[4] + _damageType[1]; }
        }
        public string Siangham
        {
            get { return "Siangham" + _type[1] + _weight[0] + _damageType[1]; }
        }
        public string Sickle
        {
            get { return "Sickle" + _type[1] + _weight[0] + _damageType[2]; }
        }
        public string Sling
        {
            get { return "Sling" + _type[0] + _weight[5] + _damageType[3]; }
        }
        public string Spear
        {
            get { return "Spear" + _type[1] + _weight[2] + _damageType[1]; }
        }
        public string BastardSword
        {
            get { return "Sword, bastard" + _type[1] + _weight[2] + _damageType[2]; }
        }
        public string ShortSword
        {
            get { return "Sword, short" + _type[1] + _weight[0] + _damageType[2]; }
        }
        public string TwoBladedSword
        {
            get { return "Sword, two-bladed" + _type[1] + _weight[2] + _damageType[2]; }
        }
        public string Trident
        {
            get { return "Trident" + _type[1] + _weight[1] + _damageType[1]; }
        }
        public string DwarvenUrgrosh
        {
            get { return "Urgrosh, dwarven" + _type[1] + _weight[2] + _damageType[2] + " or " + _damageType[1]; }
        }
        public string DwarvenWaraxe
        {
            get { return "Waraxe, dwarven" + _type[1] + _weight[1] + _damageType[2]; }
        }
        public string Warhammer
        {
            get { return "Warhammer" + _type[1] + _weight[1] + _damageType[0]; }
        }
        public string Whip
        {
            get { return "Whip" + _type[1] + _weight[1] + _damageType[2]; }
        }
        #endregion
    }
}
