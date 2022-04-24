using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewManager : MonoBehaviour
{
    private List<GameObject> partsOfBody;
    private GameObject actualPartOfBody;
    // Start is called before the first frame update
    void Start()
    {
        partsOfBody = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetNewPartOfBody(GameObject otherPart)
    {
        actualPartOfBody = otherPart;

        if (actualPartOfBody.GetComponent<PartOfBody>().isChoosed == false)
        {
            partsOfBody.Add(actualPartOfBody);
        }
        else
        {
            partsOfBody.Remove(actualPartOfBody);
        }
    }

    public void Toggle_Changed(bool newBool)
    {
        actualPartOfBody.GetComponent<PartOfBody>().isChoosed = newBool;
    }

    public void EditTransparency(float value)
    {
        foreach (GameObject part in partsOfBody)
        {
            if (part.GetComponent<PartOfBody>().isChoosed)
            {
                part.GetComponent<PartOfBody>().ChangeTransper(value);
            }
        }
    }

    public void ShowDoNotShow()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
