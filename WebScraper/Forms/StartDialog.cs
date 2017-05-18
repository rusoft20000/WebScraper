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
using System.Data.SQLite;
using System.Windows.Forms;

namespace WebScraper
{
    public partial class StartDialog : Form
    {
        public StartDialog()
        {
            InitializeComponent();
         

        }

        private void SelectDBfile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "SQlLite files|*.db3";
            openFileDialog.FileName = "";
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                pathDB.Text = openFileDialog.FileName;
                // Initialize the SQLite Connection
                IDbConnection conn = new SQLiteConnection("Data Source=" + pathDB.Text + ";Version=3;");
                SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
                conn.Open();
                projectURL.DataSource = conn.GetList<Project>();
                projectURL.DisplayMember = "ProjectURL";
                projectURL.ValueMember = "ProjectURL";
             //projectURL.SelectedIndexChanged += projectURL_SelectedIndexChanged;


            }

        }

        private void StartScraping_Click(object sender, EventArgs e)
        {
            // Initialize the SQLite Connection
             IDbConnection conn = new SQLiteConnection("Data Source=" + pathDB.Text + ";Version=3;");
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
            conn.Open();
                              
            // Initialize WebDriver
            var url = projectURL.SelectedValue.ToString(); 
            IWebDriver driver = Scraper.OpenWebSite(url, SelectedDriver.SelectedItem.ToString());
            Scraper.CleanDB(conn);
           Scraper.ParsingNode1(driver, conn);
            Scraper.ParsingNode2(driver, conn);
            Scraper.ParsingNode2a(driver, conn);
            Scraper.ParsingNode3(driver, conn);
            Scraper.ParsingNode4(driver, conn);
            Scraper.ParsingNode5(driver, conn);
            Scraper.UpdFieledName(driver, conn);

            conn.Close();
        }

     
    }
}
