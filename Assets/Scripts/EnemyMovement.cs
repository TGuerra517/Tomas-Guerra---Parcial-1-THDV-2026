using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float velocidad = 3f;
    public float alcancePersecucion = 5f;
    public Transform jugador;

    Rigidbody rb;
    EnemyStats stats;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        stats = GetComponent<EnemyStats>();
    }

    void Update()
    {
        if (stats.vida <= 0)
        {
            rb.linearVelocity = Vector3.zero;
            return;
        }

        float distancia = Vector3.Distance(transform.position, jugador.position);

        if (distancia <= alcancePersecucion)
        {
            Vector3 direccion = jugador.position - transform.position;

            direccion.y = 0;

            rb.linearVelocity = direccion.normalized * velocidad;
        }
        else
        {
            rb.linearVelocity = Vector3.zero;
        }
    }
}