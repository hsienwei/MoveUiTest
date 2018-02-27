using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UGUIFollowTargetWorld : MonoBehaviour
{
  public Camera m_CurCamera;
  public Transform m_Target;


  //private RectTransform m_SelfRectTransform;

  void Start()
  {
    //m_SelfRectTransform = this.GetComponent<RectTransform>();
  }

  // Update is called once per frame
  void Update()
  {

    transform.position = m_Target.position;// RectTransformUtility.WorldToScreenPoint(m_CurCamera, m_Target.position);

  }
}