# Using NSubstitute in Unity
Curious how unit testing works in Unity? 

This repository contains
- A blank Unity (2019.4.29f1) project you can use as a testing bench.
- NSubstitute version `2.0.3` already installed and available for Mock interfaces.
- An example that shows how to use `Editor` test with `NSubstitute` and how to Mock an interface.
- An example on how to test your `Monobehaviour` class using the `Playmode` test option.

## Before start
1. Clone this repository
1. Create a branch for your work.
1. Push your changes to your own branch.
1. Open the project in Unity.

## Useful links
NSubstitute web site
https://nsubstitute.github.io/

NSubstitute documentation
https://nsubstitute.github.io/help.html

NSubstitute 2.0.3
https://www.nuget.org/packages/NSubstitute/2.0.3

## Installing NSubstitute 2.0.3
This steps will help you install NSubstitute library in you Unity project.

### Steps
* Download nsubstitute [package]( https://www.nuget.org/packages/NSubstitute/2.0.3) or install it using NuGet.
* Find the NSubstitute.dll located in your project.
![Finding NSubstitute library](https://github.com/eduardoperez-ng/Unity_NSubstitute_Template/blob/master/Assets/Docs/Img/importDLL.png)
* Open your Unity project.
* Create a folder called `Plugins`.
* Copy and paste `NSubstitute.dll` inside `Puglins` folder.
* Go to your Test assembly library and add a reference to NSubstitute.
![Finding NSubstitute library](https://github.com/eduardoperez-ng/Unity_NSubstitute_Template/blob/master/Assets/Docs/Img/updateAssemblyDefinition.png)

## Video tutorials

- How to use NSubstitute in Unity [here](https://www.youtube.com/watch?v=xSa2S-W7x48)
- Testing Against Monobehaviors using Mocks [here](https://www.youtube.com/watch?v=r7VkbV0PRC8)
- Writing Play Mode test [here](https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/manual/reference-attribute-unitytest.html)
- Complete tutorial on writing unit test in a game [here](https://www.raywenderlich.com/9454-introduction-to-unity-unit-testing)


## Future work 

Test NSubstitute 4.2.1

