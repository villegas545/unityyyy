using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reproducirgobierno : MonoBehaviour
{
    public GameObject gobierno;
    public Transform imagetarget;
    private void OnMouseDown()
    {
        Instantiate(gobierno);
        Destroy(GameObject.FindGameObjectWithTag("cubos"),0);
    }
}
