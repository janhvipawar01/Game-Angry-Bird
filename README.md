
# Getting Started with Angry Bird

## Project Overview

This project is a 2D implementation of the popular game Angry Birds. The goal of the game is to use a slingshot to launch birds and defeat enemies by collapsing their structures, using strategy and physics-based gameplay.

The game was developed using Unity 2D, leveraging its built-in physics and graphical capabilities. The project demonstrates the development process of a 2D game, from conceptualization to implementation.

## Features
- Physics-Based Gameplay: Realistic flight trajectory and collision mechanics.

- Interactive Main Menu: Start and quit options.

- Enemy Destruction Effects: Visual effects for defeated enemies.

- Game Scene: Slingshot mechanics, enemies, and destructible structures.

- Multiple Levels: Aiming for progressive challenges and replayability.


## Tech Stack

**Game Engine:** Unity 2D

**Programming Language:** C#

**Development Platform:** Windows 7 or greater version.



## Scene Objects

The game components used in the Angry Birds Game Design is known as Scene Objects.

**The game consists of two primary scenes:**

- *Main Menu Scene:* Contains UI elements for navigation.
- *Game Scene:* Contains interactive game objects like birds, enemies, and structures.

![Sprites](https://github.com/user-attachments/assets/0d9acd02-5200-4609-8d34-d88fe70a6ba6)


**Main Menu Scene Objects**

![image](https://github.com/user-attachments/assets/2b280fea-64d7-466b-bbbe-0a7e39f4d83d)

- Main Camera: 📸
    
  - Responsible for rendering the view of the main menu.
  - Keeps the UI elements in focus.

- Canvas: 🖼️

  - Used to display UI components like the background and buttons.
  - Provides the foundation for designing the user interface.

- Play Button: ▶️

  - Allows the user to start the game by navigating to the game scene.
  - Linked to a script that triggers the SceneManager to load the next scene.

- Exit Button: ❎

  - Allows the user to exit the application.
  - When clicked, it executes the Application.Quit() function.

**Game Scene Objects**

![image](https://github.com/user-attachments/assets/27bdf0d1-31ea-44be-95a7-eeb4ed94361e)

- Main Camera: 📸

  - Used to capture and display the game environment to the player.
  - Focuses on the entire playable area, ensuring that all objects (bird, enemies, structures) are visible.

- Sky: 😶‍🌫️

  - Acts as the background for the game.
  - Provides a visual environment, such as a blue sky.

- PlankSprites: 🪵

  - Represent the wooden blocks used in the structures.
  - Include multiple instances (e.g., plankSprite, plankSprite(1)).
  - Arranged vertically and horizontally to create obstacles and shelters for the enemies.

- BirdEnemyFlapSprites: 🐤

  - Represent the yellow villain birds (enemies).
  - Include multiple instances (e.g., BirdEnemyFlapSprite, BirdEnemyFlapSprite(1)).
  - Positioned strategically on the structures to increase the challenge.

- AngryBird: 🐦

  - Represents the main character, the red bird.
  - Includes multiple instances (e.g., angrybird, angrybird(1)), indicating multiple attempts or levels.
  - Attached to the slingshot for launching.

- CatapultBackSprite and CatapultFrontSprite:

  - Represent the two parts of the slingshot used to launch the angry bird.
  - Simulate the realistic mechanics of pulling and releasing a slingshot.

- EnemyDeathEffect: 💀

  - A visual effect triggered when a villain bird is destroyed.
  - Provides feedback to the player and enhances the gameplay experience.
 
  
## How to Run

- Install Unity 2D.
- Clone this repository to your local machine:
- Copy code
```bash
  https://github.com/janhvipawar01/Unity-Slingshot-Saga-Recreating-Angry-Birds-in-2D.git
```
- Open the project in Unity.
- Run the project by clicking the Play button in the Unity Editor.


## Authors

- Github: [@janhvipawar01-github](https://www.github.com/janhvipawar01)

## Connect with me

- LinkedIn: [![LinkedIn](https://img.shields.io/badge/LinkedIn-Profile-blue?style=flat&logo=linkedin)](https://www.linkedin.com/in/janhvi-pawar-095831215)



