using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MålSkive : MonoBehaviour
{
    public static int Point = 0;

    // Start is called before the first frame update
    void Start() { }

    void OnGUI()
    {
        GUI.Label(new Rect(1, 1, 300, 50), "Hit: " + Point);
    }

    void OnCollisionEnter(Collision other)
    {
        Point++;
    }

    // Update is called once per frame
    void Update() { }
}
