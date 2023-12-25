using Klak.TestTools;
using MediaPipe.HandPose;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TestHandVisulization : MonoBehaviour
{
	#region Editable attributes

	[SerializeField] ImageSource _source = null;
	[Space]
	[SerializeField] ResourceSet _resources = null;
	[SerializeField] bool _useAsyncReadback = true;
	[SerializeField] private List<Transform> _transformList = new List<Transform>();
	[SerializeField] private List<Transform> _transformList2 = new List<Transform>();


	[Space]
	[SerializeField] Mesh _jointMesh = null;
	[SerializeField] Mesh _boneMesh = null;
	[Space]
	[SerializeField] Material _jointMaterial = null;
	[SerializeField] Material _boneMaterial = null;
	[Space]
	[SerializeField] RawImage _monitorUI = null;

	#endregion

	#region Private members

	HandPipeline _pipeline;

	static readonly (int, int)[] BonePairs =
	{
		(0, 1), (1, 2), (1, 2), (2, 3), (3, 4),     // Thumb
        (5, 6), (6, 7), (7, 8),                     // Index finger
        (9, 10), (10, 11), (11, 12),                // Middle finger
        (13, 14), (14, 15), (15, 16),               // Ring finger
        (17, 18), (18, 19), (19, 20),               // Pinky
        (0, 17), (2, 5), (5, 9), (9, 13), (13, 17)  // Palm
    };

	Matrix4x4 CalculateJointXform(Vector3 pos)
	  => Matrix4x4.TRS(pos, Quaternion.identity, Vector3.one * 0.07f);

	Matrix4x4 CalculateBoneXform(Vector3 p1, Vector3 p2)
	{
		var length = Vector3.Distance(p1, p2) / 2;
		var radius = 0.03f;

		var center = (p1 + p2) / 2;
		var rotation = Quaternion.FromToRotation(Vector3.up, p2 - p1);
		var scale = new Vector3(radius, length, radius);

		return Matrix4x4.TRS(center, rotation, scale);
	}


	#endregion

	#region MonoBehaviour implementation

	void Start()
	  => _pipeline = new HandPipeline(_resources);

	void OnDestroy()
	  => _pipeline.Dispose();
	bool UserSendSaveEvent;
	string GestureName;
	public void LateUpdate()
	{
		// Feed the input image
		_pipeline.UseAsyncReadback = _useAsyncReadback;
		_pipeline.ProcessImage(_source.Texture);

		var layer = gameObject.layer;

		// Joint balls
		for (var i = 0; i < HandPipeline.KeyPointCount; i++)
		{
			var xform = CalculateJointXform(_pipeline.GetKeyPoint(i));
			_transformList[i].position = _pipeline.GetKeyPoint(i);
		}
		int counter = 0;
		// Bones
		foreach (var pair in BonePairs)
		{
			var p1 = _pipeline.GetKeyPoint(pair.Item1);
			var p2 = _pipeline.GetKeyPoint(pair.Item2);
			var length = Vector3.Distance(p1, p2) / 2;
			var radius = 0.03f;

			var center = (p1 + p2) / 2;
			var rotation = Quaternion.FromToRotation(Vector3.up, p2 - p1);
			var scale = new Vector3(radius, length, radius);
			_transformList2[counter].position = center;
			_transformList2[counter].rotation = rotation;
			_transformList2[counter].localScale = scale;
			counter++;
		}

		if(UserSendSaveEvent)
		{
			UserSendSaveEvent = false;
			SavePrefab(_transformList[0].gameObject);
		}
	}
	public void SavePrefab(GameObject objectToSave)
	{
		// ����������, �� ��'��� ��� ���������� ����
		if (objectToSave != null)
		{
			// ������� ����, �� �������� ������
			string prefabPath = "Assets/Prefabs/" + GestureName + ".prefab";

			// ��������� ����� ��� ��������� �������
			PrefabUtility.SaveAsPrefabAsset(objectToSave, prefabPath);

			Debug.Log("������ " + objectToSave.name + " ��������� �� ������: " + prefabPath);
		}
		else
		{
			Debug.LogError("��'��� ��� ���������� ������� null.");
		}
	}



	#endregion
}
