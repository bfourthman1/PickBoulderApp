using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickBoulder.Repository
{
    public enum RockType{ Granite, Sandstone, Limestone, Quartzite, Slate}
	public class Boulder
    {
		public string BoulderName { get; set; }
        public int Difficulty { get; set; }
        public string Location { get; set; }
        public RockType TypeOfRock { get; set; }
        public int Height { get; set; }
        public bool IsHighball
        {
            get
            {
                if (this.Height > 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //FULL Constructor
        public Boulder(string boulderName, int difficulty, string location, RockType typeOfRock, int height)
        {
            BoulderName = boulderName;
            Difficulty = difficulty;
            Location = location;
            TypeOfRock = typeOfRock;
            Height = height;

        }

        //POTENTIONALLY   //EMPTY Constructor
        
        // public Boulder(string boulderName, int difficulty, string location)
        // {
        //     BoulderName = boulderName;
        //     Difficulty = difficulty;
        //     Location = location;
        // }

    }
}
