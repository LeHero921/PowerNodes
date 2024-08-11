<h1 align="center">Power Nodes - Preview</h1>

<h4 align="center">
This version Power Nodes is a PREVIEW !
</h4>

---
<h2 align="center">
What is Power Nodes
</h2>

Power Nodes is a designer-friendly tool,
designed to simplify prototyping and design workflows.

It is a Unity Package, developers can add to their projects and extend their existing systems for easier use 

<br>
<h2 align="center">
How to Install
</h2>

Power Nodes is a Unity Package, that you can install by copying the git-url of this repo and adding it inside the Unity Package-Manager.

<br>
<h2 align="center">
How to Use it - Designer
</h2>

After importing the package, you will see a new entry to the "Create" menu.
From: Create -> QuantuumStudios -> PowerNodes -> you can create new Node Trees, Root/System Nodes [...].

A NodeTree contains a RootNode which you can connect to system Nodes.
A SystemNode contains a NodeBehaviour which internally contains NodeFunctions, but thats Developer stuff.

To execute the Logic of a Node Tree,
you can add a NodeExecutionContainer script to any game object (or Prefab).
The Node Execution Container holds a reference to a Node Tree.

<br>
<h2 align="center">
How to Use it - Developer
</h2>

Now here comes the *fun* part...
I try to make this system as flexible as possible but currently you have to do a *small* setup to add your systems.

<h4> 1. Create System Nodes for your System</h4>
Within a Folder of your choosing, rightclick -> Create -> QuantuumStudios -> PowerNodes -> SystemNode.
Please fill out all Fields.

<h4> 2. Create Custom NodeBehaviour script for your System</h4>

- Create a new C# script
- Instead of MonoBehaviour, derive from NodeBehaviour
  - Please Note: NodeBehaviour derives from Scriptable object, please add [CreateAssetMenu()] to your implementation
- Follow Documentation or summary-tooltips inside your IDE
- Please follow the Documentation for a detailed description

<h4> 3. Update NodeBehaviour Functions</h4>

- Look at the top bar of the Editor
- click QuantuumStudios -> PowerNodes -> Node Behaviours -> Update All Behaviour Functions
- This adds all your NodeFunctions to the NodeBehaviour script you created

<br><br>
<h3 align="center">Components of this System - instead of real Documentation</h3>

Comming Soon™️
