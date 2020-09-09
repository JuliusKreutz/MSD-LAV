using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public void next()
    {
        Animator animator = FindObjectOfType<Animator>();

        if (animator == null) return;
        
        animator.SetTrigger("next");
    }

    public void prev()
    {
        Animator animator = FindObjectOfType<Animator>();

        if (animator == null) return;
        
        animator.SetTrigger("prev");
    }

}
