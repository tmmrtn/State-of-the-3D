using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStateKickL1 : StateMachineBehaviour
{
    GameObject lhand;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        lhand = GameObject.Find("foot.L");
        lhand.tag = "NonDamaging";

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //
        //      Enable the Damaging tag only between certain frames
        //      because not all frames of the animation are supposed to be damaging (e.g., 'winding up' the punch or kick).
        //

        if (stateInfo.normalizedTime >= 0.35f && stateInfo.normalizedTime < 0.70f)
        {
            lhand.tag = "Damaging";
        }
        else
            lhand.tag = "NonDamaging";
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
