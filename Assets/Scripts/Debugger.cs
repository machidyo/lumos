using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows.Speech;

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
        statusText.color = tester.WinSpeechRecognition.Status == SpeechSystemStatus.Stopped ? Color.red : Color.green;
        statusText.text = $"{tester.WinSpeechRecognition.Status}";
        rightHandText.text = $"RH: {rightHand.transform.position}";
        leftHandText.text = $"LH: {leftHand.transform.position}";
        magicWandText.color = MagicWand.CanLumos || MagicWand.CanNox ? Color.green : Color.black;
        magicWandText.text = MagicWand.CanLumos ? "Lumos" : MagicWand.CanNox ? "Nox" : "No Magic";
    }
}
