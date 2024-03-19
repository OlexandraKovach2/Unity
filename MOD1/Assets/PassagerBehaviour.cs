using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassagerBehaviour : MonoBehaviour
{
    public GameObject targ;
    private bool isButtonPressed = false;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (!isButtonPressed)
        {
            transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, 1);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isButtonPressed = true;   
            rb.useGravity = true;
        }
    }
}
