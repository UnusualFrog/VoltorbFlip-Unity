using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBack : MonoBehaviour
{
    public Animator animator;
    public SceneController controller;
    // Start is called before the first frame update
    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Flip()
    {
        controller.activeGame = false;
        animator.SetBool("isFlipped", true);
    }
}
