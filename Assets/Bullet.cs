using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
//this script is from https://www.youtube.com/watch?v=EwiUomzehKU
//I also implemented script from https://www.youtube.com/watch?v=swOfmyJvb98&list=PLtLToKUhgzwm1rZnTeWSRAyx9tl8VbGUE&index=1
{
   public float life = 3;

   void Awake()
   {
        Destroy(gameObject, life);
   }
    private void OnCollisionEnter(Collision collision)
  { 
    if (collision.gameObject.CompareTag("Target"))
   {
        //print("hit" + collision.gameObject.name + "!");

        //Debug.Log(collision.gameObject.name);
        Destroy(collision.gameObject);
        Destroy(gameObject);
   }

  }
}


