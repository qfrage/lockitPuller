using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System.Threading;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;

namespace lockitPuller
{
    public partial class Form1 : Form
    {
        List <string> allSheets;
        public GoogleSheetsConnector sheetsConnector;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sheetsConnector = new GoogleSheetsConnector();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            var sheetID = sheetIDTextBox.Text;
            if (sheetID.Length == 0) MessageBox.Show("Пустое поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                allSheets = sheetsConnector.GetAllSheetsInTable("1qHmaPT2-6_KsE9h_5XcDXIqS7wVpim_CvZusov3T04A");
                foreach (string sheet in allSheets)
                {
                    allSheetsComboBox.Items.Add(sheet);
                }
                allSheetsComboBox.SelectedIndex = 0;
            }
            
        }
    }

    public class GoogleSheetsConnector
    {
        private SheetsService _sheetsService;

        public GoogleSheetsConnector()
        {
            // При изменении этих областей удалите ранее сохраненные учетные данные.
            // в ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
            string[] Scopes = { SheetsService.Scope.Spreadsheets };
            string ApplicationName = "Excel to Google Sheet";

            UserCredential credential;
            try
            {
                using (var stream =
                new FileStream("Credentials/credentials.json", FileMode.Open, FileAccess.Read))
                {
                    // Файл token.json хранит токены доступа и обновления пользователя и создается
                    // автоматически, когда поток авторизации завершается в первый раз.
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }

                // Создать службу API Google Таблиц
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
                _sheetsService = service;
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к Google таблице");
            }

        }

        public List<string> GetAllSheetsInTable(string spreadsheetId)
        {
            var spreadsheet = _sheetsService.Spreadsheets.Get(spreadsheetId).Execute();
            var sheets = spreadsheet.Sheets;
            List<string> foundSheets = new List<string>();

            if (sheets != null)
            {
                foreach (var sheet in sheets)
                {
                    string sheetInfo = $"- {sheet.Properties.Title} (Id: {sheet.Properties.SheetId})";
                    foundSheets.Add(sheetInfo);
                }
            }

            return foundSheets;
        }

    }
}
