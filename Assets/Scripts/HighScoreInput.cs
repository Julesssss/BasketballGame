using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreInput : MonoBehaviour {

    public CanvasGroup canvasGroup;

    public void setVisible(bool visible) {
        if (visible) {
            canvasGroup.alpha = 1f;
        } else {
            canvasGroup.alpha = 0f;
        }
    }

    public void SaveName() {
        var input = gameObject.GetComponent<UnityEngine.UI.InputField>();
        print("SAVE NAME:: " + input.text);
        HighScoreManager.setName(input.text);
	}
}
