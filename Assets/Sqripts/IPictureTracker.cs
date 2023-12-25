using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPictureTracker
{
	EnumPictureDetectedType EnumPictureDetectedType {  get; set; }
	string DetectedVaribales { get; set; }
	float Delta { get; set; }

	void SetpictureDetecteReferense();
	void ActionPictureDetected();
}
