using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSampleIntegration
{
    public static class Constants

    {
        public static class Ngen
        { 
            public static class LoginPage
        {
            public static string User = "T00004973";
            public static string Password = "589687";
            public static string EventId = "login-event-id";
            public static string EventCodeId = "login-event-code";
            public static string BadgeId = "login-badge-id";
            public static string SubmitButtonClass = "login-button";
            public static string RadioButtonClass = "custom-radio";

        }
        }
        public static class Sheffield
        {
            public static class LoginPage
            {
                public static string User = "test.test";
                public static string Password = "Parola123+";
                public static string InputUsernameId = "inputUsername";
                public static string InputPasswordId = "inputPassword";
                public static string LoginButtonClass = "login-button";
            }

            public static class HomePage
            {
                public static string SystemAdminXpath = "//button[@data-choice='systemAdmin']";
            }

            public static class SystemAdmin
                {
                public static string SystemAdminDropdownXpath = "//a[@data-dropdown='System Admin']";
                
                }
                
        }
    }
}
