using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : LightElement
{

    float doubleClickStart = 0;

    public void OpenWay()
    {
        
        if ((Time.time - doubleClickStart) < 0.3f)
        {
            OnDoubleClick();
            doubleClickStart = -1;
        }
        else
        {
            doubleClickStart = Time.time;
            OnOneClick();
        }

    }

    public void BlockWay(Collider other)
    {
        light.model.car = other.GetComponentInParent<CarApplication>();
        light.model.car.model.speed = 0;
        light.model.car.model.sensor.ishitted = true;
        //light.model.spot.material.color = Color.red;
        ChangeSpot(Signs.red);
    }


    void OnDoubleClick()
    {
        Debug.Log("Double Clicked!");
        //light.model.spot.material.color = Color.green;
        //light.model.boxCollider2.enabled = false;
        //light.model.signs = Signs.green;
        ChangeSpot(Signs.green);
        //ChangeSpot();
    }

    void OnOneClick()
    {
        Debug.Log("One Clicked!");


        if (light.model.signs == Signs.green)
        {
            ChangeSpot(Signs.red);
        }
        else if (light.model.signs == Signs.orange)
        {
            ChangeSpot(Signs.red);
        }
        else {
            ChangeSpot(Signs.orange);
        }


        if (light.model.car != null)
        {
              light.model.car.model.speed = 0.1f;
              light.model.car.model.sensor.ishitted = false;
              light.model.car = null;
        } 
    }

    public void ChangeSpot(Signs n)
    {
        light.model.signs = n;

        switch (light.model.signs)
        {
            case Signs.red:
                light.model.spot.material.color = Color.red;
                break;
            case Signs.orange:
                light.model.spot.material.color = Color.yellow;
                break;
            case Signs.green:
                light.model.spot.material.color = Color.green;
                break;

        }
    }

}
