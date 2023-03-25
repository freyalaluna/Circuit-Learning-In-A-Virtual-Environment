using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegSnap : MonoBehaviour
{
    public bool blocked = false;
    public List<Wire> attachedComponents = new List<Wire>();

    public int col;
    public int row;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void connect(Wire connected)
    {
        Debug.Log("Connect");
        attachedComponents.Add(connected);
        if (attachedComponents.Count >= 2)
        {
            blocked = true;
        }
    }

    public void disconnect(Wire connected)
    {
        Debug.Log("Disconnect");
        attachedComponents.Remove(connected);
        if (attachedComponents.Count < 2)
        {
            blocked = false;
        }
    }
}
