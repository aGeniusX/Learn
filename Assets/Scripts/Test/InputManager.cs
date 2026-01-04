using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private CapMovement cap;
    // Start is called before the first frame update
    void Start()
    {
        cap = FindFirstObjectByType<CapMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (cap != null)
            {
                cap.Execute();
            }
        }
        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            cap.Undo();
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            Debug.Log(TestSingleton.Instance.testNum);
        }
    }
}
