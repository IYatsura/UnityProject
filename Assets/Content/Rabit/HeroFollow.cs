﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFollow : MonoBehaviour
{

    // Use this for initialization
    public HeroRabit rabit;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Отримуємо доступ до компонента Transform
        //це Скорочення до GetComponent<Transform>
        Transform rabit_transform = rabit.transform;

        //Отримуємо доступ до компонента Transform камери
        Transform camera_transform = this.transform;

        //Отримуємо доступ до координат кролика
        Vector3 rabit_position = rabit_transform.position;
        Vector3 camera_position = camera_transform.position;

        //Рухаємо камеру тільки по X,Y
        camera_position.x = rabit_position.x;
        camera_position.y = rabit_position.y;

        //Встановлюємо координати камери
        camera_transform.position = camera_position;
    }
}