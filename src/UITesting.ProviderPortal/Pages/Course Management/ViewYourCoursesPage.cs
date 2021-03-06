﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Course_Management
{

    public class ViewYourCoursesPage : TestSupport.BasePage
    {
        private static String PAGE_TITLE = "Your courses";
        private static By ViewCourseDescriptionLink = By.XPath("//*[@id='0']");       //first one in list '0'
        private static By showFirstCourseDescriptionPopupLink = By.XPath("//*[@id='0']");
        private static By showSecondCourseDescriptionPopupLink = By.XPath("//*[@id='1']");
        //elt added - View Description..
        private By courseDescriptionTitle = By.ClassName("govuk-caption-l");
        private By showCourseDescriptionPopupLink = By.LinkText("View course description");
        private By courseDescriptionPopup = By.Id("popup-descript");
        private By courseFor = By.Id("descript");
        private By entryRequirements = By.Id("next");
        private By whatWillLearn = By.Id("learn");
        private By howWillLearn = By.Id("how");
        private By equipmentNeeded = By.Id("how");
        private By howAssessed = By.Id("how");
        private By nextSteps = By.Id("next");
        private By diplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");
        private By closeViewCourseDescriptionPopup = By.Id("popup-descript-close");   //XPath("//*[@id=\"close-preview\"]"); 


        private By ClickViewURLLink = By.Id("URLLink");
        private By ViewCourseURLText = By.Id("courseRun_CourseURL");
        private By ClickURLClose = By.LinkText("Close");
        private By ClickCostDescriptionLink = By.Id("CostDetailLink");
        private By ViewCostDescriptionText = By.Id("courseRun_CostDescription");
        private By ClickCostDescriptionClose = By.LinkText("Close");


        //private By courseFor = By.Id("CourseFor");
        //private By entryRequirements = By.Id("EntryRequirements");



        //private By whatWillLearn = By.Id("WhatWillLearn");
        //private By howWillLearn = By.Id("HowYouWillLearn");
        //private By equipmentNeeded = By.Id("WhatYouNeed");
        //private By howAssessed = By.Id("HowAssessed");
        //private By nextSteps = By.Id("WhereNext");
        private By DiplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");


        //Shivani added - Line2
        private By verifyCourseTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.large:nth-of-type(1) label.govuk-label");
        private By CourseTitleInputBox = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.large:nth-of-type(1) input");

        private By verifyIDTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(2) label.govuk-label");
        private By IDTitleInputBox = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(2) input");

        private By verifyDeliveryTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(3) label.govuk-label");
        private By deliveryTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(3) select#deliveryMode");

        private By verifyStartDateTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(4) label.govuk-label");
        private By startDateTitleInputBox = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[4]/div");

        private By verifyVenueTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(5) label.govuk-label");
        private By venueTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(5) select#VenueId");

        private By verifyURLTitle = By.XPath("//*[@id='course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba']/div[6]/label");
        private By urlTitleHyperLink = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.popUpContainer a#URLLink");

        private By verifyCostTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[7]/label");
        private By costTitleInputBox = By.CssSelector("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[7]/input");

        private By verifyCostDescriptionTitle = By.XPath("//*[@id='course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba']/div[8]/label");
        private By costDescriptionTitleHyperLink = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.popUpContainer a#CostDetailLink");

        private By verifyDurationTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[9]/label");
        private By durationTitleInputBox = By.CssSelector("//*[@id='courseRun_DurationValue']");

        private By verifyDurationUnitTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[10]/label");
        private By durationUnitTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium select#durationUnit");

        private By verifyAttendanceTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[11]/label");
        private By attendanceTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium select#attendance");

        private By verifyModeTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[12]/label");
        private By modeTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium select#mode");



        //public ViewYourCoursesPage(IWebDriver webDriver) : base(webDriver)

        //private By DiplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");


        public ViewYourCoursesPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        internal void ClickCloseCostDescription()
        {
            FormCompletionHelper.ClickElement(ClickCostDescriptionClose);
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void HideCostDescription()
        {
            PageInteractionHelper.VerifyElementNotPresent(ViewCostDescriptionText);
        }
        internal void ClickCourseCostDescriptionLink()
        {
            FormCompletionHelper.ClickElement(ClickCostDescriptionLink);
        }


        internal void CloseURL()
        {
            FormCompletionHelper.ClickElement(ClickURLClose);
        }

        internal void ClickViewURL()
        {
            FormCompletionHelper.ClickElement(ClickViewURLLink);
        }

        internal void ViewCourseURL()
        {
            FormCompletionHelper.IsElementPresent(ViewCourseURLText);
        }

        internal void CheckViewCourseDescription()
        {
            PageInteractionHelper.IsElementPresent(ViewCostDescriptionText);
        }

        internal void ConfirmURLReadOnly()
        {
            //throw new NotImplementedException();
            PageInteractionHelper.IsElementReadOnly(ViewCourseURLText);
        }

        //Elt view Description->
        internal void ClickViewCourseDescription()
        {
            FormCompletionHelper.ClickElement(ViewCourseDescriptionLink);

        }

        internal void ViewCourseCostDetail()
        {
            PageInteractionHelper.VerifyElementPresent(ViewCostDescriptionText);
        }

        internal void HideURLText()
        {

            PageInteractionHelper.VerifyElementNotPresent(ViewCourseURLText);
        }

        internal void ConfirmCourseCostDescReadOnly()
        {
            PageInteractionHelper.IsElementReadOnly(ViewCostDescriptionText);
        }

        internal void ClickShowCourseDescriptionPopup()
        {
            FormCompletionHelper.ClickElement(showCourseDescriptionPopupLink);

        }


        internal void ClickOpenAccordianDiploma()
        {
            FormCompletionHelper.ClickElement(diplomaAccordianLink);

        }

        internal void VerifyDescriptionPopupOpens()
        {
            PageInteractionHelper.IsElementPresent(courseDescriptionPopup);

        }
        public ViewYourCoursesPage VerifyCourseDescriptionShown()
        {
            //Title 'Course Description' shown
            PageInteractionHelper.VerifyElementPresent(courseDescriptionTitle);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyWhoCourseFor()
        {
            PageInteractionHelper.VerifyElementPresent(courseFor);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyEntryRequirements()
        {
            PageInteractionHelper.VerifyElementPresent(entryRequirements);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyWhatWillLearn()
        {
            PageInteractionHelper.VerifyElementPresent(whatWillLearn);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyHowWillLearn()
        {
            PageInteractionHelper.VerifyElementPresent(howWillLearn);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyEquipmentNeeded()
        {
            PageInteractionHelper.VerifyElementPresent(equipmentNeeded);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyHowAssessed()
        {
            PageInteractionHelper.VerifyElementPresent(howAssessed);
            return new ViewYourCoursesPage(webDriver);
        }

        //Shivani Line2
        internal void courseNameLabelText(string courseLabel)
        {
            if (courseLabel == "Course name")
            {
                PageInteractionHelper.VerifyText(verifyCourseTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(CourseTitleInputBox);

            }
            if (courseLabel == "ID")
            {
                PageInteractionHelper.VerifyText(verifyIDTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(IDTitleInputBox);
            }
            if (courseLabel == "Delivery")
            {
                PageInteractionHelper.VerifyText(verifyDeliveryTitle, courseLabel);

            }
            if (courseLabel == "Start Date")
            {
                PageInteractionHelper.VerifyText(verifyStartDateTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(startDateTitleInputBox);
            }
            if (courseLabel == "Venue")
            {
                PageInteractionHelper.VerifyText(verifyVenueTitle, courseLabel);
            }
            if (courseLabel == "Cost")
            {
                PageInteractionHelper.VerifyText(verifyCostTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(costTitleInputBox);
            }
            if (courseLabel == "Duration")
            {
                PageInteractionHelper.VerifyText(verifyDurationTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(durationTitleInputBox);
            }
            if (courseLabel == "Duration Unit")
            {
                PageInteractionHelper.VerifyText(verifyDurationUnitTitle, courseLabel);

            }
            if (courseLabel == "Attendance")
            {
                PageInteractionHelper.VerifyText(verifyAttendanceTitle, courseLabel);
            }
            if (courseLabel == "Mode")
            {
                PageInteractionHelper.VerifyText(verifyModeTitle, courseLabel);
            }


        }

        internal void checkDropDownBoxes(string dropDown)
        {
            if (dropDown == "Delivery")
            {
                FormCompletionHelper.ClickElement(deliveryTitleDropDown);
                Thread.Sleep(2000);

            }
            if (dropDown == "Venue")
            {
                FormCompletionHelper.ClickElement(venueTitleDropDown);
                Thread.Sleep(2000);

            }
            if (dropDown == "Duration Unit")
            {
                FormCompletionHelper.ClickElement(durationUnitTitleDropDown);
                Thread.Sleep(2000);

            }
            if (dropDown == "Attendance")
            {
                FormCompletionHelper.ClickElement(attendanceTitleDropDown);
                Thread.Sleep(2000);

            }
            if (dropDown == "Mode")
            {
                FormCompletionHelper.ClickElement(modeTitleDropDown);
                Thread.Sleep(2000);

                FormCompletionHelper.ClickElement(modeTitleDropDown);
                Thread.Sleep(2000);

            }

        }

        internal void checkhyperLinkTitle(string hyperlink)
        {
            if (hyperlink == "URL")
            {
                PageInteractionHelper.VerifyText(verifyURLTitle, hyperlink);
            }

            if (hyperlink == "Cost Description")
            {
                PageInteractionHelper.VerifyText(verifyCostDescriptionTitle, hyperlink);
            }
        }

    }
}

