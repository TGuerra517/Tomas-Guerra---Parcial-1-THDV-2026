using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public float rango = 5f;
    public float daño = 20f;
    public float cadencia = 2f;

    public Transform jugador;

    float tiempoUltimoDisparo;

    EnemyStats stats;

    void Start()
    {
        stats = GetComponent<EnemyStats>();
    }

    void Update()
    {
        if (stats.vida <= 0)
        {
            return;
        }

        float distancia = Vector3.Distance(transform.position, jugador.position);

        if (distancia <= rango && Time.time >= tiempoUltimoDisparo + cadencia)
        {
            Disparar();
        }
    }

    void Disparar()
    {
        tiempoUltimoDisparo = Time.time;

        Vector3 direccion = jugador.position - transform.position;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, direccion.normalized, out hit, rango))
        {
            Debug.Log("ENEMIGO DISPARA - Raycast golpeo: " + hit.collider.name);

            PlayerStats player = hit.collider.GetComponent<PlayerStats>();

            if (player != null)
            {
                player.RecibirDaño(daño);

                Debug.Log("PLAYER GOLPEADO - Daño: " + daño);
            }
        }
    }
}