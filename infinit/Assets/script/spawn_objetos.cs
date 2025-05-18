/*using UnityEngine;

public class spawn_objetos : MonoBehaviour
{
    public GameObject objectPrefab;     // Prefab a instanciar
    public float spawnInterval = 1f;    // Intervalo de generación
    public float minX = -11f;
    public float maxX = 13f;
    public float spawnZ = -47f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, 0f, spawnZ);
        Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
    }
}
*/
/*using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnInterval = 1f;
    public float minX = -11f;
    public float maxX = 13f;
    public float spawnZ = -47f;

    public float baseSpeed = 5f;
    public float speedIncreaseRate = 0.5f; // Cuánto aumenta por segundo

    private float timer;
    private float elapsedTime;

    void Update()
    {
        timer += Time.deltaTime;
        elapsedTime += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            float currentSpeed = baseSpeed + (elapsedTime * speedIncreaseRate);
            SpawnObject(currentSpeed);
            timer = 0f;
        }
    }

    void SpawnObject(float speed)
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, 0f, spawnZ);
        GameObject obj = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);

        // Pasar la velocidad al objeto instanciado
        ObjectMover mover = obj.GetComponent<ObjectMover>();
        if (mover != null)
        {
            mover.moveSpeed = speed;
        }
    }
}
*/
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnInterval = 1f;
    public float minX = -11f;
    public float maxX = 13f;
    public float spawnZ = 50f; // Nuevo punto de spawn

    public float baseSpeed = 5f;
    public float speedIncreaseRate = 0.5f; // Aumento por segundo

    private float timer;
    private float elapsedTime;

    void Update()
    {
        timer += Time.deltaTime;
        elapsedTime += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            float currentSpeed = baseSpeed + (elapsedTime * speedIncreaseRate);
            SpawnObject(currentSpeed);
            timer = 0f;
        }
    }

    void SpawnObject(float speed)
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, 0f, spawnZ);
        GameObject obj = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);

        ObjectMover mover = obj.GetComponent<ObjectMover>();
        if (mover != null)
        {
            mover.moveSpeed = speed;
        }
    }
}
