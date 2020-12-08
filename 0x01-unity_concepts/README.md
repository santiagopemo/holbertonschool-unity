# 0x01. Unity - Unity Concepts
## Resources :books:
### Read or watch:

* [Unity Manual: GameObjects]()
* [GameObjects and Components]()
* [Creating GameObjects and Types of GameObjects]()
* [Unity Manual: Components]()
* [Components]()
* [Unity Manual: Prefabs]()
* [Creating and Using Prefabs]()
* [Unity Manual: Tags]()
* [Unity Manual: Layers]()
* [The Beginner’s Guide to Game Mechanics]()
* [The 13 Basic Principles of Gameplay Design (Read all 4 pages)]()
* [Gameplay and Game Mechanics Design: A Key to Quality in Videogames]()
* [Unity Manual]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What is a GameObject
* What is a Component
* What is a Prefab
* What is a Tag
* What is a Layer
* How to create and change the properties of a GameObject
* How to create a Prefab
* How to add Tags and Layers
* Why is it important to name GameObjects and assets clearly and organize your project hierarchy
* What are gameplay and game mechanics and how do they relate to developing any kind of interactive experience
## Requirements :white_check_mark:
### General
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your holbertonschool-unity directory
* Push the entire project folder 0x01-unity_concepts to your repo, including .meta files
* Scenes and project assets such as Materials must be named and organized as described in the tasks
* No scripts are allowed for this project
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Floor plans](./0x01-unity_concepts/Assets/0-floor.unity)** - Create a new 3D Unity project called 0x01-unity_concepts. Save your new scene as 0-floor. Create a new Cube GameObject named Floor with the following Transform properties
- [x] **[1. On the ball](./0x01-unity_concepts/Assets/1-ball.unity)** - Duplicate 0-floor by selecting the scene in the Project window and either Edit > Duplicate from the Toolbar or CTRL / CMD + D. Rename the scene 1-ball and open it. Create a new Sphere GameObject named Ball with the following Transform properties
- [x] **[2. Colors!](./0x01-unity_concepts/Assets/2-colors.unity)** - Duplicate 1-ball, rename it 2-colors, and open it. Create a Materials folder in the Project window, then create a new material named floor. In the Inspector window, change the Albedo color to any color you like using the color picker. Assign the material to the Floor GameObject
- [x] **[3. Gravity is a harsh mistress](./0x01-unity_concepts/Assets/3-gravity.unity)** - Create a new folder in the Project window named Physic Materials and create a new Physic Material called bounce. Feel free to edit the material’s settings to get an idea of what the different settings affect. Add the bounce material to the Ball’s Sphere Collider. Press Play. For this task, your final bounce material settings should be
- [x] **[4. Prefabricated](./0x01-unity_concepts/Assets/4-prefab.unity)** - Duplicate 3-gravity, rename it 4-prefab, and open it. Create a new folder named Prefabs. Create a prefab from the Ball inside the new folder, then, using the prefab, add four more instance of the Ball to the scene. Position and scale them any way you like
- [x] **[5. Even more colors!](./0x01-unity_concepts/Assets/5-more_colors.unity)** - Duplicate 4-prefab, rename it 5-more_colors, and open it. Change the colors of each ball so they are different hex colors as defined below. New materials should be named as listed below. You cannot use scripts in this task
- [x] **[6. Tag yourself](./0x01-unity_concepts/Assets/6-tags.unity)** - Duplicate 5-more_colors, rename it 6-tags, and open it. Add a tag to all Ball objects called Obstacles
### Advance :muscle:
- [x] **[7. Textures](./0x01-unity_concepts/Assets/100-textures.unity)** - Duplicate 6-tags, rename it 100-textures, and open it. Create a new instance of Ball named Textured Ball and add a texture to it. Your texture asset should be in a folder named Textures and your new material should be called ball-texture
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@Santiag11470161](https://twitter.com/Santiag11470161) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
