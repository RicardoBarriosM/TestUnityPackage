using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class TestMenu
{
    [MenuItem("Test Menu/Do Something")]
    public static void TestCommand ()
    {
        Debug.Log("This is a test command");
    }
}
