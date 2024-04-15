namespace Calc.Pages;

public partial class Calculator
{
    private string firstNumber;
    private string secondNumber;
    private string result;
    private string displayEquation = "";
    private bool IsEnteringSecondNumber = false;
    private string currentOperation;

    private void InputNum(int num)
    {
        displayEquation += num.ToString();
        if (IsEnteringSecondNumber)
        {
            secondNumber += num.ToString();
        }
        else
        {
            firstNumber += num.ToString();
        }
    }
    private void Add()
    {
        currentOperation = "+";
        displayEquation += currentOperation;
        IsEnteringSecondNumber = true;
    }
    private void Sub()
    {
        currentOperation = "-";
        displayEquation += currentOperation;
        IsEnteringSecondNumber = true;
    }
    private void Div()
    {
        currentOperation = "/";
        displayEquation += currentOperation;
        IsEnteringSecondNumber = true;
    }
    private void Mul()
    {
        currentOperation = "*";
        displayEquation += currentOperation;
        IsEnteringSecondNumber = true;
    }
    private void Clear()
    {
        currentOperation = "";
        firstNumber = "";
        secondNumber = "";
        result = "";
        displayEquation = "";
        IsEnteringSecondNumber = false;
    }
    private void Equals()
    {
        if (currentOperation == "+")
            result = (Convert.ToDouble(firstNumber) + Convert.ToDouble(secondNumber)).ToString();
        else if (currentOperation == "-")
            result = (Convert.ToDouble(firstNumber) - Convert.ToDouble(secondNumber)).ToString();
        else if (currentOperation == "/")
            result = (Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber)).ToString();
        else if (currentOperation == "*")
            result = (Convert.ToDouble(firstNumber) * Convert.ToDouble(secondNumber)).ToString();
    }
}