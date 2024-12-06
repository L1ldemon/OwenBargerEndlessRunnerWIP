using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    [SerializeField] GameObject Player;

    [SerializeField] List <GameObject> player_spawns = new List <GameObject> {};
    
    [SerializeField] bool easy;
    
    [SerializeField] bool medium;
    
    [SerializeField] bool hard;
    
    [SerializeField] bool insane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(easy == true)
        {
            medium = false;
            hard = false;
            insane = false;
            Vector3 position = new Vector3 (Player 0.96.transform.position.x, Player -1.66.transform.position.y, Player 0.transform.position.z);
            Debug.Log("Easy Mode selected");
        }
    if(medium == true)
        {
            easy = false;
            hard = false;
            insane = false;
            Vector3 position = new Vector3 (Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
            Debug.Log("Medium Mode selected");
        }
    if(hard == true)
        {
            medium = false;
            easy = false;
            insane = false;
            Debug.Log("Hard Mode selected");
        }
    if(insane == true)
        {
            medium = false;
            hard = false;
            easy = false;
            Debug.Log("Insane Mode selected");
        }
    }
}
