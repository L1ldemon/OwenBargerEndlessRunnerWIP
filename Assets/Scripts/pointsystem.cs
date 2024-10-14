using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsystem : MonoBehaviour
{
    [SerializeField] GameObject pointer;
    [SerializeField] List <GameObject> pointerspawnpoints = new List <GameObject> {};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     //makes next pointer   
     public void GenerateNextPointer()
    {
        GeneratePointer();
    }
    
    public void GeneratePointer()
    {
     //foreach (var pointerspawnpoints in pointerspawnpoints)
     
     for (var i= 0; i < 1  ; i++)
     
     { 
      int randomIndex  = Random.Range(0, pointerspawnpoints.Count-1);
      Vector3 pos = new Vector3 (pointerspawnpoints[randomIndex].transform.position.x, pointerspawnpoints[randomIndex].transform.position.y, pointerspawnpoints[randomIndex].transform.position.z);
      GameObject pointerInstantiate = Instantiate(pointer, pos, Quaternion.identity);
     }
    }
    
    private void OnCollisionEnter2D (Collision2D collider)
    {  
        Debug.Log("Pointer has spawned");
        if(collider.gameObject.CompareTag("Player"))
            {
                Debug.Log("You got a point");
                GenerateNextPointer();
                Destroy(pointer);
            }
    }
}