using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickBoulder.Repository 
{ 
    public class BoulderRepository
    {         
        List<Boulder> _boulderList = new List<Boulder>();

        public void SeedData()
        {
            Boulder theShield = new Boulder("The Shield", 12, "TN", RockType.Sandstone, 18);
            Boulder kingAir = new Boulder("King Air", 10, "CA", RockType.Granite, 40);
            Boulder westernGold = new Boulder("Western Gold", 11, "TN", RockType.Sandstone, 16);
            Boulder kintsugi = new Boulder("Kintsugi", 13, "NV", RockType.Sandstone, 20);
            Boulder boxTherapy = new Boulder("Box Therapy", 16, "CO", RockType.Granite, 12);
            Boulder spectre = new Boulder("Spectre", 13, "CA", RockType.Granite, 30);
            Boulder neverCryWolf = new Boulder("Never Cry Wolf", 13, "WY", RockType.Granite, 16);
            Boulder manOnTheMoon = new Boulder("Man On The Moon", 8, "WV", RockType.Sandstone, 12);
            Boulder algorithmic = new Boulder("Algorithmic", 10, "WV", RockType.Sandstone, 14);
            Boulder fullService = new Boulder("Full Service", 10, "TX", RockType.Sandstone, 10);
            Boulder theMultiverse = new Boulder("The Multiverse", 15, "WY", RockType.Granite, 12);
            Boulder godModule = new Boulder("God Module", 11, "AL", RockType.Sandstone, 14);
            Boulder getRichOrDieTrying = new Boulder("Get Rich Or Die Trying", 11, "WV", RockType.Sandstone, 16);
            Boulder zef = new Boulder("Zef", 14, "WY", RockType.Granite, 14);
            Boulder wetWilly = new Boulder("Wet Willy", 13, "NC", RockType.Sandstone, 14);
            Boulder crownJewel = new Boulder("Crown Jewel", 10, "CA", RockType.Granite, 12);
            Boulder masterpiece = new Boulder("Masterpiece", 13, "UT", RockType.Sandstone, 10);
            Boulder sunseeker = new Boulder("Sunseeker", 12, "CO", RockType.Granite, 14);
            Boulder osiris = new Boulder("Osiris", 10, "TN", RockType.Sandstone, 12);
            Boulder showYourScars = new Boulder("Show Your Scars ", 14, "UT", RockType.Granite, 14);
            

            Boulder[] boulderArr = { theShield, kingAir, westernGold, kintsugi, boxTherapy, spectre, neverCryWolf, manOnTheMoon, algorithmic, fullService, theMultiverse, godModule, getRichOrDieTrying, zef, wetWilly, crownJewel, masterpiece, sunseeker, osiris, showYourScars };

            foreach (Boulder ralph in boulderArr)
            {
                AddBoulderToList(ralph);
            }
        }

        public void AddBoulderToList(Boulder sam)
        {
            _boulderList.Add(sam);
        }

        //READ all 
        public List<Boulder> GetAllBoulder()
        {
            return _boulderList;
        }

    }
}