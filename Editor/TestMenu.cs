using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestMenu : MonoBehaviour
{
    [MenuItem("Test Menu/Do Something")]
    public static void TestCommand
    {
        Debug.Log("This is a test command");
    }
}
