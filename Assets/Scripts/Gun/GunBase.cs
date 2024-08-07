using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour{

    private Coroutine _currentCoroutine;
    public ProjectileBase prefabProjectile;

    public Transform positionToShoot;
    //public KeyCode keyCode = KeyCode.S;
    public float timeBetweenShoot = .3f, speed = 50f;

    protected virtual IEnumerator ShootCoroutine(){

        //esperar um tempo em cada tiro
        while (true){
            Shoot();
            yield return new WaitForSeconds(timeBetweenShoot);
        }
    }

    public virtual void Shoot(){

        var projectile = Instantiate(prefabProjectile);

        projectile.transform.position = positionToShoot.position;
        projectile.transform.rotation = positionToShoot.rotation; // fazendo tiro atira centro player e seguir rotação do player

        projectile.speed = speed;
    }

    public void StartShoot(){
        StopShoot();
        _currentCoroutine = StartCoroutine(ShootCoroutine());
    }

    public void StopShoot(){

        //Shoot();
        if (_currentCoroutine != null)  {
            StopCoroutine(_currentCoroutine);
        }
    }

}