using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPointer : MonoBehaviour
{
    private pointsystem pointsystem;
    
    
    // Start is called before the first frame update
    void Start()
    {
         pointsystem = GetComponent ("GameManager") as pointsystem;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter2D (Collision2D collider)
    {  
        {
            if(collider.gameObject.CompareTag("Player"))
            {
                Debug.Log("You got a point");
                Destroy(gameObject);
            }
        }
    }
}
