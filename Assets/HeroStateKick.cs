using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStateKick : StateMachineBehaviour
{
    GameObject rFoot;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rFoot = GameObject.Find("foot.R");
        rFoot.tag = "NonDamaging";

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //
        //      Enable the hitbox on the punching hand only between certain frames
        //      because not all frames of the animation are supposed to be damaging (e.g., 'winding up' the punch).
        //

        if (stateInfo.normalizedTime >= 0.25f && stateInfo.normalizedTime < 0.55f)
        {
            rFoot.tag = "Damaging";
        }
        else
            rFoot.tag = "NonDamaging";
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rFoot.tag = "NonDamaging";

    }

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
