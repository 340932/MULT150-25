using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float day = 1;
        for (int i = 0; day <= 30; i++)
        {
            if (day == 30)
            {
                Debug.Log("Today is my birthday!");
            }
            else 
            {
                Debug.Log(day);
            }
            day++;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
