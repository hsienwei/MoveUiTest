using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMoveTestMain : MonoBehaviour {
  public int mCnt;
  public GameObject OriObj;
  public Camera m_Camera;

  public Canvas UIRoot1;
  public UnityEngine.UI.Image OriImage1;

  public GameObject UIRoot2;
  public UI2DSprite OriImage2;
  public Camera UICamera2;

  public GameObject Switch1;
  public GameObject Switch2;

  // Use this for initialization
  void Start () {
		for(int i=0; i< mCnt; ++i)
    {
      var Obj = GameObject.Instantiate(OriObj);
      
      var a = GameObject.Instantiate(OriImage1);
      a.rectTransform.parent = UIRoot1.transform;
      var ac = a.gameObject.AddComponent<UGUIFollowTarget>();
      ac.m_Target = Obj.transform;
      ac.m_CurCamera = m_Camera;

      var b = NGUITools.AddChild(UIRoot2, OriImage2.gameObject);

      var bc = b.gameObject.AddComponent<NGUIFollowTarget>();
      bc.m_Target = Obj.transform;
      bc.m_CurCamera = m_Camera;
      bc.m_UICamera = UICamera2;
    }
	}

  void OnGUI()
  {
    if(GUI.Button(new Rect(100, 100, 100, 100), "Switch"))
    {
      if (Switch1.active)
      {
        Switch1.SetActive(false);
        Switch2.SetActive(true);
      }
      else
      {
        Switch1.SetActive(true);
        Switch2.SetActive(false);
      }
    }
  }
}
