using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float walkCooldown;
    private float cooldownForWalking;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        cooldownForWalking = 0;
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {


        float input_x = Input.GetAxisRaw("Horizontal");
        float input_y = Input.GetAxisRaw("Vertical");

        bool isWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;

        anim.SetBool("isWalking", isWalking);
        if (cooldownForWalking != 0)
        {
            cooldownForWalking--;
        }
        if (isWalking)
        {
            anim.SetFloat("x", input_x);
            anim.SetFloat("y", input_y);
            if (cooldownForWalking == 0)
            {
                cooldownForWalking = walkCooldown;
                transform.position += new Vector3(input_x, input_y, 0).normalized;
            }
            

        }
    }
}

