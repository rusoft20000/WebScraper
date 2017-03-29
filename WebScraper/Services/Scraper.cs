using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WebScraper
{
    public static class Scraper
    {

        static public IWebDriver OpenWebSite(string url, string driverName)
        {

            IWebDriver driver = CurrentWebDriver(driverName);


            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));     // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            return driver;


        }





        static public void ParsingNode1(IWebDriver driver, IDbConnection cnn)

        {

            List<IWebElement> DataList = driver.FindElements(By.XPath("//*[@id='mainSection']/div[2]/div/ul/li/a")).ToList();


            int DataListCount = driver.FindElements(By.XPath("//*[@id='mainSection']/div[2]/div/ul/li/a")).Count;

            for (var i = 0; i < DataListCount; i++)
            {

                string url = DataList.ElementAt(i).GetAttribute("href");
                string fieldName = DataList.ElementAt(i).Text;
                string fieldValue = DataList.ElementAt(i).Text;
                string parentUrl = "https://msdn.microsoft.com/en-us/library/windows/desktop/ff818516(v=vs.85).aspx";
                string parentField = "Windows API Index";
                string parentValue = "Windows API Index";
                int level = 1;
                string localUrl = "";
                DateTime dateCreated = DateTime.Now;
                cnn.Insert(new DataScraping
                {
                    Url = url,
                    FieldName = fieldName,
                    FieldValue = fieldValue,
                    ParentUrl = parentUrl,
                    ParentField = parentField,
                    ParentValue = parentValue,
                    Level = level,
                    LocalUrl = localUrl,
                });
            }

        }


        static public void ParsingNode2(IWebDriver driver, IDbConnection cnn)
        {
            var ParentNodeList = cnn.GetList<DataScraping>("where Level=1");
            int r = 0;
            foreach (var PNode in ParentNodeList)
            {
                r = r + 1;
                var Node_Url = PNode.Url;
                driver.Navigate().GoToUrl(Node_Url);
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));
                //                                                        
                List<IWebElement> DataList = driver.FindElements(By.XPath("//*[@id='mainSection']/ul[" + r + "]/li/a")).ToList();

                int DataListCount = driver.FindElements(By.XPath("//*[@id='mainSection']/ul[" + r + "]/li/a")).Count;
                //                                               //*[@id="mainSection"]/ul[" + r + "]/li/p/a
                for (var i = 0; i < DataListCount; i++)
                {
                    string url = DataList.ElementAt(i).GetAttribute("href");
                    string fieldName = DataList.ElementAt(i).Text;
                    string fieldValue = DataList.ElementAt(i).Text;
                    string parentUrl = PNode.Url;
                    string parentField = PNode.FieldName;
                    string parentValue = PNode.FieldValue;
                    int level = 2;
                    string localUrl = "";
                    DateTime dateCreated = DateTime.Now;

                    cnn.Insert(new DataScraping
                    {
                        Url = url,
                        FieldName = fieldName,
                        FieldValue = fieldValue,
                        ParentUrl = parentUrl,
                        ParentField = parentField,
                        ParentValue = parentValue,
                        Level = level,
                        LocalUrl = localUrl,
                    });
                }

                //   insert addicional items tagname <p/>       //*[@id="mainSection"]/ul[" + r + "]/li/p/a
                List<IWebElement> DataList1 = driver.FindElements(By.XPath("//*[@id='mainSection']/ul[" + r + "]/li/p/a")).ToList();

                int DataListCount1 = driver.FindElements(By.XPath("//*[@id='mainSection']/ul[" + r + "]/li/p/a")).Count;
                for (var i = 0; i < DataListCount1; i++)
                {
                    string url = DataList1.ElementAt(i).GetAttribute("href");
                    string fieldName = DataList1.ElementAt(i).Text;
                    string fieldValue = DataList1.ElementAt(i).Text;
                    string parentUrl = PNode.Url;
                    string parentField = PNode.FieldName;
                    string parentValue = PNode.FieldValue;
                    int level = 2;
                    string localUrl = "";
                    DateTime dateCreated = DateTime.Now;

                    cnn.Insert(new DataScraping
                    {
                        Url = url,
                        FieldName = fieldName,
                        FieldValue = fieldValue,
                        ParentUrl = parentUrl,
                        ParentField = parentField,
                        ParentValue = parentValue,
                        Level = level,
                        LocalUrl = localUrl,
                    });
                }


            }
        }

        static public void ParsingNode2a(IWebDriver driver, IDbConnection cnn)
        {
            var ParentNodeList = cnn.GetList<DataScraping>("where Level=1");
            int r = 0;
            foreach (var PNode in ParentNodeList)
            {
                r = r + 1;
                var Node_Url = PNode.Url;
                driver.Navigate().GoToUrl(Node_Url);
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));

                List<IWebElement> DataList = driver.FindElements(By.XPath("//*[@id='mainSection']/ul[" + r + "]/li/ul/li/a")).ToList();
                int DataListCount = driver.FindElements(By.XPath("//*[@id='mainSection']/ul[" + r + "]/li/ul/li/a")).Count;

                for (var i = 0; i < DataListCount; i++)
                {
                    string url = DataList.ElementAt(i).GetAttribute("href");
                    string fieldName = DataList.ElementAt(i).Text;
                    string fieldValue = DataList.ElementAt(i).Text;
                    string parentUrl = PNode.Url;
                    string parentField = PNode.FieldName;
                    string parentValue = PNode.FieldValue;
                    int level = 2;
                    string localUrl = "";
                    DateTime dateCreated = DateTime.Now;

                    cnn.Insert(new DataScraping
                    {
                        Url = url,
                        FieldName = fieldName,
                        FieldValue = fieldValue,
                        ParentUrl = parentUrl,
                        ParentField = parentField,
                        ParentValue = parentValue,
                        Level = level,
                        LocalUrl = localUrl,
                    });
                }
            }
        }

        static public void ParsingNode3(IWebDriver driver, IDbConnection cnn)
        {
            var ParentNodeList = cnn.GetList<DataScraping>("where Level=2");
            int r = 0;
            foreach (var PNode in ParentNodeList)
            {
                r = r + 1;
                var Node_Url = PNode.Url;
                driver.Navigate().GoToUrl(Node_Url);
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));

                List<IWebElement> DataList = driver.FindElements(By.CssSelector("a[href*='https://msdn.microsoft.com/en-us/library/windows/desktop/']")).ToList();
                int DataListCount = driver.FindElements(By.CssSelector("a[href*='https://msdn.microsoft.com/en-us/library/windows/desktop/']")).Count;

                for (var i = 0; i < DataListCount; i++)
                {



                    string url = DataList.ElementAt(i).GetAttribute("href");
                    string fieldName = DataList.ElementAt(i).Text;
                    string fieldValue = DataList.ElementAt(i).Text;
                    string parentUrl = PNode.Url;
                    string parentField = PNode.FieldName;
                    string parentValue = PNode.FieldValue;
                    int level = 3;
                    string localUrl = "";
                    DateTime dateCreated = DateTime.Now;

                    cnn.Insert(new DataScraping
                    {
                        Url = url,
                        FieldName = fieldName,
                        FieldValue = fieldValue,
                        ParentUrl = parentUrl,
                        ParentField = parentField,
                        ParentValue = parentValue,
                        Level = level,
                        LocalUrl = localUrl,
                    });


                }
            }
        }


        static public void ParsingNode4(IWebDriver driver, IDbConnection cnn)
        {
            var ParentNodeList = cnn.GetList<DataScraping>("where Level=3");
            int r = 0;
            foreach (var PNode in ParentNodeList)
            {
                r = r + 1;
                var Node_Url = PNode.Url;
                driver.Navigate().GoToUrl(Node_Url);
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));

                List<IWebElement> DataList = driver.FindElements(By.CssSelector("a[href*='https://msdn.microsoft.com/en-us/library/windows/desktop/']")).ToList();
                int DataListCount = driver.FindElements(By.CssSelector("a[href*='https://msdn.microsoft.com/en-us/library/windows/desktop/']")).Count;

                for (var i = 0; i < DataListCount; i++)
                {



                    string url = DataList.ElementAt(i).GetAttribute("href");
                    string fieldName = DataList.ElementAt(i).Text;
                    string fieldValue = DataList.ElementAt(i).Text;
                    string parentUrl = PNode.Url;
                    string parentField = PNode.FieldName;
                    string parentValue = PNode.FieldValue;
                    int level = 4;
                    string localUrl = "";
                    DateTime dateCreated = DateTime.Now;

                    cnn.Insert(new DataScraping
                    {
                        Url = url,
                        FieldName = fieldName,
                        FieldValue = fieldValue,
                        ParentUrl = parentUrl,
                        ParentField = parentField,
                        ParentValue = parentValue,
                        Level = level,
                        LocalUrl = localUrl,
                    });


                }
            }

        }


        static public void ParsingNode5(IWebDriver driver, IDbConnection cnn)
        {
            var ParentNodeList = cnn.GetList<DataScraping>("where Level=4");
            int r = 0;
            foreach (var PNode in ParentNodeList)
            {
                r = r + 1;
                var Node_Url = PNode.Url;
                driver.Navigate().GoToUrl(Node_Url);
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));

                List<IWebElement> DataList = driver.FindElements(By.CssSelector("a[href*='https://msdn.microsoft.com/en-us/library/windows/desktop/']")).ToList();
                int DataListCount = driver.FindElements(By.CssSelector("a[href*='https://msdn.microsoft.com/en-us/library/windows/desktop/']")).Count;

                for (var i = 0; i < DataListCount; i++)
                {



                    string url = DataList.ElementAt(i).GetAttribute("href");
                    string fieldName = DataList.ElementAt(i).Text;
                    string fieldValue = DataList.ElementAt(i).Text;
                    string parentUrl = PNode.Url;
                    string parentField = PNode.FieldName;
                    string parentValue = PNode.FieldValue;
                    int level = 5;
                    string localUrl = "";
                    DateTime dateCreated = DateTime.Now;

                    cnn.Insert(new DataScraping
                    {
                        Url = url,
                        FieldName = fieldName,
                        FieldValue = fieldValue,
                        ParentUrl = parentUrl,
                        ParentField = parentField,
                        ParentValue = parentValue,
                        Level = level,
                        LocalUrl = localUrl,
                    });


                }
            }
        }


        static public void UpdFieledName(IWebDriver driver, IDbConnection cnn)
        {
            var ParentNodeList = cnn.GetList<H1_list>();
            //("SELECT DataScraping.Url, DataScraping.FieldName FROM DataScraping GROUP BY DataScraping.Url, DataScraping.FieldName HAVING((DataScraping.FieldName) = ''");
            int r = 0;
            foreach (var PNode in ParentNodeList)
            {

                var Node_Url = PNode.Url;
                driver.Navigate().GoToUrl(Node_Url);
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));
                string fieldName = driver.FindElement(By.TagName("h1")).Text;
                cnn.Execute("UPDATE DataScraping SET FieldName ='" + fieldName + "' WHERE Url ='"+ Node_Url+"'");


            }
        }





        public static bool Exists(this IWebElement element)
        {
            if (element == null)
            { return false; }
            return true;
        }
        static public void CleanDB(IDbConnection cnn)
        {

            cnn.DeleteList<DataScraping>("where Id > 0");


        }
        static public void CleanDBNode(IDbConnection cnn, string fieldName, int level)
        {

            cnn.DeleteList<DataScraping>("where FiledName = fieldName and Level=level");


        }
        public static IWebElement FindElementSafe(this IWebDriver driver, By by)
        {
            try
            {
                return driver.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebDriver CurrentWebDriver(string driverName)
        {
            switch (driverName)
            {
                case "Chrome Driver":
                    {
                        IWebDriver driver = new ChromeDriver();
                        return driver;
                    }
                case "PhantomJS Driver":
                    {
                        IWebDriver driver = new PhantomJSDriver();
                        return driver;
                    }
                default:
                    {
                        IWebDriver driver = new PhantomJSDriver();
                        return driver;
                    }
            }
        }





        static public Byte[] GetFileData(string url)
        {
            byte[] rawData = File.ReadAllBytes(url);
            return rawData;
        }



        static public void DownloadWebFile(string url, string localFilePath)
        {

            string filename = Path.GetFileName(url);
            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            string localFile = localFilePath + "\\" + filename;



            if (filename.Length > 0)
            { myWebClient.DownloadFile(url, localFile); }
            else
            {
                // myWebClient.DownloadFile(url, localFile); 
            }




        }
    }
}