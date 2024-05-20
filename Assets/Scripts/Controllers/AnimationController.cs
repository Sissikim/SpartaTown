using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected SpartaTownController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<SpartaTownController>();
    }


}
