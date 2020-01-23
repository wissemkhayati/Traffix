using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarView : CarElement
{

    private void Start()
    {
        StartCoroutine(car.controller.Move());
    }

    private void OnCollisionEnter(Collision other)
    {
        car.controller.Crash(other);
    }

    public void OnMouseUp()
    {
        car.controller.Remove();
    }
}
