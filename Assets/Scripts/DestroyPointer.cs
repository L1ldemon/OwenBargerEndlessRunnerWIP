using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPointer : MonoBehaviour
{
    private pointsystem PointSystem;
    
    
    // Start is called before the first frame update
    void Start()
    {
         PointSystem =GetComponent ("GameManager") as pointsystem;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter2D (Collision2D collider)
    {  
      //if(gameOver.isAlive != false)
        {
            Debug.Log("Pointer has spawned");
                if(collider.gameObject.CompareTag("Player"))
                {
                    Debug.Log("You got a point");
                    //PointSystem.GenerateNextPointer();
                    Destroy(gameObject);
                }
        }
    }
}
