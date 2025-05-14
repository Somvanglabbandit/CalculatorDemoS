using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculatorController : MonoBehaviour
{
    public TextMeshProUGUI displayText; // Reference to your display
    private string currentInput = "";
    private float storedValue = 0;
    private string currentOperator = "";

    public void OnNumberButtonClicked(string number)
    {
        currentInput += number;
        displayText.text = currentInput;
    }

    public void OnPlusButtonClicked()
    {
        if (float.TryParse(currentInput, out float value))
        {
            storedValue = value;
            currentInput = "";
            currentOperator = "+";
        }
    }

    public void OnEqualsButtonClicked()
    {
        if (float.TryParse(currentInput, out float value))
        {
            if (currentOperator == "+")
            {
                float result = storedValue + value;
                displayText.text = result.ToString();
                currentInput = result.ToString();
                currentOperator = "";
            }
        }
    }
}
