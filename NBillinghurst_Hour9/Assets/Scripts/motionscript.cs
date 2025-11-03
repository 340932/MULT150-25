using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motionscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        float rspeed = 0.05f;
            float lspeed = -0.05f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(rspeed,0,0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(lspeed,0,0);
        }
    }
}
