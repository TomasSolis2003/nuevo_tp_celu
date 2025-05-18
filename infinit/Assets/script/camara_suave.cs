using UnityEngine;

public class camara_suave : MonoBehaviour
{
    public Transform target;         // Vehículo a seguir
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Offset de la cámara respecto al vehículo
    public float smoothSpeed = 0.125f;  // Qué tan suave es el movimiento (más bajo = más suave)

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
        transform.LookAt(target);
    }
}
