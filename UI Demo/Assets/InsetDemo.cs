
using UnityEngine;

public class InsetDemo : MonoBehaviour
{
    private RectTransform _myRectTransform;
    void Start ()
    {
        _myRectTransform = GetComponent<RectTransform>();
    }

	//void Update () {
		
	//}

    public void InsetHorisontal(float normalizedInset)
    {
        var x = _myRectTransform.parent as RectTransform;
        _myRectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, x.rect.width * normalizedInset, _myRectTransform.rect.width);
    }
    public void InsetVertical(float normalizedInset)
    {
        var x = _myRectTransform.parent as RectTransform;
        _myRectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, x.rect.height * normalizedInset, _myRectTransform.rect.height);
    }
}
