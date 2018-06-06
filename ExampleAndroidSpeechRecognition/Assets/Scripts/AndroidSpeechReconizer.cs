using UnityEngine;
using UnityEngine.UI;

public class AndroidSpeechReconizer : MonoBehaviour {

    AndroidJavaClass pluginClass;
   
    public Text uiText;

    void Start()
    {
        pluginClass = new AndroidJavaClass(
            "de.maibornwolff.speechrecognition.plugin.SpeechRecFragment");
        pluginClass.CallStatic("start", gameObject.name);
        pluginClass.CallStatic("promptSpeechInput");
    }

    public void OnSpeechRecognitionResult(string result)
    {
        uiText.text = result;
    }
}
