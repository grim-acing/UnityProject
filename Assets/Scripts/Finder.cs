using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finder : MonoBehaviour
{

    public GameObject foundObject;
    public int playerCurrentHealth;
    public int playerMaxHealth;


    // Start is called before the first frame update
    void Start()
    {
        foundObject = GameObject.Find("Player"); //or whatever you decide to call it
        if (foundObject == null){
            Debug.Log("could'nt find the Player GameObject");
        }
        //try catch is expensive. used as last resort
        
    }

    // Update is called once per frame
    void Update()
    {
        playerCurrentHealth = foundObject.GetComponent<Health>().currentHealth; //variable from script "Health"
        playerMaxHealth = foundObject.GetComponent<Health>().maxHealth;
        if(playerCurrentHealth == playerMaxHealth){
            // Debug.Log(playerCurrentHealth + " is the same as " + playerMaxHealth);
            Debug.Log($"{playerCurrentHealth} is the same as {playerMaxHealth}"); //$ before " to add variables to string in {}
        }
    }
}
