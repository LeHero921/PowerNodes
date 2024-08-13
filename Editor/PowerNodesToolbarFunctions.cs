using QuantuumStudios.Common;
using QuantuumStudios.PowerNodes;
using UnityEditor;
using UnityEngine;

public class PowerNodesToolbarFunctions : MonoBehaviour
{
    const string createHeader = QS_Headers.Common_Create_Header;
    const string prodjectHeader = PowerNodes.ProjectHeader;

    // [MenuItem(createHeader + "/" + prodjectHeader + "/Node Behaviours/Update All Behaviour Functions")]
    // public static void ExecuteControlFunctionUpdate()
    // {
    //     // Find all instances of NodeBehaviour in the scene
    //     NodeBehaviour[] allNodeBehaviours = Resources.FindObjectsOfTypeAll<NodeBehaviour>();

    //     // Loop through each instance and call ControlFunctionUpdate
    //     foreach (NodeBehaviour nodeBehaviour in allNodeBehaviours)
    //     {
    //         nodeBehaviour.ControlFunctionUpdate();
    //     }
        
    //     Debug.Log("Completed execution of ControlFunctionUpdate on all NodeBehaviours.");
    // }
}
