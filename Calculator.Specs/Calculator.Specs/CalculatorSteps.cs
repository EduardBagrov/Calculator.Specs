using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TestStack.White;

namespace Calculator.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private Utils utils = new Utils();
        private Application application;

        [AfterScenario]
        public void CloseCalculator()
        {
            application.Close();
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            application = utils.GetApplication();
        }
        
        [When(@"I add two numbers (.*) and (.*)")]
        public void WhenIAddTwoNumbersAnd(int a, int b)
        {
            utils.PutNumber(a);
            utils.GetButtonByName("Add").Click();
            utils.PutNumber(b);
            utils.GetButtonByName("Equals").Click();
        }
        
        [When(@"I add three numbers (.*) and (.*) and (.*)")]
        public void WhenIAddThreeNumbersAndAnd(int a, int b, int c)
        {
            utils.PutNumber(a);
            utils.GetButtonByName("Add").Click();
            utils.PutNumber(b);
            utils.GetButtonByName("Add").Click();
            utils.PutNumber(c);
            utils.GetButtonByName("Equals").Click();
        }
        
        [When(@"I multiply two numbers (.*) and (.*)")]
        public void WhenIMultiplyTwoNumbersAnd(int a, int b)
        {
            utils.PutNumber(a);
            utils.GetButtonByName("Multiply").Click();
            utils.PutNumber(b);
            utils.GetButtonByName("Equals").Click();
        }
        
        [When(@"I multiply three numbers (.*) and (.*) and (.*)")]
        public void WhenIMultiplyThreeNumbersAndAnd(int a, int b, int c)
        {
            utils.PutNumber(a);
            utils.GetButtonByName("Multiply").Click();
            utils.PutNumber(b);
            utils.GetButtonByName("Multiply").Click();
            utils.PutNumber(c);
            utils.GetButtonByName("Equals").Click();
        }
        
        [When(@"I subtract two numbers (.*) and (.*)")]
        public void WhenISubtractTwoNumbersAnd(int a, int b)
        {
            utils.PutNumber(a);
            utils.GetButtonByName("Subtract").Click();
            utils.PutNumber(b);
            utils.GetButtonByName("Equals").Click();
        }
        
        [When(@"I subtract three numbers (.*) and (.*) and (.*)")]
        public void WhenISubtractThreeNumbersAndAnd(int a, int b, int c)
        {
            utils.PutNumber(a);
            utils.GetButtonByName("Subtract").Click();
            utils.PutNumber(b);
            utils.GetButtonByName("Subtract").Click();
            utils.PutNumber(c);
            utils.GetButtonByName("Equals").Click();
        }
        
        [When(@"I divide two numbers (.*) and (.*)")]
        public void WhenIDivideTwoNumbersAnd(int a, int b)
        {
            utils.PutNumber(a);
            utils.GetButtonByName("Divide").Click();
            utils.PutNumber(b);
            utils.GetButtonByName("Equals").Click();
        }
        
        [Then(@"The result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(utils.ResultTextBox(), expectedResult.ToString());
        }

        [Then(@"The result of division by zero is not allowed")]
        public void ThenTheResultOfDivisionByZeroIsNotAllowed()
        {
            Assert.AreEqual(utils.ResultTextBox(), "Cannot divide by zero");
        }
        
    }
}
