using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EndGame : MonoBehaviour{

    private bool _endGame = false;

    public List<GameObject> endGameObjects;

    public int currentLevel = 1;

    private void Awake() {
        endGameObjects.ForEach(i => i.SetActive(false)); // desligando
    }

    private void OnTriggerEnter(Collider col) {

        PlayerController p = col.transform.GetComponent<PlayerController>();

        if(!_endGame && p != null){ // _endGame verificando se for falso
            ShowEndGame();
        }
    }

    private void ShowEndGame(){

        _endGame = true;
        endGameObjects.ForEach(i => i.SetActive(true)); // ativando

        foreach(var i in endGameObjects){ // ativando dos os objetos

            i.SetActive(true);
            i.transform.DOScale(0, .2f).SetEase(Ease.OutBack).From();

            SaveManager.Instance.SaveLastLevel(currentLevel); // salvando level atual
        }
    }

}