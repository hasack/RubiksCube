# RubiksCube

## Overview
A library for modelling and manipulating a Rubik's Cube in C#.

# Introduction to a Rubik's Cube

A standard 3×3 Rubik’s Cube has 6 faces, each with 9 facelets (3 rows × 3 columns).

Another way of looking at a Rubik's Cube is that it has 26 smaller pieces called **cubies**.

## Facelets vs Cubies

A **facelet** is just the colored part of a cubie that’s visible on the surface.

That totals 54 facelets across the entire cube.
Each facelet is a sticker or tile that shows the cube’s color at that position.

A **cubie** is the actual physical piece (corner, edge, or center) that makes up the cube.

- Center cubies have 1 facelet.
- Edge cubies have 2 facelets.
- Corner cubies have 3 facelets.

# Orientation of Corner Pieces

Each corner position on the cube has 3 spots where stickers go - like 3 little pockets:

Pocket 1 (top face)
Pocket 2 (front face)
Pocket 3 (right face)

The LEGO Block Has 3 Colors

Each corner piece has 3 colors painted on it:

Color 1 (maybe red)
Color 2 (maybe white)
Color 3 (maybe blue)

What Happens When You Twist?

Normal position (not twisted):

Color 1 goes in Pocket 1
Color 2 goes in Pocket 2
Color 3 goes in Pocket 3
Twisted once (orientation = 1):

Color 1 goes in Pocket 2 (shifted over!)
Color 2 goes in Pocket 3
Color 3 goes in Pocket 1
Twisted twice (orientation = 2):

Color 1 goes in Pocket 3
Color 2 goes in Pocket 1
Color 3 goes in Pocket 2