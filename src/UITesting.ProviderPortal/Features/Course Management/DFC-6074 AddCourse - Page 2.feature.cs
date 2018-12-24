﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UITesting.ProviderPortal.Features.CourseManagement
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("6074 - AddCourse Page 2")]
    public partial class _6074_AddCoursePage2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DFC-6074 AddCourse - Page 2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "6074 - AddCourse Page 2", "As a User\r\nI need the following actions to be performed on page 2:\r\nAdd Provider " +
                    "Course Reference/ID\r\nAdd Course Name\r\nAdd Course URL\r\nAdd Cost\r\nAdd Cost Descrip" +
                    "tion\r\nso that I can add a course", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 12
#line 13
 testRunner.Given("I have logged into course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.And("I have navigated to the Add Course Section 2 page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4950 User Adds Course Name")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4950UserAddsCourseName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4950 User Adds Course Name", null, new string[] {
                        "CI"});
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 18
 testRunner.When("I enter the following in the course name field Course 123(A-1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("course name error validation is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4950 User does not enter Course Name")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4950UserDoesNotEnterCourseName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4950 User does not enter Course Name", null, new string[] {
                        "CI"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 23
 testRunner.When("I enter the following in the course name field Course blank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.And("I enter the following in the URL field https://www.google.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("course name error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.And("error message for field Course Name states Enter Course Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4950 User enter Course Name greater than 255 chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4950UserEnterCourseNameGreaterThan255Chars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4950 User enter Course Name greater than 255 chars", null, new string[] {
                        "CI"});
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 30
 testRunner.When(@"I enter the following in the course name field Course ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("I enter the following in the URL field https://www.google.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("course name error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.And("error message for field Course Name states The maximum length of Course Name is 2" +
                    "55 characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4950 User enters invalid Course Name")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4950UserEntersInvalidCourseName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4950 User enters invalid Course Name", null, new string[] {
                        "CI"});
