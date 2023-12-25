using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVoiceTracker
{
	string Variable { get; }
	void SetDetectedVariable(string variable);
	void ActionVoiceDetected();
	float ProcenetSimilary { get; set; }
}
