﻿using UnityEngine;

public class TerrainSegment : MonoBehaviour {

    public float Width{ get { return transform.localScale.x; }}
    public float 
        OverlapPercentage = 0.3f, 
        MoveSpeed = 5.0f; // Would make it a const, but I also want to be able to tweak it in the inspector. :/

    void Update() {
        float vx = -MoveSpeed * Time.deltaTime;
        transform.Translate(new Vector2(vx, 0));
    }
}
