using System;
using UnityEngine;
// using ChatGPT;

namespace QuantuumStudios.PowerNodes{
/// <summary>
/// To create a NodeFunction, make a new class inside your NodeBehaviour class and extend NodeFunction
/// | Make constructor public! |
/// Please override RunNodeFunction!
/// </summary>
[Serializable]
public class NodeFunction
{
    public NodeInfo NodeInfo;
    public string executionMethodName;
    public bool allowExecution = false;
    // protected NodeBehaviour ParentBehaviour { get; private set; }

    protected NodeFunction()
    {
        NodeInfo = new NodeInfo { NodeName = GetType().Name, NodeId = Guid.NewGuid().ToString() };
    }
    
    /// <summary>
    /// Use OnNodeExecute to link your code to the execution of this function
    /// </summary>
    public virtual void RunNodeFunction()
    {

    }
}

[Serializable]
public class NodeInfo
{
    public string NodeName;
    public string NodeId;

    // Constructor to set name and ID
    public NodeInfo(string nodeName)
    {
        NodeName = nodeName;
        NodeId = Guid.NewGuid().ToString();
    }

    // Standard Constructor
    public NodeInfo()
    {
        NodeName = "Unnamed Node";
        NodeId = Guid.NewGuid().ToString();
    }
}

}