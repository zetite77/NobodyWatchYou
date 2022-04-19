using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float current_Hp;
    private const float MAX_HP = 100.0f;
    private float current_Stam;
    private const float MAX_STAM = 100.0f;
    private float Critical;
    private float hungry;
    private float Thirsty;
    private float stealth;
    private float weight;
    private float zombie_eyesight;
    private float zombie_hear;

    public float moveSpeed; // 이동 속도
    public float sprintRatio; // shift 입력시 속도 증폭 비율

    public static void Instance()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        current_Hp = MAX_HP;
        current_Stam = MAX_STAM;
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardMove();
    }

    void KeyboardMove()
    {
        // WASD 키 또는 화살표키의 이동량을 측정
        Vector3 dir = new Vector3(
                Input.GetAxis("Horizontal"),
                0,
                Input.GetAxis("Vertical")
        );

        if (Input.GetKey(KeyCode.LeftShift))
        {   // shift누를시 더빨리 전진
            dir.z *= sprintRatio;
            dir.y *= sprintRatio;
            dir.x *= sprintRatio;
        }
        transform.Translate(dir * moveSpeed * Time.deltaTime);

    }



}
