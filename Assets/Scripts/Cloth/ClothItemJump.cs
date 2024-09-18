using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cloth{
    
    public class ClothItemJump : ClothItemBase{

        public float targetJump = 15f;

        public override void Collect(){

            base.Collect();
            PlayerController.Instance.ChangeJump(targetJump, duration);
        }
    }
}