using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboDisplay : MonoBehaviour
{
    const string PRICE_TEXT = "Price: $";

    public float comboPrice1 = 45.50f;
    public float comboPrice2 = 57.47f;
    public float comboPrice3 = 57.47f;
    public float comboPrice4 = 125.68f;

    public Text comboText;
    public Text comboPriceText;

    public GameObject comboFood1;
    public GameObject comboFood2;
    public GameObject comboFood3;
    public GameObject comboFood4;

    public GameObject comboDrink1;
    public GameObject comboDrink2;
    public GameObject comboDrink3;
    public GameObject comboDrink4;
    // Start is called before the first frame update
    void Start()
    {
        comboText.text = "Combo 1";
        comboPriceText.text = PRICE_TEXT + comboPrice1.ToString();

        comboFood1.SetActive(true);
        comboDrink1.SetActive(true);

        comboFood2.SetActive(false);
        comboDrink2.SetActive(false);

        comboFood3.SetActive(false);
        comboDrink3.SetActive(false);

        comboFood4.SetActive(false);
        comboDrink4.SetActive(false);
    }

    // Update is called once per frame
    public void OnCombo1Btn()
    {
        comboText.text = "Combo 1";
        comboPriceText.text = PRICE_TEXT + comboPrice1.ToString();

        comboFood1.SetActive(true);
        comboDrink1.SetActive(true);

        comboFood2.SetActive(false);
        comboDrink2.SetActive(false);

        comboFood3.SetActive(false);
        comboDrink3.SetActive(false);

        comboFood4.SetActive(false);
        comboDrink4.SetActive(false);
    }

    public void OnCombo2Btn()
    {
        comboText.text = "Combo 2";
        comboPriceText.text = PRICE_TEXT + comboPrice2.ToString();

        comboFood1.SetActive(false);
        comboDrink1.SetActive(false);

        comboFood2.SetActive(true);
        comboDrink2.SetActive(true);

        comboFood3.SetActive(false);
        comboDrink3.SetActive(false);

        comboFood4.SetActive(false);
        comboDrink4.SetActive(false);
    }

    public void OnCombo3Btn()
    {
        comboText.text = "Combo 3";
        comboPriceText.text = PRICE_TEXT + comboPrice3.ToString();

        comboFood1.SetActive(false);
        comboDrink1.SetActive(false);

        comboFood2.SetActive(false);
        comboDrink2.SetActive(false);

        comboFood3.SetActive(true);
        comboDrink3.SetActive(true);

        comboFood4.SetActive(false);
        comboDrink4.SetActive(false);
    }

    public void OnCombo4Btn()
    {
        comboText.text = "Combo 4";
        comboPriceText.text = PRICE_TEXT + comboPrice4.ToString();

        comboFood1.SetActive(false);
        comboDrink1.SetActive(false);

        comboFood2.SetActive(false);
        comboDrink2.SetActive(false);

        comboFood3.SetActive(false);
        comboDrink3.SetActive(false);

        comboFood4.SetActive(true);
        comboDrink4.SetActive(true);
    }
}
