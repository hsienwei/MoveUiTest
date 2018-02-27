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

  public Canvas UIRoot3;
  public UnityEngine.UI.Image OriImage3;

  public GameObject UIRoot4;
  public UIPanel OriImage4;

  public GameObject Switch1;
  public GameObject Switch2;
  public GameObject Switch3;
  public GameObject Switch4;

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

      var c = GameObject.Instantiate(OriImage3);
      c.rectTransform.parent = UIRoot3.transform;
      var cc = c.gameObject.AddComponent<UGUIFollowTargetWorld>();
      cc.m_Target = Obj.transform;
      cc.m_CurCamera = m_Camera;

      var d = NGUITools.AddChild(UIRoot4, OriImage4.gameObject);
      var dc = d.gameObject.AddComponent<UGUIFollowTargetWorld>();
      dc.m_Target = Obj.transform;
      dc.m_CurCamera = m_Camera;
    }

    Switch1.SetActive(true);
    Switch2.SetActive(false);
    Switch3.SetActive(false);
    Switch4.SetActive(false);
  }

  void OnGUI()
  {
    if (Switch1.active)
      GUI.Label(new Rect(100, 100, 100, 50), "UGUI UI");
    if (Switch2.active)
      GUI.Label(new Rect(100, 100, 100, 50), "NGUI UI");
    if (Switch3.active)
      GUI.Label(new Rect(100, 100, 100, 50), "UGUI World");
    if (Switch4.active)
      GUI.Label(new Rect(100, 100, 100, 50), "NGUI World");

    if (GUI.Button(new Rect(200, 100, 100, 50), "UGUI UI"))
    {
      Switch1.SetActive(true);
      Switch2.SetActive(false);
      Switch3.SetActive(false);
      Switch4.SetActive(false);
    }
    if (GUI.Button(new Rect(300, 100, 100, 50), "NGUI UI"))
    {
      Switch1.SetActive(false);
      Switch2.SetActive(true);
      Switch3.SetActive(false);
      Switch4.SetActive(false);
    }
    if (GUI.Button(new Rect(400, 100, 100, 50), "UGUI World"))
    {
      Switch1.SetActive(false);
      Switch2.SetActive(false);
      Switch3.SetActive(true);
      Switch4.SetActive(false);
    }
    if (GUI.Button(new Rect(500, 100, 100, 50), "NGUI World"))
    {
      Switch1.SetActive(false);
      Switch2.SetActive(false);
      Switch3.SetActive(false);
      Switch4.SetActive(true);
    }

  }
}
