using System.Collections.Generic;
using System;
using UnityEngine;

namespace QuantuumStudios.PowerNodes{

/// <summary>
/// Node Behaviour NEEDS list of NodeFunction and a dictionary with string, Action
/// | implement all public override functions
/// | implement PowerNodesAPI.UpdateNodeExecution +=/-= OnNodeExecution in OnEn/Disable
/// </summary>
public class NodeBehaviour : ScriptableObject
{
    #region Pipeline Functions
    /// <summary>
    /// implement this in your custom Node Behaviour class to invoke your System functions
    /// </summary>
    /// <param name="funcDict"></param>
    /// <param name="methodName"></param>
    public virtual void InvokeMethodByName(Dictionary<string, Action> funcDict, string methodName)
    {
        if (funcDict.TryGetValue(methodName, out Action method))
        {
            method.Invoke();
        }
        else
        {
            Debug.LogWarning($"Method {methodName} not found");
        }
    }

    /// <summary>
    /// On Node Enter runns code at a nodes start
    /// </summary>
    public virtual void OnNodeEnter()
    {
        Debug.Log("Node execution started! " + this.name);
        // Run NodeBehaviour
    }

    /// <summary>
    /// On Node Execution runns code every frame
    /// </summary>
    public virtual void OnNodeExecution()
    {
        Debug.Log("Node is Executing! " + this.name);
    }

    /// <summary>
    /// On Node Exit runns code on node finish
    /// </summary>
    public virtual void OnNodeExit()
    {
        Debug.Log("Node Execution stopped! " + this.name);
        // Continue to next Node
    }

    /// <summary>
    /// Use StartCoroutine(functionName) inside this function
    /// | Make sure to type the function name correctly!
    /// </summary>
    /// <param name="functionName"></param>
    public virtual void RunFunctionByName(string functionName)
    {
    }
    #endregion
}

}