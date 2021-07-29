using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public Transform respawnPoint;

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            other.transform.position = respawnPoint.position;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
