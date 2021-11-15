using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] InputField inputField;

    const string msg = "文字を入力して下さい。";

    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        text.text = msg;

    }

    // Update is called once per frame
    void Update()
    {

    }

    #endregion

    #region UI Callback Methods
    public void OnEnterButtonClicked()
    {
        if (inputField.text == "")
        {
            text.text = msg;
        }
        else
        {
            text.text = inputField.text;
        }

    }

    #endregion
}
