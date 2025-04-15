using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KampVognStyr : MonoBehaviour
{
    public GameObject LøbPåTårn; // Her skal du trække en 'Empty' hen, som er der skudet kommer fra.

    public GameObject Kugle; //Dette er dit skud; Måske bare en sphere.

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(Kugle, LøbPåTårn.transform.position, LøbPåTårn.transform.rotation);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1f, 0);
        }
    }
}
