using DG.Tweening;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [Header("Speeds")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private float speedRun = 10f;

    [Header("Jump")]
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private int maxJump = 2;

    private float CurrentSpeed => Input.GetKey(KeyCode.LeftShift) ? speedRun : speed;
    private int countJump = 0;

    private void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");

        HandleMovement(horizontalInput);
        HandleJump();
        Flip(horizontalInput);
    }

    private void Flip(float horizontalInput)
    {
        if (horizontalInput > 0)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void HandleMovement(float horizontalInput)
    {
        rb.velocity = new Vector2(horizontalInput * CurrentSpeed, rb.velocity.y);
    }

    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && countJump < maxJump)
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
        countJump++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            countJump = 0;
        }
    }
}
