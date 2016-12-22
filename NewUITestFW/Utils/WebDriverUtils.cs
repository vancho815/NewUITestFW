﻿using System;
using NewUITestFW.Controls;
using OpenQA.Selenium;

namespace NewUITestFW.Utils
{
    static class WebDriverUtils
    {
        public static void WaitForPageIsLoaded(this IWebDriver driver)
        {
            driver.WaitForCondition(dri =>
            {
                string state = "";
                return state == "complete";
            }, 10);
        }

        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeout)
        {

            Func<T, bool> execute = (arg) =>
            {
                try
                {
                    return condition(arg);
                }
                catch (Exception e)
                {
                    
                    throw;
                }
            };
        }

        public static object ExecuteJS(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }
    }
}
