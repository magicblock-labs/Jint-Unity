using Jint;
using UnityEngine;

public class RunJs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Read form file
        // var source = new StreamReader(Application.dataPath + "/Resources/" + "main.js");
        // Debug.Log(source);
        // string script = source.ReadToEnd();
        // source.Close();
        // js.Execute(script);
        
        // Example 1
        var square = new Engine()
            .SetValue("x", 3) // define a new variable
            .Evaluate("x * x") // evaluate a statement
            .ToObject();
        Debug.Log(square);
        
        // Example 2
        Engine js = new Engine();
        js.SetValue("Console",typeof(Debug));
        js.Execute("function Compute() { const a = 3; const res = a * a; Console.Log('Js computation: ' + res); }");
        js.Invoke("Compute");
    }
}
