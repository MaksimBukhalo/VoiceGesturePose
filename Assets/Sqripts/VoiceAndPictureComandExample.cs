using Klak.TestTools;
using LeastSquares.Undertone;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceAndPictureComandExample : MonoBehaviour, IVoiceTracker, IPictureTracker
{
	[SerializeField] private ImageSource _imageEngine;
	[SerializeField] private string _detectedReferense;

	[SerializeField] private Text _voiceCommandText;

	[SerializeField] private SpeechEngine _speachEgine;
	[SerializeField] private string _lastCommand;
	[SerializeField] private string _detectedVariable;

	[SerializeField] private Action _actionToPerform;
	public string Variable => throw new System.NotImplementedException();

	public EnumPictureDetectedType EnumPictureDetectedType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
	public string DetectedVaribales { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public ImageSource ImageSource
	{
		get => default;
		set
		{
		}
	}

	public SpeechEngine SpeechEngine
	{
		get => default;
		set
		{
		}
	}

	public float ProcenetSimilary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public float Delta { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public event EventHandler StartDetected;
	public event EventHandler CorrectDetected;


	public void ActionPictureDetected()
	{
		throw new System.NotImplementedException();
	}

	public void ActionVoiceDetected()
	{
		throw new System.NotImplementedException();
	}

	public void SetDetectedVariable(string variable)
	{
		throw new System.NotImplementedException();
	}

	public void SetpictureDetecteReferense()
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
	private void StartCaptureDetected()
	{

	}

	private void RecognizeGesture()
	{

	}
	public void SetActionPictureDetected()
	{

	}

	private void Reset()
	{

	}

	private void ValidateGesture()
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
