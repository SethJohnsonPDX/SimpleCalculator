using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string firstNumber = firstValue.Text;
            string secondNumber = secondValue.Text;

            int addResult = int.Parse(firstNumber) + int.Parse(secondNumber);

            resultLabel.Text = addResult.ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            string firstNumber = firstValue.Text;
            string secondNumber = secondValue.Text;

            int subtractResult = int.Parse(firstNumber) - int.Parse(secondNumber);

            resultLabel.Text = subtractResult.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            string firstNumber = firstValue.Text;
            string secondNumber = secondValue.Text;

            int multiplyResult = int.Parse(firstNumber) * int.Parse(secondNumber);

            resultLabel.Text = multiplyResult.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            string firstNumber = firstValue.Text;
            string secondNumber = secondValue.Text;

            int parseFirst = int.Parse(firstNumber);
            int parseSecond = int.Parse(secondNumber);

            double divideResult = (double)parseFirst / (double)parseSecond;

            resultLabel.Text = divideResult.ToString();
        }
    }
}