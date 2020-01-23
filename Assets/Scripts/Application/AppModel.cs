using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Path
{
    public int id;
    public WiPath wipath;
    public List<int> cars;
    public int maximumCarIsWaiting;
    public Flag flag;
    public float wave;
}

public class AppModel : AppElement
{
    public List<Path> spawner;
  
}
