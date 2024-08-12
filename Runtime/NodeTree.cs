using System;
using System.Collections.Generic;
using UnityEngine;
using QuantuumStudios.Common;
using QuantuumStudios.PowerNodes.api;

[CreateAssetMenu(fileName = "New Node Tree", menuName = QS_Headers.Common_Create_Header + "/" + PowerNodes.ProjectHeader + "/Node Tree")]
public class NodeTree : ScriptableObject
{
    public RootNodeContainer rootNode;
#region look at later
    //you can create nodes from the compatible nodes list of the slected node
    public void CreateNode()
    {
        
    }

    public void DeleteNode()
    {
        
    }
#endregion

    private void OnValidate() {
        foreach (SystemNodeContainer container in rootNode.attatchedSystemNodes)
        {
            container.nodeBehaviour = container.containedSystemNode.nodeBehaviour;
            container.nodeID = container.containedSystemNode.nodeID;
        }
    }
}

[Serializable]
public class RootNodeContainer
{
    public RootNode containedRootNode;
    public string nodeID => containedRootNode.nodeID;
    public List<SystemNodeContainer> attatchedSystemNodes;
}

[Serializable]
public class SystemNodeContainer
{
    public SystemNode containedSystemNode;
    public NodeBehaviour nodeBehaviour;
    public string nodeID;
}