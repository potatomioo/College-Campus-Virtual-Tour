using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TriggerAnimationOnClick : MonoBehaviour
{
    public GameObject objectToAnimate; // The object that has the Animator component
    private Animator animator;
    public string triggerName;

    void Start()
    {
        if (objectToAnimate != null)
        {
            animator = objectToAnimate.GetComponent<Animator>();
        }
    }

    public void OnClick()
    {
        if (animator != null)
        {
            animator.SetTrigger(triggerName);
        }
    }
}
