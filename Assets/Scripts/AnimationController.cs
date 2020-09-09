using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    private int counter;

    [SerializeField] private Text text;

    private int max = 11;

    public void next()
    {
        Animator animator = FindObjectOfType<Animator>();

        if (animator == null) return;

        if (animator.GetBool("next")) return;
        
        counter = counter == max ? 0 : counter + 1;

        animator.SetTrigger("next");

        text.text = "" + counter;
    }

    public void prev()
    {
        Animator animator = FindObjectOfType<Animator>();

        if (animator == null) return;
        
        if (animator.GetBool("prev")) return;

        counter = counter == 0 ? max : counter - 1;

        animator.SetTrigger("prev");

        text.text = "" + counter;
    }
}