# Point Kinematics

This project is a Windows Forms application (C#, .NET Framework) that demonstrates basic point kinematics, such as position, speed, and acceleration, based on a specific motion law. The code is developed as a lab assignment with specific requirements governing how the user interface is set up and how the program behaves in calculation and testing modes.

## Table of Contents

1. [Description](#description)
2. [Features](#features)
3. [Assignment Constraints](#assignment-constraints)
4. [Project Structure](#project-structure)
5. [Requirements](#requirements)
6. [How to Run](#how-to-run)
7. [Usage](#usage)

---

## Description

The application calculates the kinematics of a moving point based on the motion law:
`x(t) = sin(πt / 4)    v(t) = (π / 4) * cos(πt / 4)    a(t) = - (π / 4)² * sin(πt / 4)`
It provides two modes:

1. **Calculation Mode** – The program fills text boxes with computed values (coordinates, speed, and acceleration) for three different time moments.
2. **Testing Mode** – The program checks user-entered values against the expected calculations and highlights the text boxes in red if the value is correct (as per the assignment requirement, the color is red for correct answers).

Time intervals can be changed by clicking on the time labels, which displays a modal dialog allowing the user to adjust the time step.

---

## Features

- **Fully Programmatic UI**  
  Labels, text boxes, and buttons (except for the group with two radio buttons in the design) are created at runtime.

- **Calculation**  
  Fill in three sets of text boxes with position, speed, and acceleration values for `t = 0, t = timeStep, t = 2 * timeStep`.

- **Testing**  
  In testing mode, users can manually enter values. A button click then checks if the values are approximately correct and highlights the boxes accordingly.

- **Interactive Time Step**  
  Click on any time label to open a dialog that changes the interval between time points.

- **Tooltips**  
  In testing mode, hovering over text boxes displays the formula used for that value, as a hint.

---

## Assignment Constraints

1. Only a group box with **two radio buttons** (for operating modes) is placed on the form at design time.
2. Labels and buttons are created **programmatically**.
3. Text boxes are created **programmatically**, grouped in arrays (for coordinates, speed, and acceleration).
4. The motion law is specified by the lab assignment (`x(t) = sin(πt / 4)`).
5. The group box is used to select the operating mode:
   - **Calculation Mode**: button text changes to "Calculate", text boxes become read-only, and are cleared before displaying new results.
   - **Testing Mode**: button text changes to "Check", text boxes become editable, are cleared, and the focus is set to the first text box.
6. Clicking on the time labels opens a modal window where the user can set a new time step.
7. Tooltips showing the formulas appear in **Testing Mode**.

---

## Project Structure

---

## Requirements

- **.NET Framework 4.x** or compatible.  
- **Visual Studio 2019** (or later) recommended.

---

## How to Run

1. **Clone this repository**:
`   git clone https://github.com/AnnMarko/Point-Kinematics.git
   cd point-kinematics`

2. Open the project in Visual Studio:
- Double-click the lab9.sln or open it via File > Open > Project/Solution.

3. Build and Run:
- Press F5 (or select Debug > Start Debugging).

## Usage

### Select the Mode via Radio Buttons

- **Calculation Mode**  
  Click **Calculate** to fill the text boxes with position, speed, and acceleration values.

- **Testing Mode**  
  1. Manually enter values in the text boxes.  
  2. Click **Check** to verify correctness.  
     - Correct answers turn **green**.  
     - Incorrect answers turn **red**.

### Change the Time Step

1. Click on any time label (`t = 0`, `t = timeStep`, or `t = 2 * timeStep`).  
2. In the modal dialog that appears, enter a new integer value.  
3. The time labels and their associated text boxes will update accordingly.

### Tooltips

- While in **Testing Mode**, hover over any text box to see the formula used to calculate its value.
