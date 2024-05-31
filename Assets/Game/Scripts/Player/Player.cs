using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // rb.MovePosition(rb.position + speed * Time.deltaTime * Vector2.left);
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // rb.MovePosition(rb.position + speed * Time.deltaTime * Vector2.right);
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
    }
}
