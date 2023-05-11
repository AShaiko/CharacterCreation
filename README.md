# CharacterCreation
iOS demo application for creating character by getting data.

## Setup
1. Install [UnityHub](https://unity.com/ru/download)
2. Install [Unity editor](https://unity.com/releases/editor/archive) v.2021.3.23f1
3. Install [Xcode](https://apps.apple.com/ru/app/xcode/id497799835?mt=12) v.14.2 (14C18)

## Run

The project has 3 part:
- UnityCharacterCreation - Unity application part
- iOSCharacterCreation - iOS native application part
- UnityExport - generated from Unity iOS project (generated in next steps)

Application can be run ONLY by device (not simulator).

### Unity project

1. Open Unity project UnityCharacterCreation/UnityCharacterCreation.sln
2. Open SampleScene
3. Generate iOS project:
    - Select File -> Build Settings
    - Check that in Scenes In Build part there is SampleScene
    - Select iOS in Platforms
    - Click Build button
    - Select UnityExport folder in root of the project

# iOS project

1. Open by Xcode CharacterCreation.xcworkspace
2. In Unity-iPhone project select Data group and check that it include in Target Membership of Unity Framework.
3. Select connected device and RUN.

Actual for May, 2023