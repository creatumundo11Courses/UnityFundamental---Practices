using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class P4Player : MonoBehaviour
{
    public Rigidbody rigidbody;

    public float Speed;

    public int Score;

    public Text ScoreText;
    
    void Update()
    {
        Vector3 movement = new Vector3();
        movement.z = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");

        rigidbody.AddForce(movement * Speed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            Score++;
            ScoreText.text = Score.ToString(); //Example: 6 => "6"
        }
    }
}
