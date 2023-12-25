using Klak.TestTools;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PictureComandExample : IPictureTracker
{
	[SerializeField] private ImageSource _imageEngine;
	[SerializeField] private Action _actionToPerform;


	public event EventHandler StopPictureDetected;

	public event EventHandler StartPictureDetected;
	public event EventHandler CorrectPictureDetected;
	public event EventHandler EroorPictureDetected;



	public EnumPictureDetectedType EnumPictureDetectedType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
	public string DetectedVaribales { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public ImageSource ImageSource
	{
		get => default;
		set
		{
		}
	}

	public float Delta { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public void ActionPictureDetected()
	{
		throw new System.NotImplementedException();
	}

	public void SetpictureDetecteReferense()
	{
		throw new System.NotImplementedException();
	}

	private void StartCaptureDetected()
	{

	}

	private void RecognizeGesture()
	{

	}
	private void PerformAction()
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
