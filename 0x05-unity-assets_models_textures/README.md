# 0x05. Unity - Assets: Models, Textures
## Assets
The realization of this project was possible, thanks to the following assets:
* [Skyboxes: Farland Skies - Cloudy Crown](https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004)
* [Models: Kenney's Nature Pack Extended](https://intranet.hbtn.io/rltoken/BYHZEB1i-sI1-GsnUpatbw)
## Resources :books:
### Read or watch:

* [Unity Manual: Asset Workflow (Read all sections from “Primitive and Placeholder Objects” to “Standard Assets”)]()
* [Materials]()
* [Models and Materials]()
* [Unity Manual: Nested Prefabs]()
* [Unity Manual: Prefab Variants]()
* [New Prefab Workflows in Unity]()
* [Textures]()
* [Using Skyboxes]()
* [Game Programming Patterns]()
* [Unity Manual]()
* [Unity Manual: Textures]()
* [Unity Manual: Time]()
* [Unity Manual: Quaternion]()
* [Unity Manual: Euler Angles]()
* [Unity Manual: CharacterController]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What is an Asset and how to import and use them
* How to use Asset Packages and the Unity Asset Store
* What are common Asset types
* How to use Unity primitives as placeholders to prototype a project
* What are materials and how to use them
* What are textures and how to use them
* What is a skybox
* What is are the components of a 3D model
* What is a mesh
* How to create UI elements with image components
* What is a Rigidbody and what is a Character Controller and what are the pros and cons of using each
* What is a Quaternion
## Requirements :white_check_mark:
### General
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your holbertonschool-unity directory
* Push the entire project folder 0x05-unity-assets_models_textures to your repo
* Scenes and project assets such as Scripts must be organized as described in the tasks
* In your scripts, all your public classes and their members should have XML documentation tags
* In your scripts, all your private classes and members should be documented but without XML documentation tags
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Primitive player](./Assets/Scenes/Level01.unity)** - Create a new Scene called Level01. Create a capsule GameObject called Player which will be a placeholder for this project
- [x] **[1. Primitive prototype](./Assets/Scenes/Level01.unity)** - In the Level01 scene, create a layout of floating platforms of different sizes and positions using only Unity Cube GameObjects, . Plan for a start point and an endpoint and create a path so that the Player can jump between them. The cubes will be placeholders for 3D models that we will import later on
- [x] **[2. Pole position](./Assets/Scenes/Level01.unity)** - At the end point of the platforms, create a placeholder cylinder GameObject called WinFlag to designate the end of the path. Do not make WinFlag a child of any object. Later we will add scripting for when the Player reaches the WinFlag
- [x] **[3. Jump man](./Assets/Scenes/Level01.unity)** - Create a new folder called Scripts. Inside that folder, create a new C# script called PlayerController and attach it to Player
- [x] **[4. Camera ready](./Assets/Scenes/Level01.unity)** - Position the Main Camera at an offset behind the player
- [x] **[5. Steady cam](./Assets/Scenes/Level01.unity)** - In the Scripts folder, create a new C# script called CameraController that allows the camera to follow the player. The script should also allow the player to rotate the camera on their own by moving the mouse, either by just moving the mouse or holding down right-click and dragging the mouse to move the camera
- [x] **[6. Falling up](./Assets/Scenes/Level01.unity)** - Currently if the player falls off a platform, it falls infinitely. Edit the PlayerController and CameraController scripts so that if the player falls from a platform and can’t get to another platform, the player instead falls from the top of the screen onto the start position, causing the player to need to start from the beginning again
- [x] **[7. Time trial](./Assets/Scenes/Level01.unity)** - Create a new Canvas and UI Text element that displays a timer on screen
- [x] **[8. Clock's ticking](./Assets/Scenes/Level01.unity)** - Create a script called Timer and attach to the Player. Timer should have a public Text variable called Timer Text for the TimerText Text object
- [x] **[9. Finish line](./Assets/Scenes/Level01.unity)** - Create a script called WinTrigger and attach to WinFlag
- [x] **[10. The sky's the limit](./Assets/Scenes/Level01.unity)** - In the Unity Asset Store, find Farland Skies - Cloudy Crown, a free set of skyboxes. Add them to a folder called Skyboxes in the Assets/Materials folder in your 0x05-unity-assets project
- [x] **[11. The great outdoors](./Assets/Scenes/Level01.unity)** - Download Kenney’s Nature Pack Extended. Import the asset package and place the files in a directory called Models. For the sake of organization, inside the Assets folder, create a new directory called Materials and move the materials in Models into Materials
- [x] **[12. Environmental awareness](./Assets/Scenes/Level01.unity)** - From the Nature Pack asset package in your Models folder, add trees, rocks, flowers, etc. to the platforms as you like. Organize your objects in your Hierarchy using empty GameObjects
- [x] **[13. What's left of the flag](./Assets/Scenes/Level01.unity)** - Download this flag model. Place it in the Models directory. Add Flag to your scene and make it a child of the WinFlag GameObject. The pole of the flag should be positioned inside WinFlag‘s collider. Resize or reposition the collider if necessary
- [x] **[14. (Sea)horse race](./Assets/Scenes/Level01.unity)** - Download this flag texture. Place it in a new directory called Textures
- [x] **[15. Under development](./Builds/)** - Scenes in Build
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@Santiag11470161](https://twitter.com/Santiag11470161) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
