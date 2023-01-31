using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamage : MonoBehaviour
{
    public delegate void ActionKey(GameObject enemy,float damage);
    public static event ActionKey onCollisionKey;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            if (onCollisionKey != null)
            {
                onCollisionKey.Invoke(null, 0);
            }
        }
        else if (collision.gameObject.CompareTag("Meteorite"))
        {
            // _gameManager.TakeDamage(30f);
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            // _gameManager.TakeDamage(10f);
        }
        else if (collision.gameObject.CompareTag("BigBoss"))
        {
            // _gameManager.TakeDamage(50f);
        }
    }

    

}
