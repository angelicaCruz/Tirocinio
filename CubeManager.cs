using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using HoloToolkit.Unity;

public class CubeManager : MonoBehaviour {

    KeywordRecognizer keywordRecognizer;

    delegate void KeywordAction(PhraseRecognizedEventArgs args);
    Dictionary<string, KeywordAction> keywordCollection;

    // Use this for initialization
    void Start() {

        keywordCollection = new Dictionary<string, KeywordAction>();

        keywordCollection.Add("Modify Cube", ModifyCubeCommand);

        keywordRecognizer = new KeywordRecognizer(keywordCollection.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();

    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        KeywordAction keywordAction;

        if (keywordCollection.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke(args);
        }
    }

    private void ModifyCubeCommand(PhraseRecognizedEventArgs args)
    {
        GestureManager.Instance.Transition(GestureManager.Instance.manipulationRecognizer);

    }
}
