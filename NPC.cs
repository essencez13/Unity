using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    int health = 5;

    //Уровень NPC
    int level = 1;

    //Скорость NPC
    float speed = 1.2f;


    void Start()
    {
        health += level;

        print("Здоровье NPC после обновления: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;

        newPosition = transform.position;

        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
