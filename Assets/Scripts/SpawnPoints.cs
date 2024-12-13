using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour

{
    [SerializeField] public List <GameObject> pointerspawnpoints = new List <GameObject> {};
    [SerializeField] public GameObject pointer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D (Collision2D collider)
    {  
        if(collider.gameObject.CompareTag("point"))
            {
                Debug.Log("You got a point");
                GenerateNextPointer();
                Destroy(collider.gameObject); //destroys the gameobject it is colliding with. due to the if staetment it will only run when it's with the compare tag of point
            }
    }

     public void GenerateNextPointer()
    {
        GeneratePointer();
    }

    public void GeneratePointer()
    {
        Debug.Log("Pointer has spawned");

     
     for (var i= 0; i < 1  ; i++)
     
     { 
      int randomIndex  = Random.Range(0, pointerspawnpoints.Count-1);
      Vector3 pos = new Vector3 (pointerspawnpoints[randomIndex].transform.position.x, pointerspawnpoints[randomIndex].transform.position.y, pointerspawnpoints[randomIndex].transform.position.z);
      GameObject pointerInstantiate = Instantiate(pointer, pos, Quaternion.identity);
     }
    }
}
