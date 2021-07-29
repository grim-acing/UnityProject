using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    public float speed = 10f;
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal"); //on the keyboard is A (-1) and D (1)
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 horizontalMove = Vector3.right * horizontalInput * Time.deltaTime * speed;
        transform.Translate(horizontalMove);

        Vector3 verticalMove = Vector3.forward * verticalInput * Time.deltaTime * speed;
        transform.Translate(verticalMove);

    }
}
