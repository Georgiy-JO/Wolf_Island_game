# Wold Island game
Just a pet project of the Wolfs Island game.

## Main idea
Field is filled with grass, rabbits and wolfs. Wolfs eat rabbits, rabbits eat grass, grass grow. All animals can starve to death. 
You can set the amount of each and the field size at the beginning of the game and see how it goes.

## Technical part
- Project is written in a C# as a pet project. 
- Some bags can still remain ([Notes](#notes-for-future)), I will fix those when I have time probably.
- The project supports the MVC pattern so all the logic is inside the `Wolf_Island.Core` folder, while `Wolf_Island.App` folder contains GUI and a simple `Program.cs`.

## Version notes
This is the version where animals can multiply any time they are near each other, that freaks up the game, by looks fun.

## Notes for future
1. Eating patterns (wolfs doesn't eat sometimes) -- might be something with the WeightField (or everything may be fine, and it's just me).
2. optional changes:
   1. make view field global for animals (require rework of the game structure, for example weight field will have to be global as well).
   2. make possible position matrix for all the animals and food







