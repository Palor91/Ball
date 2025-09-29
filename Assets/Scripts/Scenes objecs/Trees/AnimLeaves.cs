using UnityEngine;

public class AnimLeaves : StateMachineBehaviour
{
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        animator.SetInteger("Anim_ID", Random.Range(0, 9));
    }
}
