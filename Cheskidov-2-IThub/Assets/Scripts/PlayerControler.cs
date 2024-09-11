using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float moventSpeed;
    [SerializeField] private float jumpForece;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            Move(horizontalInput * moventSpeed);

        }
    }
    private void Move(float moveSpeed)
    {
        rb.AddForce(new Vector2(moveSpeed, 0));
    }
}
