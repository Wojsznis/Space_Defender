using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
   
    public Health myHealth;
    [SerializeField] int heal = 0;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            if(myHealth.health >= myHealth.startHealth - 50)
            {
                myHealth.health = myHealth.startHealth;
            }
            else
            {
                myHealth.health += heal;
            }
            Destroy(gameObject);
        }
    }
        
    
    
}
