using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cloth{
    
    public class ClothItemBase : MonoBehaviour{

        public ClothType clothType;
        public float duration = 2f;

        public string compareTag = "Player";

        public void OnTriggerEnter(Collider col){

            if (col.transform.CompareTag(compareTag)){
                Collect();
            }
        }

        public virtual void Collect(){

            var setup = ClothManager.Instance.GetSetupByType(clothType);

            PlayerController.Instance.ChangeTexture(setup, duration);

            HideObject();
        }

        public void HideObject(){
            gameObject.SetActive(false);
        }
    }
}