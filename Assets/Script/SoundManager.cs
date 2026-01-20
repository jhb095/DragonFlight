using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    public AudioClip soundBullet;
    public AudioClip soundDie;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SoundDie()
    {
        audioSource.PlayOneShot(soundDie); // 몬스터 죽는 소리
    }

    public void SoundExplosion()
    {
        audioSource.PlayOneShot(soundBullet); // 총알 소리
    }
}
