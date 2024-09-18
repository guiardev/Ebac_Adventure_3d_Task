using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChestBase : MonoBehaviour{

    private bool _chestOpened = false;

    public KeyCode keyCode = KeyCode.E;
    public Animator animator;
    public string triggerOpen = "Open";

    [Header("Notification")]
    public GameObject notification;
    public Ease tweenEase = Ease.OutBack;
    public float tweenDuration = .2f, startScale;

    [Space]
    public ChestItemBase chestItem;

    // Start is called before the first frame update
    void Start(){
        startScale = notification.transform.localScale.x;
        HideNotification(); 
    }

    private void Update() {

        if (Input.GetKeyDown(keyCode) && notification.activeSelf){
            OpenChest();
        }
    }

    [NaughtyAttributes.Button]
    private void OpenChest(){

        if (_chestOpened) return;

        animator.SetTrigger(triggerOpen);
        _chestOpened = true;

        HideNotification();
        
        Invoke(nameof(ShowItem), 1f);
    }

    private void ShowItem(){

        chestItem.ShowItem();

        Invoke(nameof(CollectItem), 1f);        
    }

    private void CollectItem(){
        chestItem.Collect();
    }

    public void OnTriggerEnter(Collider col){

        PlayerController p = col.transform.GetComponent<PlayerController>();

        if(p != null){
            ShowNotification();
        }
    }

    private void OnTriggerExit(Collider col) {

        PlayerController p = col.transform.GetComponent<PlayerController>();

        if (p != null){
            HideNotification();
        }
    }

    [NaughtyAttributes.Button]
    private void ShowNotification(){

        notification.SetActive(true);
        notification.transform.localScale = Vector3.zero;
        notification.transform.DOScale(startScale, tweenDuration);
    }

    [NaughtyAttributes.Button]
    private void HideNotification(){
        notification.SetActive(false);
    }
}