using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
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
        Debug.Log("[UIManager] Player receives damage: " + damage);
    }
}
