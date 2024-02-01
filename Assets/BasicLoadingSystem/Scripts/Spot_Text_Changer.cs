//This code generetad by ChatGpt
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Spot_Text_Changer : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public string[] textOptions; // De�i�tirmek istedi�iniz metin se�enekleri

    private float timer = 1.5f; // Saniyede bir de�i�mesini istedi�iniz zaman aral���
    private int currentIndex = 0;

    void Start()
    {
        if (myText == null)
        {
            Debug.LogError("Text component not assigned!");
            return;
        }

        if (textOptions.Length == 0)
        {
            Debug.LogError("No text options provided!");
            return;
        }

        UpdateText();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer = 1.5f; // Her saniye de�i�tirmek i�in
            currentIndex = (currentIndex + 1) % textOptions.Length;
            UpdateText();
        }
    }

    void UpdateText()
    {
        myText.text = textOptions[currentIndex];
    }
}
