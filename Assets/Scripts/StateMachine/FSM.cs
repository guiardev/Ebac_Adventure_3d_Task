using System.Collections;
using System.Collections.Generic;
using Game.StateMachine;
using UnityEngine;

public class FSM : MonoBehaviour{

    public enum StateMachineEnum{
        STATE_ONE, STATE_TWO, STATE_THREE
    }

    public StateMachine<StateMachineEnum> stateMachine;

    private void Start(){
        stateMachine = new StateMachine<StateMachineEnum>();
        stateMachine.Init();
        stateMachine.RegisterState(StateMachineEnum.STATE_ONE, new StateBase());
        stateMachine.RegisterState(StateMachineEnum.STATE_TWO, new StateBase());
    }
}
