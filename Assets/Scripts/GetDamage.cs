using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamage : MonoBehaviour
{
    public delegate void DamageEnemy(float damage);
    public static event DamageEnemy DamageAmount;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            if (DamageAmount != null)
            {
                DamageAmount?.Invoke(100.0f);
            }
        }
        else if (collision.gameObject.CompareTag("Meteorite"))
        {
            if (DamageAmount != null)
            {
                DamageAmount?.Invoke(30.0f);
            }
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (DamageAmount != null)
            {
                DamageAmount?.Invoke(10.0f);
            }
        }
        else if (collision.gameObject.CompareTag("BigBoss"))
        {
            if (DamageAmount != null)
            {
                DamageAmount?.Invoke(50.0f);
            }
        }
    }

    

}
