﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowTiendaSpecs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AgregarArticuloALaVentaFeature : object, Xunit.IClassFixture<AgregarArticuloALaVentaFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AgregarArticuloALaVenta.feature"
#line hidden
        
        public AgregarArticuloALaVentaFeature(AgregarArticuloALaVentaFeature.FixtureData fixtureData, SpecFlowTiendaSpecs_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Agregar articulo a la venta", "    Como vendedor\r\n    Quiero agregar articulos a la venta\r\n    Para reflejar la " +
                    "seleccion del cliente y conocer el total", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Listar combinaciones de talle y stock e informacion de articulo existente")]
        [Xunit.TraitAttribute("FeatureTitle", "Agregar articulo a la venta")]
        [Xunit.TraitAttribute("Description", "Listar combinaciones de talle y stock e informacion de articulo existente")]
        public virtual void ListarCombinacionesDeTalleYStockEInformacionDeArticuloExistente()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Listar combinaciones de talle y stock e informacion de articulo existente", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
        testRunner.Given("una venta en proceso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Codigo",
                            "Marca",
                            "Descripcion"});
                table1.AddRow(new string[] {
                            "123",
                            "Lacoste",
                            "Remera fachera"});
#line 10
        testRunner.And("existe un articulo con el codigo 123, con la informacion:", ((string)(null)), table1, "And ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Talle",
                            "Color",
                            "Stock"});
                table2.AddRow(new string[] {
                            "32",
                            "negro",
                            "5"});
                table2.AddRow(new string[] {
                            "36",
                            "blanco",
                            "4"});
                table2.AddRow(new string[] {
                            "38",
                            "rosa",
                            "0"});
#line 13
        testRunner.And("existen las siguientes combinaciones de talle y color para el articulo 123:", ((string)(null)), table2, "And ");
#line hidden
#line 18
        testRunner.When("ingreso el codigo 123", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Marca",
                            "Descripcion"});
                table3.AddRow(new string[] {
                            "Lacoste",
                            "Remera fachera"});
#line 19
        testRunner.Then("se debe mostrar la siguiente informacion del articulo:", ((string)(null)), table3, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Talle",
                            "Color",
                            "Stock"});
                table4.AddRow(new string[] {
                            "32",
                            "negro",
                            "5"});
                table4.AddRow(new string[] {
                            "36",
                            "blanco",
                            "4"});
#line 22
        testRunner.And("Se deben listar las siguientes combinaciones de talle y color con stock mayor a 0" +
                        ":", ((string)(null)), table4, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AgregarArticuloALaVentaFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AgregarArticuloALaVentaFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
