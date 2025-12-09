using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Play Anim A");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Play Anim B");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Play Anim C");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Play Anim D");
        }




    }
}
