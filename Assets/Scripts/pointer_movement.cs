using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer_movement : MonoBehaviour
{
    

    [SerializeField] Difficulty Difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        if(Difficulty.easy == true)
        {
           transform.position = new Vector3 (5.31f, 0.31f, 0f); 
        }
            
        if(Difficulty.medium == true)
        {
           transform.position = new Vector3 (5.31f, 143f, 0); 
        }
    
        if(Difficulty.hard == true)
        {
           transform.position = new Vector3 (-190.7f, 143f, 0); 
        }

        if(Difficulty.insane == true)
        {
           transform.position = new Vector3 (-190.7f, 0.31f, 0); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
