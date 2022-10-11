using System;
using UnityEngine;

public class TeleportToLocation : MonoBehaviour
{
    [SerializeField] private Transform XRRig;
    [SerializeField] private TeleportLocation[] locations;
    void Update()
    {
        foreach (var location in locations)
        {
            if (!Input.GetKeyDown(location.TeleportKey))
                continue;
            
            XRRig.position = location.TeleportTransform.position;
            XRRig.rotation = location.TeleportTransform.rotation;
        }
    }
}

[Serializable]
public class TeleportLocation
{
    public Transform TeleportTransform;
    public KeyCode TeleportKey;
}