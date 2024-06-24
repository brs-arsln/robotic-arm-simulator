Robotic Arm Simulator

Project Overview

This project is a robotic arm simulator designed to classify and sort objects based on their colors using image processing techniques. The project leverages Unity, Matlab, and Blender 3D to create a comprehensive and interactive simulation environment.

Prerequisites

Software Requirements
- Unity: Version 2021.3.14f1 or later
- MATLAB: R2022a or later
- Blender: Version 2.93 or later

Hardware Requirements
- A computer capable of running the above software
- At least 8GB of RAM

Installation Instructions

Unity Setup
1. Download and install Unity Hub from the [Unity official website](https://unity3d.com/get-unity/download).
2. Through Unity Hub, install Unity version 2021.3.14f1 or later.
3. Open Unity Hub and create a new 3D project or open the existing project related to this simulator.

MATLAB and RVCTools Setup
1. Install MATLAB R2022a or later from the [MathWorks website](https://www.mathworks.com/products/matlab.html).
2. Download RVCTools (Robotics Visualization and Control Toolbox) from the [official website](http://petercorke.com/toolboxes/robotics-toolbox).
3. Unzip the RVCTools package to a directory of your choice.
4. Add RVCTools to the MATLAB path by executing the following command in MATLAB:

   ```matlab
   addpath('path_to_rvctools_directory')
   startup_rvc
   ```
   Replace `path_to_rvctools_directory` with the actual path where you unzipped the RVCTools package.

Blender Setup
1. Download and install Blender version 2.93 or later from the [Blender official website](https://www.blender.org/download/).
2. Open Blender and ensure that you have the necessary add-ons enabled for 3D modeling and exporting.

Running the Simulator
1. Unity Configuration:
   - Open the Unity project.
   - Ensure that all prefabs and scripts related to the robotic arm simulator are correctly placed in the Unity Editor.
   - Configure the Unity Editor settings as per the project requirements.

2. MATLAB Configuration:
   - Open MATLAB and navigate to the project directory.
   - Run the `TCPInit.m` script to establish a connection between Unity and MATLAB:

     ```matlab
     run('TCPInit.m')
     ```

3. Starting the Simulation:
   - Start the Unity Editor and press the Play button to run the simulation.
   - MATLAB should automatically start processing the image data and controlling the robotic arm.

Project Structure
- Assets: Contains all Unity assets including prefabs, scripts, and scenes.
- MATLAB: Contains all MATLAB scripts including image processing algorithms and control scripts.
- Blender: Contains Blender files used for 3D modeling of the robotic arm.

Troubleshooting
- Ensure that Unity, MATLAB, and Blender are correctly installed and configured.
- Verify that the MATLAB path includes RVCTools and the `startup_rvc.m` script is executed.
- Check the TCP/IP settings to ensure proper communication between Unity and MATLAB.

Contributors
- Barış Arslan 
- Alp Bora Korkmaz 
- Advisor: Assistant Professor Dr. Barış Ata

License
This project is licensed under the MIT License - see the LICENSE file for details.
