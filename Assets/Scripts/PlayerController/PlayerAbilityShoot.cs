using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAbilityShoot : PlayerAbilityBase{

    private GunBase _currentGun;
    public Transform gunPosition;
    public GunBase gunBaseShootLimit, gunBaseAngle;

    [Header("Gun Key Setup")]
    public KeyCode gunShootLimit = KeyCode.Alpha1;
    public KeyCode gunAngle = KeyCode.Alpha2;

    protected override void Init(){

        base.Init();

        //shootAction.performed += ctx => Shoot();
        inputs.Gameplay.Shoot.performed += cts => StartShoot();  // quando essa botão clicado vai chamar método Shoot();
        inputs.Gameplay.Shoot.canceled += cts => CancelShoot();
    }

    private void Update() {
        
        if (Input.GetKeyDown(gunShootLimit)){
            Debug.Log("gunShootLimit");
            CreateGun(gunBaseShootLimit);
        }else if(Input.GetKeyDown(gunAngle)){
            Debug.Log("gunAngle");
            CreateGun(gunBaseAngle);
        }
    }

    private void CreateGun(GunBase gun){

        _currentGun = Instantiate(gun, gunPosition);

        _currentGun.transform.localPosition = _currentGun.transform.localEulerAngles = Vector3.zero;
    }

    private void StartShoot(){
        _currentGun.StartShoot();
        Debug.Log("Start Shoot");
    }

    private void CancelShoot(){
        Debug.Log("Cancel Shoot");
        _currentGun.StopShoot();
    }
}
