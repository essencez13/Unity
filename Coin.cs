using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider Other)
    {
        Player player = Other.GetComponent<Player>();
        player.CollectCoins();
        Destroy(gameObject);
    }
    
}
