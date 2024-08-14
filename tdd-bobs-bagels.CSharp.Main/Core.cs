using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {

        /// <summary>
        /// enum as my bagle shop only produces standardised bagles.
        /// </summary>
        public enum BagleType
        {
            PLAINBAGEL,
            EGGBAGEL,
            RAINBOWBAGEL,
            VICTORSSPECIALBAGEL,
            CUSTOMBAGLE
        }


        /// <summary>
        /// Shoppinglist
        /// </summary>
        private List<BagleType> bagleBasket;

        //Max number of items in baset
        private int maxBasketSize;

        //Corrent number of items in basket
        private int currentBasketSize;

        /// <summary>
        /// Init all bagle-related data
        /// </summary>
        public Core()
        {
            bagleBasket = new List<BagleType>();
            maxBasketSize = 5;
            currentBasketSize = 0;
        }

        /// <summary>
        /// adds bagle if 
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>

        public bool addBagle(BagleType b)
        {
            if (maxBasketSize <= currentBasketSize)
            {
                return false;
            }
            else
            {
                bagleBasket.Add(b);
                currentBasketSize++;
                return true;
            }
        }

        public bool removeBagle(BagleType b)
        {
            if (bagleBasket.Remove(b))
            {
                currentBasketSize--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getMaxBasketSize() { return maxBasketSize; }

        public int getCurrentBasketSize() { return currentBasketSize; }

        public void setBasketSize(int newBasketSize) { maxBasketSize = newBasketSize; }

    }
}
