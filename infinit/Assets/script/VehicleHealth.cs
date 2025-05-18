using UnityEngine;
using System.Collections;

public class VehicleHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    public float slowMotionDuration = 0.75f;
    public float slowMotionScale = 0.2f;

    private bool isSlowingTime = false;

    void Start()
    {
        currentHealth = maxHealth;
        Time.timeScale = 1f; // Asegurarse de que el tiempo esté normal al iniciar
        Time.fixedDeltaTime = 0.02f;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            TakeDamage(20f); // Podés cambiar el daño
            if (!isSlowingTime)
                StartCoroutine(SlowTime());
        }
    }

    void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        Debug.Log("Salud del vehículo: " + currentHealth);

        // Aquí podrías llamar a una función de "Game Over" si la salud llega a 0
    }

    IEnumerator SlowTime()
    {
        isSlowingTime = true;

        Time.timeScale = slowMotionScale;
        Time.fixedDeltaTime = 0.02f * slowMotionScale;

        yield return new WaitForSecondsRealtime(slowMotionDuration);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;

        isSlowingTime = false;
    }
}

