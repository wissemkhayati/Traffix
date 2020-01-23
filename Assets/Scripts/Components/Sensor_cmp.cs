using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Sensor_cmp : MonoBehaviour
{
    private RaycastHit _hit;
    private float _sensibility;
    private Vector3 origin;
    private Vector3 forward;
    private float speed;
    public bool ishitted;

    void Start()
    {
        _sensibility = 1f;
        speed = GetComponent<CarApplication>().model.speed;
    }


    void Update(){
        
        origin = new Vector3(transform.position.x, transform.position.y, transform.position.z );
        
        forward = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(origin, forward * _sensibility, Color.green);


        onHit();
      }

      public void onHit()
      {
        if (Physics.Raycast(origin, forward, out _hit, _sensibility))
        {
            if (_hit.collider.CompareTag("Player"))
            {
                if (_hit.collider.GetComponent<CarApplication>().model.speed == 0
                && !_hit.collider.GetComponent<CarApplication>().model.isCrashed)
                {
                    ishitted = true;
                    GetComponent<CarApplication>().model.speed = 0;
                }
            }
            
           
        }
        else {
            if (!GetComponent<CarApplication>().model.isCrashed)
            {
                ishitted = false;
                GetComponent<CarApplication>().model.speed = speed;
            }
        }

    }
  
   
}