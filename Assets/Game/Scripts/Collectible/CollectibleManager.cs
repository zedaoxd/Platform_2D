using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    [SerializeField] private int countCollectible = 0;

    public static CollectibleManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Reset();
    }

    public void AddCollectible(int amount = 1)
    {
        countCollectible += amount;
    }

    private void Reset()
    {
        countCollectible = 0;
    }
}
