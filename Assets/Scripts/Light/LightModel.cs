using UnityEngine.AI;
using UnityEngine;

public enum Signs { red, orange, green };

public class LightModel : LightElement
{

    public CarApplication car;
    public Signs signs;
    public Renderer spot;

    public void Awake()
    {
        signs = Signs.red;       
    }
}
