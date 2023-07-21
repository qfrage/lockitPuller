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
        public GoogleSheetsConnector sheetsConnector;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sheetsConnector = new GoogleSheetsConnector();
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
    }
}
