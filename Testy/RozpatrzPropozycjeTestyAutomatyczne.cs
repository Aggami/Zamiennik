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
            int success = 0;
            /*Konieczne zastosowanie try, catch 
             * - w przeciwnym przypadku przy niepowodzeniu testu proces nie zostanie zakończony 
             * i zablokuje następne próby kompilacji. 
            */
        try
            {
                
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
                success = 1; // jeśli nie zostanie rzucony wyjątek, to sukces
            }
            catch(Exception e) {
                
            }
            finally
            {
                application.Kill();
                
            }

            Assert.AreEqual(1, success, "GUI Element not found");

        }

        [TestMethod]
        public void OdrzucPropozycje()
        {
            var applicationDirectory = TestContext.TestDeploymentDir;
            Application application = Application.Launch(zamiennikPath);
            int success = 0;


            try
            {

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
                komentarz.Text = "Zła propozycja.";
                Button odrzuc= rozpatrzPropozycje.Get<Button>("odrzuc");
                odrzuc.Click();
                TestStack.White.UIItems.WindowItems.Window potw = application.GetWindow("Komunikat");
                Button yes = potw.Get<Button>("yesButton");
                yes.Click();
                TestStack.White.UIItems.WindowItems.Window wyborPropozycji2 = application.GetWindow("WyborPropozycji");
                propozycje = wyborPropozycji2.Get<ListView>("Propozycje");

                wyborPropozycji.Close();
                application.Close();
                success = 1; // jeśli nie zostanie rzucony wyjątek, to sukces

            }
            catch (Exception e)
            {
            }
            finally
            {
                application.Kill();

            }
            Assert.AreEqual(1, success, "GUI Element not found");
        }

        [TestMethod]
        public void OdrzucPropozycjeBezKomentarza()
        {
            var applicationDirectory = TestContext.TestDeploymentDir;
            Application application = Application.Launch(zamiennikPath);
            int success = 0;


            try
            {

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
                Button odrzuc = rozpatrzPropozycje.Get<Button>("odrzuc");
                odrzuc.Click();
                TestStack.White.UIItems.WindowItems.Window potw = application.GetWindow("Komunikat");
                Button ok = potw.Get<Button>("okButton");
                ok.Click();
                wyborPropozycji.WaitWhileBusy();
                propozycje = wyborPropozycji.Get<ListView>("Propozycje");

                wyborPropozycji.Close();
                application.Close();
                success = 1; // jeśli nie zostanie rzucony wyjątek, to sukces

            }
            catch (Exception e)
            {

            }
            finally
            {
                application.Kill();

            }
            Assert.AreEqual(1, success, "GUI Element not found");

        }
    }
}
