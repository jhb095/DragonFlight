using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject monster;
    public bool isSpawn = true;
    public float startTime = 2f;
    public float spawnInterval = 2f;

    float left;
    float right;
    float monsterWidth;

    void Start()
    {
        Camera cam = Camera.main;

        float halfHeight = cam.orthographicSize;
        float halfWidth = halfHeight * cam.aspect;

        SpriteRenderer sr = monster.GetComponent<SpriteRenderer>();
        monsterWidth = sr.bounds.size.x / 2;

        left = cam.transform.position.x - halfWidth + monsterWidth;
        right = cam.transform.position.x + halfWidth - monsterWidth;

        InvokeRepeating(nameof(Spawn), startTime, spawnInterval);
    }

    void Update()
    {

    }

    void Spawn()
    {
        if (isSpawn)
        {
            float x;

            x = Random.Range(left, right);

            Instantiate(monster, new Vector3(x, monster.transform.position.y, 0), Quaternion.identity);
        }
    }
}
