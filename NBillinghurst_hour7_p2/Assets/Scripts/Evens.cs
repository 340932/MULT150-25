using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float count = 22;
        for (int i=0 ; count <= 100; i++)
        {
            Debug.Log(count);
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
