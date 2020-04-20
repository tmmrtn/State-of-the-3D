using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStatePunch : StateMachineBehaviour
{
    //GameObject robot;
    GameObject lhand;
    BoxCollider lhandBox;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // robot =     
        //GameObject.FindWithTag("P1LeftHand").SetActive(true);
        lhand = GameObject. Find("hand.L");
        lhandBox = lhand.GetComponent<BoxCollider>();
        lhandBox.enabled = false;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //    float a = animator.GetFloat("PunchTime");

        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.50f && animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 0.85f)
        {
            lhandBox.enabled = true;
        }
        else
            lhandBox.enabled = false;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //GameObject.FindGameObjectWithTag("P1LeftHand").SetActive(false);
        //        lhand.SetActive(false);
        lhandBox.enabled = false;

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
