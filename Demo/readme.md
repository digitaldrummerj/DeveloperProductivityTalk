# Script for the demos for the Developer Productivity Talk

**Author:** Justin James

**Twitter:** @digitaldrummerj

## Section 1: Windows Programs

* Launchy
	1. Google Search
	2. Custom Links (BG / GH )
* Greenshot
* Last Pass
* Feedly
* Pocket
* Chocolatey
* Dropbox
* Vagrant
* Kanbanflow.com 
* Todoist
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
1. Properties Snippets
1. ErrorTrapping
1. Misc

**Surrounds With Code Snippets**

1. Ctrl + K, S


### Code focused IDE

1. Open AccountController
1. Suspend Resharper
1. Notice greyed out using statements.
1. Go to ExternalLogin Method
1. Highlight 2nd parameter to the ChallengeResult constructor
1. press Ctrl + Period
1. Note the introduce Local and extract a method options with preview
1. Select introduce local
1. Rename window show, type redirectUri
1. Click Apply button
1. Highlight "ExternalLoginCallback" string 
1. Press Ctrl + Period
1. Select option to introduce constant for all occurrences
1. Name constant ExternalLoginCallbackConstant
1. Hold mouse over Url.Action within ExternalLogin method.  Note parameter colorized
1. Collapse ExternalLoginMethod and hover over with mouse
    * Now shows full color
    * Full Method declaration


### Javascript Editor

1. load jquery-1.10.2.js
1. Has navigation bar
1. Collapse and Expand other code blocks such as multi-line comments and if statements
1. //TODO comments suppported
1. open _references.js
1. Add following

        function add(lhs, rhs)
        {
            return lhs + rhs;
        }

1. Add //TODO to add function
1. Load Task List Window (View Menu)
1. JSDoc Format show for intellisense

        /**
        * Adds Two Numbers
        * @returns {Number} Sum of input numbers
        */
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



##Visual Studio 2015 Debugging** 

**Breakpoint Configuration**

1. Expense Solution
1.  Breakpoints to set
    * MainWindowViewModel.cs, line 164
    * RepositoryService.cs, Line 17, 20, 36
1. RepositoryService.cs
1. Breakpoint on opening brace for GetEmployeeAsync 
1. Hold Mouse over red breakpoint indicator
1. 2 icons: 

    * Modify settings
    * On/Off Breakpoint
1. Breakpoint settings are inline!!
1. 2 categories initially show, Conditions and Actions
1. Select Conditions 
    * Look at options avaiable
    * Set conditional Expression: "Is True" employeeAlias == "kimakers"
1. Also possible to add Actions
    * Option to log message to Output window
    * $FUNCTION, Thread: $TID $TNAME
    * Uncheck "Continue execution" for action
1. Close breakpoint settings window

**Exception Settings**

1. Debug -> Windows -> Exception settings
1. Grouped 
1. Filter button on left
1. pick option "Show Only Enabled Exceptions"
1. Quick search
1. EndpointNotFoundException 
1. Check that exception

**Diagnostic Tools Window and Perftips**

1. Open Expense project
1. Set Multiple start projects
1. Set Expenses.WCF to "Start without debugging"
1. Set Expsnses.WPF to "Start"
1. Click ok
1. F5 
1. Breakpoint from earlier should be hit
1. Go to Diagnostics Tools Window
    * Debug -> Show Diagnostic Tools
1. Can monitor performance while debugging
1. However over break point to get elapsed duration
1. Click on the red rectangle break event.  Notice debugger tab
1. F10 to step in the debugger and notice timeline update
1. Place breakpoint onbefore using line that returns Employee object from WCF
1. F5 to go to next breakpoint
1. Diagnostic Tools window auto updated to start the time you pressed F5 and end at current breakpoint
1. Code Editor performance tips.  
    * NO MORE StopWatch or other utilities

**Lambda Expression Debugging**

1. Open MainWindowViewModel.cs
1. Set breakpoint in the ShowChargersAsyc method within the "Continue With" callback
1. F5 to continue to breakpoint
1. Immediate Window
    * charges.Result.Where((c) => c.BilledAmount < 100).Count()


**Additional Features**

1. Edit and Continue
    * Adding methods, fields, indexers, delegates
    * Modifying bodies of constructors
    * Adding or modifying methods using async/away, dynamic objects, iterators
    * Reordering type members and type parameter constraints
    * Refactorying code using extract method and inline temporary variable
1. Update RepositoryService.GetEmployeeAsync using statement
1. F10 to step through the code
1. See memory usage tab in Diagnostic Tools Window


**Timeline Tool**

1. Open BlankXamlApp
1. F5
1. Look at Diag Tools Window see all the events
1. Stop the debugging session
1. VS 2013 XAML UI Responsive tool  rename to Timeline tool.
1. Debug -> Start Diagnostic Tools without Debugging
1. Select Timeline Tool
1. Play with application
1. Stop debugging
1. Look at UI thread utilization graph
1. Zoom into a section with layout activity and further drill down
1. Select Sort by dropdown and pick Duration
1. Drill into layout nodes
1. **Fixing Perf Issues:**

    * Open MainPage.xaml
    * Find GridView declaration
    * Place cursor on the event handler assignment for ContainerContentChanging and press F12
    * Change Utility.LongOperation(); to

            Task.Run(() =>
            {
                Utility.LongOperation();
            });

1. **Verifying Fix**
    * Run Timeline Tool again and perform similar test
    * Stop profiler and view report
    * Note that UI thread utilization % is much less than before.


### C# 6 Enhancements 

1. Auto properties getter only
1. Init Auto Properties
1. reference Static classes in using statements
1. String.Format
1. ToString lambda
1. Computed Properties lambda
1. ToJson lamba with init
1. FromJSon - null checks
1. ArgumentNullException nameof 
1.  Exception when clause
1. Async calls in catch and finally blocks
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
	1. 2013 VS Commands
		* Cancel Build on 1st Error is turned off by default
		* Tools -> Options -> VS Command 2013 -> Open Configuration
    1. 2015 - Stop On First Build Error
            * Tools -> Options -> Stop On First Build Error
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

    1. UnitTest1 -> GetUserInfo
    1. Ctrl + Shift + D


### Layouts

* **Layouts O Rama**

	1. Show Pre-Save Layouts
	1. Show How to Save Layout

* ** VS 2015 Custom Layouts**

    1. Windows -> Reset Window Layout
    1. Windows -> Save Window Layout
    1. Arrange Windows
    1. Windows -> Save Window Layout
    1. Switch between layouts (Ctrl + Alt + 1,2,3, etc)
    

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
    - Pulled out of VS 2015.  Minify File Extension 
	- Scripts -> MyScriptFile.	js
	- open File to show contents
	- Right Click in Solution Explorer to minify
	- Add Another function to MyScriptFile.js
	- Check out the min file

* **Sprites**
    - Pulled out of VS 2015
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
