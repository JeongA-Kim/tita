using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    public float startTime;
    public float minX, maxY, minY;

    public float moveSpeed;
    public float moveS=1;

    public int sing = -1;
    public int b;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= startTime)
        {
            //�̵� ���� ó��
            // transform.position += new Vector3(moveSpeed * Time.deltaTime * sing, 0, 0);

            maxY = 2;
            minY = -2;
            if (transform.position.y >= maxY)
            {
               b = -1; // ���� ��迡 �����ϸ� �Ʒ��� ���� ��ȯ
            }
            else if (transform.position.y <= minY)
            {
                b = 1; // �Ʒ��� ��迡 �����ϸ� ���� ���� ��ȯ
            }
            transform.position += new Vector3(moveSpeed * Time.deltaTime * sing, moveS * Time.deltaTime * b, 0);
        }
    }
}