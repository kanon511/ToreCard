using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class BagCard : BagItem
    {
        Card card;
        
        public BagCard()
        {
            card = new Card();
        }
        public void UseCard(Entity entity,Vector3 position)
        {
            card.UseCard(entity, position);
        }
    }
}
