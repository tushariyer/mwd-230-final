# WinBall Survivor
----
#### By Tushar Iyer
----

[![Logo](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Logo/DarkOrb.jpg)](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Logo/DarkOrb.jpg)

### Version 1 Released! https://github.com/tushariyer/mwd-230-final/releases/tag/1.0

WinBall Survivor is a game I made for my Game Design (MWD 230) final project. It includes several standard assets and UI kits..

  - Navigate to the source code folder
  - Download .zip file
  - Magic

You can also:
  - Go to the 'Builds' folder
  - Download the macOS/Windows executable
  - Go to [my website](http://winball.tushariyer.co) to play online

### Objective
----
The objective of this game is to get to the WinBall. You have spawned on an unfamiliar terrain and you are dying. Your health is falling and only the WinBall can help you. Use the HealthPacks along the way to bolster your reserves. Be careful not to traverse over cliffs, or you might not have enough health to make it back up.  

> # The objective of this game is to get to the WinBall.
> You have spawned on an unfamiliar terrain and you are dying. 
> Your health is falling and only the WinBall can help you.
> Use the HealthPacks along the way to bolster your reserves.
>  Be careful not to traverse over cliffs, or you might not have enough health to make it back up.
> 
> Good luck.

### Welcome
----
Welcome to your HUD. That's your viewport. The game is rendered in First-Person. You have an objective, a healthbar, and a minimap. For those of you that enjoy knowing how the game performs, theres an FPS counter as well. Refer below to see the HUD setup:
[![HUD](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/HUD.png)](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/HUD.png)

----
Heads-Up Display
----
* Top Left: Active HUD. This shows you the current objective and your health bar. Be mindful
* Top Right: FPS Counter. Know how many frames per second you're playing at. If the number's under 30, don't be disturbed. 
* Bottom Left: MiniMap. This shows you a bird's eye view of you and your surroundings. 


### Mission Directions
----
Observe the waterfall below:
[![Waterfall](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/Waterfall.png)](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/Waterfall.png)

Go back and look at it again. You clearly just skimmed past it. Above the waterfall, there's a small oasis in the middle of the lake at the top:
[![Oasis](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/WinBall%20Location.png)](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/WinBall%20Location.png)

On that island, we have the WinBall (A.K.A. "the Orb"; according to the enemies):
[![Winball](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/winball.png)](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/winball.png)

Go Fetch!

### Console Output in Unity
----
From this we can see the ```console``` output that occurs during gameplay. I'm actually really happy to be able to say that the game runs without any warnings at all! the ```Debug.Log();``` statements are written in to various classes and are triggered when certain events fire. If you open the project in Unity and test, you'll see how the console notifies you of the coordinates at which the enemies/healthpacks spawn. They're visisble on the minimap as well!

[![Console](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/Console%20Output%20-%20Spawning.png)](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/Console%20Output%20-%20Spawning.png)


### Test Data
----
Head over to the Test Builds directory to see the game in its various stages of development. The earlier builds are all built for macOS, so you might need to borrow a laptop for it. I made a windows build once I reached beta. I'll have a Windows and macOS version of the GM build in the Builds folder once I'm done. That's all.

### Controls
----
The controls are fairly simple. Use the ```W``` ```A``` ```S``` ```D``` keys to navigate and strafe. Your mouse controls directional input. Use ```Space``` to jump and ```Shift``` to sprint. You also have a very very very very flappy sword. Hit ```F``` to use it. Hope that helps.

### Enemies
----

We're (by we're, I mean me) proud to state that this game has three kinds of enemies. 
> A Sentry, which is an enemy that stays in one spot and looks at you. It will not attack, lest you enter its 15 foot radius. Then God help you.
> A Passive enemy, which roams the land aimlessly. This enemy just wants to be alone, and won't hurt you unless you touch it. Then it's your fault. Don't come to me and complain.
> An Aggressive enemy; who randomly goes about the terrain. Don't be fooled, these look similar to the Passive Enemies but have a slightly darker side (get it? They're all black). If these see you, they will follow you. They will find you, and they will kill you. :)

### HealthPacks | Static Packs
----

So what's the difference between the two? Nothing really. Static Packs can be found around the map, prespawned, and healthpacks will spawn only in your hour of need in a location near you. So move around and explore, you'll never be too far from a health pack when you need it. 

[![HealthPacks](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/health-static.png)](https://raw.githubusercontent.com/tushariyer/mwd-230-final/master/Test%20Data%20(Unfinished%20Versions)/Renderings/health-static.png)

### Tech
----
WinBall Survivor uses a couple of open source assets to work:

* Unity's Default asset kit
* Unity's UI/Cinematic Effects & WaterFX
* Campfire [Free]
* IslandAssets [Free]
* Attack Jump & Hit Damage Human Sounds [Free]
* Nature Starter Kit 2 [Free]

And of course WinBall itself is open source with a [public repository](https://github.com/tushariyer)
on GitHub.

### Installation
----
WinBall requires you to download the executable and double-click.

Download and discover [Unity](https://store.unity.com/products/unity-personal?_ga=1.202645457.1591437004.1467993975).


### License
----

MIT
----

[![Unity](https://dannagle.com/unityscreenshots/windows7_madewithunity.png)](https://store.unity.com/products/unity-personal?_ga=1.202645457.1591437004.1467993975)

***Wooo! Cool game!***
