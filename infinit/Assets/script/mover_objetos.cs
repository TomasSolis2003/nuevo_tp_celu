/*using UnityEngine;

public class mover_objetos : MonoBehaviour
{
    public float moveSpeed = 10f;        // Velocidad de movimiento
    public float destroyZ = 60f;         // Posición en Z donde se destruye el objeto

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.position.z >= destroyZ)
        {
            Destroy(gameObject);
        }
    }
}
*/
/*using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float destroyZ = -60f;

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.position.z >= destroyZ)
        {
            Destroy(gameObject);
        }
    }
}
*/
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
