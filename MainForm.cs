using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FileManager
{
    public partial class MainForm : Form
    {
        private List<String> VisitedAdresses { get; set; } = new List<String>();

        private int CurrentAdressIndex { get; set; } = -1;

        private String CurrentListViewAdress { get; set; } = "";

        public MainForm()
        {
            InitializeComponent();
            DirectoryContentListView.ColumnClick += new ColumnClickEventHandler(ClickOnColumn);
            DirectoryContentListView.Columns.Add(new ColumnHeader() { Text = "Имя", Width = 160 });
            DirectoryContentListView.Columns.Add(new ColumnHeader() { Text = "Размер", Width = 100 });
            DirectoryContentListView.Columns.Add(new ColumnHeader() { Text = "Тип", Width = 60 });
            DirectoryContentListView.Columns.Add(new ColumnHeader() { Text = "Дата изменения", Width = 110 });
            //заполнение TreeView узлами локальных дисков и заполнение дочерних узлов этих дисков
            int n = 0;
            foreach(String driveName in Environment.GetLogicalDrives())
            {
                FileCatalogTreeView.Nodes.Add(new TreeNode()
                { Name = driveName, Text = "Logical drive " + driveName, ImageIndex = 2, SelectedImageIndex = 2 });
                String[] subDirs;
                try
                {
                    subDirs = Directory.GetDirectories(@driveName);
                    foreach (String fullDirName in subDirs)
                    {
                        String shortDirName = fullDirName.Substring(fullDirName.LastIndexOf('\\') + 1);
                        FileCatalogTreeView.Nodes[n].Nodes.Add(fullDirName, shortDirName, 0);
                    }
                }
                catch (IOException)
                {
                    // Ignore non-working drive's content
                }
                n++;
            }
        }

        private void FileCatalogTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (VisitedAdresses.Count != 0)
            {
                String lastAdress = VisitedAdresses[VisitedAdresses.Count - 1];
                VisitedAdresses.Clear();
                VisitedAdresses.Add(lastAdress);
                CurrentAdressIndex = 0;
                toolStripButton1.Enabled = true;
            } else
            {
                toolStripButton1.Enabled = false;
            }          
            VisitedAdresses.Add(e.Node.Name);
            CurrentAdressIndex++;
            //проверка возможности перехода назад/вперёд
            //if (currentAdressIndex + 1 == Adresses.Count)
                toolStripButton2.Enabled = false;
            //else    toolStripButton2.Enabled = true;
            //if (currentAdressIndex - 1 == -1)
            //    toolStripButton1.Enabled = false;
            //else
            //    toolStripButton1.Enabled = true;
            DirectoryContentListView.Items.Clear();
            CurrentListViewAdress = e.Node.Name;
            toolStripTextBox1.Text = CurrentListViewAdress;
            //заполнение ListView
            try
            {
                if (DirectoryContentListView.View != View.Tile)
                {
                    FileInfo f = new FileInfo(@e.Node.Name);
                    string t = "";
                    string[] str2 = Directory.GetDirectories(@e.Node.Name);
                    ListViewItem lw;
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        string type = "Папка";
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t, "", type, f.LastWriteTime.ToString() }, 0);
                        lw.Name = s2;
                        DirectoryContentListView.Items.Add(lw);
                    }
                    str2 = Directory.GetFiles(@e.Node.Name);
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        string type = "Файл";
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t, f.Length.ToString() + " байт", type, f.LastWriteTime.ToString() }, 1);
                        lw.Name = s2;
                        DirectoryContentListView.Items.Add(lw);
                    }
                }
                else
                {
                    FileInfo f = new FileInfo(@e.Node.Name);
                    string t = "";
                    string[] str2 = Directory.GetDirectories(@e.Node.Name);
                    ListViewItem lw = new ListViewItem();
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t }, 0);
                        lw.Name = s2;
                        DirectoryContentListView.Items.Add(lw);
                    }
                    str2 = Directory.GetFiles(@e.Node.Name);
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t }, 1);
                        lw.Name = s2;
                        DirectoryContentListView.Items.Add(lw);
                    }
                }
            }
            catch (Exception er) {
                int a = 2 + 2;
            }
        }

        private void списокИконокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryContentListView.View = View.SmallIcon;
        }

        private void списокИзображенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryContentListView.View = View.LargeIcon;
        }

        private void плиткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryContentListView.View = View.Tile;
            DirectoryContentListView.Items.Clear();
            FileInfo f = new FileInfo(CurrentListViewAdress);
            string t = "";
            string[] str2 = Directory.GetDirectories(CurrentListViewAdress);
            ListViewItem lw = new ListViewItem();
            foreach (string s2 in str2)
            {
                f = new FileInfo(@s2);
                t = s2.Substring(s2.LastIndexOf('\\') + 1);
                lw = new ListViewItem(new string[] { t }, 0);
                lw.Name = s2;
                DirectoryContentListView.Items.Add(lw);
            }
            str2 = Directory.GetFiles(CurrentListViewAdress);
            foreach (string s2 in str2)
            {
                f = new FileInfo(@s2);
                t = s2.Substring(s2.LastIndexOf('\\') + 1);
                lw = new ListViewItem(new string[] { t }, 1);
                lw.Name = s2;
                DirectoryContentListView.Items.Add(lw);
            }
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryContentListView.View = View.List;
        }

        private void таблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryContentListView.View = View.Details;
            DirectoryContentListView.Items.Clear();
            FileInfo f = new FileInfo(CurrentListViewAdress);
            string t = "";
            string[] str2 = Directory.GetDirectories(CurrentListViewAdress);
            ListViewItem lw = new ListViewItem();
            foreach (string s2 in str2)
            {
                f = new FileInfo(@s2);
                string type = "Папка";
                t = s2.Substring(s2.LastIndexOf('\\') + 1);
                lw = new ListViewItem(new string[] { t, "", type, f.LastWriteTime.ToString() }, 0);
                lw.Name = s2;
                DirectoryContentListView.Items.Add(lw);
            }
            str2 = Directory.GetFiles(CurrentListViewAdress);
            foreach (string s2 in str2)
            {
                f = new FileInfo(@s2);
                string type = "Файл";
                t = s2.Substring(s2.LastIndexOf('\\') + 1);
                lw = new ListViewItem(new string[] { t, f.Length.ToString() + " байт", type, f.LastWriteTime.ToString() }, 1);
                lw.Name = s2;
                DirectoryContentListView.Items.Add(lw);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView currentListView = (ListView)sender;
            //обработка двойного нажатия по папке или файлу в ListView
            if (currentListView.SelectedItems[0].ImageIndex == 0/*listView1.SelectedItems[0].SubItems[2].Text.Equals("Папка")*/)
            {
                //обработка нажатия на папку
                VisitedAdresses.Add(((ListView)sender).SelectedItems[0].Name);
                CurrentAdressIndex++;
                CurrentListViewAdress = VisitedAdresses[CurrentAdressIndex];
                if (CurrentAdressIndex + 1 == VisitedAdresses.Count)
                    toolStripButton2.Enabled = false;
                else
                    toolStripButton2.Enabled = true;
                if (CurrentAdressIndex - 1 == -1)
                    toolStripButton1.Enabled = false;
                else
                    toolStripButton1.Enabled = true;
                CurrentListViewAdress = currentListView.SelectedItems[0].Name;
                toolStripTextBox1.Text = CurrentListViewAdress;
                FileInfo f = new FileInfo(@currentListView.SelectedItems[0].Name);
                string t = "";
                string[] str2 = Directory.GetDirectories(@currentListView.SelectedItems[0].Name);
                string[] str3 = Directory.GetFiles(@currentListView.SelectedItems[0].Name);
                currentListView.Items.Clear();
                ListViewItem lw = new ListViewItem();
                if (currentListView.View == View.Details)
                {
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        string type = "Папка";
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t, "", type, f.LastWriteTime.ToString() }, 0);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                    foreach (string s2 in str3)
                    {
                        f = new FileInfo(@s2);
                        string type = "Файл";
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t, f.Length.ToString() + " байт", type, f.LastWriteTime.ToString() }, 1);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                }
                else
                {
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t }, 0);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                    foreach (string s2 in str3)
                    {
                        f = new FileInfo(@s2);
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t }, 1);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                }
            }
            else
            {
                //обработка нажатия на файл(его запуска)
                System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
                MyProc.StartInfo.FileName = @currentListView.SelectedItems[0].Name;
                MyProc.Start();
            }
        }

        private void ClickOnColumn(object sender, ColumnClickEventArgs e)
        {
            ListView currentListView = (ListView)sender;
            //обработка нажатия на колонку имя(изменение порядка сортировки)
            if (e.Column == 0)
            {
                if (currentListView.Sorting == SortOrder.Descending)
                    currentListView.Sorting = SortOrder.Ascending;
                else
                    currentListView.Sorting = SortOrder.Descending;
            }
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DirectoryContentListView.Refresh();
            //listView2.Refresh();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            int i = 0;
            //заполнение дочерних узлов дочерними узлами развёртываемого узла
            try
            {
                foreach (TreeNode tn in e.Node.Nodes)
                {
                    string[] str2 = Directory.GetDirectories(@tn.Name);
                    foreach (string str in str2)
                    {
                        TreeNode temp = new TreeNode();
                        temp.Name = str;
                        temp.Text = str.Substring(str.LastIndexOf('\\') + 1);
                        e.Node.Nodes[i].Nodes.Add(temp);
                    }
                    i++;
                }
            }
            catch (Exception er) {
                int a = 2 + 2;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            ListView currentListView = (ListView)sender;
            //обработка "Назад"
            if (CurrentAdressIndex - 1 != -1)
            {
                CurrentAdressIndex--;
                CurrentListViewAdress = ((string)VisitedAdresses[CurrentAdressIndex]);
                if (CurrentAdressIndex + 1 == VisitedAdresses.Count)
                    toolStripButton2.Enabled = false;
                else
                    toolStripButton2.Enabled = true;
                if (CurrentAdressIndex - 1 == -1)
                    toolStripButton1.Enabled = false;
                else
                    toolStripButton1.Enabled = true;
                toolStripTextBox1.Text = CurrentListViewAdress;
                FileInfo f = new FileInfo(CurrentListViewAdress);
                string t = "";
                string[] str2 = Directory.GetDirectories(CurrentListViewAdress);
                string[] str3 = Directory.GetFiles(CurrentListViewAdress);
                currentListView.Items.Clear();
                ListViewItem lw = new ListViewItem();
                if (currentListView.View == View.Details)
                {
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        string type = "Папка";
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t, "", type, f.LastWriteTime.ToString() }, 0);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                    foreach (string s2 in str3)
                    {
                        f = new FileInfo(@s2);
                        string type = "Файл";
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t, f.Length.ToString() + " байт", type, f.LastWriteTime.ToString() }, 1);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                }
                else
                {
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t }, 0);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                    foreach (string s2 in str3)
                    {
                        f = new FileInfo(@s2);
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t }, 1);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                }
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            ListView currentListView = (ListView)sender;
            //обработка "Вперёд"
            if (CurrentAdressIndex + 1 != VisitedAdresses.Count)
            {
                CurrentAdressIndex++;
                CurrentListViewAdress = ((string)VisitedAdresses[CurrentAdressIndex]);
                if (CurrentAdressIndex + 1 == VisitedAdresses.Count)
                    toolStripButton2.Enabled = false;
                else
                    toolStripButton2.Enabled = true;
                if (CurrentAdressIndex - 1 == -1)
                    toolStripButton1.Enabled = false;
                else
                    toolStripButton1.Enabled = true;
                toolStripTextBox1.Text = CurrentListViewAdress;
                FileInfo f = new FileInfo(CurrentListViewAdress);
                string t = "";
                string[] str2 = Directory.GetDirectories(CurrentListViewAdress);
                string[] str3 = Directory.GetFiles(CurrentListViewAdress);
                currentListView.Items.Clear();
                ListViewItem lw = new ListViewItem();
                if (currentListView.View == View.Details)
                {
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        string type = "Папка";
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t, "", type, f.LastWriteTime.ToString() }, 0);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                    foreach (string s2 in str3)
                    {
                        f = new FileInfo(@s2);
                        string type = "Файл";
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t, f.Length.ToString() + " байт", type, f.LastWriteTime.ToString() }, 1);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                }
                else
                {
                    foreach (string s2 in str2)
                    {
                        f = new FileInfo(@s2);
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t }, 0);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                    foreach (string s2 in str3)
                    {
                        f = new FileInfo(@s2);
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        lw = new ListViewItem(new string[] { t }, 1);
                        lw.Name = s2;
                        currentListView.Items.Add(lw);
                    }
                }
            }
        }

        private void ToolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            ListView currentListView = (ListView)sender;
            //проверка на то что был нажат enter, если был нажат enter и введённый адресс синтаксически верен, то будет произведён переход
            if (e.KeyValue == 13)
            {
                try
                {
                    string[] str2 = Directory.GetDirectories(@toolStripTextBox1.Text);
                    string[] str3 = Directory.GetFiles(@toolStripTextBox1.Text);
                    CurrentAdressIndex++;
                    CurrentListViewAdress = toolStripTextBox1.Text;
                    VisitedAdresses.Add(toolStripTextBox1.Text);
                    if (CurrentAdressIndex + 1 == VisitedAdresses.Count)
                        toolStripButton2.Enabled = false;
                    else
                        toolStripButton2.Enabled = true;
                    if (CurrentAdressIndex - 1 == -1)
                        toolStripButton1.Enabled = false;
                    else
                        toolStripButton1.Enabled = true;
                    FileInfo f = new FileInfo(@toolStripTextBox1.Text);
                    string t = "";
                    currentListView.Items.Clear();
                    ListViewItem lw = new ListViewItem();
                    if (currentListView.View == View.Details)
                    {
                        foreach (string s2 in str2)
                        {
                            f = new FileInfo(@s2);
                            string type = "Папка";
                            t = s2.Substring(s2.LastIndexOf('\\') + 1);
                            lw = new ListViewItem(new string[] { t, "", type, f.LastWriteTime.ToString() }, 0);
                            lw.Name = s2;
                            currentListView.Items.Add(lw);
                        }
                        foreach (string s2 in str3)
                        {
                            f = new FileInfo(@s2);
                            string type = "Файл";
                            t = s2.Substring(s2.LastIndexOf('\\') + 1);
                            lw = new ListViewItem(new string[] { t, f.Length.ToString() + " байт", type, f.LastWriteTime.ToString() }, 1);
                            lw.Name = s2;
                            currentListView.Items.Add(lw);
                        }
                    }
                    else
                    {
                        foreach (string s2 in str2)
                        {
                            f = new FileInfo(@s2);
                            t = s2.Substring(s2.LastIndexOf('\\') + 1);
                            lw = new ListViewItem(new string[] { t }, 0);
                            lw.Name = s2;
                            currentListView.Items.Add(lw);
                        }
                        foreach (string s2 in str3)
                        {
                            f = new FileInfo(@s2);
                            t = s2.Substring(s2.LastIndexOf('\\') + 1);
                            lw = new ListViewItem(new string[] { t }, 1);
                            lw.Name = s2;
                            currentListView.Items.Add(lw);
                        }
                    }
                }
                catch
                {
                    toolStripTextBox1.Text = CurrentListViewAdress;
                }
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            ListView currentListView = (ListView)sender;
            //обработка "Вверх"
            int lio = toolStripTextBox1.Text.LastIndexOf('\\');
            if (lio != -1)
            {
                toolStripTextBox1.Text = toolStripTextBox1.Text.Substring(0, lio);
                try
                {
                    string[] str2 = Directory.GetDirectories(@toolStripTextBox1.Text + "\\");
                    string[] str3 = Directory.GetFiles(@toolStripTextBox1.Text + "\\");
                    CurrentAdressIndex--;
                    CurrentListViewAdress = toolStripTextBox1.Text;
                    if (CurrentAdressIndex + 1 == VisitedAdresses.Count)
                        toolStripButton2.Enabled = false;
                    else
                        toolStripButton2.Enabled = true;
                    if (CurrentAdressIndex - 1 == -1)
                        toolStripButton1.Enabled = false;
                    else
                        toolStripButton1.Enabled = true;
                    FileInfo f = new FileInfo(@toolStripTextBox1.Text + "\\");
                    string t = "";
                    currentListView.Items.Clear();
                    ListViewItem lw = new ListViewItem();
                    if (currentListView.View == View.Details)
                    {
                        foreach (string s2 in str2)
                        {
                            f = new FileInfo(@s2);
                            string type = "Папка";
                            t = s2.Substring(s2.LastIndexOf('\\') + 1);
                            lw = new ListViewItem(new string[] { t, "", type, f.LastWriteTime.ToString() }, 0);
                            lw.Name = s2;
                            currentListView.Items.Add(lw);
                        }
                        foreach (string s2 in str3)
                        {
                            f = new FileInfo(@s2);
                            string type = "Файл";
                            t = s2.Substring(s2.LastIndexOf('\\') + 1);
                            lw = new ListViewItem(new string[] { t, f.Length.ToString() + " байт", type, f.LastWriteTime.ToString() }, 1);
                            lw.Name = s2;
                            currentListView.Items.Add(lw);
                        }
                    }
                    else
                    {
                        foreach (string s2 in str2)
                        {
                            f = new FileInfo(@s2);
                            t = s2.Substring(s2.LastIndexOf('\\') + 1);
                            lw = new ListViewItem(new string[] { t }, 0);
                            lw.Name = s2;
                            currentListView.Items.Add(lw);
                        }
                        foreach (string s2 in str3)
                        {
                            f = new FileInfo(@s2);
                            t = s2.Substring(s2.LastIndexOf('\\') + 1);
                            lw = new ListViewItem(new string[] { t }, 1);
                            lw.Name = s2;
                            currentListView.Items.Add(lw);
                        }
                    }
                }
                catch
                {
                    toolStripTextBox1.Text = CurrentListViewAdress;
                }
            }
        }

    }
}