using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRigidbody;
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {   
        // ���� ������Ʈ���� Rigidbody  ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      //  if(Input.GetKey(KeyCode.UpArrow)== true)
      //  {
      //      PlayerRigidbody.AddForce(0f, 0f, speed);
      //  }
       // if (Input.GetKey(KeyCode.DownArrow) == true)
     //   {
      //      PlayerRigidbody.AddForce(0f, 0f, -speed);
     //   }
    //    if (Input.GetKey(KeyCode.RightArrow) == true)
     //   {
     //       PlayerRigidbody.AddForce(speed, 0f, 0f);
     //   }
    //    if (Input.GetKey(KeyCode.LeftArrow) == true)
     //   {
    //        PlayerRigidbody.AddForce(-speed,0f, 0f);
     //   }
     // ������� �������� �Է°��� �����Ͽ� ����
     float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵��ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3�ӵ��� (xSpeed, 0, zSpeed)�� ����//
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        PlayerRigidbody.velocity = newVelocity;
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
