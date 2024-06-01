using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] private int damage = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var collisionSide = collision.GetContact(0).normal;
            var isTop = collisionSide.y < 0;

            if (isTop)
            {
                Destroy(gameObject);
                var player = collision.gameObject.GetComponent<Player>();
                player.Jump();
            }
            else
            {
                collision.gameObject.GetComponent<HelthBase>().TakeDamage(damage);
            }

        }
    }
}
