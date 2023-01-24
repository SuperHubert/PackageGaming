using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Logs : MonoBehaviour
{
    [Conditional("DEBUG")]
    public static void Log(string text)
    {
        UnityEngine.Debug.Log(text);
    }
}
