using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Test;

namespace Game
{
    public class BagCard : BagItem
    {
        Card card;

        public void UseCard(Entity entity,Vector3 position)
        {
            card.UseCard(entity, position);
        }
    }
}
