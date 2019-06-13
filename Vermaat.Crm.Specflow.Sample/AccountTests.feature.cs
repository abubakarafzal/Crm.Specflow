// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Vermaat.Crm.Specflow.Sample
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("AccountTests", Description="\tSome tests involving the account entity", SourceFile="AccountTests.feature", SourceLine=0)]
    public partial class AccountTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccountTests.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AccountTests", "\tSome tests involving the account entity", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Create a new Account", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=4)]
        public virtual void CreateANewAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a new Account", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table1.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table1.AddRow(new string[] {
                        "Main Phone",
                        "06123456789"});
            table1.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table1.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 6
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table2.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table2.AddRow(new string[] {
                        "Main Phone",
                        "06123456789"});
            table2.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table2.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 12
testRunner.Then("TestAccount has the following values", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Update an existing Account", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=19)]
        public virtual void UpdateAnExistingAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update an existing Account", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table3.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table3.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table3.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table3.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 21
testRunner.Given("an account named TestAccount with the following values", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table4.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands B.V."});
            table4.AddRow(new string[] {
                        "Main Phone",
                        "06987654321"});
            table4.AddRow(new string[] {
                        "Fax",
                        "4839432324"});
#line 27
testRunner.When("TestAccount is updated with the following values", ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table5.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands B.V."});
            table5.AddRow(new string[] {
                        "Main Phone",
                        "06987654321"});
            table5.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table5.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 32
testRunner.Then("TestAccount has the following values", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check visiblity of form items", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=40)]
        public virtual void CheckVisiblityOfFormItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check visiblity of form items", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table6.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table6.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table6.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table6.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 42
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "State"});
            table7.AddRow(new string[] {
                        "SIC Code",
                        "Visible"});
            table7.AddRow(new string[] {
                        "Ownership",
                        "Invisible"});
#line 48
testRunner.Then("TestAccount\'s form has the following form state", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Create Account - Check two option fields", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=53)]
        public virtual void CreateAccount_CheckTwoOptionFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Account - Check two option fields", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table8.AddRow(new string[] {
                        "Account Name",
                        "Checkbox"});
            table8.AddRow(new string[] {
                        "Do not allow Phone Calls",
                        "Do Not Allow"});
            table8.AddRow(new string[] {
                        "Do not allow Faxes",
                        "Do Not Allow"});
            table8.AddRow(new string[] {
                        "Do not allow Mails",
                        "Do Not Allow"});
#line 55
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table9.AddRow(new string[] {
                        "Account Name",
                        "Checkbox"});
            table9.AddRow(new string[] {
                        "Do not allow Phone Calls",
                        "Do Not Allow"});
            table9.AddRow(new string[] {
                        "Do not allow Faxes",
                        "Do Not Allow"});
            table9.AddRow(new string[] {
                        "Do not allow Mails",
                        "Do Not Allow"});
#line 61
testRunner.Then("TestAccount has the following values", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Clearing values of Account", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=68)]
        public virtual void ClearingValuesOfAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clearing values of Account", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 69
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table10.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table10.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table10.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table10.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 70
testRunner.Given("an account named TestAccount with the following values", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table11.AddRow(new string[] {
                        "Industry",
                        ""});
            table11.AddRow(new string[] {
                        "Website",
                        ""});
#line 76
testRunner.When("TestAccount is updated with the following values", ((string)(null)), table11, "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table12.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table12.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table12.AddRow(new string[] {
                        "Website",
                        ""});
            table12.AddRow(new string[] {
                        "Industry",
                        ""});
#line 80
testRunner.Then("TestAccount has the following values", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Setting values while switching tabs", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=87)]
        public virtual void SettingValuesWhileSwitchingTabs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setting values while switching tabs", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 88
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table13.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table13.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table13.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table13.AddRow(new string[] {
                        "Credit Hold",
                        "Yes"});
            table13.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
#line 89
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table13, "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table14.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table14.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table14.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table14.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table14.AddRow(new string[] {
                        "Credit Hold",
                        "Yes"});
#line 96
testRunner.Then("TestAccount has the following values", ((string)(null)), table14, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Full Merge of two accounts into one", new string[] {
                "API",
                "Cleanup"}, SourceLine=104)]
        public virtual void FullMergeOfTwoAccountsIntoOne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Full Merge of two accounts into one", null, new string[] {
                        "API",
                        "Cleanup"});
#line 105
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table15.AddRow(new string[] {
                        "Account Name",
                        "Merging Source"});
            table15.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
#line 106
testRunner.Given("an account named MergeSource with the following values", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table16.AddRow(new string[] {
                        "Account Name",
                        "Merging Target"});
            table16.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table16.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 110
testRunner.Given("an account named MergeTarget with the following values", ((string)(null)), table16, "Given ");
#line 115
testRunner.When("MergeSource is fully merged into MergeTarget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table17.AddRow(new string[] {
                        "Account Name",
                        "Merging Source"});
            table17.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table17.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table17.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
#line 116
testRunner.Then("MergeTarget has the following values", ((string)(null)), table17, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Partial Merge of two accounts into one", new string[] {
                "API",
                "Cleanup"}, SourceLine=123)]
        public virtual void PartialMergeOfTwoAccountsIntoOne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Partial Merge of two accounts into one", null, new string[] {
                        "API",
                        "Cleanup"});
#line 124
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table18.AddRow(new string[] {
                        "Account Name",
                        "Merging Source"});
            table18.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
#line 125
testRunner.Given("an account named MergeSource with the following values", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table19.AddRow(new string[] {
                        "Account Name",
                        "Merging Target"});
            table19.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table19.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 129
testRunner.Given("an account named MergeTarget with the following values", ((string)(null)), table19, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property"});
            table20.AddRow(new string[] {
                        "Main Phone"});
#line 134
testRunner.When("The following fields of MergeSource are fully merged into MergeTarget", ((string)(null)), table20, "When ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table21.AddRow(new string[] {
                        "Account Name",
                        "Merging Target"});
            table21.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table21.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table21.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
#line 137
testRunner.Then("MergeTarget has the following values", ((string)(null)), table21, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
