using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int balasQueSuma = 5;

    void OnTriggerEnter(Collider other)
    {
        PlayerGun arma = other.GetComponent<PlayerGun>();

        if (arma != null)
        {
            arma.balas += balasQueSuma;

            Debug.Log("MUNICION RECOGIDA - Balas: " + arma.balas);

            Destroy(gameObject);
        }
    }
}