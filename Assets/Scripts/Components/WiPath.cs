using UnityEngine;


public class WiPath : MonoBehaviour
{
    public Transform[] connectedMarker;
    
    public Color color;

    public void OnDrawGizmos()
    {
        for (int i = 0; i < connectedMarker.Length-1; i++)
        {
            Gizmos.color = color;
            
            Gizmos.DrawLine(connectedMarker[i].position, connectedMarker[i+1].position);
            connectedMarker[i].transform.LookAt(connectedMarker[i+1]);
        }
    }

}

