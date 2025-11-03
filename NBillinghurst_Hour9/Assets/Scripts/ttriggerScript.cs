using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ttriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " is touching " + gameObject.name);
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still still touching "+ gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " is no longer touching " + gameObject.name);
    }
}
