using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reproducirimss : MonoBehaviour
{
    public GameObject imss;
    public Transform imagetarget;
    private void OnMouseDown()
    {
        Instantiate(imss);
        Destroy(GameObject.FindGameObjectWithTag("cubos"), 0);
    }
}
