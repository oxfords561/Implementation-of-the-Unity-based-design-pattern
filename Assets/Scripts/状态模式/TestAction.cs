using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAction : MonoBehaviour
{

    private Animator animator;

    private People _people;

    void Start()
    {
        animator = GetComponent<Animator>();
        _people = new People();
        _people.SetAnimatorController(animator);
    }

    // Update is called once per frame
    void Update()
    {
        _people.Update();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");              
        float v = Input.GetAxis("Vertical");
        animator.SetFloat("direction", h);
    }
}
