using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float scrollSpeed = 0.2f;
    private Material material;
    
    void Start()
    {
        // 머터리얼 가져오기
        material = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        float offset = Time.time * scrollSpeed;

        material.mainTextureOffset = new Vector2(0, offset);
    }
}
