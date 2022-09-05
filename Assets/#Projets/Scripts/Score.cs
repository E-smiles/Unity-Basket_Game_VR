using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshPro countText;
    public Goal basketball;
    // Start is called before the first frame update
    void Start()
    {
        countText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = $"Score: {basketball.score}";
    }
}
