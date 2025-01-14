﻿using AnthaGames.Assets.Scripts.DialogueSystem.ScriptableObjects;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class DialogueBox
{
    public GameObject Go { get => _go; }
    public Image Figure { get => _figure; }
    public TMP_Text Name { get => _name; }
    public TMP_Text Message { get => _message; }
    public ChoiceBox ChoiceBox { get => _choiceBox; }
    public Button AdvanceButton { get => _advanceButton; }
    

    [SerializeField] private GameObject _go;
    [SerializeField] private Image _figure;
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _message;
    [SerializeField] private Button _advanceButton;
    [SerializeField] private ChoiceBox _choiceBox;

    public void ShowChoices(List<Choice> responses, DialogueManager dialogueManager)
    { 
        ChoiceBox.Show(responses, dialogueManager); 
    }
}
