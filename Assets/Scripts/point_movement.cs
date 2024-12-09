using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.Difficulty.easy == true)
        {
           transform.position = new Vector3 (0.7139654f, 12.40304f, -20.36209f); 
        }
    }
}
