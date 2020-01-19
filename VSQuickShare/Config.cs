using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bhojarajsahu88.VSQuickShare
{
    public static class Config
    {
        public static string GetSettings(string sett)
        {
            string result = string.Empty;
            switch (sett)
            {
                case "URL":
                    result = @"http://services.bsahu.com/VSQuickShare/VSQuickShareService.svc";
                    break;
                case "UID":
                    result = "bhojarajsahu";
                    break;
                case "PWD":
                    result = "BhojarajSahu2017";
                    break;
                default:
                    break;
            }

            return result;

        }
    }
}
