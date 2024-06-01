using UnityEngine;

public class HelthBase : MonoBehaviour
{
    [SerializeField] private int startLife = 10;

    public int CurrentLife { get; private set; }
    public bool IsAlive => CurrentLife > 0;

    private void Awake()
    {
        CurrentLife = startLife;
    }

    public void TakeDamage(int damage)
    {
        CurrentLife -= damage;
        Debug.Log($"Current life: {CurrentLife}");
        if (!IsAlive)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
