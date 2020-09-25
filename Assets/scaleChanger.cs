using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            transform.localScale = new Vector3(Random.Range(0,4f),Random.Range(0,4f), Random.Range(0,4f));
        }
    }
}
