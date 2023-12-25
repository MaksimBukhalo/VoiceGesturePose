using LeastSquares.Undertone;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceComandExample : MonoBehaviour, IVoiceTracker
{
	[SerializeField] private Text _voiceCommandText;

	[SerializeField] private SpeechEngine _speachEgine;
	[SerializeField] private string _lastCommand;
	[SerializeField] private string _detectedVariable;

	[SerializeField] private Action _actionToPerform;
	public string Variable => throw new System.NotImplementedException();

	public SpeechEngine SpeechEngine
	{
		get => default;
		set
		{
		}
	}

	public float ProcenetSimilary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public event EventHandler StartVoiceDetected;
	public event EventHandler CorrectVoiceDetected;

	public event EventHandler EroorVoiceDetected;
	public void ActionVoiceDetected()
	{
		throw new System.NotImplementedException();
	}

	public void SetDetectedVariable(string variable)
	{
		throw new System.NotImplementedException();
	}

	private void PerformAction()
	{

	}

	public void SetActionVoiceDetected()
	{

	}

	public string GetVoiceCommandText()
	{
		return _lastCommand;
	}

	public string GetRecognizedCommand()
	{
		return _voiceCommandText.text;
	}

	private void Reset()
	{
		
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
