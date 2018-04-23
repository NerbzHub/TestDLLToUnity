using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using TestCSharpLibrary;


public class UseDLL : MonoBehaviour
{
    
    // Straight From the c++ Dll (unmanaged)
    [DllImport("TestCPPLibrary", EntryPoint = "TestDivide")]
    public static extern float StraightFromDllTestDivide(float a, float b);

    [DllImport("RakNet", EntryPoint = "RakPeerInterface")]
    public static extern void ImportedRakPeerInterface();

    // Use this for initialization
    void Start()
    {


        /* */
        // Call the C# DLL SharpMultiply function
        float multiplyResult = TestCSharpLibrary.TestCSharpLibrary.SharpMultiply(3, 5);

        // Call the C# DLL TestDivide function which relies on the C++ DLL for this functionality
        float divideResult = TestCSharpLibrary.TestCSharpLibrary.TestDivide(15, 3);

        float straightFromDllDivideResult = StraightFromDllTestDivide(20, 5);

        // Print it out to the console
        Debug.Log(multiplyResult);
        Debug.Log(divideResult);
        Debug.Log(straightFromDllDivideResult);

        // Write the result into a file, so we can even see it working in a build
        using (StreamWriter writer = new StreamWriter("debug.txt", true))
        {
            writer.WriteLine(multiplyResult);
            writer.WriteLine(divideResult);
            writer.WriteLine(straightFromDllDivideResult);
        }
        /* */

    }

    // Update is called once per frame
    void Update()
    {

    }
}