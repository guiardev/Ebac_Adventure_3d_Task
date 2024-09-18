using System.Collections;
using System.Collections.Generic;
using Animation;
using UnityEngine;

namespace Enemy{
    
    public class EnemyWalk : EnemyBase{

        public AnimationBase animationBase;
        [Header("Waypoints")]
        private int _index = 0;
        public GameObject[] waypoints;
        public float minDistance = 1f, speed = 1f;

        public void Start() {
            animationBase.animator.SetTrigger("Walk");
        }

        public override void Update(){


            base.Update();

            //fazendo inimigo andar seguindo os waypoints
            if (Vector3.Distance(transform.position, waypoints[_index].transform.position) < minDistance){

                _index++;

                if (_index >= waypoints.Length){
                    _index = 0;
                }
            }

            transform.position = Vector3.MoveTowards(transform.position, waypoints[_index].transform.position, Time.deltaTime * speed);
            transform.LookAt(waypoints[_index].transform.position); // fazendo inimigo olhar na direção do waypoints
        }
    }
}