using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System;
using UnityEngine;

/// <summary>
/// Node Behaviour NEEDS list of NodeFunction ;
/// use public override:
/// -> OnNodeEnter()
/// -> OnNodeExecution()
/// -> OnNodeExit()
/// </summary>
public class NodeBehaviour : ScriptableObject
{
    #region Magic Code finding other code

    protected NodeBehaviour()
    {
        RegisterNodeFunctions(new List<NodeFunction>());
    }

    // Diese Methode sucht nach allen NodeFunction-Klassen und fügt sie zur Liste hinzu
    public virtual void RegisterNodeFunctions(List<NodeFunction> functions)
    {
        var nodeFunctionTypes = GetType().GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic)
            .Where(t => t.IsSubclassOf(typeof(NodeFunction)) && !t.IsAbstract)
            .ToArray();

        foreach (var type in nodeFunctionTypes)
        {
            var nodeFunctionInstance = (NodeFunction)Activator.CreateInstance(type, new object[] { this });
            if (nodeFunctionInstance.NodeInfo.NodeName == "" || nodeFunctionInstance.NodeInfo.NodeId == "")
            {
                Debug.LogWarning("You forgot to set either NodeInfo.NodeName or .NodeID for: " + nodeFunctionInstance);
                break;
            }
            else if (functions.Find(NodeFunction => NodeFunction.NodeInfo.NodeId == nodeFunctionInstance.NodeInfo.NodeId) == null)
            {
                Debug.Log("Is Function already in list?: " + functions.Find(NodeFunction => NodeFunction.NodeInfo.NodeId == nodeFunctionInstance.NodeInfo.NodeId));
                Debug.Log("Adding node function: " + nodeFunctionInstance.NodeInfo.NodeName);
                functions.Add(nodeFunctionInstance);
            }
        }
    }
    #endregion

    #region Pipeline Functions
    /// <summary>
    /// Control Function Update is REQUIRED to be used!
    /// just do: RegisterNodeFunctions(yourListHere);
    /// inside the override!
    /// </summary>
    public virtual void ControlFunctionUpdate()
    {
        List<NodeFunction> tempList = new List<NodeFunction>();
        RegisterNodeFunctions(tempList);
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
    #endregion
}