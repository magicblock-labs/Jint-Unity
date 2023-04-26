# Jint Unity
  
Jint Unity provides an easy way to install [Jint](https://github.com/sebastienros/jint) trough the package manager and execute javascript in Unity


## ➕ Installation

* Open [Unity Package Manager](https://docs.unity3d.com/Manual/upm-ui.html) window.
* Click the add **+** button in the status bar.
* The options for adding packages appear.
* Select Add package from git URL from the add menu. A text box and an Add button appear.
* Enter the `https://github.com/magicblock-labs/Jint-Unity.git` Git URL in the text box and click Add.
* Once the package is installed, in the Package Manager inspector you will have Samples. Click on Import
* You may also install a specific package version by using the URL with the specified version.
  * `https://github.com/magicblock-labs/Jint-Unity.git#vX.Y.X`
  * Please note that the version `X.Y.Z` stated here is to be replaced with the version you would like to get.
  * You can find all the available releases [here](https://github.com/magicblock-labs/Jint-Unityreleases).
  * The latest available release version is [![Last Release](https://img.shields.io/github/v/release/magicblock-labs/Jint-Unity)](https://github.com/magicblock-labs/Jint-Unity/releases/latest)
  
## Usage

### Example 1

```csharp
var square = new Engine()
    .SetValue("x", 3) // define a new variable
    .Evaluate("x * x") // evaluate a statement
    .ToObject();
Debug.Log(square);
```

### Example 2

```csharp
Engine js = new Engine();
js.SetValue("Console",typeof(Debug));
js.Execute("function Compute() { const a = 3; const res = a * a; Console.Log('Js computation: ' + res); }");
js.Invoke("Compute");
```

### Example 3

Loading a script: 

```csharp
var source = new StreamReader(Application.dataPath + "/Resources/" + "main.js");
string script = source.ReadToEnd();
source.Close();
js.Execute(script);

```

## Dependencies

Script with dependencies can be bundled using webpack or rollup, see this [tutorial](https://pleasenophp.github.io/posts/using-real-javascript-with-unity.html) for reference.