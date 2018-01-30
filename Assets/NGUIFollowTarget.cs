using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGUIFollowTarget : MonoBehaviour {
  public Camera m_CurCamera;
  public Transform m_Target;
  public Camera m_UICamera;

  // Update is called once per frame
  void Update () {
    Vector3 screenPos = m_CurCamera.WorldToScreenPoint(m_Target.position);
    var NewPos = transform.parent.InverseTransformPoint(m_UICamera.ScreenToWorldPoint(screenPos));
    NewPos.z = 0;
    transform.localPosition = NewPos;
  }
}
