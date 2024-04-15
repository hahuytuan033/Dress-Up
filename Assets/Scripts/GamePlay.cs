using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    public Image loadingBar;
    public Button hairButton;
    public Button jacketButton;
    public Button shoesButton;
    public Button button4;
    public Button button5;
//cái được ẩn đi
    public Image hair_image;
    public Image jacket_image;
    public Image shoes_image;

//cái được hiện lên
    public GameObject hair;
    public GameObject jacket;
    public GameObject shoes; // Add this line
    private int buttonClickCount = 0;

    private void Start()
    {
        loadingBar.fillAmount = 0f;
        hairButton.onClick.AddListener(IncrementLoadingBar);
        jacketButton.onClick.AddListener(()=>
        {
            IncrementLoadingBar();
            jacket_image.gameObject.SetActive(false);
            jacket.SetActive(true);
        });
        shoesButton.onClick.AddListener(() => 
        {
            IncrementLoadingBar();
            shoes_image.gameObject.SetActive(false); // Disable button3
            shoes.SetActive(true); // Enable otherObject
        });
    }

    void IncrementLoadingBar()
    {
        buttonClickCount++;
        if (buttonClickCount <= 7)
        {
            loadingBar.fillAmount = buttonClickCount / 7f;
        }
    }
}
