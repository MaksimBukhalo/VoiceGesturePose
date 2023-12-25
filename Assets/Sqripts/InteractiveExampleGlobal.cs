using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveExampleGlobal
{
	public VoiceAndPictureComandExample VoiceAndPictureComand;
	public PictureComandExample PictureComand;
	public VoiceComandExample VoiceComand;

	[SerializeField] private Canvas _mainUI;
	[SerializeField] private string InterectionWhith3DModel;
	[SerializeField] private string InterectionWhithAniamtor;



	public event EventHandler Error;

	public VoiceComandExample VoiceComandExample
	{
		get => default;
		set
		{
		}
	}

	public VoiceAndPictureComandExample VoiceAndPictureComandExample
	{
		get => default;
		set
		{
		}
	}

	public PictureComandExample PictureComandExample
	{
		get => default;
		set
		{
		}
	}

	private void Start()
	{

	}

	private void Update()
	{

	}

	private void OnEnable()
	{

	}

	private void OnDisable()
	{

	}

	private void Init()
	{

	}

	private void OpenUIWhithVoise()
	{

	}

	private void OpenUIWhithPose()
	{

	}

	private void StartGAmeAfterVoiceAndPoseDetected()
	{

	}


	private void StartGastureTRekerForGame()
	{

	}

	private void Restart()
	{

	}

	private void Reset()
	{

	}



}
