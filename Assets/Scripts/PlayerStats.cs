using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float vida = 100;
    public float estamina = 10;

    void Update()
    {
        estamina += 2 * Time.deltaTime;
        estamina = Mathf.Clamp(estamina, 0, 10);

        if (vida <= 0)
        {
            vida = 0;
        }
    }


    public void RecibirDaño(float daño)
    {
        vida -= daño;

        Debug.Log("PLAYER RECIBIO DAÑO - Vida: " + vida);

        if (vida <= 0)
        {
            vida = 0;
            Debug.Log("PLAYER MUERTO");
        }
    }
}
