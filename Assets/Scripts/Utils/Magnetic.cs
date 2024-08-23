using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetic : MonoBehaviour{

    public float dist = .2f, coinSpeed = 3f;
    
    // Update is called once per frame
    void Update(){

        if(Vector3.Distance(transform.position, PlayerController.Instance.transform.position) > dist){
            coinSpeed++;
            transform.position = Vector3.MoveTowards(transform.position, PlayerController.Instance.transform.position, Time.deltaTime * coinSpeed);
        }
    }
}