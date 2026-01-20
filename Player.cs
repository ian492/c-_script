using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Здоровье игрока
    private int health = 10;

    //  Число собранных монеток
    private int coins = 0;

    // метод увеличивающий число монеток
    public void CollectCoins()
    {
        coins++;
        print("Собранные монетки: " + coins);
    }

    //Метод понижающий здоровье игрока
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока:"+ health);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
