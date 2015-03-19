# Script for the demos for the Developer Productivity Talk

**Author:** Justin James

**Twitter:** @digitaldrummerj

## Section 1: Windows Shortcuts

* Arrange Programs
	1. Win + Left/Right Arrow
	1. Win + Up/Down
	1. Win + Shift + Left/Right

* Show Desktop
	1. Win + D (toggle)

* Open As Admin
	1. Win, type program to open, Ctrl+Shift+Enter (or Ctrl + Shift+ Click) to open it as admin

* Windows Explorer 
	1. Add project folders to Favorites by dragging them in to it

## Section 2: Visual Studio Productivity

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

### Shortcuts

* Search
	1. Term: Method
	1. File Type: *.cs

* Build 

	1. ctrl + shift + b
* Build Current Project 

	1. ctrl + \\
	1. Tools -> Options -> Keyboard -> Build.BuildSelection 
* Debug

	1.  F5
* Start without Debug 

	1. ctrl + f5

### Debugging
	* Set Console project as Start Up
	* Set Startup Project to Service
	* Breakpoint toggle - F9
	* Run to Cursor - Shift + F10		
	* Step into Next Step - F11

**Debug Attributes**

* ( DASAT ) or BizLogic -> DebuggerAttributes -> DebugAttributeShowAndTell.cs
* 


###Group - Visualizer / Regions / Mixed Tabs

1. Structure Visualizer
* Structure Visualizer is what add the column guides
* Tools -> Options -> Productivity Power Tools

1. I Hate Regions
* Not Allowing Collapse of Region is Off by Default
* Tools -> Options -> Disable Regions

1. Fix Mixed Tabs
* Productivity Power Tools
* Can change tabs to spaces or keep tabs

### Group - Cancel Build 1st Error

1. Cancel Build on First Error
* Add BizLogic -> CopyProjectReferences.cs
* Build 
* VS Commands
		* Cancel Build on 1st Error is turned off by default
		* Tools -> Options -> VS Command 2013 -> Open Configuration
* Right Click on Interface project and select copy as reference
* Right click on BizLogic References and Select Paste Reference

### Group - Open Cmd / Folder

1. Open Command Prompt
	* Open Cmd
	* Productivity Power Tools

1. Open Containing Folder
	* Productivity Power Tools

### Group - Peek / GoTo Definition / GhostDoc
1. Peek Definition / Go To Definition
* Open Tests -> UnitTest1.cs
* F12 to go to definition
* Alt+F12 to Peek Definition
* GhostDoc

### Group - Layouts

1. Layouts O Rama

* Show Pre-Save Layouts
* Show How to Save Layout

### Group - Switch Startup Project

1. Switch Startup Project
* Show how to configure different startup projects


### Group - VS Commands

1. Sync Zoom Levels
1. Keep Docs Open when reloading project
1. Debug as Different User

### Group - Task Runner

## File Nesting

* Open Web Project -> Scripts
* Select Angular and Auto Nest
* Select Jquery-1.8.2 except min
* ctrl+alt+n
* select jquery-1.8.2.min.js
* Select jquery-ui-1.8.24.js
* ctrl+alt+n
* selectc jquery-ui-1.8.24.min.js

## Group - Web Essentials

*  Minification
	- Scripts -> MyScriptFile.	js
	- open File to show contents
	- Right Click in Solution Explorer to minify
	- Add Another function to MyScriptFile.js
	- Check out the min file

* Sprites
	- Tools -> Options -> Web Essentials -> Sprite
	- Turn on Run on Build
	- Select Web -> Images -> orderedList*.png 
	- Right-Click -> Web Essentials -> Create Sprite
	- Change from Vertical to Horizontal
	- Build and see if change

* Markdown Editor 
* JSHint


## Group: Mads Is Awesome

* Add New Empty File
* Json Schema Generator

## Group: Resharper

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