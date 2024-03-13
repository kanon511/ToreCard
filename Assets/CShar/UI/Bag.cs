using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public enum Area
    {
        Primary,//使用卡牌
        Secondary,//备使用卡牌
        Bag,//背包物品
    }
    public class Bag
    {
        BagCard[] primaryCards = new BagCard[4];
        BagCard[] secondaryCards = new BagCard[4];
        BagItem[] bagItems = new BagItem[24];

        public Bag()
        {
            primaryCards[0] = new BagCard();
        }
        public void AddBagItem()
        {
            
        }

        public void TransferTo(Area area, int position, Area toArea, int toPosition)
        {
            
        }

        public void UseBagCard(int index,Entity entity,Vector3 position)//使用对应位置卡牌（0-3），使用对象，使用点世界坐标
        {
            primaryCards[index].UseCard(entity, position);
        }
        public void ToreBagCard(int index, Entity entity, Vector3 position)//撕毁对应位置卡牌（0-3），使用对象，使用点世界坐标
        {
            //primaryCards[index].ToreCard(entity, position);
        }
    }
}
