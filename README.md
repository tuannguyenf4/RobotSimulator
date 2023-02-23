# RobotSimulator
The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5 units

Requirement: 
The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5
units.
 There are no other obstructions on the table surface.
 The robot is free to roam around the surface of the table but must be prevented from falling to
destruction. Any movement that would result in the robot falling from the table must be prevented,
however further valid movement commands must still be allowed.
 Create an application that can read in commands of the following form -
 PLACE X,Y,F
 MOVE
 LEFT
 RIGHT
 REPORT
 PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.
 The origin (0,0) can be considered to be the SOUTH WEST most corner.
 The first valid command to the robot is a PLACE command, after that, any sequence of commands may
be issued, in any order, including another PLACE command. The application should discard all
commands in the sequence until a valid PLACE command has been executed.
 MOVE will move the toy robot one unit forward in the direction it is currently facing.
 LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position
of the robot.
 REPORT will announce the X,Y and F of the robot. This can be in any form, but standard output is
sufficient.
 A robot that is not on the table can choose to ignore the MOVE, LEFT, RIGHT and REPORT commands.
 Input can be from a file, or from command line input, as the developer chooses.
 Provide test data to demonstrate the application in operation. (file input commands.txt)

CONSTRAINTS
The toy robot must not fall off the table during movement. This also includes the initial placement of the toy
robot.
Any move that would cause the robot to fall must be ignored.

* Structure
  The solution contains two components, first one is main project to execute and and get the result, the secone one for testing
  
* How to run the project 
  From the command line, user input below information:
   1. PLACE X,Y,F (Where X and Y are integers and F 
     must be either NORTH, SOUTH, EAST or WEST)

   2. When the toy is placed, have at go at using
     the following commands.           
     REPORT – Shows the current status of the toy. 
     LEFT   – turns the toy 90 degrees left.
     RIGHT  – turns the toy 90 degrees right.
     MOVE   – Moves the toy 1 unit in the facing direction.
     EXIT   – Closes the toy Simulator.
     
  Example: 
    PLACE 0,0,NORTH
    LEFT
    REPORT
    Result : 0,0,WEST
    
* How to push the existing project to github: https://www.digitalocean.com/community/tutorials/how-to-push-an-existing-project-to-github
