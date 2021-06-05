# 0x0C. Unity - AR Slingshot Game
## Resources :books:
* [Basics of AR: Anchors, Keypoints, & Feature Detection]()
* [Basics of AR: SLAM]()
* [AR Foundation Documentation]()
* [Augmented Reality Design Guidelines]()
* [Designing UI for Multiple Resolutions]()
* [Unity Manual: Understanding optimization in Unity]()
* [References]()
* [Unity Manual]()

## Learning Objectives :bulb:
* At the end of this project you are expected to be able to explain to anyone, without the help of Google:

* What is ARKit
* What is ARCore
* What is ARFoundation
* How does plane detection work
* How to detect planes using AR Foundation
* How to publish applications for both Android and iOS with Unity’s AR Foundation
* How to create responsive UI for mobile devices
* How to design in an augmented reality space
* What does SLAM stand for and what does it mean
* Requirements for Unity projects
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your holbertonschool-unity directory
* Push the entire project folder 0x0C-unity-ar_slingshot_game to your repo
* Scenes and project assets such as Scripts must be organized as described in the tasks
* In your scripts, all your public classes and their members should have XML documentation tags
* In your scripts, all your private classes and members should be documented but without XML documentation tags
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Detective work](./Assets/)** - Create a new Unity project and install the following packages via the Package Manager
- [x] **[1. Detected and selected](./Assets/)** - Now that the application is detecting planes, the player must be able to choose the plane they want to play the game on
- [x] **[2. Target practice](./Assets/)** - Create a new Capsule GameObject named Target and save it as a Prefab. Add behavior to the Target Prefab so that it moves within the bounds of the detected plane. There are several ways to accomplish this, such as using the plane’s boundary as constraints or finding a way to bake a NavMesh based on the selected plane at runtime. The method of implementation is up to you as long as the following requirements are met
- [x] **[3. Angry Birds-like](./Assets/)** - Create a new Sphere GameObject named Ammo and save it as a Prefab. Add behavior to the Ammo Prefab so that when instantiated it is positioned in the center of the player’s device screen. Ammo should behave as a slingshot would, meaning
- [x] **[4. U and I](./Assets/)** - Create a vertical UI layout for the game that includes the following elements
- [x] **[5. You can (not) redo](./Assets/)** - When the Ammo count reaches 0 or all Targets are eliminated, display a button for the player to replay the game
- [x] **[6. Trajectory projection](./Assets/)** - Add a LineRenderer to Ammo so that when it is pulled back, it shows a line indicating the direction and arc the Ammo will follow when it is released
- [x] **[7. Target platforms](./Assets/)** - Scenes in Build
### Advance :muscle:
- [x] **[8. Top of the charts](Assets/)** - Create a method of saving high scores and display a leaderboard of the highest scores when the player runs out of ammo
- [x] **[9. Sorry Sylvain, they're not Tic Tacs anymore](Assets/)** - Replace the target Capsule and ammo Sphere primitives with proper 3D models and/or animation. You can find 3D models and animations on mixamo.com and Unity Asset Store
- [x] **[10. Audio cues](Assets/)** - Add sound effects for one or more of the following
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@santiagopemo](https://twitter.com/Santiag11470161) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
