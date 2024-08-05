using System.Collections;
using System.Collections.Generic;
using Game.StateMachine;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static GameManager;

public class PlayerController : MonoBehaviour{

    private Vector3 _speedVector;
    private float _vSpeed = 0f;
    private bool _alive = true;
    public Animator animator;
    public List<Collider> colliders;
    public KeyCode jumpKeyCode = KeyCode.Space;
    public CharacterController characterController;
    public float speed = 1f, turnSpeed = 1f, jumpSpeed = 15f, gravity = -9.8f;

    [Header("Life")]
    public HealthBase healthBase;
    public UIFillUpdater uifillUpdater;

    [Header("Run Setup")]
    public KeyCode keyRun = KeyCode.LeftShift;
    public float speedRun = 1.5f;

    [Header("Flash")]
    public List<FlashColor> flashColors;

    #region VALIDATE

    private void OnValidate(){

        if (healthBase == null){
            healthBase = GetComponent<HealthBase>();
        }
    }

    private void Awake(){

        OnValidate();
        healthBase.OnDamage += Damage;
        healthBase.OnKill += OnKill;
    }

    #endregion

    #region LIFE

    private void OnKill(HealthBase h){

        if (_alive){

            _alive = false;
            animator.SetTrigger("Death");
            colliders.ForEach(i => i.enabled = false); // tirando colisão personagem

            Invoke(nameof(Revive), 3f);
        }
    }

    private void Revive(){

        _alive = true;

        healthBase.ResetLife();
        animator.SetTrigger("Revive");

        Respawn();
        Invoke(nameof(TurnOnColliders), .1f);
    }

    #endregion

    private void TurnOnColliders(){
        colliders.ForEach(i => i.enabled = true); // ativando colisão personagem  
    }

    public void Damage(HealthBase h){
        flashColors.ForEach(i => i.Flash()); // fazendo personagem piscar quando for atingindo
    }

    // Update is called once per frame
    void Update(){

        transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);

        var inputAxisVertical = Input.GetAxis("Vertical");
        var speedVector = transform.forward * inputAxisVertical * speed;

        if (characterController.isGrounded){

            _vSpeed = 0;

            if (Input.GetKeyDown(jumpKeyCode)){
                _vSpeed = jumpSpeed;
            }
        }

        _vSpeed -= gravity * Time.deltaTime; // fazendo gravidade funcionar
        speedVector.y = _vSpeed;

        var isWalking = inputAxisVertical != 0;
        if (isWalking){

            if (Input.GetKey(keyRun)){

                speedVector *= speedRun;
                animator.speed = speedRun;
            }else{
                animator.speed = 1;
            }
        }

        characterController.Move(speedVector * Time.deltaTime);

        animator.SetBool("Run", inputAxisVertical != 0);  //verificar input Vertical
    }

    [NaughtyAttributes.Button]
    public void Respawn(){

        if (CheckpointManager.Instance.HasCheckpoint()){
            transform.position = CheckpointManager.Instance.GetPositionFromLastCheckpoint();
        }
    }
}