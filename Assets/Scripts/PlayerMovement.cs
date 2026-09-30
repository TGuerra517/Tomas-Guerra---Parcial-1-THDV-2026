using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 5f;

    PlayerStats stats;
    Rigidbody rb;
    bool estaEnElPiso;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        stats = GetComponent<PlayerStats>();
    }

    void Update()
    {
        if (stats.vida <= 0)
        {
            rb.linearVelocity = Vector3.zero;
            return;
        }



        float movimientoX = Input.GetAxis("Horizontal");
        float movimientoZ = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoX, 0, movimientoZ);

        rb.linearVelocity = movimiento * velocidad;


        if (Input.GetKeyDown(KeyCode.Space) && estaEnElPiso && stats.estamina >= 5)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            stats.estamina -= 5;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        estaEnElPiso = true;
    }

    void OnCollisionExit(Collision collision)
    {
        estaEnElPiso = false;
    }




}
