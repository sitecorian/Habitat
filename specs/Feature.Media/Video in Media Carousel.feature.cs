﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Media.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class VideoInMediaCarouselFeature : Xunit.IClassFixture<VideoInMediaCarouselFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Video in Media Carousel.feature"
#line hidden
        
        public VideoInMediaCarouselFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Video in Media Carousel", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(VideoInMediaCarouselFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC1_Review default video item")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC1_ReviewDefaultVideoItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC1_Review default video item", new string[] {
                        "NeedIMplementation"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table1.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
#line 8
 testRunner.Then("Following video presents", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC2_New video was added to Carousel")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC2_NewVideoWasAddedToCarousel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC2_New video was added to Carousel", new string[] {
                        "NeedIMplementation"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video test source"});
            table2.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\Sitecore CMS.mp4"});
#line 17
 testRunner.And("<Sitecore CMS.mp4> video should be added to Media library Habitat, Saved and Publ" +
                    "ished", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Image test source"});
            table3.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\HabitatTest.jpg"});
#line 21
 testRunner.And("<Sitecore CMS.mp4> thumbnail should be added to Media library Habitat, Saved and " +
                    "Published", ((string)(null)), table3, "And ");
#line 25
 testRunner.When("User starts Video item creation under Habitat Shared Media", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.And("User inserts <Sitecore CMS.mp4 path> into Link to video: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("User inserts <Habitat-001-wide path> image into Thumbnail field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("User moves <Sitecore CMS.mp4> item to Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table4.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
            table4.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore CMS.mp4"});
#line 38
 testRunner.And("Following video presents", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Thumbnail path"});
            table5.AddRow(new string[] {
                        "/-/media/Habitat/Images/Wide/HabitatTest.jpg"});
#line 42
 testRunner.And("Following thumbnail presents", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC3_New video was added to Carousel_Link to video field i" +
            "s empty and thumbnail filled")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC3_NewVideoWasAddedToCarousel_LinkToVideoFieldIsEmptyAndThumbnailFilled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC3_New video was added to Carousel_Link to video field i" +
                    "s empty and thumbnail filled", new string[] {
                        "NeedIMplementation"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Image test source"});
            table6.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\HabitatTest.jpg"});
#line 50
 testRunner.And("<Sitecore CMS.mp4> thumbnail should be added to Media library Habitat, Saved and " +
                    "Published", ((string)(null)), table6, "And ");
#line 53
 testRunner.When("User starts Video item creation under Habitat Shared Media", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.And("User inserts <Habitat-001-wide path> image into Thumbnail field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("User moves <Sitecore CMS.mp4> item to Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table7.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
#line 65
 testRunner.And("Following video presents", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table8.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore CMS.mp4"});
#line 68
 testRunner.And("Following video absents", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Thumbnail path"});
            table9.AddRow(new string[] {
                        "/-/media/Habitat/Images/Wide/HabitatTest.jpg"});
#line 71
 testRunner.And("Following thumbnail presents", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC4_New video was added to Carousel_Link to video field i" +
            "s empty and thumbnail empty")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC4_NewVideoWasAddedToCarousel_LinkToVideoFieldIsEmptyAndThumbnailEmpty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC4_New video was added to Carousel_Link to video field i" +
                    "s empty and thumbnail empty", new string[] {
                        "NeedIMplementation"});
#line 76
this.ScenarioSetup(scenarioInfo);
#line 77
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video source"});
            table10.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\Sitecore CMS.mp4"});
#line 78
 testRunner.And("<Sitecore CMS.mp4> video should be added to Media library Habitat, Saved and Publ" +
                    "ished", ((string)(null)), table10, "And ");
#line 82
 testRunner.When("User starts Video item creation under Habitat Shared Media", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("User moves <Sitecore CMS.mp4> item to Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table11.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
#line 93
 testRunner.And("Following video presents", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table12.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore CMS.mp4"});
#line 96
 testRunner.And("Following video absents", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Thumbnail path"});
            table13.AddRow(new string[] {
                        "/-/media/Habitat/Images/Wide/HabitatTest.jpg"});
#line 99
 testRunner.And("Following thumbnail absents", ((string)(null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC5_New video was added to Carousel_Link to video field i" +
            "s filled and thumbnail empty")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC5_NewVideoWasAddedToCarousel_LinkToVideoFieldIsFilledAndThumbnailEmpty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC5_New video was added to Carousel_Link to video field i" +
                    "s filled and thumbnail empty", new string[] {
                        "NeedIMplementation"});
#line 104
this.ScenarioSetup(scenarioInfo);
#line 105
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video source"});
            table14.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\Sitecore CMS.mp4"});
#line 106
 testRunner.And("<Sitecore CMS.mp4> video should be added to Media library Habitat, Saved and Publ" +
                    "ished", ((string)(null)), table14, "And ");
#line 110
 testRunner.When("User starts Video item creation under Habitat Shared Media", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
 testRunner.And("User inserts <Sitecore CMS.mp4 path> into Link to video: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("User moves <Sitecore CMS.mp4> item to Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table15.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
            table15.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore CMS.mp4"});
#line 122
 testRunner.And("Following video presents", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Thumbnail path"});
            table16.AddRow(new string[] {
                        "/-/media/Habitat/Images/Wide/HabitatTest.jpg"});
#line 126
 testRunner.And("Following thumbnail absents", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC6_Video was removed from carousel")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC6_VideoWasRemovedFromCarousel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC6_Video was removed from carousel", new string[] {
                        "NeedIMplementation"});
#line 131
this.ScenarioSetup(scenarioInfo);
#line 132
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 133
 testRunner.When("And User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.And("User removes <Sitecore-Experience.mp4> item from Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table17.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
#line 141
 testRunner.And("Following video absents", ((string)(null)), table17, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                VideoInMediaCarouselFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                VideoInMediaCarouselFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
