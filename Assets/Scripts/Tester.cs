using TMPro;
using UnityEngine;

public class Tester : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    
    private WinSpeechRecognition winSpeechRecognition;
    
    void Start()
    {
        winSpeechRecognition = new WinSpeechRecognition();
        winSpeechRecognition.OnDictationResult += (t, c) =>
        {
            Debug.Log("YOU:" + t);
            text.text = t;
            MagicWand.CastSpell(t);
        };
        winSpeechRecognition.StartSpeechRecognition();
    }
}