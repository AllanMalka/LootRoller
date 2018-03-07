using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootRoller.Classes
{
    class GoodsContainer
    {
        private Random index = new Random();

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
        /// This is taken from the goods table in Magic Item Compendium and is therefore bound to specific letters as input.
        /// </summary>
        /// <param name="type">Can only be A, B, C, D, E, F, G, H or I.</param>
        /// <returns></returns>
        public string Goods(string type)
        {
            string result = "";
            switch (type)
            {
                case "A": result = AGoods(); break;
                case "B": result = BGoods(); break;
                case "C": result = CGoods(); break;
                case "D": result = DGoods(); break;
                case "E": result = EGoods(); break;
                case "F": result = FGoods(); break;
                case "G": result = GGoods(); break;
                case "H": result = HGoods(); break;
                case "I": result = IGoods(); break;
                default: result = type + "No Goods"; break;
            }
            return result;
        }

        private string AGoods()
        {
            string[] goods = { "Banded Agate", "Eye Agate", "Moss Agate", "Azurite", "Blue Quartz", "Hematite", "Lapis Lazuli", "Malachite", "Obsidian", 
                                 "Rhodochrosite", "Tiger Eye Turquoise", "Freshwater Pearl", "Steel Pledge Pin", "Boarskin Hat", "Embroidered Linen Blanket", 
                                 "Platter Carved From Maple", "Sealskin Boots", "Teak Bowl", "Cotton Tunic with Royal Crest", "Bronze Spectacles", "Granite Dice", "Satin Belt", "Hammered Brass Wine Cup"};
            return goods[index.Next(goods.Length)] + " worth " + (D(4) + D(4) + D(4) + D(4)) + "gp";
        }
        private string BGoods()
        {
            string[] goods = { "Bloodstone","Carnelian","Chalcedony","Chrysoprase","Citrine","Iolite","Jasper","Moonstone","Onyx","Peridot","Clear Quartz","Sard",
                                 "Sardonyx","Rose Quartz", "Smoky Quartz","Star Rose Quartz","Zircon","Silver Ewer","Carved Bone Statuette","Carved Ivory Statuette",
                                 "Small Gold Bracelet", "Bronze Statue of a Knight", "Mahogany Bust of a Poet","Silver Ring with Blue Quartz","Small Perfume Bottle of Black Crystal",
                                 "Purple Velvet Gloves with Silver Stitching","Ornate Wooden Box","Bronze Earrings Set with Ceramic Ovals","Copper Horn Ringed with Seashells",
                                 "Oak Candlestick","Mahogany Tray Carved with Flowers","Rhinoceros-hide Sack","Peacock-feather Mask","Broad-brimmed Velvet Hat","Zircon-studded Dancing Slippers"};


            return goods[index.Next(goods.Length)] + " worth " + (D(4) + D(4)) * 10 + "gp";
        }
        private string CGoods()
        {
            string[] goods = { "Amber", "Amethyst", "Chrysoberyl", "Coral", "Red Garnet", "Brown-green Garnet", "Jade", "Jet", "White Pearl", "Golden Pearl", 
                                 "Pink Pearl", "Silver Pearl", "Red Spinel", "Red-brown Spinel", "Deep Green Spinel", "Tourmaline", "Cloth of Gold Vestments", 
                                 "Black Velvet Mask adorned with Citrines", "Silver Chalice with Lapis inlay", "Coral Saucer", "Heraldic Banner edged with Swan Feathers", 
                                 "Marble Relief of Dwarf Wrestlers", "Copper Anklet Plated with Silver", "Prayer Mat with inlaid Gold Thread" };

            return goods[index.Next(goods.Length)] + " worth " + (D(4) + D(4) + D(4) + D(4)) * 10 + "gp";
        }
        private string DGoods()
        {
            string[] goods = { "Large Wool Tapestry", "Brass Mug with Jade inlays", "Harp painted with Pastoral Scene", "Mountain landscape in Ash frame", 
                                 "Wall hanging of a Forest in black ink", "Velvet Cloak with Wagle Feathers", "Small Marble Statue of an Athlete", 
                                 "Granite Cup carved with Staring Eyes", "Ivory Bust of a High Priest", "Mithral Circlet engraved with Elvish Poetry", 
                                 "Dragonhide Gloves", "Onyx Hourglass set with Malachite", "Coral Brooch with Oval Jasper setting", "Gold Anklet with Bloodstone Cabochons", 
                                 "Adamantine Armband with Filigree carvings", "Oil Painting of a Royal Wedding", "Jade Cameo Pendant", "Life-size Darkwood Cat Sculpture with yellow Topaz Eyes" };

            return goods[index.Next(goods.Length)] + " worth " + (D(4)) * 100 + "gp";
        }
        private string EGoods()
        {
            string[] goods = { "Alexandrite", "Aquamarine", "Violet Garnet", "Black Pearl", "Deep Blue Spinel", "Golden Yellow Topaz", "Silver Comb with Moonstones", 
                                 "Silver-plated Scabbard with Jet Cabochons", "Carved Darkwood Harp with Ivory inlay and Zircon gems", "Solid Gold Idol (10 lb.)", 
                                 "Linen Tapestry Depicting Giants Destroying a Town", "Obsidian Statue of a Hunting Dog", "Painting of a Sailing Ship", 
                                 "Onyx Sphere with Trees Carved in Relief", "Silk Banner Embroidered with Performing Musician", "Small Masterpiece Portrait in Gold Frame inlaid with Opal" };

            return goods[index.Next(goods.Length)] + " worth " + (D(4) + D(4)) * 100 + "gp";
        }
        private string FGoods()
        {
            string[] goods = { "Emerald", "White Opal", "Black Opal", "Fire Opal", "Blue Sapphire", "Fiery yellow Corundum", "Rich Purple Corundum", 
                                 "Blue Star Sapphire", "Black Star Sapphire", "Star Ruby, Gold Dragon Comb with Red Garnet Eye", "Gold and Topaz Bottle Stopper Cork", 
                                 "Ceremonial Electrum Dagger with Star Ruby in Pommel", "Eyepatch with Mock Eye of Sapphire and Moonstone", "Fire Opal Pendant on Gold Chain", 
                                 "Masterpiece Portrait of an Elite General", "Dinosaurhide Tapestry Depicting a Mage", "Mother-of-pearl Statue of a Naga", 
                                 "Mithral Comb with Opal Runes", "Silver Crown with Opal inlay", "Vestments of Celestial Lion Fur", 
                                 "Set of Six Gold and Silver Bells with Jeweled Handles" };

            return goods[index.Next(goods.Length)] + " worth " + (D(4) + D(4) + D(4) + D(4)) * 100 + "gp";
        }
        private string GGoods()
        {
            string[] goods = { "Eembroidered Silk and Velvet Mantle with Moonstones", "Sapphire Pendant on Gold Chain", "Embroidered and Bejeweled Glove", 
                                 "Jeweled Anklet", "Golden Circlet with Four Aquamarines", "Necklace of Pink Pearls", "Basalt Pyramid with Images of Dragons inlaid in Gems", 
                                 "Lead Crown Adorned with Black Pearls", "Bejeweled Gold Tiara Shaped like Dragon Horns", "Bronze Music Box with Pearl inlay", 
                                 "Mahogany Bracelet Plated with Gold and Platinum", "Dragonhide Formal Shoes with Electrum Buckles" };

            return goods[index.Next(goods.Length)] + " worth " + (D(4)) * 1000 + "gp";
        }
        private string HGoods()
        {
            string[] goods = { "Bright green emerald", "Blue-white Diamond", "Canary Diamond", "Pink Diamond", "Brown Diamond", "Blue Diamond", "Jacinth", 
                                 "Jeweled Gold Crown", "Jeweled Electrum Ring", "Bone Mug set with Opals", "Platinum Sunburst Crown" };

            return goods[index.Next(goods.Length)] + " worth " + (D(4) + D(4)) * 1000 + "gp";
        }
        private string IGoods()
        {
            string[] goods = { "Gold and Ruby Ring", "Gold Cup set with Emeralds", "Regal Scepter set with Sapphires", "Platinum Locket Ringed with Garnets", 
                                 "Mithral Statue of a Noble Horse", "Platinum Tiara", "Gilt Dragon’s Skull with Opal Eyes and Adamantine Teeth" };

            return goods[index.Next(goods.Length)] + " worth " + (D(4) + D(4) + D(4) + D(4)) * 1000 + "gp";
        }
    }
}
