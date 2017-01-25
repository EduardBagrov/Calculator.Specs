using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using System.Windows.Automation;

namespace Calculator.Specs
{
    public class Utils
    {
        private Application application;

        public Utils()
        {
             application = Application.Launch(@"C:\Windows\SysWOW64\calc.exe");
        }

        public Button GetButtonByName(string windowName)
        {
            for (var i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                var button = GetWindowByName().Get<Button>(SearchCriteria.ByText(windowName));
                if (button != null)
                {
                    return button;
                }
            }

            return null;
        }

        public Window GetWindowByName()
        {
            return application.GetWindow("Calculator");
        }

        public Application GetApplication()
        {
            return application;
        }

        public string ResultTextBox()
        {
            return
                GetWindowByName().Get<Label>(SearchCriteria.ByAutomationId("150")).AutomationElement.
                    GetCurrentPropertyValue(AutomationElement.NameProperty).ToString();

        }

        public void PutNumber(int number)
        {
            List<int> list = new List<int>();
            bool negative = false;

            if (number < 0) // if negative make it positive to ease num
            {
                negative = true;
                number *= -1;
            }
            else if (list.Count == 0) // if number is 0
            {
                GetButtonByName("0").Click();
            }            

            // extracting number by digits
            while (number != 0)
            {
                list.Add(number % 10);
                number /= 10;
            }
            
            if (negative)
            {
                GetButtonByName("Subtract").Click();
            }
            for (int i = list.Count - 1; i >= 0 ; i--)
            {
                GetButtonByName(list[i].ToString()).Click();
            }            
        }
    }
}
