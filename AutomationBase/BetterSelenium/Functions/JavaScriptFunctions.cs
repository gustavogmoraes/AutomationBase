﻿namespace AutomationBase.BetterSelenium.Functions
{
    public static class JavaScriptSugar
    {
        public static string DocumentGetElementByXpath(string xpath)
        {
            return $"document.evaluate('{xpath}', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue";
        }
    }
}
