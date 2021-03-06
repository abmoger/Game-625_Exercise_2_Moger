﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct Line
{
    public Character character;

    [TextArea(2, 5)] public string text;
}

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation")]
public class Conversation : ScriptableObject
{

    public int blockNumber;
    public bool isQuest;
    public bool isLeveling;
    public EndingType endingCon;
    public enum EndingType { question, nextDialogue, noFollowup }
    public Question question;
    public Conversation nextConversation;

    public Character speakerLeft;
    public Character speakerRight;
    public Line[] lines;

}
