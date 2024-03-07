using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public enum Area
    {
        Primary,
        Secondary,
        Bag,
    }
    public class Bag : MonoBehaviour
    {
        BagCard[] primaryCards = new BagCard[4];
        BagCard[] secondaryCards = new BagCard[4];
        BagItem[] bagItems = new BagItem[24];

        public void AddBagItem()
        {
            
        }

        public void TransferTo(Area area, int position, Area toArea, int toPosition)
        {
            
        }
    }
}
