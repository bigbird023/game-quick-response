# game-quick-response
tutorial to help development of a game

## Console Game

Pre-requisites
1.) You have .NET core installed
2.) You have an Visual Code installed

To Start:
1.) create a folder for the project to live installed
2.) run "dotnet new console"

Concept of The Game we will be building:  It is a response game, the user will pick Easy, Medium or Hard, which will determine speed of screen changes.  User will click start, which will allow the game to start outputting "---" on a line.  When the letter "x" appears, then the user is expected to touch any keyboard value.

## Understanding how a program starts
Open up Program.cs

Because this is a console game, the below method signature is how .NET will know which part of your code to execute first

class Program
    {
        static void Main(string[] args)


So we will start by asking the User the Question of Easy, Mediocre, or Hard

Todo:
1.) Move Code Section into it's own method name inputGameLevel
2.) Add input validation
3.) Add Loop until valide input is made

Need Help, Go onto Step 2 of the tutorial