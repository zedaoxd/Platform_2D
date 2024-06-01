using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cinemachine;

public class GameManager : Singleton<GameManager>
{
    [Header("Player")]
    [SerializeField] private GameObject playerPrefab;

    [Header("Enemies")]
    [SerializeField] private List<GameObject> enemies;

    [Header("References")]
    [SerializeField] private Transform playerSpawnPoint;

    [Header("Animations")]
    [SerializeField] private float duration = 0.2f;
    [SerializeField] private Ease easeType = Ease.InOutSine;

    [Header("Camera")]
    [SerializeField] private CinemachineVirtualCamera cameraFollow;


    private GameObject player;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        player = Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);
        player.transform.DOScale(0, duration).From().SetDelay(duration).SetEase(easeType);
        cameraFollow.Follow = player.transform;
        cameraFollow.LookAt = player.transform;
    }
}
