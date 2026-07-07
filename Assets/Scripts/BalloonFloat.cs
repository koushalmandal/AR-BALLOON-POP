using UnityEngine;

public class BalloonFloat : MonoBehaviour
{
    private float speed;

    void Start()
    {
        speed = Random.Range(2.2f, 2.5f);
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y > 6f)
        {
            Destroy(gameObject);
        }
    }
}