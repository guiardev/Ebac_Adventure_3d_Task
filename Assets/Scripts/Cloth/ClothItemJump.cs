using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cloth{
    
    public class ClothItemJump : ClothItemBase{

        public float targetJump = 15f;

        private void PlaySFX(){
            SFXPool.Instance.Play(sfxType);
        }

        public override void Collect(){

            PlaySFX();
            base.Collect();
            PlayerController.Instance.ChangeJump(targetJump, duration);
        }
    }
}