using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float vida = 100f;

    public void RecibirDaño(float daño)
    {
        vida -= daño;

        Debug.Log("ENEMIGO RECIBIO DAÑO - Vida: " + vida);

        if (vida <= 0)
        {
            vida = 0;
            Debug.Log("ENEMIGO MUERTO");
        }
    }
}