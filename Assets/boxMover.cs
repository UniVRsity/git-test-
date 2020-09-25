using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMover : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        
        transform.position += Vector3.right*movement;  
    }
}
