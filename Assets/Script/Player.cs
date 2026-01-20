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

    // 둘다 트리거가 아닐때
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        Destroy(collision.gameObject);
    //        Destroy(gameObject);
    //    }
    //}

    // 트리거
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
