namespace Информационная_система_библиотеки
{
    partial class MainFormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияЧитателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карточкаЧитателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весьБиблиотечныйФондToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеОКнигеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списатьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдатьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выданныеКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.99647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.00353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.58427F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.41573F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 3);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.читателиToolStripMenuItem,
            this.книгиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem1.Text = "Программа";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияЧитателяToolStripMenuItem,
            this.карточкаЧитателяToolStripMenuItem});
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.читателиToolStripMenuItem.Text = "Читатели";
            // 
            // регистрацияЧитателяToolStripMenuItem
            // 
            this.регистрацияЧитателяToolStripMenuItem.Name = "регистрацияЧитателяToolStripMenuItem";
            this.регистрацияЧитателяToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.регистрацияЧитателяToolStripMenuItem.Text = "Регистрация читателя";
            this.регистрацияЧитателяToolStripMenuItem.Click += new System.EventHandler(this.РегистрацияЧитателяToolStripMenuItem_Click);
            // 
            // карточкаЧитателяToolStripMenuItem
            // 
            this.карточкаЧитателяToolStripMenuItem.Name = "карточкаЧитателяToolStripMenuItem";
            this.карточкаЧитателяToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.карточкаЧитателяToolStripMenuItem.Text = "Карточка читателя";
            this.карточкаЧитателяToolStripMenuItem.Click += new System.EventHandler(this.КарточкаЧитателяToolStripMenuItem_Click);
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.весьБиблиотечныйФондToolStripMenuItem,
            this.добавитьКнигуToolStripMenuItem,
            this.изменитьДанныеОКнигеToolStripMenuItem,
            this.списатьКнигуToolStripMenuItem,
            this.выдатьКнигуToolStripMenuItem,
            this.выданныеКнигиToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // весьБиблиотечныйФондToolStripMenuItem
            // 
            this.весьБиблиотечныйФондToolStripMenuItem.Name = "весьБиблиотечныйФондToolStripMenuItem";
            this.весьБиблиотечныйФондToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.весьБиблиотечныйФондToolStripMenuItem.Text = "Библиотечный фонд";
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            this.добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            this.добавитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.добавитьКнигуToolStripMenuItem.Text = "Добавить книгу";
            this.добавитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьКнигуToolStripMenuItem_Click);
            // 
            // изменитьДанныеОКнигеToolStripMenuItem
            // 
            this.изменитьДанныеОКнигеToolStripMenuItem.Name = "изменитьДанныеОКнигеToolStripMenuItem";
            this.изменитьДанныеОКнигеToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.изменитьДанныеОКнигеToolStripMenuItem.Text = "Изменить данные о книге";
            // 
            // списатьКнигуToolStripMenuItem
            // 
            this.списатьКнигуToolStripMenuItem.Name = "списатьКнигуToolStripMenuItem";
            this.списатьКнигуToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.списатьКнигуToolStripMenuItem.Text = "Списать книгу";
            // 
            // выдатьКнигуToolStripMenuItem
            // 
            this.выдатьКнигуToolStripMenuItem.Name = "выдатьКнигуToolStripMenuItem";
            this.выдатьКнигуToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.выдатьКнигуToolStripMenuItem.Text = "Выдать книгу";
            this.выдатьКнигуToolStripMenuItem.Click += new System.EventHandler(this.ВыдатьКнигуToolStripMenuItem_Click);
            // 
            // выданныеКнигиToolStripMenuItem
            // 
            this.выданныеКнигиToolStripMenuItem.Name = "выданныеКнигиToolStripMenuItem";
            this.выданныеКнигиToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.выданныеКнигиToolStripMenuItem.Text = "Выданные книги";
            this.выданныеКнигиToolStripMenuItem.Click += new System.EventHandler(this.ВыданныеКнигиToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 323);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(48, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавление книги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(589, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Поиск книги";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(319, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удаление книги";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFormAdmin";
            this.Text = "Главное окно администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormAdmin_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияЧитателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карточкаЧитателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весьБиблиотечныйФондToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдатьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выданныеКнигиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеОКнигеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списатьКнигуToolStripMenuItem;
    }
}