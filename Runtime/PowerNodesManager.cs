using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuantuumStudios.PowerNodes
{

public class PowerNodesManager : MonoBehaviour
{
    #region Singelton
    private static PowerNodesManager _instance;
    public static PowerNodesManager Instance => _instance;

    private void Awake() {
        if (_instance == null)
        {
            _instance = this;
        }else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    private void Update() {
        // TODO: make some optimizing logic
        try
        {
            PowerNodesAPI.UpdateNodeExecution();
        }
        catch{}
    }
}

}