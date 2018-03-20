using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SetOffset : MonoBehaviour
{

    private RectTransform _myRectTransform;

    public Vector2 OffsetMin;
    public Vector2 OffsetMax;
	// Use this for initialization
	void Start ()
	{
	    _myRectTransform = GetComponent<RectTransform>();
	}

    void OnValidate()
    {
        SetOffsets();
    }

    public void SetOffsets()
    {
        _myRectTransform.offsetMin = OffsetMin;
        _myRectTransform.offsetMax = OffsetMax;
    }
}

//[CustomEditor(typeof(SetOffset))]
//public class ObjectBuilderEditor : Editor
//{
//    public override void OnInspectorGUI()
//    {
//        DrawDefaultInspector();

//        SetOffset setOffsetScript = (SetOffset)target;
//        if (GUILayout.Button("Update Offsets"))
//        {
//            setOffsetScript.SetOffsets();
//        }
//    }
//}
