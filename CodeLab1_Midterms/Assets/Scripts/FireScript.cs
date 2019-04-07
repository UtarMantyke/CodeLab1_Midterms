using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //if the collider that hit us has a tag "Player"
        {
            Destroy(gameObject); //Destroy the gameObject I am attached to
            ScoreManager.instance.Score--;
        }
		
    }
}
