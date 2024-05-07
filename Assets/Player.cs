using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float InputX;
    public float InputY;
    public float InputZ;
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        InputZ = Input.GetAxis("");
        InputY = Input.GetAxis("Vertical");
        InputX = Input.GetAxis("Horizontal");
        animator.SetFloat("InputZ", InputY);
        animator.SetFloat("InputY", InputY);
        animator.SetFloat("InputX", InputX);
    }
}
