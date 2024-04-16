using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4InputTest : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //WASD
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Debug.Log("horizontal Value = " + horizontal);
        Debug.Log("vertical Value = " + vertical);
    }

    
}
