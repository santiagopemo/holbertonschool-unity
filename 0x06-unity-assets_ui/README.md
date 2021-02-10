# 0x06. Unity - Assets: UI
## Resources :books:
### Read or watch:

* [Unity Manual: Asset Workflow (Read all sections from “Primitive and Placeholder Objects” to “Standard Assets”)]()
* [UI Button]()
* [UI Image]()
* [UI Events and Event Triggers]()
* [UI Slider]()
* [UI Transitions]()
* [Saving Data in Unity: PlayerPrefs]()
* [Unity Manual]()
* [Unity Manual: UI]()
* [Unity Manual: Designing UI for Multiple Resolutions]()
* [Unity UI Optimization Tips]()
* [Unity Manual: PlayerPrefs]()
* [Game UI Discoveries: What Players Want (Read all 4 pages)]()
* [The Right to Play: Accessibility in Gaming]()
* [How to Make Your Game UI Shine]()
* [6 Examples of UI Design to Study]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What is an Asset and how to import and use them
* How to import images to use in a user interface
* What is a Sprite
* How is a Sprite different from a Texture
* How to use the Sprite Editor
* What is 9-slicing
* How to create a Slider
* How to create a Toggle
* How to swap button images
* How to use PlayerPrefs and what are they used for
## Requirements :white_check_mark:
### General
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your holbertonschool-unity directory
* Push the entire project folder 0x06-unity-assets_ui to your repo
* Scenes and project assets such as Scripts must be organized as described in the tasks
* In your scripts, all your public classes and their members should have XML documentation tags
* In your scripts, all your private classes and members should be documented but without XML documentation tags
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Leveling up](./Assets/Scenes/Level02.unity)** - We’ll be adding on to the last project to add a menu and UI (see example ). Duplicate your 0x05-unity-assets_models_textures directory and rename it 0x06-unity-assets_ui
- [x] **[1. Choose your own adventure](./Assets/Scenes/MainMenu.unity)** - The next few tasks will be creating UI elements using imported images to build a menu that allows the player to choose a level
- [x] **[2. Option in](./Assets/Scenes/Options.unity)** - Create a new Scene called Options
- [x] **[3. Pushing buttons](./Assets/Scripts/MainMenu.cs)** - Create a new C# script called MainMenu.cs. In the MainMenu scene, script the level buttons scene so that choosing Level01, Level02, or Level03 loads the corresponding scene
- [x] **[4. Wait, hold on, time out](./Assets/Prefabs/PauseCanvas.prefab)** - Inside the Level01 Scene, create a new Canvas and using the image as a guide, create a pause screen with the following objects
- [x] **[5. Es-ca-pé](./Assets/Scripts/PauseMenu.cs)** - Create a new C# script called PauseMenu.cs. Add a method to this script so that when the player presses Esc while playing the game, the game should pause and the PauseCanvas should become active. The timer should also pause
- [x] **[6. Even more button pushing](./Assets/Scripts/PauseMenu.cs)** - In the PauseMenu and PauseMenu.cs, script the RestartButton so that it reloads the level scene that the player is currently on
- [x] **[7. Up is down, down is up](./Assets/Scripts/CameraController.cs)** - In the CameraController.cs script, add the ability to invert the Y axis
- [x] **[8. But Y?](./Assets/Scenes/Options.unity)** - In Options and OptionsMenu.cs, script it so that checking the InvertYToggle in the menu and applying the changes reverses the camera/mouse movements in the level scene
- [x] **[9. A winner is you](./Assets/Prefabs/WinCanvas.prefab)** - In the Level01 Scene, create a new Canvas and using the image as a guide, create a win screen with the following objects
- [x] **[10. Winning isn't everything](./Assets/Scripts/WinMenu.cs)** - Edit WinTrigger.cs so that when the player touches the flag, WinCanvas becomes active
- [x] **[11. Still under development](./Assets/Builds/*)** - Scenes in Build
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@Santiag11470161](https://twitter.com/Santiag11470161) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
