using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanSwitchOn : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.Play("Take 001");

    }

    // Update is called once per frame
    void Update()
    {
      //animator.SetBool("start", true);  
    }
}
