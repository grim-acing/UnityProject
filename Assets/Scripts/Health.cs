using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// everything is private by default
public class Health : MonoBehaviour
{
    //global variables
    public int currentHealth;
    public int maxHealth;

    public int GetMaxHealth(){
        return maxHealth;
    }

    public int GetCurrentHealth(){
        return currentHealth;
    }

    public void AddHealth(int amount){
        // currentHealth = amount + currentHealth;
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); //value, min, max
                                                                  //so it doesnt go over max health
    }
    public void RemoveHealth(int amount){
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void FullHealth(){
        currentHealth = maxHealth;
    }


    //................................MonoBehaviors..................................
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
