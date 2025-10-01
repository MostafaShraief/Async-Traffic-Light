# Async Traffic Light

This project is a simple Windows Forms application that simulates a traffic light. It was created as a learning exercise to practice and demonstrate asynchronous programming in C# and the creation of custom user controls.

## Purpose

The primary goal of this project is to apply and understand asynchronous programming (`async`/`await`) in a real-world scenario. The traffic light's state changes (from red to green to orange) are managed using asynchronous methods to prevent the UI from freezing.

A secondary goal is to learn how to create and use custom controls in a Windows Forms application. The traffic light itself is a reusable user control (`ucTrafficLight`).

## Features

*   A visual representation of a traffic light.
*   The traffic light cycles through red, green, and orange states automatically.
*   The light changes are handled asynchronously, ensuring a responsive user interface.
*   The traffic light is implemented as a self-contained, reusable user control.

## Technologies Used

*   **C#**
*   **Windows Forms (.NET Framework)**
*   **Async/Await** for asynchronous operations.
*   **User Controls** for creating reusable UI components.

## How to Run

1.  Clone the repository.
2.  Open the `my Traffic Light.sln` file in Visual Studio.
3.  Build the solution.
4.  Run the application.
