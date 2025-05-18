/*using UnityEngine;

public class ObstacleDamage : MonoBehaviour
{
    public float damageAmount = 20f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VehicleHealth vehicle = other.GetComponent<VehicleHealth>();
            if (vehicle != null)
            {
                vehicle.TakeDamage(damageAmount);
                vehicle.ApplySlow();
            }

            // Destruir obstáculo si querés que desaparezca al chocar:
            // Destroy(gameObject);
        }
    }
}
*/