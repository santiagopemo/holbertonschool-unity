# 0x03. Unity - UI
## Build
[Click here](https://santiagopemo.github.io/0x03-unity-ui/) to watch the game
## Resources :books:
### Read or watch:

* [Unity Manual: UI (Read sections Canvas to Interaction Components)]()
* [UI Canvas]()
* [How to make a Video Game in Unity - Score & UI]()
* [Start Menu in Unity]()
* [The Four Elements of Game Design Part 1]()
* [The Four Elements of Game Design Part 2]()
* [I Have No Words & I Must Design]()
* [Game Accessibility Guidelines]()
* [Unity Manual]()
* [Unity Manual: UI Reference]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What is the Canvas
* What is screen space vs world space
* How to use the Rect Tool
* What are anchors and how to use them
* How to display and update information in the UI
* What is a coroutine
* How to create a menu
* How to use Unity’s UI Interaction Components
* What the alpha value of a color is
* How to set and change material colors with scripts
* What are common accessibility concepts to consider
## Requirements :white_check_mark:
### General
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your project folder
* Push the entire project folder 0x03-unity-ui to your repo
* Scenes and project assets such as Scripts must be organized as described in the tasks
* In your scripts, all your public classes and their members should have XML documentation tags
* In your scripts, all your private classes and members should be documented but without XML documentation tags
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Scoreboard](./Assets/maze.unity)** - We’ll be building off the last project to add UI elements (see example)
- [x] **[1. What does "new high score" mean? Is that bad? Did I break it?](./Assets/maze.unity)** - Edit the PlayerController.cs script. Create a new public Text scoreText variable. In the Inspector, set the value of the scoreText field to your ScoreText GameObject
- [x] **[2. HP](./Assets/maze.unity)** - Inside the existing Canvas GameObject, create a new UI Image GameObject and name it HealthBG. Anchor it to the top left of the game window using Anchor Presets
- [x] **[3. Health inspection](./Assets/maze.unity)** - Edit the PlayerController.cs script. Create a new public Text healthText variable. In the Inspector, set the value of the healthText field to your HealthText GameObject
- [x] **[4. Win, lose, or draw](./Assets/maze.unity)** - Inside the existing Canvas GameObject, create a new UI Image GameObject and name it WinLoseBG. Anchor it to the center of the game window using Anchor Presets
- [x] **[5. Chicken dinner](./Assets/maze.unity)** - Edit the PlayerController.cs script so that when the Player touches the Goal
- [x] **[6. Game over, man, game over](./Assets/maze.unity)** - Edit the PlayerController.cs script so that when the Player‘s health reaches 0
- [x] **[7. Wait a second...](./Assets/maze.unity)** - The transition from the Game Over! text and the scene reloading is very sudden and abrupt. Let’s use a coroutine and WaitForSeconds() to create a delay where once the Player‘s health is 0 and the Game Over! text is displayed, the scene waits 3 seconds to reload
- [x] **[8. What's on the menu](./Assets/menu.unity)** - Create a new scene called menu in the Project window. Add a new UI Panel GameObject called MenuBG
- [x] **[9. Let's play](./Assets/menu.unity)** - Create a new C# script MainMenu.cs. Create a new method public void PlayMaze()
- [x] **[10. We're not retreating, we're advancing! Toward future victory!](./Assets/menu.unity)** - Inside the MainMenu.cs script, create a new method public void QuitMaze()
- [x] **[11. A narrow variety of options](./Assets/menu.unity)** - Inside the existing Canvas GameObject, create an empty GameObject called OptionsMenu. Anchor it to the center of the game window with Anchor Presets
- [x] **[12. Accessibility](./Assets/menu.unity)** - Having red traps and a green goal isn’t very accessible design for certain types of colorblindness. Ideally in game design, it would be better to avoid color coding important mechanics or objects entirely. For the sake of this UI project, we’ll add a Colorblind Mode option for our maze
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@Santiag11470161](https://twitter.com/Santiag11470161) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
