using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int coins = 0;
    public int health = 10;
    public int maxHealth = 10;
    public AudioSource audioSource;
    public AudioClip damageSound;
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
        
        if (health > 0)
        {
            print("Tu vida es: " + health);
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
