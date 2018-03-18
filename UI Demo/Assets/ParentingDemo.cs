using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentingDemo : MonoBehaviour
{

    public RectTransform PanelOne;
    public RectTransform PanelTwo;

    private RectTransform _myRect;
	// Use this for initialization
	void Start ()
	{
	    _myRect = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame

    public void SetParentWorldStays()
    {
        _myRect.SetParent(_myRect.parent == PanelOne ? PanelTwo : PanelOne, true);
    }

    public void SetParentLocalStays()
    {
        _myRect.SetParent(_myRect.parent == PanelOne ? PanelTwo : PanelOne, false);
    }

    public void SetParentLegacy()
    {
        _myRect.SetParent(_myRect.parent == PanelOne ? PanelTwo : PanelOne);
    }
}
