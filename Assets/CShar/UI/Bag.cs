using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public enum Area
    {
        Primary,//ʹ�ÿ���
        Secondary,//��ʹ�ÿ���
        Bag,//������Ʒ
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

        public void UseBagCard(int index,Entity entity,Vector3 position)//ʹ�ö�Ӧλ�ÿ��ƣ�0-3����ʹ�ö���ʹ�õ���������
        {
            primaryCards[index].UseCard(entity, position);
        }
        public void ToreBagCard(int index, Entity entity, Vector3 position)//˺�ٶ�Ӧλ�ÿ��ƣ�0-3����ʹ�ö���ʹ�õ���������
        {
            //primaryCards[index].ToreCard(entity, position);
        }
    }
}
