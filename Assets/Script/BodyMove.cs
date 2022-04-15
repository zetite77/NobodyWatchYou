using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMove : MonoBehaviour
{
    public float moveSpeed; // �̵� �ӵ�
    public float sprintRatio; // shift �Է½� �ӵ� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardMove();
    }

    void KeyboardMove()
    {
        // WASD Ű �Ǵ� ȭ��ǥŰ�� �̵����� ����
        Vector3 dir = new Vector3(
                Input.GetAxis("Horizontal"),
                0,
                Input.GetAxis("Vertical")
        );

        if (Input.GetKey(KeyCode.LeftShift))
        {   // shift������ ������ ����
            dir.z *= sprintRatio;
            dir.y *= sprintRatio;
            dir.x *= sprintRatio;
        }
        transform.Translate(dir * moveSpeed * Time.deltaTime);

    }
}
