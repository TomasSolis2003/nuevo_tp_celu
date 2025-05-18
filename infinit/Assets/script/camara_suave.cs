using UnityEngine;

public class camara_suave : MonoBehaviour
{
    public Transform target;         // Veh�culo a seguir
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Offset de la c�mara respecto al veh�culo
    public float smoothSpeed = 0.125f;  // Qu� tan suave es el movimiento (m�s bajo = m�s suave)

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
        transform.LookAt(target);
    }
}
