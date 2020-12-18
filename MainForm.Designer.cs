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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripForwardButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripAdressTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownViewButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.iconsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUpButton = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainAreaSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FileCatalogTreeView = new System.Windows.Forms.TreeView();
            this.DirectoryContentListView = new System.Windows.Forms.ListView();
            this.optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainAreaSplitContainer)).BeginInit();
            this.mainAreaSplitContainer.Panel1.SuspendLayout();
            this.mainAreaSplitContainer.Panel2.SuspendLayout();
            this.mainAreaSplitContainer.SuspendLayout();
            this.optionsContextMenuStrip.SuspendLayout();
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
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1104, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton,
            this.toolStripForwardButton,
            this.toolStripAdressTextBox,
            this.toolStripDropDownViewButton,
            this.toolStripUpButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1104, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackButton.Enabled = false;
            this.toolStripBackButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackButton.Image")));
            this.toolStripBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(28, 29);
            this.toolStripBackButton.Text = "Назад";
            this.toolStripBackButton.Click += new System.EventHandler(this.ToolStripBackButton_Click);
            // 
            // toolStripForwardButton
            // 
            this.toolStripForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripForwardButton.Enabled = false;
            this.toolStripForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripForwardButton.Image")));
            this.toolStripForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripForwardButton.Name = "toolStripForwardButton";
            this.toolStripForwardButton.Size = new System.Drawing.Size(28, 29);
            this.toolStripForwardButton.Text = "Вперёд";
            this.toolStripForwardButton.Click += new System.EventHandler(this.ToolStripForwardButton_Click);
            // 
            // toolStripAdressTextBox
            // 
            this.toolStripAdressTextBox.Name = "toolStripAdressTextBox";
            this.toolStripAdressTextBox.Size = new System.Drawing.Size(618, 32);
            this.toolStripAdressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolStripAdressTextBox_KeyDown);
            // 
            // toolStripDropDownViewButton
            // 
            this.toolStripDropDownViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownViewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconsListToolStripMenuItem,
            this.imagesListToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.simpleListToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.toolStripDropDownViewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownViewButton.Image")));
            this.toolStripDropDownViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownViewButton.Name = "toolStripDropDownViewButton";
            this.toolStripDropDownViewButton.Size = new System.Drawing.Size(60, 29);
            this.toolStripDropDownViewButton.Text = "Вид";
            // 
            // iconsListToolStripMenuItem
            // 
            this.iconsListToolStripMenuItem.Name = "iconsListToolStripMenuItem";
            this.iconsListToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.iconsListToolStripMenuItem.Text = "Список иконок";
            this.iconsListToolStripMenuItem.Click += new System.EventHandler(this.IconsListToolStripMenuItem_Click);
            // 
            // imagesListToolStripMenuItem
            // 
            this.imagesListToolStripMenuItem.Name = "imagesListToolStripMenuItem";
            this.imagesListToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.imagesListToolStripMenuItem.Text = "Список изображений";
            this.imagesListToolStripMenuItem.Click += new System.EventHandler(this.ImagesListToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.tileToolStripMenuItem.Text = "Плитки";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.TileToolStripMenuItem_Click);
            // 
            // simpleListToolStripMenuItem
            // 
            this.simpleListToolStripMenuItem.Name = "simpleListToolStripMenuItem";
            this.simpleListToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.simpleListToolStripMenuItem.Text = "Список";
            this.simpleListToolStripMenuItem.Click += new System.EventHandler(this.SimpleListToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.detailsToolStripMenuItem.Text = "Таблица";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // toolStripUpButton
            // 
            this.toolStripUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripUpButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUpButton.Image")));
            this.toolStripUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUpButton.Name = "toolStripUpButton";
            this.toolStripUpButton.Size = new System.Drawing.Size(64, 29);
            this.toolStripUpButton.Text = "Вверх";
            this.toolStripUpButton.Click += new System.EventHandler(this.ToolStripUpButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "directory_mini.bmp");
            this.imageList1.Images.SetKeyName(1, "file_mini.bmp");
            this.imageList1.Images.SetKeyName(2, "localdriver.png");
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
            // mainAreaSplitContainer
            // 
            this.mainAreaSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAreaSplitContainer.Location = new System.Drawing.Point(0, 67);
            this.mainAreaSplitContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainAreaSplitContainer.Name = "mainAreaSplitContainer";
            // 
            // mainAreaSplitContainer.Panel1
            // 
            this.mainAreaSplitContainer.Panel1.Controls.Add(this.FileCatalogTreeView);
            // 
            // mainAreaSplitContainer.Panel2
            // 
            this.mainAreaSplitContainer.Panel2.Controls.Add(this.DirectoryContentListView);
            this.mainAreaSplitContainer.Size = new System.Drawing.Size(1104, 577);
            this.mainAreaSplitContainer.SplitterDistance = 284;
            this.mainAreaSplitContainer.SplitterWidth = 6;
            this.mainAreaSplitContainer.TabIndex = 3;
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
            this.FileCatalogTreeView.Size = new System.Drawing.Size(284, 577);
            this.FileCatalogTreeView.TabIndex = 0;
            this.FileCatalogTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.FileCatalogTreeView_BeforeExpand);
            this.FileCatalogTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FileCatalogTreeView_AfterSelect);
            // 
            // DirectoryContentListView
            // 
            this.DirectoryContentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectoryContentListView.LargeImageList = this.imageList2;
            this.DirectoryContentListView.Location = new System.Drawing.Point(0, 0);
            this.DirectoryContentListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DirectoryContentListView.Name = "DirectoryContentListView";
            this.DirectoryContentListView.Size = new System.Drawing.Size(814, 577);
            this.DirectoryContentListView.SmallImageList = this.imageList1;
            this.DirectoryContentListView.TabIndex = 0;
            this.DirectoryContentListView.UseCompatibleStateImageBehavior = false;
            this.DirectoryContentListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DirectoryContentListView_MouseDoubleClick);
            // 
            // optionsContextMenuStrip
            // 
            this.optionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.RenameToolStripMenuItem,
            this.CreateFileToolStripMenuItem,
            this.CreateFolderToolStripMenuItem});
            this.optionsContextMenuStrip.Name = "optionsContextMenuStrip";
            this.optionsContextMenuStrip.Size = new System.Drawing.Size(241, 277);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.RenameToolStripMenuItem.Text = "Переименовать";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // CreateFileToolStripMenuItem
            // 
            this.CreateFileToolStripMenuItem.Name = "CreateFileToolStripMenuItem";
            this.CreateFileToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.CreateFileToolStripMenuItem.Text = "Создать файл";
            this.CreateFileToolStripMenuItem.Click += new System.EventHandler(this.CreateFileToolStripMenuItem_Click);
            // 
            // CreateFolderToolStripMenuItem
            // 
            this.CreateFolderToolStripMenuItem.Name = "CreateFolderToolStripMenuItem";
            this.CreateFolderToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.CreateFolderToolStripMenuItem.Text = "Создать папку";
            this.CreateFolderToolStripMenuItem.Click += new System.EventHandler(this.CreateFolderToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 666);
            this.Controls.Add(this.mainAreaSplitContainer);
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
            this.mainAreaSplitContainer.Panel1.ResumeLayout(false);
            this.mainAreaSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainAreaSplitContainer)).EndInit();
            this.mainAreaSplitContainer.ResumeLayout(false);
            this.optionsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownViewButton;
        private System.Windows.Forms.ToolStripMenuItem iconsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private System.Windows.Forms.ToolStripButton toolStripForwardButton;
        private System.Windows.Forms.ToolStripTextBox toolStripAdressTextBox;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripUpButton;
        private System.Windows.Forms.SplitContainer mainAreaSplitContainer;
        private System.Windows.Forms.TreeView FileCatalogTreeView;
        private System.Windows.Forms.ListView DirectoryContentListView;
        private System.Windows.Forms.ContextMenuStrip optionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
    }
}

