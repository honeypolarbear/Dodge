using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // 생성할 탄알의 원본 프리팹
    public float spawnRateMin = 0.5f; // 최소 생성주기
    public float spawnRateMax = 3f; //최대 생성주기

    private Transform target; // 발사할 대상
    private float spawnRate; //생성주기
    private float timeAfterSpawn; // 최근 생성 시점에서 지난 시간
    // Start is called before the first frame update
    void Start()
    {// 최근 생성 이후의 누적시간을 0으로 초기화
        timeAfterSpawn = 0f;
        // 탄알 생성 간격을 spawnMin과 spawnMax 사이에서 랜덤 지정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //PlayerController 컴포넌트를 가진 게임 오브젝트를 골라 조준 대상으로 설정
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
