using System;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class WinSpeechRecognition : IDisposable
{
    public SpeechSystemStatus Status => _dictationRecognizer.Status;
    
    private readonly DictationRecognizer _dictationRecognizer;
    public event Action<string, ConfidenceLevel> OnDictationResult;

    public WinSpeechRecognition()
    {
        _dictationRecognizer = new DictationRecognizer();
        _dictationRecognizer.DictationResult += (t, c) => OnDictationResult!(t, c);
    }

    public void StartSpeechRecognition()
    {
        _dictationRecognizer.InitialSilenceTimeoutSeconds = 120 * 1000; // 120 seconds
        Debug.Log($"DEBUG INFO: {_dictationRecognizer.InitialSilenceTimeoutSeconds}, {_dictationRecognizer.AutoSilenceTimeoutSeconds}");
        Debug.Log("Start speech recognition, waiting for your voice.");
        _dictationRecognizer.Start();
    }

    public void StopSpeechRecognition() => _dictationRecognizer.Stop();

    public void Dispose()
    {
        _dictationRecognizer?.Stop();
        _dictationRecognizer?.Dispose();
    }
}
