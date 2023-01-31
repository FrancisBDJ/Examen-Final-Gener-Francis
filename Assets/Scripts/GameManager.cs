using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        GetDamage.DamageAmount += OnPlayerDamageReceived;
    }

    private void OnDisable()
    {
        GetDamage.DamageAmount += OnPlayerDamageReceived;
    }

    private void OnPlayerDamageReceived(float damage)
    {
        Debug.Log("Player receives damage: " + damage);
    }
}
