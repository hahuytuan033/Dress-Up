using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public Image loadingBar;
    public Button button1;
    public Button button2;
    public Button button3;
    private int buttonClickCount = 0;

    private void Start()
    {
        loadingBar.fillAmount = 0f;
        button1.onClick.AddListener(IncrementLoadingBar);
        button2.onClick.AddListener(IncrementLoadingBar);
        button3.onClick.AddListener(IncrementLoadingBar);
    }

    void IncrementLoadingBar()
    {
        buttonClickCount++;
        if (buttonClickCount <= 5)
        {
            loadingBar.fillAmount = buttonClickCount / 5f;
        }
    }
}
