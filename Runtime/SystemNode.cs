using QuantuumStudios.Common;
using QuantuumStudios.PowerNodes.api;
using UnityEngine;

[CreateAssetMenu(menuName = QS_Headers.Common_Create_Header + "/" + PowerNodes.ProjectHeader + "/System Node", fileName = "newSystemNode")]
public class SystemNode : ScriptableObject
{
    public string nodeName;
    public string nodeID;
    public SystemNode[] compatibleSystems;
    public NodeBehaviour nodeBehaviour;
}
