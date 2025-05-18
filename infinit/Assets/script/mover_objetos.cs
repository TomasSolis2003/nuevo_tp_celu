using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float despawnZ = -60f;

    void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if (transform.position.z <= despawnZ)
        {
            Destroy(gameObject);
        }
    }
}


