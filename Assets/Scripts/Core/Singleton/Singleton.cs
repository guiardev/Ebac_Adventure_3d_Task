using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Singleton{

    // <T> e um parâmetro esta dizendo o tipo de class e where e para detalhar
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour{

        public static T Instance;

        protected virtual void Awake(){

            //verificando se tem instance objeto GameManager
            if(Instance == null){
                Instance = GetComponent<T>(); // pegando componente dando para referencia
                DontDestroyOnLoad(Instance); // add DontDestroyOnLoad para todo script que estiver associado com Singleton nao vai ser destruído por muda se cena
            }else{
                Destroy(gameObject);
            }
        }
    }
}