# Unity AR Project Template

Start a new Unity AR Foundation project using this template.

## Getting Started

This template is preconfigured for AR Foundation 5.1.0-pre.8 which includes the XR Simulation Environment for fast iteration of your project.

It also includes the XR Interaction Toolkit 2.3.2 to quickly add interactable functionality to augmented reality projects.

### Prerequisites

```
 - Git client
 - Unity Editor version 2023.1.0b1 or newer
```

## Installing

Follow these steps to create a project from this template and get it running in Unity on your computer.

* Click `Use this template` button in the upper right of the Github page where you found this
* Configure your repository and click `Create repository from template`
* Clone your new repository to your machine
* In Unity Hub, click `Add project from disk`
* Open your project in Unity!

## Usage

This project includes basic XR Simulation and a simple XR Interactable to demonstrate simulating augmented reality within the Unity editor.

There are two buttons on the AR Session in the project hierarchy:
* Enable Touch Simulation - use this when you want to interact as if you were touching the screen of a mobile device
* Disable Touch Simulation - use this when you want to "fly" around the simulation as if you were moving a mobile device through space

**Note:** You can move the buttons to any GameObject you like by adding the Tools script to it.

When Touch Simulation is disabled, hold down the right mouse button and rotate the mouse to rotate the view.

While holding down the right mouse button:
* Use WASD to move forward, left, back, and right respectively
* Use Q and E to to lower and raise the simulated device height respectively


### Run the project

* Fly around the simulation to detect planes in a simulated backyard environment
* Enable Touch Simulation (see above)
* Click a detected plane in the editor - a cube should be placed where you click
* Click the cube to select it - a semi-transparent cube should appear around the selected cube
* Click the selected cube and drag it - it should move within the bounds of the detected plane

**Note:** If your simulated environment includes horizontal and vertical planes, and they've been detected in a way that they touch, you should be able to drag the selected cube between them.



## Authors

* **Jason Harrison** - [JasonSpatial](https://github.com/JasonSpatial)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
