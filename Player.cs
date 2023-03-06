using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int coins = 0;
    int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void CollectCoins()
    {
        coins++;
        print("Tus monedas son: " + coins);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Tu vida es: " + health);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }

    }
}
