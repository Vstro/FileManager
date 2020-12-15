namespace FileManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IconListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.списокИконокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокИзображенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плиткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.FileCatalogTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DirectoryContentListView = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1104, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.dToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1104, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconListToolStripMenuItem,
            this.ImageListToolStripMenuItem,
            this.TilesToolStripMenuItem,
            this.ListToolStripMenuItem,
            this.TableToolStripMenuItem,
            this.toolStripSeparator1,
            this.UpdateToolStripMenuItem});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.dToolStripMenuItem.Text = "Вид";
            // 
            // IconListToolStripMenuItem
            // 
            this.IconListToolStripMenuItem.Name = "IconListToolStripMenuItem";
            this.IconListToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.IconListToolStripMenuItem.Text = "Список иконок";
            this.IconListToolStripMenuItem.Click += new System.EventHandler(this.списокИконокToolStripMenuItem_Click);
            // 
            // ImageListToolStripMenuItem
            // 
            this.ImageListToolStripMenuItem.Name = "ImageListToolStripMenuItem";
            this.ImageListToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.ImageListToolStripMenuItem.Text = "Список изображений";
            this.ImageListToolStripMenuItem.Click += new System.EventHandler(this.списокИзображенийToolStripMenuItem_Click);
            // 
            // TilesToolStripMenuItem
            // 
            this.TilesToolStripMenuItem.Name = "TilesToolStripMenuItem";
            this.TilesToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.TilesToolStripMenuItem.Text = "Плитки";
            this.TilesToolStripMenuItem.Click += new System.EventHandler(this.плиткиToolStripMenuItem_Click);
            // 
            // ListToolStripMenuItem
            // 
            this.ListToolStripMenuItem.Name = "ListToolStripMenuItem";
            this.ListToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.ListToolStripMenuItem.Text = "Список";
            this.ListToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // TableToolStripMenuItem
            // 
            this.TableToolStripMenuItem.Name = "TableToolStripMenuItem";
            this.TableToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.TableToolStripMenuItem.Text = "Таблица";
            this.TableToolStripMenuItem.Click += new System.EventHandler(this.таблицаToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.UpdateToolStripMenuItem.Text = "Update";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripTextBox1,
            this.toolStripDropDownButton1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1104, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 29);
            this.toolStripButton1.Text = "Назад";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 29);
            this.toolStripButton2.Text = "Вперёд";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(618, 32);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyDown);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокИконокToolStripMenuItem,
            this.списокИзображенийToolStripMenuItem,
            this.плиткиToolStripMenuItem,
            this.списокToolStripMenuItem,
            this.таблицаToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 29);
            this.toolStripDropDownButton1.Text = "Вид";
            // 
            // списокИконокToolStripMenuItem
            // 
            this.списокИконокToolStripMenuItem.Name = "списокИконокToolStripMenuItem";
            this.списокИконокToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.списокИконокToolStripMenuItem.Text = "Список иконок";
            this.списокИконокToolStripMenuItem.Click += new System.EventHandler(this.списокИконокToolStripMenuItem_Click);
            // 
            // списокИзображенийToolStripMenuItem
            // 
            this.списокИзображенийToolStripMenuItem.Name = "списокИзображенийToolStripMenuItem";
            this.списокИзображенийToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.списокИзображенийToolStripMenuItem.Text = "Список изображений";
            this.списокИзображенийToolStripMenuItem.Click += new System.EventHandler(this.списокИзображенийToolStripMenuItem_Click);
            // 
            // плиткиToolStripMenuItem
            // 
            this.плиткиToolStripMenuItem.Name = "плиткиToolStripMenuItem";
            this.плиткиToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.плиткиToolStripMenuItem.Text = "Плитки";
            this.плиткиToolStripMenuItem.Click += new System.EventHandler(this.плиткиToolStripMenuItem_Click);
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.списокToolStripMenuItem.Text = "Список";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            this.таблицаToolStripMenuItem.Click += new System.EventHandler(this.таблицаToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(64, 29);
            this.toolStripButton3.Text = "Вверх";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 67);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 577);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.FileCatalogTreeView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DirectoryContentListView);
            this.splitContainer2.Size = new System.Drawing.Size(1104, 467);
            this.splitContainer2.SplitterDistance = 284;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // FileCatalogTreeView
            // 
            this.FileCatalogTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileCatalogTreeView.ImageIndex = 0;
            this.FileCatalogTreeView.ImageList = this.imageList1;
            this.FileCatalogTreeView.Location = new System.Drawing.Point(0, 0);
            this.FileCatalogTreeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileCatalogTreeView.Name = "FileCatalogTreeView";
            this.FileCatalogTreeView.SelectedImageIndex = 0;
            this.FileCatalogTreeView.Size = new System.Drawing.Size(284, 467);
            this.FileCatalogTreeView.TabIndex = 0;
            this.FileCatalogTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView1_BeforeExpand);
            this.FileCatalogTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FileCatalogTreeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "directory_mini.bmp");
            this.imageList1.Images.SetKeyName(1, "file_mini.bmp");
            this.imageList1.Images.SetKeyName(2, "localdriver.png");
            // 
            // DirectoryContentListView
            // 
            this.DirectoryContentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectoryContentListView.LargeImageList = this.imageList2;
            this.DirectoryContentListView.Location = new System.Drawing.Point(0, 0);
            this.DirectoryContentListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DirectoryContentListView.Name = "DirectoryContentListView";
            this.DirectoryContentListView.Size = new System.Drawing.Size(814, 467);
            this.DirectoryContentListView.SmallImageList = this.imageList1;
            this.DirectoryContentListView.TabIndex = 0;
            this.DirectoryContentListView.UseCompatibleStateImageBehavior = false;
            this.DirectoryContentListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "directory.bmp");
            this.imageList2.Images.SetKeyName(1, "file.bmp");
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.asdToolStripMenuItem.Text = "asd";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 666);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "FileManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView FileCatalogTreeView;
        private System.Windows.Forms.ListView DirectoryContentListView;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem списокИконокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокИзображенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плиткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IconListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImageListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

