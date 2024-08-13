using QuantuumStudios.Common;
using QuantuumStudios.PowerNodes;
using UnityEditor;
using UnityEngine;

public class PowerNodesToolbarFunctions : Editor
{
    const string createHeader = QS_Headers.Common_Create_Header;
    const string prodjectHeader = PowerNodes.ProjectHeader;

    private void OnValidate() {
        CheckPowerNodesManager();
    }

    [MenuItem(createHeader + "/" + prodjectHeader + "/Add PowerNodes Manager")]
    public static void CheckPowerNodesManager()
    {
        if (FindObjectOfType<PowerNodesManager>() == null)
        {
            Instantiate(new GameObject().AddComponent<PowerNodesManager>());
        }else
        {
            FindObjectOfType<PowerNodesManager>().gameObject.name = "PowerNodes Manager";
        }
    }
}
