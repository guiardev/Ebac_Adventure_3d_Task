using System.Collections;
using System.Collections.Generic;
using Core.Singleton;
using UnityEngine;
using Game.StateMachine;

public class GameManager : Singleton<GameManager>{

    public enum GameStates{
        INTRO, GAMEPLAY, PAUSE, JUMP, WIN, LOSE
    }

    public StateMachine<GameStates> stateMachine;

    private void Start(){
        Init();
    }

    public void Init(){ // inicial statos do game

        stateMachine = new StateMachine<GameStates>();

        stateMachine.Init();

        stateMachine.RegisterState(GameStates.INTRO, new GMStateIntro());
        stateMachine.RegisterState(GameStates.GAMEPLAY, new StateBase());
        stateMachine.RegisterState(GameStates.PAUSE, new StateBase());
        stateMachine.RegisterState(GameStates.WIN, new StateBase());
        stateMachine.RegisterState(GameStates.LOSE, new StateBase());

        stateMachine.SwitchState(GameStates.INTRO);
    }

    public void InitGame(){

    }
}
