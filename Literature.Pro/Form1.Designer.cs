namespace Literature.Pro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAuthorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видавництваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.librarydbDataSet = new Literature.Pro.LibrarydbDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Literature.Pro.LibrarydbDataSetTableAdapters.booksTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pBHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBHouseTableAdapter = new Literature.Pro.LibrarydbDataSetTableAdapters.PBHouseTableAdapter();
            this.EditionsbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editionsTableAdapter = new Literature.Pro.LibrarydbDataSetTableAdapters.EditionsTableAdapter();
            this.ReadersbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersTableAdapter = new Literature.Pro.LibrarydbDataSetTableAdapters.ReadersTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditionsbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadersbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutAProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookAuthorsToolStripMenuItem1,
            this.видавництваToolStripMenuItem,
            this.видачаToolStripMenuItem,
            this.читачToolStripMenuItem});
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.booksToolStripMenuItem.Text = "База даних";
            // 
            // bookAuthorsToolStripMenuItem1
            // 
            this.bookAuthorsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("bookAuthorsToolStripMenuItem1.Image")));
            this.bookAuthorsToolStripMenuItem1.Name = "bookAuthorsToolStripMenuItem1";
            this.bookAuthorsToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.bookAuthorsToolStripMenuItem1.Text = "Книги";
            this.bookAuthorsToolStripMenuItem1.Click += new System.EventHandler(this.bookAuthorsToolStripMenuItem1_Click);
            // 
            // видавництваToolStripMenuItem
            // 
            this.видавництваToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("видавництваToolStripMenuItem.Image")));
            this.видавництваToolStripMenuItem.Name = "видавництваToolStripMenuItem";
            this.видавництваToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.видавництваToolStripMenuItem.Text = "Видавництва ";
            this.видавництваToolStripMenuItem.Click += new System.EventHandler(this.видавництваToolStripMenuItem_Click);
            // 
            // видачаToolStripMenuItem
            // 
            this.видачаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("видачаToolStripMenuItem.Image")));
            this.видачаToolStripMenuItem.Name = "видачаToolStripMenuItem";
            this.видачаToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.видачаToolStripMenuItem.Text = "Видачі";
            this.видачаToolStripMenuItem.Click += new System.EventHandler(this.видачаToolStripMenuItem_Click);
            // 
            // читачToolStripMenuItem
            // 
            this.читачToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("читачToolStripMenuItem.Image")));
            this.читачToolStripMenuItem.Name = "читачToolStripMenuItem";
            this.читачToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.читачToolStripMenuItem.Text = "Читачі";
            this.читачToolStripMenuItem.Click += new System.EventHandler(this.читачToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historyToolStripMenuItem.Image")));
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutAProgramToolStripMenuItem
            // 
            this.aboutAProgramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutAProgramToolStripMenuItem.Image")));
            this.aboutAProgramToolStripMenuItem.Name = "aboutAProgramToolStripMenuItem";
            this.aboutAProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.aboutAProgramToolStripMenuItem.Text = "About a program";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(128, 331);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 44);
            this.add.TabIndex = 3;
            this.add.Text = "Edit book";
            this.add.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete book";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.librarydbDataSet;
            this.bindingSource1.Position = 0;
            // 
            // librarydbDataSet
            // 
            this.librarydbDataSet.DataSetName = "LibrarydbDataSet";
            this.librarydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.bindingSource1;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 276);
            this.dataGridView1.TabIndex = 6;
            // 
            // pBHouseBindingSource
            // 
            this.pBHouseBindingSource.DataMember = "PBHouse";
            this.pBHouseBindingSource.DataSource = this.bindingSource1;
            // 
            // pBHouseTableAdapter
            // 
            this.pBHouseTableAdapter.ClearBeforeFill = true;
            // 
            // EditionsbindingSource
            // 
            this.EditionsbindingSource.DataMember = "Editions";
            this.EditionsbindingSource.DataSource = this.bindingSource1;
            // 
            // editionsTableAdapter
            // 
            this.editionsTableAdapter.ClearBeforeFill = true;
            // 
            // ReadersbindingSource
            // 
            this.ReadersbindingSource.DataMember = "Readers";
            this.ReadersbindingSource.DataSource = this.bindingSource1;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Literature.Pro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditionsbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadersbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAProgramToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripMenuItem bookAuthorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem видавництваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читачToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private LibrarydbDataSet librarydbDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibrarydbDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pBHouseBindingSource;
        private LibrarydbDataSetTableAdapters.PBHouseTableAdapter pBHouseTableAdapter;
        private System.Windows.Forms.BindingSource EditionsbindingSource;
        private LibrarydbDataSetTableAdapters.EditionsTableAdapter editionsTableAdapter;
        private System.Windows.Forms.BindingSource ReadersbindingSource;
        private LibrarydbDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
    }
}

