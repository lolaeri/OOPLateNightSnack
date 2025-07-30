using UnityEngine;

public class GhostWander : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public float changeDirectionTime = 2f;
    public float floatAmplitude = 0.3f;
    public float floatFrequency = 2f;

    private Vector2 moveDirection;
    private float directionTimer;
    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
        PickNewDirection();
    }

    void Update()
    {
        directionTimer -= Time.deltaTime;
        if (directionTimer <= 0)
        {
            PickNewDirection();
        }

        Vector2 movement = moveDirection * moveSpeed * Time.deltaTime;
        float floatY = Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        transform.Translate(new Vector3(movement.x, floatY * Time.deltaTime, 0));
    }

    void PickNewDirection()
    {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        moveDirection = new Vector2(x, y).normalized;
        directionTimer = Random.Range(1f, changeDirectionTime);
    }
}
