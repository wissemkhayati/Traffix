using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : CarElement
{

    private int current_marker;
  
    public void Crash(Collision other) 
    {
       if (other.gameObject.CompareTag("Player"))
        {
            car.model.speed = 0;
            car.model.effect.SetActive(true);
            car.model.GetComponent<Rigidbody>().useGravity = false;
            car.model.isCrashed = true;
        }
    }


    public IEnumerator Move()
    {
        current_marker = 0;

        while (current_marker < car.model.path.wipath.connectedMarker.Length)
        {
            transform.LookAt(car.model.path.wipath.connectedMarker[current_marker]);

            while (Vector3.Distance(transform.position, car.model.path.wipath.connectedMarker[current_marker].position) > 0.1f)
            {

                transform.position = Vector3.MoveTowards(transform.position, car.model.path.wipath.connectedMarker[current_marker].position, car.model.speed );
                //transform.Translate(car.model.wipath.connectedMarker[current_marker].position * Time.deltaTime);

                yield return null;
            }
            if (current_marker != car.model.path.wipath.connectedMarker.Length)
            {
                current_marker++;
            }
           

        }

        Finish();

    }


    public void Finish()
    {
        //remove references
        foreach (Path p in AppApplication.Instance.model.spawner)
        {
            if (p.id == car.model.path.id)
            {
                p.cars.Remove(car.model.id);
            }
        }

        //destroy object
        Destroy(gameObject);
    }


    public void Remove()
    {
        if (car.model.isCrashed) { Finish(); }
    }


}
