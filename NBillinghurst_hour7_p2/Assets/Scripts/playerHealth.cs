using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //declare health and poisonDamage float variables
        float health = 1004f;
        float poisonDamage = 125.5f;
        
        Debug.Log(health);
        

        for (int i = 0; health > 0; i++)
        {
            health = health - poisonDamage;
            Debug.Log(health);
        }
        if (health <= 0)
        {
            Debug.Log("Player has been unalived");
            //print Player has been unalived
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
