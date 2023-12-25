using Klak.TestTools;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SavePictureComand : MonoBehaviour
{

	[SerializeField] private ImageSource _imageEngine;
	[SerializeField] private EnumPictureDetectedType _type;

	[SerializeField] private UnityEvent _saveUnityEvent;
	[SerializeField] private string _path;
	[SerializeField] private string _nameObgectForSave;


	public event EventHandler CompleteSaveCamand;
	public event EventHandler ErrorSaveCamand;

	public ImageSource ImageSource
	{
		get => default;
		set
		{
		}
	}

	private void SaveComand()
	{

	}

	private void ReSaveComand()
	{

	}

	private void DeleteComand()
	{

	}


	private void Update()
	{
		
	}


	private void Start()
	{
		
	}
}
