using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        // 좌우로만 이동
        float dir = Time.deltaTime * moveSpeed * Input.GetAxis("Horizontal");

        transform.Translate(dir, 0, 0);
    }
}
