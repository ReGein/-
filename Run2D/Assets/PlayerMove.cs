using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float jumpPower = 1.0f;
    int jumpCount = 0;

    public Rigidbody2D rigid;
    float horizontal; //����, ������ ���Ⱚ�� �޴� ����

    public bool isground;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Jump(); //����   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isground = true;//ground�� �����ϸ� isground�� true��
        }
    }


    void Jump()
    {
        if (Input.GetButton("Jump")) //���� Ű�� ������ ��//ground�̸鼭 �����̽��� ������ 
        {
            if (isground == true) //���� ������ ���� ��
            {
                rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse); //�������� ���� �ش�.
                isground = false;
                jumpCount++;
            }
            else return; //���� ���� ���� �������� �ʰ� �ٷ� return.
        }
    }
}
