using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamageFromFireball : MonoBehaviour
{
    //take damage from fireball 1
    int TDFF1()
    { 
        int playerHealth = 100; return playerHealth - 5; 
    }
    //take damage from fireball 2
    int TDFF2(int damage)
    {
        int playerHealth = 100; return playerHealth - damage; 
    }
    //take damage from fireball 3
    int TDFF3(int damage, int playerHealth)
    {
        return playerHealth - damage; 
    }
    // Start is called before the first frame update
    void Start()
    {
        int x = TDFF1();
        print("Player health: " + x);

        int y = TDFF2(25); 
        print("Player health: " + y);

        int z = TDFF3(30, 50);
        print("Player health: " + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
