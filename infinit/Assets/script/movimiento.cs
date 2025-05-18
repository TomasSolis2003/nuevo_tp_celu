/*using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float moveSpeed = 5f;             // Velocidad de movimiento lateral
    public float maxX = 5f;                  // Límite derecho
    public float minX = -5f;                 // Límite izquierdo
   // public float rotationYLimit = 26f;       // Límite de rotación en Y

    private Rigidbody rb;

    void Start()
    {
        // Activamos el giroscopio si está disponible
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!SystemInfo.supportsGyroscope)
            return;

        float tilt = Input.gyro.rotationRateUnbiased.y;

        // Movimiento en el eje X
        float moveX = tilt * moveSpeed * Time.deltaTime;

        Vector3 newPosition = transform.position + new Vector3(moveX, 0f, 0f);

        // Restringir movimiento en X
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        transform.position = newPosition;

        // Rotación en Y basada en inclinación
        float rotationY = Mathf.Clamp(tilt * -rotationYLimit, -rotationYLimit, rotationYLimit);
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
       
    }
}
*/
using UnityEngine;

public class TiltVehicleController : MonoBehaviour
{
    public float moveSpeed = 10f;             // Velocidad de movimiento lateral
    public float maxX = 5f;                   // Límite derecho
    public float minX = -5f;                  // Límite izquierdo
    public float tiltSensitivity = 2f;        // Sensibilidad del tilt (ajustalo según necesidad)
    public float rotationYLimit = 26f;        // Rotación máxima en Y para efecto visual

    void Update()
    {
        float tilt = Input.acceleration.x * tiltSensitivity;

        // Movimiento lateral
        Vector3 move = new Vector3(tilt * moveSpeed * Time.deltaTime, 0f, 0f);
        transform.position += move;

        // Limitar posición
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

        // Rotación en Y para efecto visual
        float rotationY = Mathf.Clamp(tilt * rotationYLimit, -rotationYLimit, rotationYLimit);
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
    }
}
