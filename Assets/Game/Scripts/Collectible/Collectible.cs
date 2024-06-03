using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private string tagName = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(tagName))
        {
            Collect();
        }
    }

    protected virtual void Collect()
    {

    }
}
