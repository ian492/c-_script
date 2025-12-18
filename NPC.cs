using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    public int health = 5;

    //Уровень NPC
    public int level = 1;

    //Скорость NPC
    public float speed = 1.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Жизней: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        //"создаём переменную вида Vector3 и сохраняем в неё позицию NPC
        Vector3 newPosition = transform.position;

        //"меняем позицию NPC по оси Z согласно скорости NPC и времени между кадрами
        newPosition.z += speed * Time.deltaTime;

        //"меняем позицию NPC на новое значение рассчитанное выше
        transform.position = newPosition;
    }
}
