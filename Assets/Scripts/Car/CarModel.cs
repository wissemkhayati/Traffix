using UnityEngine;

public enum Flag { black, white}

public class CarModel : CarElement
{
    public int id;
    public Flag flag;
    public float speed;
    public Path path;
    public bool isCrashed;
    public Sensor_cmp sensor;
    public Renderer[] renderers;

    public GameObject effect;

    void Start()
    {
        transform.position = path.wipath.connectedMarker[0].position;

        if(flag == Flag.black) 
        { 
            renderers[0].material.color = Color.black;
           // renderers[1].material.color = Color.black;
        }
        else if (flag == Flag.white)
        {
            renderers[0].material.color = Color.white;
           // renderers[1].material.color = Color.white;
        }

    }

}
