# Animation_Proj_1
CS6366 Computer animation and gaming project 1

Create a program by Unity3D that displays a cube and allows the user to rotate and translate it
along the three axes of world space and object space, respectively.

(1) Add a cube geometry and a camera to the world space. Please adjust the position of cube
and camera so that the cube is displayed at the center of the rendering window initially.

(2) Allow rotation and translation along the three axes of World Coordinate System (WCS)
and three axes of Object Coordinate System (OCS), respectively. Draw the three axes of WCS
and three axes of OCS, so it is easy to tell whether the cube is rotating along the correct axes
(and/or translating along the correct direction).

(3) Users can switch between WCS transformation and OCS transformation. In any coordinate
system, the program should allow users to apply transformations (rotations and translations
along any of the three axes) in arbitrary order. That is, your code should be written in “orderindependent”
way in terms of transformations.

(4) The program should have user-interaction controls to allow users to interactively rotate and
translate the cube. The controls can be buttons, checkboxes, mouse clicks, mouse motions, key
pressing etc. as long as it is easy to use. The rotation degree and translation distance are not
important, but it should be intuitive for the user to rotate clock-wisely/counter clock-wisely,
and translate positively/negatively.

(5) Have a “Reset” button that can reset the cube to the initial position and orientation.
