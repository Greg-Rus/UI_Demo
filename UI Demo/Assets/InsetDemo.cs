
using UnityEditor;
using UnityEngine;

public class InsetDemo : MonoBehaviour
{
    private RectTransform _myRectTransform;
    public RectTransform.Edge ParentEdge;
    public float Inset;
    public float Size;


    void Start ()
    {
        _myRectTransform = GetComponent<RectTransform>();
    }

    public void UpdateInset()
    {
        var x = _myRectTransform.parent as RectTransform;
        _myRectTransform.SetInsetAndSizeFromParentEdge(ParentEdge, Inset, Size);
    }
}

[CustomEditor(typeof(InsetDemo))]
public class ObjectBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        InsetDemo setOffsetScript = (InsetDemo)target;
        if (GUILayout.Button("Update Inset"))
        {
            setOffsetScript.UpdateInset();
        }
    }
}
