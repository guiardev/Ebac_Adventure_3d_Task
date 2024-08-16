using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Itens{
    
    public class ItemCollectableBase : MonoBehaviour{

        public ItemType itemType;

        public Collider collider;

        public ParticleSystem particleSystem;
        public GameObject graphicItem;
        public string compareTag = "Player";
        public int timeToHide = 3;

        [Header("Sounds")]
        public AudioSource audioSource;

        private void Awake() {

            //if (particleSystem != null) particleSystem.transform.SetParent(null);
        }

        private void OnTriggerEnter(Collider col){

            if(col.transform.CompareTag(compareTag)){
                Collect();
            }
        }

        protected virtual void Collect(){

            //Debug.Log("Collect");
            //gameObject.SetActive(false);

            if(collider != null) collider.enabled = false; // verificando collider para nao repetir passar do valor de novo.

            if(graphicItem != null) graphicItem.SetActive(false); //checando se object nao esta null para nao fica travando game
            Invoke("HideObject", timeToHide); // invoke chama um método por um tempo, para esperar efeitos das partículas antes do objeto ser destrói-o
            OnCollect();
        }

        public void HideObject(){
            gameObject.SetActive(false);
        }

        protected virtual void OnCollect(){

            if (particleSystem != null) particleSystem.Play();
            if (audioSource != null) audioSource.Play();

            ItemManager.Instance.AddByType(itemType);
        }
    }
}