# [Augmenta](https://www.augmenta-tech.com) [Unity](https://unity.com/) Library

Examples and documentation using this library are available [here](https://github.com/Theoriz/AugmentaUnity-Demo).

# Feature List
## Implemented
- OSC Data Parsing

   Scene, PersonsArray, SceneUpdatedEvent, PersonEnterEvent, PersonUpdatedEvent,PersonLeftEvent

- Augmenta scene object
- Augmenta person object
- Debug view
- Custom prefab instantiation on Augmenta objects
- Custom spawning and destroy behaviours for Augmenta objects
- Offset object position from its velocity



How to Use
-------------------------------------

### Setup

To start developping your application you probably need Augmenta data. If you do not have an Augmenta node ready, you can use our [Augmenta simulator](https://github.com/Theoriz/Augmenta-simulator/releases).

- Open your Unity scene.

- Drop the Augmenta prefab (from Assets/Plugins/Augmenta/Prefabs) in it.

- Set the input port in the AugmentaManager script of the Augmenta prefab to your protocol port.

- Run the scene.

- You should see gizmos of your Augmenta scene and persons in the scene view. You can enable or disable debug objects with the Show Debug option of the AugmentaManager.

### Using Custom Object Prefabs

To instantiate your own prefab on each Augmenta object, add your prefab to the Custom Object Prefab parameter of the Augmenta Manager.

You can change this prefab at runtime by calling the function `ChangeCustomObjectPrefab(GameObject newPrefab)` of the Augmenta Manager.

**Using Custom Behaviours**

You can implement custom spawn and destroy behaviours for your custom Augmenta objects by implementing the IAugmentaObjectBehaviour interface in a script of your object. If you do, its Spawn function will be called when the object is instantiated, and its Destroy function will be called when the object should be destroyed (i.e. when the corresponding AugmentaObject is destroyed).

Note that if you implement the IAugmentaObjectBehaviour interface, the AugmentaObject will *NOT* destroy your object when it destroys itself, instead it will call the Destroy function of the interface. You should handle the destruction of the custom object yourself in the Destroy() function of the interface.

### Using Several Augmenta Streams

You can receive different Augmenta streams in the same Unity application as long as they are not on the same OSC port. You need to add an Augmenta prefab (i.e. AugmentaManager) for each incoming stream, then set each AugmentaManager ID and input port to listen to each protocol.

### Examples Scenes

You will find setup examples in the Demo folder. This folder can be deleted safely if you do not need it.

*Note that the Spout examples will work for Windows only.*