﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour {
    private Vector3 screenPoint;
    private Vector3 offset;
    private float oZ;

    void Start() {
        oZ = transform.localPosition.z;
    }
		
    void OnMouseDown(){
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.localPosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
		
    void OnMouseDrag(){
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.localPosition = new Vector3(cursorPosition.x, cursorPosition.y, oZ);
    }
}