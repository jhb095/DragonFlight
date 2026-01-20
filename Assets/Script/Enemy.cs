using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1f;

    float bottom;
    float monsterHeight;

    void Start()
    {
        Camera cam = Camera.main;

        float halfHeight = cam.orthographicSize;

        bottom = cam.transform.position.y - halfHeight;

        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        monsterHeight = sr.bounds.size.y / 2;
    }

    void Update()
    {
        float y = moveSpeed * Time.deltaTime;

        if(transform.position.y - y < bottom - monsterHeight)
        {
            Destroy(gameObject);
            return;
        }

        transform.Translate(0, -y, 0);
    }

    // 트리거 충돌
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    // 미사일 충돌
    //    if(collision.gameObject.CompareTag("Bullet"))
    //    {
    //        Destroy(collision.gameObject);
    //        Destroy(gameObject);
    //    }
    //}
}
