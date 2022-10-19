# DECO3801 - UNI-VERSE
## Description
Welcome to Uni-verse! Uni-verse is the next step in online collaborative learning that the team "This is Fine" has developed. This repository will contain the source code for the Unity application we will use to prototype/demo the product. The final prototype demonstrates the core concepts that set this platform apart from existing platforms. These features being the avatar creation systems, improved collaboration amendments (areas for avatars to interact, virutal meeting rooms, conventional educational tools), and a preview into the 'all in one' feel that can be achieved. Please see below for instructions on how to set up the build for yourself!

## Relevent Links
1. Link to Repository: https://github.com/JacobB69420/Deco3801Unity
2. Link to Demonstration of Working Prototype:

## Initial Set Up from repository:
1. Go to Unity Hub and create a new project. 
2. Clone this repository to desired location on local device. 
3. Copy any of the folders in your Unity project that are not in the cloned repository into the repository. (Files like library which are too large to be uploaded to git hub)
4. Go to Unity Hub, click open and select the cloned repository. You should now be able to view the full project. 
5. Call git pull on the repository in bash to make sure everything is up to date. You should now be able work on and commit changes to the project. 
## Required Unity Packages
1. PUN - Photon Engine
2. Free Draw - Simple Drawing on Sprites/2D Textures
Please ensure you import these assests into the project before attempting to build.
### Setting up Photon Unity Package:
1. Click "Add to My Assets" on the following URL. https://assetstore.unity.com/packages/tools/network/pun-2-free-119922
2. This should open the Package Manager in Unity, click Import Package.
3. Hopefully this should open the PUN setup wizard. If not (on the filebar) click Windows -> Photon Unity Networking -> PUN Setup Wizard.
4. Click Setup Network
5. Copy in the following appID: c2e57944-8585-48cd-9534-f69abc75d0e1

You should now have Photon installed and the app should compile correctly.

## Instructions to Build/Compile from repository
1. Ensure you have done the initial respository set up correctly.
2. Ensure you have imported the required assets into the build, and set up PUN. 
3. Open the project from Unity Hub. 
4. In project, navigate to Assets -> Scenes -> Login and open the scene.
5. Navigate to File -> Build Settings and click 'Add open scenes'.
6. Now repeat this process for all other scenes. (Located in Assets -> Scenes , Assets -> CharacterCreator -> Scenes and Assets -> AvatarCreator -> Scenes).
7. Once done, in Build Settings click 'Build' and select where to store the build on your PC.
8. You can now execute the .exe file and run the full build. 

## Dependencies
1. Unity Hub, 3.2.0 and higher.
2. Unity Editor, 2021.3.8f1 and higher.
3. Visual Studio, Latest.
4. PUN - Photon Engine, 2.41.

## References
https://github.com/tutmo/2D-Character-Creator
