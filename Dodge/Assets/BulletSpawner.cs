using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // ������ ź���� ���� ������
    public float spawnRateMin = 0.5f; // �ּ� �����ֱ�
    public float spawnRateMax = 3f; //�ִ� �����ֱ�

    private Transform target; // �߻��� ���
    private float spawnRate; //�����ֱ�
    private float timeAfterSpawn; // �ֱ� ���� �������� ���� �ð�
    // Start is called before the first frame update
    void Start()
    {// �ֱ� ���� ������ �����ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        // ź�� ���� ������ spawnMin�� spawnMax ���̿��� ���� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ��� ���� ������� ����
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if (timeAfterSpawn>= spawnRate)
        {
            timeAfterSpawn = 0f;


                GameObject bullet
                = Instantiate(bulletPrefab, transform.position, transform.rotation);

            bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
