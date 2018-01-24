# *Hungry Penguins Game*

Puzzle-platformer game where the player should collect a certain number of fish; spread out over a series of increased difficulty levels. 

The game was developed in Unity by Rory Davidson and Cristina Guerrero, as project for the **IGGI Game Development module** at _Goldsmiths University_ on November 2016.

-------

## Game 

### Game Concept

It was in mind developing a game with the idea of penguins living in a city, being forced to steal fish in order to eat and survive. Citizens would try to prevent the penguins from taking the fish, and being discovered would result in the loss of fish. Human clothes found in the game world could be used to fool the people and be able to walk through them without being noticed.

This game concept was primarily a story- and interaction-based conceptualization, rather than specifying what type of game it would be. Having this game concept, the first point to be discussed was the kind of game that would be developed, as the whole game design would depend on this. The options considered at the beginning were a platformer and an action-adventurer. It was tried to develop a prototype based in some games belonging to these genres (specially _Super Mario Bros_ and _The Legend of Zelda: Link's Awakening_, respectively) but none of the ideas worked for what it was wanted to be achieved.

The initial game concept called for a Mario-like structure, in which the player advances from left to right in order to reach the end of each level by running and jumping between platforms. Three problems were identified with this design:

+ _A lack of originality_, as the game’s basic interactions and goals would be largely similar to any other 2D platformer.
+ _The complexity of design_. Action platforming games like Mario typically have expansive levels, which would be difficult and time consuming to design.
+ _The role of certain objects from the initial concept_ In particular, in a long level, it was not clear what role the fish would play in level design.

In order to address some of these issues, a more modular design was considered, inspired by the _Metroidvania_ genre. In this design, levels were broken up into smaller rooms with a number of exits blocked by hungry penguins; players would collect fish in these rooms and use them to open up more rooms. 

The **final design** was a simplified version of this; a series of one-screen platforming puzzles in which the player must collect all of the fish on screen to progress.

A lot of the engagement in a game of this nature comes from the design of the puzzles. The constraints of a one-screen game make them less engaging as the element of exploration and progress forward is lose, as well as simply being more difficult to design in a level with a size limit. In order to create compelling challenged within these smaller levels, therefore, it was needed a larger number of ways in which the player could interact with the environment.

A number of possible puzzles elements were discussed, such as pushable objects, as well as other abilities for the penguin, such as a belly flop. In the end, it was chosen to implement two types of pushable objects, one being an ice block that would slide forward frictionlessly until hitting another solid; an enemy able to detect the penguin that must be avoided, and a disguise that would allow the penguin to evade detection. In the initial concept, this disguise consisted of three pieces; again due to the constrained level size, this ended up simplified to a single object.

### Player

Single player game, where the player controlls a _Penguin_, capable of moving left, right and to jump to reach places that wouldn't be reachable otherwise.

### Game elememts

+ _Ground_. Where the penguin and the rest of objects would stand on. It would have different levels.
+ _Fish_. Collectible by the player. It would increase the counter displayed in the level. It would be considered the win condition; the player would need to collect all of them to end the level.
+ _Penguin family_. It would act as the level exit once the player had collected all the fish.
+ _Person_. The penguin would need to avoid people or it would lose and restart the level.
+ _Clothes_. Collectible by the player. It would allow the penguin go through the people without being detected.
+ _Wood box (bin)_. Movable item.
+ _Ice box (bin)_. Movable item that slides.

### UI elements

+ _Fish display_. Would show the number of total fish available in the level which the player would need to collect in order to finish the level.
+ _Restart level button_. It would allow to restart the level.
+ _Game over message_. It would be displayed when the penguin had been detected by a person or felt into the void. A Try again message and a restart level button would appear.
+ _Win message_. It  would be displayed when the player had finished a level. A success message and a Start next level button would appear.

### Scenes

+ Start game screen.
+ Levels. Level loaded.
+ End of game screen.

### Levels

The idea was designing around 15 one-screen levels with increased difficulty. The first 10 levels would be considered as an introduction to familiarize the player with the game, controllers, elements and interactions.
Levels were designed in paper first and then implemented in Unity. Because of the playtesting during the development some of them suffered slight variations during this phase, which was expected.

### Gameplay

A video of the full gameplay of the final version developed can be found at:

[![Hungry Penguins Game full gameplay](https://img.youtube.com/vi/kq78pKoEnhU/0.jpg)](https://www.youtube.com/watch?v=kq78pKoEnhU)

## Improvements

The list of improvements that could not be included in the version developed but would have been implemented with more time is the following:

+ _Level information_. Additional UI elements displaying the current level number and name, as well as the total number of levels to complete.
+ _Select level option_. Additional menu screen allowing players to select the level to begin from, providing they have beaten all previous levels. This would allow players to keep their progress between play sessions, providing a greater sense of progress as well as supporting a longer game with more levels.
+ _Information and help screens_. They would be accessible from the main menu, providing more information about the game and the controllers, as well as allowing customization of options such as screen size and key bindings. Ideally, it would also be possible to load a menu during the game with Resume, Help, info and Exit options.
+ _Additional movement options_. One early idea that never made it past the design stage was the “belly slide” ability; having an ability apart from walking and jumping would increase the number of actions available to the player, apart from walking and jumping, would allow the player to move faster and reach further locations.
+ _More costume options_. In the version submitted, the hat is the only object that prevents people from discovering the penguin. Although it was dropped at an early stage due to level size, the initial concept had multiple costume types (sunglasses, hat and tie); these could be implemented either to provide visual variation or to allow for different levels of disguise - for instance, a single piece dramatically reducing but not eliminating detection range, or different person types requiring different costume items to bypass.
+ _Further aesthetic polish_. In the polish phase, the majority of changes were to gameplay-impacting objects and interactions. Further aesthetic improvements could include animations for various actions such as walking, jumping and pushing, visual effects such as dust clouds upon landing, and additional messages in circumstances such as when bypassing a person by using a disguise.



