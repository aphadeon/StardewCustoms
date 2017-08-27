# StardewCustoms

[![Github All Releases](https://img.shields.io/github/downloads/atom/atom/total.svg)]()
[![GitHub issues](https://img.shields.io/github/issues/badges/shields.svg)]()
[![license](https://img.shields.io/github/license/mashape/apistatus.svg)]()

--------------------------------

An SMAPI mod for modders, to simplify the addition of custom content.  Notably it focuses primarily on ease of use, with flexibility being directly second.

##### _This is an early work-in-progress. As such it may or may not work as intended, and is not yet recommended for production use whatsoever. Please stay tuned._

###### Features:
 * Still working on basic item support

###### Future plans/ideas (subject to change):

 * Custom machines, with custom recipes and animations
 * Custom maps (using something like Tiled)
 * Custom weapons/armors
 * Custom forage items
 * Custom quest items/quests
 * Custom NPCs
 * Custom ResourceClumps and LargeTerrainFeatures
 * Custom Crops
 * Custom TV stations
 * NPC Schedule modifications

-----

### Usage (for players):

This mod may be a prerequisite for a mod you'd like to play.  If so, simply install this mod normally into your SMAPI _/mods/_ folder, and you should be good to go.

-----

### Usage (for modders):

You will need to ensure that your mod can access this one. I'm still working on the details of dependant mods in SMAPI, and will post more details here as I learn them.  But regardless, you will need to add a reference to this mod's DLL to your project, though ideally you should _not_ need to include this mod inside your own mod's folder.

You will need to create an instance of StardewCustoms.CustomObject. If the instance members don't provide  the functionality you need, you can extend the class and override any of its virtual methods to push the boundaries even further.

```C#
StardewCustoms.CustomObject myObject = new StardewCustoms.CustomObject("exampleMod", "myObject");
```

Notably CustomObject does _not_ extend StardewValley.Object; the behind-the-scenes of this middleware are rather complex and quite potentially subject to change, should future updates of either the game or this mod break the current design.  So instead CustomObject is our own specification, and efforts will be made to preserve the integrity of this data structure across updates.

Once you have your CustomObject instance, you will need to register the object, by calling

```C#
StardewCustoms.CustomObjectHandler.registerCustomObject(myObject);
```

-----

### License:
All code and content hereunder, notably excluding any bundled dependencies (detailed below), is licensed under the MIT open source license.

Copyright © 2017 avarisc

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

-----

### Dependencies:

 * [Harmony](https://github.com/pardeike/Harmony) [included as binary, as I couldn't find a NuGet package] [MIT Licensed]
 * [SMAPI](https://github.com/Pathoschild/SMAPI/) [not included] [LGPL licensed]

-----
### Contributing:

Want to contribute? Comment or submit a pull request - as time permits, I'll review and implement (or work with you to do so).