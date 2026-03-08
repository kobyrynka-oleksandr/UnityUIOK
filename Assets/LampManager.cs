using UnityEngine;

public class LampManager : MonoBehaviour
{
    Transform[] streetLamps;

    void Start()
    {
        streetLamps = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            streetLamps[i] = transform.GetChild(i);
        }
    }

    public void ToggleAllLamps()
    {
        foreach (Transform lamp in streetLamps)
        {
            foreach (Transform child in lamp)
            {
                child.gameObject.SetActive(!child.gameObject.activeSelf);
            }
        }
    }
}
