# Script for the demos for the Developer Productivity Talk

**Author:** Justin James

**Twitter:** @digitaldrummerj

## Section 1: Windows Programs

* Launchy
	1. Google Search
	2. Custom Links (BG / GH )
* Greenshot
* Last Pass
* Pocket
* Chocolatey
* Vagrant
* Linqpad
* Visual Studio Code (replaced my plain text editor)

## Section 2: Windows Shortcuts

* Arrange Programs
	1. Half Screen - Win + Left/Right Arrow
	1. Max/Min - Win + Up/Down
	1. Move to Next Monitor - Win + Shift + Left/Right

* Show Desktop
	1. Win + D (toggle)

* Open As Admin
	1. Win
  1. type cmd to open command prompt
  1. Ctrl+Shift+Enter (or Ctrl + Shift+ Click) to open it as admin

* Windows Explorer 
	1. Add project folders to Favorites by dragging them in to it

## Section 3: Visual Studio Productivity

* Open Demo Solution
* Collapse Projects / Collapse All

1. Power Tools collapses to folder level (Collapse Projects)
1. Resharper collapse everything (Collapse All)

### Code snippets

1. Ctrl + K, X pulls up Code Snippets
1. Logic -> BizLogic -> Snippets
1. Loops
1. PropertiesSnippets
1. ErrorTrapping
1. Misc

**Surrounds With Code Snippets**

1. Ctrl + K, S

### Debugging

1. Set Console project as Start Up
1. Set Startup Project to Service
1. Breakpoint toggle - F9
1. Run to Cursor - Shift + F10		
1. Step into Next Step - F11
1. Start Without Debugging

**Debug Attributes**

1. ( DASAT ) or BizLogic -> DebuggerAttributes -> DebugAttributeShowAndTell.cs 
1. open Console Application Program.cs and put in breakpoint
1. Run Console Application



**Visual Studio 2015 Debugging** 

### Shortcuts

* **Search**

  1.	Ctrl + Shift + f
  1. Term: Method
	1. File Type: *.cs
  1. F8 to go to next result
  1. Shift + F8 to go to previous result

* **Resharper Navigate**

  * Go to Everything - Ctrl + T
  * Go to File - Ctrl + Shift + T
  * Go to Member in File - Alt + \

* **Build** 

	1. ctrl + shift + b

* **Build Current Project** 

	1. ctrl + \\
	1. Tools -> Options -> Keyboard -> Build.BuildSelection 

* **Debug**

	1.  F5
* **Start without Debug** 

	1. ctrl + f5




### Visualizer / Regions / Mixed Tabs

* **Structure Visualizer**
	1. Structure Visualizer is what add the column guides
	1. Tools -> Options -> Productivity Power Tools

* **I Hate Regions**
	1. Not Allowing Collapse of Region is Off by Default
	1. Tools -> Options -> Disable Regions

* **Fix Mixed Tabs**
	1. Productivity Power Tools
	1. Can change tabs to spaces or keep tabs

### Cancel Build 1st Error

* **Cancel Build on First Error**
	1. Add BizLogic -> CopyProjectReferences.cs
	1. Build 
	1. VS Commands
		* Cancel Build on 1st Error is turned off by default
		* Tools -> Options -> VS Command 2013 -> Open Configuration
	1. Right Click on Interface project and select copy as reference
	1. Right click on BizLogic References and Select Paste Reference

### Open Cmd / Folder

* **Open Command Prompt**
	1. Open Cmd
	1. Productivity Power Tools

* **Open Containing Folder**
	1. Productivity Power Tools

### Peek / GoTo Definition / GhostDoc
* **Peek Definition / Go To Definition**
	1. Open Tests -> UnitTest1.cs
	1. F12 to go to definition
	1. Alt+F12 to Peek Definition
* **GhostDoc**

### Layouts

* **Layouts O Rama**

	1. Show Pre-Save Layouts
	1. Show How to Save Layout

### Switch Startup Project

* **Switch Startup Project**
	1. Show how to configure different startup projects


### VS Commands

* Sync Zoom Levels
* Keep Docs Open when reloading project
* Debug as Different User

### Task Runner

* Gulp/Grunt
* Open Solution / Pre-Build / Post-Build / Clean

## File Nesting

* Open Web Project -> Scripts
* Select Angular and Auto Nest
* Select Jquery-1.8.2 except min
* ctrl+alt+n
* select jquery-1.8.2.min.js
* Select jquery-ui-1.8.24.js
* ctrl+alt+n
* selectc jquery-ui-1.8.24.min.js

## Web Essentials

*  **Minification**
	- Scripts -> MyScriptFile.	js
	- open File to show contents
	- Right Click in Solution Explorer to minify
	- Add Another function to MyScriptFile.js
	- Check out the min file

* **Sprites**
	- Tools -> Options -> Web Essentials -> Sprite
	- Turn on Run on Build
	- Select Web -> Images -> orderedList*.png 
	- Right-Click -> Web Essentials -> Create Sprite
	- Change from Vertical to Horizontal
	- Build and see if change

* **Markdown Editor** 

## Mads Is Awesome [http://tinyurl.com/madsisawesome](http://tinyurl.com/madsisawesome)

* Add New Empty File
* Json Schema Generator

## Resharper

* Navigation

	- Go To File: Ctrl + Shift + T
	- Go To Member: Alt + \
	- Rabbit Hole (Everything): Ctrl + T

* Find In Solution Explorer
	- Alt + Shift + L


* CamelHumps

	- Find File
	- Find Method
	- new Method

* Remove Redundant Code
* Code Cleanup
	- Unit test -> Reformat then Full
* Unit Test Runner
