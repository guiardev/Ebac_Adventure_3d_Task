using System.Collections;
using System.Collections.Generic;
using Game.StateMachine;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static GameManager;

public class PlayerController : MonoBehaviour{

    private CharacterController controller;
    private Vector3 moveDirection;
    private float inputX, inputZ;
    public StateMachine<GameStates> stateMachine;
    public Rigidbody rb;
    public LayerMask ground;
    public float speed, jumpForce;
    public bool grounded, jump, isWalking;

    // Start is called before the first frame update
    void Start(){
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update(){
        Move();
        Jump();
        IsMove();
        CkeckGrounded();
        HandleInput();
    }

    void Move(){

       inputX = Input.GetAxisRaw("Horizontal");
       inputZ = Input.GetAxisRaw("Vertical");

       moveDirection = new Vector3(inputX, 0f, inputZ).normalized;

       stateMachine = new StateMachine<GameStates>();
       stateMachine.Init();

       stateMachine.RegisterState(GameStates.GAMEPLAY, new StateBase());
       Debug.Log("GameStates " + GameStates.GAMEPLAY);

       if(moveDirection.magnitude >= 0.1f){
          controller.Move(moveDirection.normalized * Time.deltaTime * speed);
       }
    }

    void IsMove(){

        if (moveDirection.x != 0 || moveDirection.z != 0 && grounded){
            isWalking = true;
        }else{
            stateMachine.RegisterState(GameStates.PAUSE, new StateBase());
            Debug.Log("GameStates " + GameStates.PAUSE);
            isWalking = false;
        }
    }

    void Jump(){

        if(jump && grounded){

            stateMachine.RegisterState(GameStates.JUMP, new StateBase());
            Debug.Log("GameStates " + GameStates.JUMP);
            
            transform.position += Vector3.up * .1f;
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.y);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump = false;
        }
    }

    void CkeckGrounded(){
        grounded = Physics.Raycast(transform.position + Vector3.up * .1f, Vector3.down, .2f, ground);
    }

    void HandleInput(){

        if(Input.GetKey(KeyCode.Space) && grounded){
            jump = true;
        }
    }

}
