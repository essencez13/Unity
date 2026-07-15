using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public AudioSource audioSource;
    public AudioClip damageSound;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
            print("Здоровье игрока: " + health);
        }
    }
    public void CollectCoins()
    {
        coins++;
        print("Собранные монетки: " + coins);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);    
        }

    }
}
