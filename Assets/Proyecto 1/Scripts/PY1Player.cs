using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PY1Player : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed;
    public Animator animator;
    public AudioSource coinAS;

    public static int Score = 0;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3();
        movement.x = horizontal;
        rigidbody.velocity = movement * speed;

        bool IsMoving = Mathf.Abs(horizontal) > 0;
        if (IsMoving)
        {
            animator.Play("CharacterArmature_Walk_Hold");
        }
        else
        {
            animator.Play("CharacterArmature_Idle_Hold");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            Score++;
            coinAS.Play();
        }
    }
}
