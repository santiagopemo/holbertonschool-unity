# ty - Animation
## Resources :books:
### Read or watch:

* [What is the difference between 2D and 3D animation? (We will not be covering how to create models, rigs, or animations in 3D modeling software, but it’s important to understand the parts of a 3D model and how they are animated.)]()
* [Unity Manual: Animation (Read sections “Animation System Overview”, “Animation Clips”, “Animator Controllers”)]()
* [The Animation View]()
* [Animation Properties]()
* [Animation Curves and Events]()
* [The Animator Component]()
* [The Animator Controller]()
* [Animator Scripting]()
* [Animation 101 - Intro to Animation in Unity]()
* [Mecanim and Mixamo in Unity]()
* [Unity Manual]()
* [Unity Manual: Animation Reference]()
* [Unity Manual: Glossary of Animation Terms]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What is a keyframe
* What are Dopesheets and how to use them
* What are Curves and how to use them
* How to import and use Animation Clips
* What are Animator Controllers and how to use them
* What is a State Machine
* What is a Sub-State Machine
* What is Root Motion
## Requirements :white_check_mark:
### General
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your holbertonschool-unity directory
* Push the entire project folder 0x07-unity-animation to your repo
* Scenes and project assets such as Scripts must be organized as described in the tasks
* In your scripts, all your public classes and their members should have XML documentation tags
* In your scripts, all your private classes and members should be documented but without XML documentation tags
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Cinematic universe](./Assets/Scenes/Level01.unity)** - We’re continuing to add on to the Platformer project to add animation (see example). Duplicate the 0x06-unity-assets_ui directory and rename it 0x07-unity-animation
- [x] **[1. Keyframes](./Assets/Scenes/Level01.unity)** - With Intro01 open in the Animation tab, use keyframes to animate the CutsceneCamera‘s Position and Rotation so that the camera pulls back from the flag, panning over the length of the platforms, and stopping behind the player, ending in the position and rotation of the Main Camera
- [x] **[2. Transitions](./Assets/Scenes/Level01.unity)** - Open the CutsceneCamera Animator in the Animator tab. Make sure that Entry has a transition to Intro
- [x] **[3. Sorry Sylvain, it's not a Tic Tac anymore](./Assets/Scenes/Level01.unity)** - Download this character model and import it into your Models folder. You may need to remap the materials and textures associated with the model. If you cannot find the materials and/or textures, extract them from the model’s Materials tab in the Inspector
- [x] **[4. Running in circles](./Assets/Scenes/Level01.unity)** - Edit CameraController.cs so that the camera still follows the player, but when the player turns, it does not change the orientation of the camera. The only rotation the camera should do is when the player moves the camera with the mouse
- [x] **[5. Happily idling](./Assets/Scenes/Level01.unity)** - All of the animations we’ll be using in this project are from Mixamo
- [x] **[6. Run boy run](./Assets/Scenes/Level01.unity)** - Download this Animation Clip and import it into your Animations folder. Change the settings so that they match Happy Idle‘s settings
- [x] **[7. Jump, jump](./Assets/Scenes/Level01.unity)** - Download this Animation Clip and import it into your Animations folder. Change the settings so it matches Happy Idle and Running‘s settings
- [x] **[8. Free falling](./Assets/Scenes/Level01.unity)** - Create a new Sub-state Machine called FallingDown. Create transitions to it from Running and Jump named RunningToFalling and JumpToFalling
- [x] **[9. Splat](./Assets/Scenes/Level01.unity)** - Download this Animation Clip and import it into your Animations folder
- [x] **[10. Down but not out](./Assets/Scenes/Level01.unity)** - Download this Animation Clip and import it into your Animations folder
- [x] **[11. Animated features](./Assets/Scenes/Level02.unity)** - Update the Level02 and Level03 scenes to have their own intro animations named Intro02 and Intro03 respectively. Replace the placeholder player with the animated model in each scene as well
- [x] **[12. Not quite done yet](./Assets/Builds/*)** - Scenes in Build
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@santiagopemo](https://twitter.com/Santiag11470161) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
