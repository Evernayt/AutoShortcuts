using AutoShortcuts.Properties;
using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AutoShortcuts
{
    public partial class fmMain : Form
    {
        private bool allowShowDisplay = false;
        string mainPath = Settings.Default.mainPath;
        string monthPath = Settings.Default.monthPath;
        bool newMonthFound = false;
        readonly string iconsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Auto Shortcuts Icons";
        readonly string monthIcon = "\\month.ico";
        readonly string tempIcon = "\\temp.ico";
        readonly string sublimIcon = "\\sublim.ico";
        readonly string printPhotoIcon = "\\printPhoto.ico";
        readonly string canvasIcon = "\\canvas.ico";
        string tempPath, sublimPath, printPhotoPath, canvasPath;

        public fmMain()
        {
            InitializeComponent();

            Rectangle workingArea = Screen.GetWorkingArea(this);
            Location = new Point(workingArea.Right - Width - 10, workingArea.Bottom - Height - 10);

            SetAutorunText(Settings.Default.autorun);
            if (Settings.Default.firstRun)
            {
                Settings.Default.firstRun = false;
                SetAutorun(true);
            }

            FindMonthFolder();
            AutoShortcutsCreate();
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowShowDisplay ? value : allowShowDisplay);
        }

        private void ShowForm()
        {
            allowShowDisplay = true;
            Show();
        }

        private void FindMonthFolder()
        {
            string monthName = DateTime.Now.ToString("MMMM");
            lblCurrentMonth.Text = $"Месяц: {monthName}";

            if (string.IsNullOrEmpty(mainPath))
            {
                DialogResult result = MessageBox.Show("Не указана основная папка.\nНажмите ОК, чтобы открыть настройки.",
                    Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    ShowForm();
                    btnSettings.PerformClick();
                }
                return;
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(mainPath);
            DirectoryInfo[] monthDirs = directoryInfo.GetDirectories($"*{monthName}*");

            if (monthDirs.Length < 1)
            {
                lblInfo.Text = "Не удалось найти папку месяца";
                lblInfo.ForeColor = Color.DarkRed;
                return;
            }

            lblInfo.Text = $"Папка месяца: {monthDirs[0].Name.Replace(" ", "")}";
            lblInfo.ForeColor = Color.Gray;

            monthPath = monthDirs[0].FullName;
            Settings.Default.monthPath = monthPath;
            Settings.Default.Save();

            newMonthFound = true;
        }

        public void CreateShortcut(string targetPath, string shortcutFile, string iconLocation)
        {
            if (string.IsNullOrEmpty(targetPath))
            {
                throw new ArgumentNullException("TargetPath");
            }
            if (string.IsNullOrEmpty(shortcutFile))
            {
                throw new ArgumentNullException("ShortcutFile");
            }

            WshShellClass wshShell = new WshShellClass();
            IWshShortcut shorcut = (IWshShortcut)wshShell.CreateShortcut(shortcutFile);

            shorcut.TargetPath = targetPath;
            shorcut.IconLocation = iconLocation;
            shorcut.Save();
        }

        private bool FindMonthFolders()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(monthPath);
            DirectoryInfo[] tempDirs = directoryInfo.GetDirectories("*ВРЕМЕННО*");
            DirectoryInfo[] sublimDirs = directoryInfo.GetDirectories("*СУБЛИМАЦИЯ*");
            DirectoryInfo[] printPhotoDirs = directoryInfo.GetDirectories("*ПЕЧАТЬ ФОТО*");
            DirectoryInfo[] canvasDirs = directoryInfo.GetDirectories("*ХОЛСТЫ*");

            if (tempDirs.Length < 1 || sublimDirs.Length < 1 || printPhotoDirs.Length < 1 || canvasDirs.Length < 1)
            {
                return false;
            }

            tempPath = tempDirs[0].FullName;
            sublimPath = sublimDirs[0].FullName;
            printPhotoPath = printPhotoDirs[0].FullName;
            canvasPath = canvasDirs[0].FullName;

            return true;
        }

        private void ShortcutsCreate()
        {
            if (string.IsNullOrEmpty(mainPath) || string.IsNullOrEmpty(monthPath))
            {
                DialogResult result = MessageBox.Show("Не указана основная папка или папка месяца.\nНажмите ОК, чтобы открыть настройки.",
                    Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    btnSettings.PerformClick();
                }
                return;
            }

            Directory.CreateDirectory(iconsFolder);

            using (FileStream stream = new FileStream(iconsFolder + monthIcon, FileMode.Create))
            {
                Resources.month.Save(stream);
            }
            using (FileStream stream = new FileStream(iconsFolder + tempIcon, FileMode.Create))
            {
                Resources.temp.Save(stream);
            }
            using (FileStream stream = new FileStream(iconsFolder + sublimIcon, FileMode.Create))
            {
                Resources.sublim.Save(stream);
            }
            using (FileStream stream = new FileStream(iconsFolder + printPhotoIcon, FileMode.Create))
            {
                Resources.printPhoto.Save(stream);
            }
            using (FileStream stream = new FileStream(iconsFolder + canvasIcon, FileMode.Create))
            {
                Resources.canvas.Save(stream);
            }

            if (FindMonthFolders())
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string monthName = DateTime.Now.ToString("MMMM");

                CreateShortcut(monthPath, desktopPath + "\\" + monthName + ".lnk", iconsFolder + monthIcon);
                CreateShortcut(tempPath, desktopPath + "\\Временно.lnk", iconsFolder + tempIcon);
                CreateShortcut(sublimPath, desktopPath + "\\Сублимация.lnk", iconsFolder + sublimIcon);
                CreateShortcut(printPhotoPath, desktopPath + "\\Печать фото.lnk", iconsFolder + printPhotoIcon);
                CreateShortcut(canvasPath, desktopPath + "\\Холсты.lnk", iconsFolder + canvasIcon);
            }
            else
            {
                MessageBox.Show("Указана неправильная папка!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AutoShortcutsCreate()
        {
            if (newMonthFound)
            {
                ShortcutsCreate();

                if (!Program.LaunchedViaStartup)
                {
                    CloseApp();
                }
            }
        }

        private void ShowSettings(bool isVisible)
        {
            pSettings.Visible = isVisible;
            pMain.Visible = !isVisible;
        }

        private void SetAutorun(bool autorun)
        {
            string name = Text;
            string path = Assembly.GetExecutingAssembly().Location;

            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");

            try
            {
                if (autorun)
                {
                    registryKey.SetValue(name, path);
                }
                else
                {
                    registryKey.DeleteValue(name);
                }

                SetAutorunText(autorun);
                Settings.Default.autorun = autorun;

                registryKey.Flush();
                registryKey.Close();
            }
            catch (Exception)
            {
                SetAutorunText(autorun);
                Settings.Default.autorun = false;
            }
            finally
            {
                Settings.Default.Save();
            }
        }

        private void SetAutorunText(bool autorun)
        {
            const string autorunText = "Автозапуск: ";

            if (autorun)
            {
                autorunToolStripMenuItem.Text = autorunText + "Вкл";
            }
            else
            {
                autorunToolStripMenuItem.Text = autorunText + "Выкл";
            }
        }

        private void CloseApp()
        {
            notifyIcon.Visible = false;
            Environment.Exit(0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ShortcutsCreate();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            tbxMainPath.Text = mainPath;
            tbxMonthPath.Text = monthPath;
            ShowSettings(true);
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(monthPath))
            {
                Process.Start(monthPath);
            }
        }

        private void btnSelectMainPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = mainPath
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                mainPath = folderBrowserDialog.SelectedPath;
                tbxMainPath.Text = mainPath;
                Settings.Default.mainPath = mainPath;
                Settings.Default.Save();
            }
        }

        private void btnSelectMonthPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = monthPath
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                monthPath = folderBrowserDialog.SelectedPath;
                tbxMonthPath.Text = monthPath;
                lblInfo.Text = $"Папка месяца: {Path.GetFileName(monthPath).Replace(" ", "")}";
                lblInfo.ForeColor = Color.Gray;
                Settings.Default.monthPath = monthPath;
                Settings.Default.Save();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ShowSettings(false);
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void autorunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAutorun(!Settings.Default.autorun);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApp();
        }
    }
}
