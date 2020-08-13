using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [TextArea(3,10)]
    public string[] sentences;
    public string name;
    public bool answer;
    public bool showInfos;
    public Material diagCam;
    public enum Mood { Normal, Happy };
    public Mood mood;
}
