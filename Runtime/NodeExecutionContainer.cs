using UnityEngine;

namespace QuantuumStudios.PowerNodes{

/// <summary>
/// The Node Execution Container is the place where
/// a Node Tree gets executed
/// </summary>
public class NodeExecutionContainer : MonoBehaviour
{
    public NodeTree nodeTree;
    public bool runPipeline;
    bool inPipeline;

    public enum PipelineStartType {
        OnStart,
        OnLoadAllNodeEntities
    }

    public PipelineStartType pipelineStartType;

    #region OnEn/Disable
    private void OnEnable() {
        if (pipelineStartType == PipelineStartType.OnLoadAllNodeEntities)
        {
            PowerNodesAPI.NodeExecution.LoadAllNodeEntities += StartExecutionPipeline;
        }
    }

    private void OnDisable() {
        if (pipelineStartType == PipelineStartType.OnLoadAllNodeEntities)
        {
            PowerNodesAPI.NodeExecution.LoadAllNodeEntities += StartExecutionPipeline;
        }
    }
    #endregion

    // TODO: add the comments below to the correct event later on
    // this is just temp code
    // the node behaviour will be started through an event, like 
    // OnNodePipelineStartup, which will can be called by for example a level loading system

    private void Start() {
        if (pipelineStartType == PipelineStartType.OnStart)
        {
            StartExecutionPipeline();
        }
    }

    private void Update() {
        if (runPipeline == true && inPipeline == false)
        {
            StartExecutionPipeline();
        }
        // if inPipeline is false, the pipeline is exiting execution
        else if (runPipeline == true && inPipeline == false)
        {
            // maybe use event or unity action event

            // Exits out of the entire tree
            // nodeTree.rootNode.containedRootNode.nodeBehaviour.OnNodeExit();
            ExitExecutionPipeline();
        }
    }

    #region Node Execution Pipeline
    public void StartExecutionPipeline()
    {
        Debug.Log("Starting Node Execution pipeline for: " + gameObject.name + "!");
        runPipeline = true;
        inPipeline = true;
        // forech system node, run the Node Enter function
        foreach (SystemNodeContainer systemsContainer in nodeTree.rootNode.attatchedSystemNodes)
        {
            // from here on out, the node can handle its logic on its own
            systemsContainer.containedSystemNode.nodeBehaviour.OnNodeEnter();
            systemsContainer.containedSystemNode.nodeBehaviour.OnNodeExecution(true);
        }
    }

    public void ExitExecutionPipeline()
    {
        runPipeline = false;
        inPipeline = false;
        foreach (SystemNodeContainer systemsContainer in nodeTree.rootNode.attatchedSystemNodes)
        {
            // from here on out, the node can handle its logic on its own
            systemsContainer.containedSystemNode.nodeBehaviour.OnNodeExecution(false);
            systemsContainer.containedSystemNode.nodeBehaviour.OnNodeExit();
        }

        Debug.Log("Stopping Node Pipeline execution for: " + gameObject.name + "!");
    }
    #endregion
}

}