#line 36
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 37
 testRunner.When("I enter the following in the course name field Course 我想输入文字", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.And("I enter the following in the URL field https://www.google.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("course name error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("error message for field Course Name states Invalid characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters valid course URL")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersValidCourseURL()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters valid course URL", null, new string[] {
                        "CI"});
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 44
 testRunner.When("I enter the following in the URL field https://www.google.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters valid course URL 2")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersValidCourseURL2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters valid course URL 2", null, new string[] {
                        "CI"});
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 49
 testRunner.When("I enter the following in the URL field http://www.google.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters valid course URL 3")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersValidCourseURL3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters valid course URL 3", null, new string[] {
                        "CI"});
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 54
 testRunner.When("I enter the following in the URL field http://www.google.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters valid course URL 4")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersValidCourseURL4()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters valid course URL 4", null, new string[] {
                        "CI"});
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 59
 testRunner.When("I enter the following in the URL field http://www.12345.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters Invalid course URL")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersInvalidCourseURL()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters Invalid course URL", null, new string[] {
                        "CI"});
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 64
 testRunner.When("I enter the following in the URL field https://www.google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("course URL error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.And("error message for field URL states The format of URL is incorrect", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters Invalid course URL 2")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersInvalidCourseURL2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters Invalid course URL 2", null, new string[] {
                        "CI"});
#line 70
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 71
 testRunner.When("I enter the following in the URL field htts://www.google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.Then("course URL error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.And("error message for field URL states The format of URL is incorrect", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters Invalid course URL 3")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersInvalidCourseURL3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters Invalid course URL 3", null, new string[] {
                        "CI"});
#line 77
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 78
 testRunner.When("I enter the following in the URL field https//www.google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.Then("course URL error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.And("error message for field URL states The format of URL is incorrect", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters Invalid course URL 4")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersInvalidCourseURL4()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters Invalid course URL 4", null, new string[] {
                        "CI"});
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 85
 testRunner.When("I enter the following in the URL field https:/www.google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("course URL error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.And("error message for field URL states The format of URL is incorrect", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters Invalid course URL 5")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersInvalidCourseURL5()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters Invalid course URL 5", null, new string[] {
                        "CI"});
#line 91
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 92
 testRunner.When("I enter the following in the URL field https://www.google.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.Then("course URL error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.And("error message for field URL states The format of URL is incorrect", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5115 User enters Invalid course URL 6")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5115UserEntersInvalidCourseURL6()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5115 User enters Invalid course URL 6", null, new string[] {
                        "CI"});
#line 98
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 99
 testRunner.When("I enter the following in the URL field test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.Then("course URL error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.And("error message for field URL states The format of URL is incorrect", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5116 User enters valid cost")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5116UserEntersValidCost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5116 User enters valid cost", null, new string[] {
                        "CI"});
#line 105
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 106
 testRunner.When("I enter the following in the cost field 9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5116 User enters valid cost 1")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5116UserEntersValidCost1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5116 User enters valid cost 1", null, new string[] {
                        "CI"});
#line 110
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 111
 testRunner.When("I enter the following in the cost field 0.01", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5116 User enters valid cost 2")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5116UserEntersValidCost2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5116 User enters valid cost 2", null, new string[] {
                        "CI"});
#line 115
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 116
 testRunner.When("I enter the following in the cost field 999999.99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5116 User enters invalid cost")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5116UserEntersInvalidCost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5116 User enters invalid cost", null, new string[] {
                        "CI"});
#line 120
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 121
 testRunner.When("I enter the following in the cost field 9999999", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.Then("course Cost error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
 testRunner.And("error message for field Cost states Maximum value for cost is £999,999.99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5116 User enters no cost")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5116UserEntersNoCost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5116 User enters no cost", null, new string[] {
                        "CI"});
#line 127
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 128
 testRunner.When("I enter the following in the cost field blank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.When("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 130
 testRunner.Then("course Cost error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.And("error message for field Cost states Enter the cost in pounds and pence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5011 User Adds Provider Course ID")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5011UserAddsProviderCourseID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5011 User Adds Provider Course ID", null, new string[] {
                        "CI"});
#line 135
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 136
 testRunner.When("I enter the following in the course id field 123(A-1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 137
 testRunner.And("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5011 User does not enter Course ID")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5011UserDoesNotEnterCourseID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5011 User does not enter Course ID", null, new string[] {
                        "CI"});
#line 140
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 141
 testRunner.When("I enter the following in the course id field blank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 142
 testRunner.And("I enter the following in the URL field https://www.google.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.Then("course id error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
 testRunner.And("error message for field Course ID states Enter an ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5011 User enter Course ID greater than 255 chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5011UserEnterCourseIDGreaterThan255Chars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5011 User enter Course ID greater than 255 chars", null, new string[] {
                        "CI"});
#line 147
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 148
 testRunner.When(@"I enter the following in the course id field ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.And("I enter the following in the URL field https://www.google.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.Then("course id error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.And("error message for field Course ID states ID must be 255 characters or less", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC5011 User enters invalid Course ID")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC5011UserEntersInvalidCourseID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC5011 User enters invalid Course ID", null, new string[] {
                        "CI"});
#line 154
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 155
 testRunner.When("I enter the following in the course id field 我想输入文字", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.And("I enter the following in the URL field https://www.google.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.Then("course id error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.And("error message for field Course ID states Invalid characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4768 User Adds Cost Description")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4768UserAddsCostDescription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4768 User Adds Cost Description", null, new string[] {
                        "CI"});
#line 161
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 162
 testRunner.When("I enter the following in the cost description field 123(A-1) £!\"£$%^&*()_+ 123456" +
                    "7890-= QWERTYUIOP asdfghjklmnbvcxz #\';:@~/.,<>?|\\ qwertyuiop ASDFGHJKL ZXCVBNM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
 testRunner.And("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4768 User Adds Cost Description max chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4768UserAddsCostDescriptionMaxChars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4768 User Adds Cost Description max chars", null, new string[] {
                        "CI"});
#line 166
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 167
 testRunner.When(@"I enter the following in the cost description field ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTU", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 168
 testRunner.And("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4768 User Adds Cost Description over max chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4768UserAddsCostDescriptionOverMaxChars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4768 User Adds Cost Description over max chars", null, new string[] {
                        "CI"});
#line 171
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 172
 testRunner.When(@"I enter the following in the cost description field ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 173
 testRunner.And("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
 testRunner.Then("cost description error validation is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.And("error message for field Cost Description states Cost description must be 255 char" +
                    "acters or less", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.And("info message for field Cost Description states You have 1 character too many", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4810 User Select Attendance Evening")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4810UserSelectAttendanceEvening()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4810 User Select Attendance Evening", null, new string[] {
                        "CI"});
#line 179
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 180
 testRunner.When("I Select attendance mode Evening", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 181
 testRunner.And("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4810 User Select Attendance Weekend")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4810UserSelectAttendanceWeekend()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4810 User Select Attendance Weekend", null, new string[] {
                        "CI"});
#line 184
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 185
 testRunner.When("I Select attendance mode Weekend", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 186
 testRunner.And("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4810 User Select Attendance Day/Block Release")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4810UserSelectAttendanceDayBlockRelease()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4810 User Select Attendance Day/Block Release", null, new string[] {
                        "CI"});
#line 189
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 190
 testRunner.When("I Select attendance mode Day/Block Release", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 191
 testRunner.And("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC4810 User Select Attendance Daytime")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC4810UserSelectAttendanceDaytime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC4810 User Select Attendance Daytime", null, new string[] {
                        "CI"});
#line 194
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
this.FeatureBackground();
#line 195
 testRunner.When("I Select attendance mode Day/Block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 196
 testRunner.When("I Select attendance mode Daytime", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 197
 testRunner.And("I enter the following in the course name field Course test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
