using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badbird : MonoBehaviour
{      public GameObject deathEffect;
       public float health = 4f;
       public static int EnemiesAlive=0;
 
       void start()
       { EnemiesAlive++;
       }
 
       void OnCollisionEnter2D(Collision2D colInfo)
       { if(colInfo.relativeVelocity.magnitude > health) 
         { Die();
         }
       }
       void Die()
       { Instantiate(deathEffect, transform.position, Quaternion.identity);
         EnemiesAlive--;
         if(EnemiesAlive<=0)
           Debug.Log("LEVEL WON !!!");
         Destroy(gameObject);
       }
}
