﻿using UnityEngine;
using System.Collections;

public class Panning : MonoBehaviour
{
    public float speed = 0.1F;
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-touchDeltaPosition.x * speed * Time.deltaTime, -touchDeltaPosition.y * speed * Time.deltaTime, 0);
        }
    }
}