using System;
using UnityEngine;
using UnityEngine.Events;

public class PowerNodesAPI : MonoBehaviour
{
    public static class NodeExecution
    {
        public static UnityAction LoadAllNodeEntities;
        public static UnityAction<RootNode> LoadAllNodeEntitiesOfType;
    }
}

namespace QuantuumStudios.Common
{
    public class QS_Headers
    {
        public const string Common_Create_Header = "QuantuumStudios";
    }
}

namespace QuantuumStudios.PowerNodes
{
    public class PowerNodes
    {
        public const string ProjectHeader = "PowerNodes";
    }
}