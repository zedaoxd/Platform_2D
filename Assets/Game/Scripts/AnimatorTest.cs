using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTest : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private KeyCode keyToTrigger = KeyCode.A;
    [SerializeField] private string triggerName = "Fly";

    private void OnValidate()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToTrigger))
        {
            animator.SetTrigger(triggerName);
        }
    }
}
