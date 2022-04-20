using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartOfBody : MonoBehaviour
{
    public bool isChoosed;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        color = GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeTransper(float value)
    {
        GetComponent<MeshRenderer>().material.SetColor("_Color", new Color(color.r, color.g, color.b, value));
    }

    public void ShowDoNotShow()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }

}
