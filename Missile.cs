using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //Скорость полёта огненного шара
    public float speed;

    //Когда шар касается противника он уничтожается
    void OnTriggerEnter(Collider other)
    {
        //враг уничтожается
        //Пробуем получить компонент Enemy у объекта, которого коснулся шар
        Enemy enemy = other.GetComponent<Enemy>();
        //Если получили компонент Enemy то объект которого коснулся шар враг

        //Уничтожаем объект - враг
        Destroy(enemy.gameObject);

        //Уничтожаем снаряд - огненный шар
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Клон огненного шара уничтожается через 3 секунды
        Destroy(gameObject, 3);

        //каждый кадр позиция шара обновляется на произведение вектора движения вперёд (0,0,1)
        //скорость движения шара и значения разницы в секундах между последним и текущим кадрами
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
