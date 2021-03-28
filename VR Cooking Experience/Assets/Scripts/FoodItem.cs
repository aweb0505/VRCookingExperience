using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{

    public MeshRenderer meshRenderer;

    public float cookRate;

    private bool isCooking;



    // Update is called once per frame
    void Update()
    {
        if (isCooking)
        {
            meshRenderer.material.color = Color.Lerp(meshRenderer.material.color, Color.black, cookRate * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CookSurface"))
        {
            isCooking = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("CookSurface"))
        {
            isCooking = false;
        }
    }
}
