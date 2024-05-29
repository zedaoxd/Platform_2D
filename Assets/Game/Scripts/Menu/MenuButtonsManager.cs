using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MenuButtonsManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> buttons;

    [Header("Animation")]
    [SerializeField] private float duration = 0.2f;
    [SerializeField] private float delay = 0.1f;
    [SerializeField] private Ease ease = Ease.OutBack;

    private void Awake()
    {
        ShowButtons();
    }

    private void ShowButtons()
    {
        StartCoroutine(ShowButtonsWithDelay());
    }

    IEnumerator ShowButtonsWithDelay()
    {
        foreach (var button in buttons)
        {
            button.SetActive(true);
            button.transform.DOScale(1, duration).From(0).SetEase(ease);
            var nextDelay = delay * buttons.IndexOf(button);
            yield return new WaitForSeconds(nextDelay);
        }
    }
}
