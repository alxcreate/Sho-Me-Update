using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;



namespace Sho_Me_Update
{
    public partial class Form_Main : Form
    {
        List<Model> Models;

        static Model LinkDB;
        static Model LinkFW;
        public Form_Main()
        {
            InitializeComponent();

            CBox_DriveLetter.DataSource = System.IO.DriveInfo.GetDrives() //Получение списка съемных дисков для выпадающего списка
            .Where(d => d.DriveType == System.IO.DriveType.Removable).ToList();
            CBox_DriveLetter.DisplayMember = "Name";

            Models = new List<Model> //Список регистраторов и ссылок для скачивания баз
            {
                new Model { Id=1, Name="SHO-ME COMBO SMART SIGNATURE", LinkDB="https://speedcam.online/rd.online/shome/shome3/combo_database.zip",            LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/14-08-2020/sho-me-combo-smart-signature-firmware-rd-sw.zip"},
                new Model { Id=2, Name="SHO-ME COMBO SLIM SIGNATURE",  LinkDB="https://speedcam.online/rd.online/shome/shome3/combo_database.zip",            LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/14-08-2020/sho-me-combo-slim-signature-firmware-rd-sw.zip"},
                new Model { Id=3, Name="SHO-ME COMBO №1 SIGNATURE",    LinkDB="https://speedcam.online/rd.online/shome/shome3/combo_database.zip",            LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/14-08-2020/sho-me-combo-signature-firmware-rd-sw.zip"},
                new Model { Id=4, Name="SHO-ME COMBO DRIVE SIGNATURE", LinkDB="https://speedcam.online/rd.online/shome/shome3/combo_database.zip",            LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/14-08-2020/sho-me-combo-drive-signature-firmware-rd-sw.zip"},
                new Model { Id=5, Name="SHO-ME COMBO MINI WiFi",       LinkDB="https://speedcam.online/rd.online/shome/shome3/combo_database.zip",            LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/14-08-2020/sho-me-combo-mini-wifi-signature-firmware-rd-sw.zip"},
                new Model { Id=6, Name="",                             LinkDB="",                                                                             LinkFW=""},
                new Model { Id=7, Name="SHO-ME COMBO №1",              LinkDB="https://sho-me.ru/downloads/database/archive/sho-me-combo-1-db.zip",           LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/sho-me-combo-1-dec.zip"},
                new Model { Id=8, Name="SHO-ME COMBO №1 A7",           LinkDB="https://sho-me.ru/downloads/database/combo_database.zip",                      LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/27-12-2018/sho-me-combo-1-a7.zip"},
                new Model { Id=9, Name="SHO-ME COMBO №3",              LinkDB="https://sho-me.ru/downloads/database/archive/sho-me-combo-n3-db.zip",          LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/17-03-2016/sho-me-combo-3-software-at-30-november.zip"},
                new Model { Id=10, Name="SHO-ME COMBO №3 A7",          LinkDB="https://sho-me.ru/downloads/database/sho-me-combo-n3a7-n5a7-wombat-db.zip",    LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/combo/28-08-2018/sho-me-combo-3-a7-firmware-sn-1511.zip"},
                new Model { Id=11, Name="SHO-ME COMBO №5 A7",          LinkDB="https://sho-me.ru/downloads/database/sho-me-combo-n3a7-n5a7-wombat-db.zip",    LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/combo/28-08-2018/sho-me-combo-5-a7-firmware.zip"},
                new Model { Id=12, Name="SHO-ME COMBO №5 A12",         LinkDB="https://speedcam.online/rd.online/shome/shome3/combo_database.zip",            LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/14-08-2020/sho-me-combo-n5-a12-firmware-rd-sw.zip"},
                new Model { Id=13, Name="SHO-ME COMBO SLIM",           LinkDB="https://sho-me.ru/downloads/database/combo_database.zip",                      LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/27-12-2018/sho-me-combo-slim.zip"},
                new Model { Id=14, Name="SHO-ME COMBO SMART",          LinkDB="https://sho-me.ru/downloads/database/combo_database.zip",                      LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/27-12-2018/sho-me-combo-smart.zip"},
                new Model { Id=15, Name="SHO-ME COMBO WOMBAT",         LinkDB="https://sho-me.ru/downloads/database/sho-me-combo-n3a7-n5a7-wombat-db.zip",    LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/combo/28-08-2018/sho-me-combo-wombat-firmware.zip"},
                new Model { Id=16, Name="SHO-ME COMBO №3 iCatch",      LinkDB="https://speedcam.online/rd.online/shome/shome3/combo_database.zip",            LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/14-08-2020/sho-me-combo-3-i-catch-firmware-rd-sw.zip"},
                new Model { Id=17, Name="SHO-ME COMBO SUPER SMART",    LinkDB="https://speedcam.online/rd.online/shome/shome3/combo_database.zip",            LinkFW="https://sho-me.ru/downloads/obnovleniya/firmware/14-08-2020/sho-me-combo-super-smart-firmware-rd-sw.zip"},
            };

            CBox_Model.DataSource = Models; //Источник данных для выпадающего списка выбора модели регистратора
            CBox_Model.ValueMember = "Id";
            CBox_Model.DisplayMember = "Name";
            CBox_Model.SelectedIndexChanged += CBox_Model_SelectedIndexChanged;
            CheckBox_Clean.CheckedChanged += CheckBox_Clean_CheckedChanged;
        }
        class Model
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LinkDB { get; set; }
            public string LinkFW { get; set; }
        }
        public static bool CheckForInternetConnection(out string msg) //Проверка доступа в интернет
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead(new Uri("https://google.com")))
                {
                    msg = "";
                    return true;
                }
            }
            catch
            {
                msg = "Сеть недоступна";
                return false;
            }
        }
        public static bool CheckDownloadLinkDB(out string msg) //Проверка доступа ссылки
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead(new Uri(LinkDB.LinkDB)))
                {
                    msg = "";
                    return true;
                }
            }
            catch
            {
                msg = "Не найдена база на сайте";
                return false;
            }
        }
        public static bool CheckDownloadLinkFW(out string msg) //Проверка доступа ссылки
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead(new Uri(LinkFW.LinkFW)))
                {
                    msg = "";
                    return true;
                }
            }
            catch
            {
                msg = "Не найдена база на сайте";
                return false;
            }
        }
        public static bool CheckDriveLetter(string path, out string msg) //Проверка карты памяти
        {
            try
            {
                var dir = new DirectoryInfo(path);
                if (dir.Exists)
                {
                    msg = string.Empty;
                    return true;//The directory exists
                }
                else
                {
                    msg = "Карта памяти недоступна";
                    return false;//The path is valid, but does not exist.
                }
            }
            catch
            {
                msg = "Карта памяти недоступна";
                return false;//The path is invalid or user does not have access.
            }
        }
        void Form1_Load(object sender, EventArgs e)
        {
        }
        void Label_Title_Click(object sender, EventArgs e) //Заголовок
        {
        }
        void CBox_Model_SelectedIndexChanged(object sender, EventArgs e) //Выпадающий список выбора моделей регистраторов
        {
            Label_Status.Text = null;
            LinkDB = (Model)CBox_Model.SelectedItem;
        }
        void CBox_DriveLetter_SelectedIndexChanged(object sender, EventArgs e) //Выпадающий список выбора съемного диска
        {
            Label_Status.Text = null;
        }
        void CheckBox_Clean_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox CheckBox_Clean = (CheckBox)sender;
        }
        void Button_DownloadBase_Click(object sender, EventArgs e) //Кнопка загрузки базы данных на съемный диск
        {
            Label_Status.Text = "Загрузка...";

            LinkDB = (Model)CBox_Model.SelectedItem;
            var path = CBox_DriveLetter.SelectedValue != null ? CBox_DriveLetter.SelectedItem.ToString() : "";
            if (CheckForInternetConnection(out string errorMsg)
                    && CheckDownloadLinkDB(out errorMsg)
                    && CheckDriveLetter(path, out errorMsg))
            {
                var Drive = CBox_DriveLetter.SelectedItem.ToString();
                var FileDB = Drive + "ComboDB.bin"; //Переменная для файла
                var ArchiveDB = Drive + "combo_database.zip"; //Переменная для архива

                System.IO.DirectoryInfo drive = new DirectoryInfo(Drive);
                if (CheckBox_Clean.Checked == true)
                    foreach (FileInfo file in drive.EnumerateFiles())
                    {
                    file.Delete();
                    }
                Thread.Sleep(1000);

                var downloadDB = new WebClient(); //Скачивание архива
                downloadDB.DownloadFile(LinkDB.LinkDB, ArchiveDB);

                if (File.Exists(ArchiveDB)) //Проверка существования загруженного архива
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(ArchiveDB, Drive); //Распаковка архива
                        File.Delete(ArchiveDB);
                        Label_Status.Text = "Готово!";
                    }
                    catch
                    {
                        Label_Status.Text = "Ошибка распаковки архива. Очистите карту памяти";
                    }
                }
                else
                {
                    Label_Status.Text = "Загрузка базы не выполнена";
                }
            }
            else
            {
                Label_Status.Text = errorMsg;
            }
        }
        void Button_Download_Firmware_Click(object sender, EventArgs e) //Кнопка загрузки прошивки на съемный диск
        {
            Label_Status.Text = "Загрузка...";
            var Drive = CBox_DriveLetter.SelectedItem.ToString();
            var FileFW = Drive + "firmware.bin"; //Переменная для файла
            var ArchiveFW = Drive + "firmware.zip"; //Переменная для архива

            LinkFW = (Model)CBox_Model.SelectedItem;
            var path = CBox_DriveLetter.SelectedValue != null ? Drive : "";
            if (CheckForInternetConnection(out string errorMsg)
                    && CheckDownloadLinkFW(out errorMsg)
                    && CheckDriveLetter(path, out errorMsg))
            {
                System.IO.DirectoryInfo drive = new DirectoryInfo(Drive);
                if (CheckBox_Clean.Checked == true)
                    foreach (FileInfo file in drive.EnumerateFiles())
                    {
                        file.Delete();
                    }
                Thread.Sleep(1000);

                var downloadFW = new WebClient(); //Скачивание архива
                downloadFW.DownloadFile(LinkFW.LinkFW, ArchiveFW);

                if (File.Exists(ArchiveFW)) //Проверка существования загруженного архива
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(ArchiveFW, Drive); //Распаковка архива
                        File.Delete(ArchiveFW);
                        Label_Status.Text = "Готово!";
                    }
                    catch
                    {
                        Label_Status.Text = "Ошибка распаковки архива. Очистите карту памяти";
                    }
                }
                else
                {
                    Label_Status.Text = "Загрузка базы не выполнена";
                }
            }
            else
            {
                Label_Status.Text = errorMsg;
            }
        }

        void Label_Status_Click(object sender, EventArgs e) //Текст статуса и вывод ошибок
        {
        }
        void Button_Exit_Click(object sender, EventArgs e) //Кнопка выхода из программы
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
