using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //declare health and poisonDamage float variables
        float health=1004f;
        float poisonDamage=125.5f;
        //print health should be 1004
        Debug.Log(health);
        //subtract poisonDamage from health
        health = health - poisonDamage;
        Debug.Log(health);
        //repition until 0
        health = health - poisonDamage;
        Debug.Log(health);
        health = health - poisonDamage;
        Debug.Log(health);
        health = health - poisonDamage;
        Debug.Log(health);
        health = health - poisonDamage;
        Debug.Log(health);
        health = health - poisonDamage;
        Debug.Log(health);
        health = health - poisonDamage;
        Debug.Log(health);
        health = health - poisonDamage;
        Debug.Log(health);
        //player's health is 0 now 
        Debug.Log("Player has been unalived!");
        //print Player has been unalived

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
