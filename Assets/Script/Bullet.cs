using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1f;
    public GameObject effect;

    void Start()
    {
        
    }

    void Update()
    {
        // y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    // 화면 밖으로 나가면 호출되는 함수
    private void OnBecameInvisible()
    {
        // 미사일 지우기
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            // 이펙트 생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);

            // 사운드 재생
            SoundManager.Instance.SoundDie();

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
