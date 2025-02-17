using System.Collections;
using System.Collections.Generic;
using Game.StateMachine;
using UnityEngine;

namespace Boss{

    public class BossStateBase : StateBase{

        protected BossBase boss;

        public override void OnStateEnter(params object[] objs){

            Debug.Log("boss " + boss);
            Debug.Log("objs[] " + objs);
            Debug.Log("(BossBase)objs[0] " + objs[0]);
            base.OnStateEnter(objs);
            boss = (BossBase)objs[0];
        }
    }

    public class BossStatesInit : BossStateBase{

        public override void OnStateEnter(params object[] objs){

            base.OnStateEnter(objs);
            boss.StartInitAnimation();
            //Debug.Log("Boss: " + boss); 
        }
    }

    public class BossStatesWalk : BossStateBase{
        
        public override void OnStateEnter(params object[] objs){

            Debug.Log("BossStatesWalk objs" + objs);
            base.OnStateEnter(objs);
            boss.GoToRandomPoint(OnArrive);
        }

        private void OnArrive(){  // mudando stato boss quando ele chegar no destino
            boss.SwitchState(BossAction.ATTACK);
            Debug.Log("method OnArrive");
            
        }

        public override void OnStateExit(){
            base.OnStateExit();
            boss.StopAllCoroutines();
            Debug.Log("OnStateExit Exit Attack");
        }
    }

    public class BossStatesAttack : BossStateBase{

        public override void OnStateEnter(params object[] objs){

            base.OnStateEnter(objs);
            boss.StartAttack(EndAttacks);
        }

        private void EndAttacks(){
            boss.SwitchState(BossAction.WALK);
        }

        public override void OnStateExit(){
            Debug.Log("Exit Walk");
            base.OnStateExit();
            boss.StopAllCoroutines();
        }
    }

    public class BossStatesDeath : BossStateBase{

        public override void OnStateEnter(params object[] objs){
            Debug.Log("Enter Death");
            base.OnStateEnter(objs);
            boss.transform.localScale = Vector3.one * .2f;
        }
    }
}