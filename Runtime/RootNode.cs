using System.Collections.Generic;
using QuantuumStudios.Common;
using QuantuumStudios.PowerNodes;
using UnityEngine;

[CreateAssetMenu(menuName = QS_Headers.Common_Create_Header + "/" + PowerNodes.ProjectHeader + "/RootNode")]
public class RootNode : ScriptableObject
{
    public string nodeName;
    public string nodeID;
    public SystemNode[] compatibleSystems;
}