using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.Configuration;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using System.Windows.Automation;
using TestStack.White;


namespace Testy
{
    /// <summary>
    /// Opis podsumowujący elementu RozpatrzPropozycjeTestyAutomatyczne
    /// </summary>
    [TestClass]
    public class RozpatrzPropozycjeTestyAutomatyczne 
    {
        private string zamiennikPath = @"C:\Users\aggam\source\repos\Zamiennik2\Zamiennik\bin\Debug\Zamiennik.exe";


        public RozpatrzPropozycjeTestyAutomatyczne()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Pobiera lub ustawia kontekst testu, który udostępnia
        ///funkcjonalność i informację o bieżącym przebiegu testu.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        

        [TestMethod]
        public void AkceptujPropozycje()
        {
            var applicationDirectory = TestContext.TestDeploymentDir;
            Application application = Application.Launch(zamiennikPath);
            TestStack.White.UIItems.WindowItems.Window mainwindow = application.GetWindow("Menu");
            mainwindow.WaitWhileBusy();
            Button rozpProp = mainwindow.Get<Button>("propozycje");
            rozpProp.Click();
            mainwindow.WaitWhileBusy();
            TestStack.White.UIItems.WindowItems.Window wyborPropozycji = application.GetWindow("WyborPropozycji");
            ListView propozycje = wyborPropozycji.Get<ListView>("Propozycje");
            propozycje.Rows[0].Click();
            TestStack.White.UIItems.WindowItems.Window rozpatrzPropozycje = application.GetWindow("Rozpatrz propozycję zamiennika");
            Button kartyPrzedm = rozpatrzPropozycje.Get<Button>("pokazKartyPrzedm");
            kartyPrzedm.Click();
            TestStack.White.UIItems.WindowItems.Window podgladPDF = application.GetWindow("PodgladPDF");
            podgladPDF.Close();
            TextBox komentarz = rozpatrzPropozycje.Get<TextBox>("komentarz");
            komentarz.Text = "Dobra propozycja.";
            Button zaakceptuj = rozpatrzPropozycje.Get<Button>("zaakceptuj");
            zaakceptuj.Click();
            TestStack.White.UIItems.WindowItems.Window potw = application.GetWindow("Komunikat");
            Button yes = potw.Get<Button>("yesButton");
            yes.Click();
            wyborPropozycji.Close();
            application.Close();

        }
    }
}
