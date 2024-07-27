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
            //이동 로직 처리
            // transform.position += new Vector3(moveSpeed * Time.deltaTime * sing, 0, 0);

            maxY = 2;
            minY = -2;
            if (transform.position.y >= maxY)
            {
               b = -1; // 위쪽 경계에 도달하면 아래로 방향 전환
            }
            else if (transform.position.y <= minY)
            {
                b = 1; // 아래쪽 경계에 도달하면 위로 방향 전환
            }
            transform.position += new Vector3(moveSpeed * Time.deltaTime * sing, moveS * Time.deltaTime * b, 0);
        }
    }
}