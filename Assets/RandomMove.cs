using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour {
  public Vector3 Range;
	// Update is called once per frame
	void Update () {
    transform.position = new Vector3(
      Random.Range(-Range.x, Range.x), 
      Random.Range(-Range.y, Range.y), 
      Random.Range(-Range.z, Range.z));
	}
}
