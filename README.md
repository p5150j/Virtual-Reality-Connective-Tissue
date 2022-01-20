# Welcome to Virtual-Reality-Connective-Tissue!!

This is an experimental repo for exploring a new way of interfacing with a immersive virtual worlds and the relation of interacting with real world digital hardware systems that run our daily lives. For past and ongoing experiments see the [wiki here](https://github.com/p5150j/Virtual-Reality-Connective-Tissue/wiki) and [project board here](https://github.com/p5150j/Virtual-Reality-Connective-Tissue/projects/1)

## To get this repositopry up and running you will need:

 - Windows 10/11 
	 - Intel i5-4590 / AMD Ryzen 5 1500X or greater,  
	 - NVIDIA  GTX 1060 / AMD Radeon RX 480 or greater, 
	 - 16GB+ RAM, 
	 - 1x USB 3.0 ports 
  - macOS and linux distros have issues with GFX card and driver support still so beware if you are going to try 
  - Oculus quest or [Oculus quest 2 headset](https://www.oculus.com/quest-2/)  and `OS build 34.0 +`
	  - this project is HMD agostic, but as quest is the market leader in consumer grade HMDs we use this
	  - An Oculus dev account [developer.oculus.com](https://developer.oculus.com/)
   - Install Unity hub https://unity3d.com/get-unity/download 
     - Make sure you install `Unity 2020.3.25f1 LTS`
     - Additional unity modules (*Visual Studio dev tools, Android build support [sdk, ndk, openJDK]*)
     - [Oculus Integration](https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022) Unity package
     - [OpenXR Plugin](https://docs.unity3d.com/Manual/com.unity.xr.openxr.html) 
	     - with Air link support *(helps with streaming and reduces the need for a full build when testing*)
    - [Side quest](https://sidequestvr.com/setup-howto) for APK and deploy to device managment (unity build and run is clunky and this is much smoother IMHO)
    - [Android studio](https://developer.android.com/studio) 
    - [Oculus quest desktop app](https://www.oculus.com/download_app/?id=1582076955407037) 
	    - [Air link configured](https://support.oculus.com/airlink/) for steaming psudeo builds (*no need to to a full build when testing, steam over wifi*)
    - An array of wifi ready IoT devices 
	    - We will be using raspberry pi as our core controller but each experiment will have its own needs and will be found in the [experiments wiki section](https://github.com/p5150j/Virtual-Reality-Connective-Tissue/wiki)
    - [Postman](https://www.postman.com/downloads/) or [Insomnia](https://insomnia.rest/download) rest client tools, this helps when debugging payload interfaces between VR and IoT

### Addtional tools we can see using in the future (not needed ATM):
Media related:
-  Oculus [Mixed reality video capture](https://developer.oculus.com/downloads/package/mixed-reality-capture-tools/) desktop app
	- Oculus [headset app](https://www.oculus.com/experiences/quest/2532132800176262/) for the HMD
	- Configured and [controllers tracked](https://support.oculus.com/articles/in-vr-experiences/social-features-and-sharing/quest-2-mixed-reality-capture/)
- [OBS studio](https://obsproject.com/) and the Oculus MRVC plugin installed 
- Green screen
- Photography lighting 
- Sony a7iii or higher end DLSR camera able to do 4k video capture 
- 4k Camlink
