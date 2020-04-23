using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStateIdle : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetBool("WalkRoot", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("WalkRoot", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("WalkRoot", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("WalkRoot", true);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("Punch");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetTrigger("Kick");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("Blocking", true);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetTrigger("Test1");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetTrigger("Test2");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.SetTrigger("Test3");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            animator.SetTrigger("Test4");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            animator.SetTrigger("Test5");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            animator.SetTrigger("Test6");
        }

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
