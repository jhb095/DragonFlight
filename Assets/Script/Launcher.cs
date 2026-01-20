using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;   // 미사일 프리팹

    void Start()
    {
        InvokeRepeating(nameof(Shoot), 0.5f, 1f);
    }

    void Update()
    {
        
    }

    void Shoot()
    {
        // 미사일 프리팹, 런처 포지션, 방향값 X
        Instantiate(bullet, transform.position, Quaternion.identity);

        // 사운드 재생
        SoundManager.Instance.SoundExplosion();
    }
}
