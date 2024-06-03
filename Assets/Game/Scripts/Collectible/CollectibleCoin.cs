using DG.Tweening;
using UnityEngine;

public class CollectibleCoin : Collectible
{
    protected override void Collect()
    {
        base.Collect();

        transform.DOScale(Vector3.zero, 0.5f).OnComplete(() => Destroy(gameObject));

        CollectibleManager.Instance.AddCollectible();
    }
}
