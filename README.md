# OpenFace-Unity_HDRP



## Installation

1.Download the following:
-Unity hub: https://unity.com/download
-Unity Editor v2022.3.24f1 (when the hub is installed): unityhub://2022.3.24f1/334eb2a0b267
-A desktop app compatible with GitLab: https://gitextensions.github.io
-The project (using GitLab)
-Feedback Resources folder: https://drive.google.com/drive/folders/1M7w5lsE9E4ncZNu8HWR77qdJ0jst41af?usp=sharing

2.Copy the Resources folder to OpenFace-Unity_HDRP/Assets/

3.Import OpenFace-Unity_HDRP as a project using Unity hub

4.If you are going to modify the project, open Git Bash (should be installed with Git app) and enter the following command to avoid “too long path” error while committing the project to GitLab:
git config --system core.longpaths true

5.Open the project and open the only scene in Assets/Scenes via the Project window


## Adding new animation

1.Download and install Python: https://www.python.org/downloads/

2.Download and install FFmpeg build following the instruction below:
https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-essentials.7z
https://www.hostinger.com/tutorials/how-to-install-ffmpeg

3.Download OpenFace: https://sourceforge.net/projects/openface.mirror/

4.Download the video pre-treatment script: https://drive.google.com/drive/folders/1ZSYP_PdBIB5PjZcdl6F5-48s1jgLlTXq?usp=sharing

5.Copy OUTCOME_V_Feedback_Treatment folder you’ve just downloaded to the OpenFace root

6.Copy all the feedback videos you want to be treated to OUTCOME_V_Feedback_Treatment/Video_input

7.Launch OUTCOME_Vl_Feedback_Treatment/Video_pre-Treatment.bat” and wait till it finishes its work (it will also automatically install the necessary libraries)

8.Copy all videos from OUTCOME_V_Feedback_Treatment/Video_output to Assets/Resources/Video in the Unity project folder

9.Copy all audio tracks from OUTCOME_V_Feedback_Treatment/Audio_output to Assets/Resources/Audio in the Unity project folder

10.Copy all OpenFace CSV tables from OUTCOME_V_Feedback_Treatment/OpenFace_output to Assets/Resources/OpenFace in the Unity project folder

11.Edit Assets/Resources/FeedbackData.json and add entries for every new feedback you are adding in accordance with the following example:
    {
  		"id": 20,
  		"name": "Feedback_Name",
  	"path_OpenFace": "OpenFace/CSV_Name",
  		"path_Video": "Video/Video_Name",
  	"path_Audio": "Audio/Audio_Name"
	},
	
Don’t forget to keep the ID’s unique and separate entries with a comma. After saving the JSON, new feedbacks should appear at the end of the respective menu.

12.If you experience wobbly head animations with your feedback, replace the respective CSV in Assets/Resources/OpenFace with its analogue from OUTCOME Virtual_Feedback_Treatment/OpenFace_output_smooth. No need to edit the JSON


## OUTCOME Virtual Interface

The app interface consists of several control buttons, 2 menus and a set of settings. 

### Avatar selection menu
There are 20 diverse avatars available for the virtual agent: 10 female and 10 male, all can be chosen via the avatar selection menu in the top right corner of the screen. 

### Feedback selection menu
The Feedback performed by the selected avatar can be picked in the Feedback menu in the bottom right corner. New custom Feedbacks can be added by the user.

### Playing Feedback
In order to play the selected feedback, the user should press the Play Button in the top center. By default the virtual agent adopts only Action Unit values captured by OpenFace but there are some settings to alter that:

### Lip-sync
When active, replaces lips-related Action Units and jaw movement values with those calculated with Salsa module in accordance to the designated feedback audio track resulting in a more faithful labial expressions during speech.

### Frame Interpolation
When active, it applies interpolated intermediate Action Unit values between video frames resulting in a higher FPS and thus smoother movement than on the original video.

### Noise Reduction
When active, seeks out irregularly abrupt movements using statistical methods and smoothes them down.

### Play source video:
When active, adds a reference video player element in the background playing the active Feedback in sync with the virtual agent.

### Customizing Action Unit Conversion Parameters
Action Unit data produced by OpenFace isn’t directly compatible with the avatars in use and thus it’s being converted in real time with the results that may turn out imperfect. For that reason, there’s an option to edit the multipliers in the developer version of the app. 

For that, you need to look for the DataWindow in the Unity editor. If it’s missing, you can open it by clicking on Window/UI Toolkit/DataWindow

In case you want to revert your changes, feel free to look into the screenshot to the right

### Recording Feedback
There’s also an option to record the Feedbacks in 1080p 60fps mp4 format for further analyses. In order to record the selected Feedback, the user is to push the Record button  in the top center. The recording will start immediately however the Feedback will start playing in a few seconds for the future viewer’s comfort and for the same reason the recording will go on for a few more seconds after the Feedback stopped playing. 

Warning: you will not hear any sound produced by the app during recording! This is normal and will not affect the final videos.

The videos will be saved in the FeedbackRecordings folder in the app’s root. Recording a given Feedback for the second time will erase the old recording.

There’s also an option to record all the Feedbacks available in a batch. You can do it by pressing the Record all Feedbacks button  to the right, squeezed in between Avatar and Feedback menus. The Feedbacks will be recorded one by one in the order they are stored in the list and will be saved in separate files.

There is only one setting related to recording that will be applied in both cases.

### Hide UI on Recording :
When active, removes the UI each time before the recording has begun and restores it immediately afterwards.
