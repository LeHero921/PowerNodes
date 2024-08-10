using System;
// using ChatGPT;


[Serializable]
public class NodeFunction
{
    public NodeInfo NodeInfo { get; private set; }
    protected NodeBehaviour ParentBehaviour { get; private set; }

    protected NodeFunction(NodeBehaviour parent)
    {
        ParentBehaviour = parent;
        NodeInfo = new NodeInfo { NodeName = GetType().Name, NodeId = Guid.NewGuid().ToString() };
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