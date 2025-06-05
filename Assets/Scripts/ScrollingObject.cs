using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

// 게임 오브젝트를 계속 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; // 이동 속도

    private void Update()
    {
        if (!GameManager.instance.isGameover)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
}