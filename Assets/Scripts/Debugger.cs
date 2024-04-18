using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    [SerializeField] private Tester tester;
    [SerializeField] private GameObject rightHand;
    [SerializeField] private GameObject leftHand;

    [SerializeField] private TextMeshProUGUI statusText;
    [SerializeField] private TextMeshProUGUI rightHandText;
    [SerializeField] private TextMeshProUGUI leftHandText;
    [SerializeField] private TextMeshProUGUI magicWandText;
    
    private void Update()
    {
        statusText.text = $"{tester.WinSpeechRecognition.Status}";
        rightHandText.text = $"RightHand: {rightHand.transform.position}";
        leftHandText.text = $"LeftHand: {leftHand.transform.position}";
        var lumos = MagicWand.CanLumos ? "○" : "×"; 
        var nox = MagicWand.CanNox ? "○" : "×"; 
        magicWandText.text = $"{lumos}, {nox}";
    }
}
