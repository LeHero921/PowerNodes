using System;
using UnityEngine;
using UnityEngine.Events;

namespace QuantuumStudios.PowerNodes
{
    public class PowerNodesAPI
    {
        public static UnityAction LoadAllNodeEntities;
        public static UnityAction<RootNode> LoadAllNodeEntitiesOfType;
        public static Action UpdateNodeExecution;
    }

    public class PowerNodes
    {
        public const string ProjectHeader = "PowerNodes";
    }
}

namespace QuantuumStudios.Common
{
    public class QS_Headers
    {
        public const string Common_Create_Header = "QuantuumStudios";
    }
}
