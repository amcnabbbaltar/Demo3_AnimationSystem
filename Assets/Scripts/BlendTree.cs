using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTree : MonoBehaviour
{
    Animator animator;

    [Range(0.0f, 1.0f)]
    public float speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", speed);
    }
}
