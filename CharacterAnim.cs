using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    int isWalkingHash, isRunningHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }
        else animator.SetBool(isWalkingHash, false);

        if (forwardPressed && runPressed)
        {
            animator.SetBool(isRunningHash, true);
        }
        else animator.SetBool(isRunningHash, false);
    }
}
