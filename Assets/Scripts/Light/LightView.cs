using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightView : LightElement
{

    private void Start()
    {
        light.controller.ChangeSpot(Signs.red);
    }


    public void OnMouseUp()
    {
        light.controller.OpenWay();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (light.model.signs == Signs.red)
        {
            light.controller.BlockWay(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("exit");
        if (light.model.signs == Signs.orange)
        {
            light.controller.ChangeSpot(Signs.red);
        }
    }


}
