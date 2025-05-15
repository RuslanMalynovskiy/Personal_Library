namespace Personal_Library.Forms
{
    partial class MainForm
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
            AddButton = new Button();
            BookChoose = new ComboBox();
            Author = new TextBox();
            Title = new TextBox();
            Publication = new TextBox();
            BookStatus = new TextBox();
            BookRating = new TextBox();
            Spec = new TextBox();
            AddReset = new Button();
            TitleCheck = new CheckBox();
            AuthorCheck = new CheckBox();
            PublicationSort = new TextBox();
            TitleSort = new TextBox();
            AuthorSort = new TextBox();
            StatusSort = new ComboBox();
            RatingSort = new ComboBox();
            BookTypeSort = new ComboBox();
            SpecSort = new TextBox();
            PublicationCheck = new CheckBox();
            StatusCheck = new CheckBox();
            RatingCheck = new CheckBox();
            BookTypeCheck = new CheckBox();
            SpecCheck = new CheckBox();
            SortButton = new Button();
            SortReset = new Button();
            EditButton = new Button();
            RemoveButton = new Button();
            CancelButton = new Button();
            MainListBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 215);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(158, 31);
            AddButton.TabIndex = 1;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // BookChoose
            // 
            BookChoose.FormattingEnabled = true;
            BookChoose.Location = new Point(12, 157);
            BookChoose.Name = "BookChoose";
            BookChoose.Size = new Size(229, 23);
            BookChoose.TabIndex = 2;
            BookChoose.Text = "Тип книги";
            BookChoose.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Author
            // 
            Author.Location = new Point(12, 41);
            Author.Name = "Author";
            Author.Size = new Size(192, 23);
            Author.TabIndex = 3;
            Author.Text = "Автор";
            // 
            // Title
            // 
            Title.Location = new Point(12, 12);
            Title.Name = "Title";
            Title.Size = new Size(192, 23);
            Title.TabIndex = 4;
            Title.Text = "Назва";
            // 
            // Publication
            // 
            Publication.Location = new Point(12, 70);
            Publication.Name = "Publication";
            Publication.Size = new Size(192, 23);
            Publication.TabIndex = 5;
            Publication.Text = "Видавництво";
            // 
            // BookStatus
            // 
            BookStatus.Location = new Point(12, 99);
            BookStatus.Name = "BookStatus";
            BookStatus.Size = new Size(192, 23);
            BookStatus.TabIndex = 6;
            BookStatus.Text = "Наявність";
            // 
            // BookRating
            // 
            BookRating.Location = new Point(12, 128);
            BookRating.Name = "BookRating";
            BookRating.Size = new Size(192, 23);
            BookRating.TabIndex = 7;
            BookRating.Text = "Оцінка від 1 до 10";
            // 
            // Spec
            // 
            Spec.Location = new Point(12, 186);
            Spec.Name = "Spec";
            Spec.Size = new Size(192, 23);
            Spec.TabIndex = 8;
            // 
            // AddReset
            // 
            AddReset.Location = new Point(12, 252);
            AddReset.Name = "AddReset";
            AddReset.Size = new Size(158, 31);
            AddReset.TabIndex = 11;
            AddReset.Text = "Скинути";
            AddReset.UseVisualStyleBackColor = true;
            // 
            // TitleCheck
            // 
            TitleCheck.AutoSize = true;
            TitleCheck.Location = new Point(663, 14);
            TitleCheck.Name = "TitleCheck";
            TitleCheck.Size = new Size(58, 19);
            TitleCheck.TabIndex = 12;
            TitleCheck.Text = "Назва";
            TitleCheck.UseVisualStyleBackColor = true;
            // 
            // AuthorCheck
            // 
            AuthorCheck.AutoSize = true;
            AuthorCheck.Location = new Point(663, 43);
            AuthorCheck.Name = "AuthorCheck";
            AuthorCheck.Size = new Size(59, 19);
            AuthorCheck.TabIndex = 14;
            AuthorCheck.Text = "Автор";
            AuthorCheck.UseVisualStyleBackColor = true;
            AuthorCheck.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // PublicationSort
            // 
            PublicationSort.Location = new Point(794, 70);
            PublicationSort.Name = "PublicationSort";
            PublicationSort.Size = new Size(121, 23);
            PublicationSort.TabIndex = 16;
            // 
            // TitleSort
            // 
            TitleSort.Location = new Point(794, 12);
            TitleSort.Name = "TitleSort";
            TitleSort.Size = new Size(121, 23);
            TitleSort.TabIndex = 17;
            TitleSort.TextChanged += textBox3_TextChanged;
            // 
            // AuthorSort
            // 
            AuthorSort.Location = new Point(794, 41);
            AuthorSort.Name = "AuthorSort";
            AuthorSort.Size = new Size(121, 23);
            AuthorSort.TabIndex = 18;
            AuthorSort.TextChanged += AuthorSort_TextChanged;
            // 
            // StatusSort
            // 
            StatusSort.FormattingEnabled = true;
            StatusSort.Location = new Point(794, 99);
            StatusSort.Name = "StatusSort";
            StatusSort.Size = new Size(121, 23);
            StatusSort.TabIndex = 19;
            StatusSort.SelectedIndexChanged += StatusSort_SelectedIndexChanged;
            // 
            // RatingSort
            // 
            RatingSort.FormattingEnabled = true;
            RatingSort.Location = new Point(794, 128);
            RatingSort.Name = "RatingSort";
            RatingSort.Size = new Size(121, 23);
            RatingSort.TabIndex = 20;
            // 
            // BookTypeSort
            // 
            BookTypeSort.FormattingEnabled = true;
            BookTypeSort.Location = new Point(794, 157);
            BookTypeSort.Name = "BookTypeSort";
            BookTypeSort.Size = new Size(121, 23);
            BookTypeSort.TabIndex = 21;
            // 
            // SpecSort
            // 
            SpecSort.Location = new Point(794, 186);
            SpecSort.Name = "SpecSort";
            SpecSort.Size = new Size(121, 23);
            SpecSort.TabIndex = 22;
            // 
            // PublicationCheck
            // 
            PublicationCheck.AutoSize = true;
            PublicationCheck.Location = new Point(663, 72);
            PublicationCheck.Name = "PublicationCheck";
            PublicationCheck.Size = new Size(97, 19);
            PublicationCheck.TabIndex = 23;
            PublicationCheck.Text = "Видавництво";
            PublicationCheck.UseVisualStyleBackColor = true;
            // 
            // StatusCheck
            // 
            StatusCheck.AutoSize = true;
            StatusCheck.Location = new Point(663, 101);
            StatusCheck.Name = "StatusCheck";
            StatusCheck.Size = new Size(80, 19);
            StatusCheck.TabIndex = 24;
            StatusCheck.Text = "Наявність";
            StatusCheck.UseVisualStyleBackColor = true;
            StatusCheck.CheckedChanged += StatusCheck_CheckedChanged;
            // 
            // RatingCheck
            // 
            RatingCheck.AutoSize = true;
            RatingCheck.Location = new Point(663, 130);
            RatingCheck.Name = "RatingCheck";
            RatingCheck.Size = new Size(64, 19);
            RatingCheck.TabIndex = 25;
            RatingCheck.Text = "Оцінка";
            RatingCheck.UseVisualStyleBackColor = true;
            // 
            // BookTypeCheck
            // 
            BookTypeCheck.AutoSize = true;
            BookTypeCheck.Location = new Point(663, 159);
            BookTypeCheck.Name = "BookTypeCheck";
            BookTypeCheck.Size = new Size(81, 19);
            BookTypeCheck.TabIndex = 26;
            BookTypeCheck.Text = "Тип книги";
            BookTypeCheck.UseVisualStyleBackColor = true;
            // 
            // SpecCheck
            // 
            SpecCheck.AutoSize = true;
            SpecCheck.Location = new Point(663, 188);
            SpecCheck.Name = "SpecCheck";
            SpecCheck.Size = new Size(97, 19);
            SpecCheck.TabIndex = 27;
            SpecCheck.Text = "Спеціфікація";
            SpecCheck.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(794, 236);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(121, 47);
            SortButton.TabIndex = 28;
            SortButton.Text = "Сортувати";
            SortButton.UseVisualStyleBackColor = true;
            // 
            // SortReset
            // 
            SortReset.Location = new Point(663, 236);
            SortReset.Name = "SortReset";
            SortReset.Size = new Size(109, 47);
            SortReset.TabIndex = 29;
            SortReset.Text = "Очистити";
            SortReset.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(176, 214);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(111, 32);
            EditButton.TabIndex = 30;
            EditButton.Text = "Редагувати";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(293, 252);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(119, 31);
            RemoveButton.TabIndex = 31;
            RemoveButton.Text = "Видалити";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(293, 215);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(119, 31);
            CancelButton.TabIndex = 32;
            CancelButton.Text = "Відмінити";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // MainListBox
            // 
            MainListBox.FormattingEnabled = true;
            MainListBox.ItemHeight = 15;
            MainListBox.Location = new Point(12, 302);
            MainListBox.Name = "MainListBox";
            MainListBox.Size = new Size(903, 364);
            MainListBox.TabIndex = 33;
            // 
            // button1
            // 
            button1.Location = new Point(176, 251);
            button1.Name = "button1";
            button1.Size = new Size(111, 32);
            button1.TabIndex = 34;
            button1.Text = "Вибрати";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 678);
            Controls.Add(button1);
            Controls.Add(MainListBox);
            Controls.Add(CancelButton);
            Controls.Add(RemoveButton);
            Controls.Add(EditButton);
            Controls.Add(SortReset);
            Controls.Add(SortButton);
            Controls.Add(SpecCheck);
            Controls.Add(BookTypeCheck);
            Controls.Add(RatingCheck);
            Controls.Add(StatusCheck);
            Controls.Add(PublicationCheck);
            Controls.Add(SpecSort);
            Controls.Add(BookTypeSort);
            Controls.Add(RatingSort);
            Controls.Add(StatusSort);
            Controls.Add(AuthorSort);
            Controls.Add(TitleSort);
            Controls.Add(PublicationSort);
            Controls.Add(AuthorCheck);
            Controls.Add(TitleCheck);
            Controls.Add(AddReset);
            Controls.Add(Spec);
            Controls.Add(BookRating);
            Controls.Add(BookStatus);
            Controls.Add(Publication);
            Controls.Add(Title);
            Controls.Add(Author);
            Controls.Add(BookChoose);
            Controls.Add(AddButton);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddButton;
        private ComboBox BookChoose;
        private TextBox Author;
        private TextBox Title;
        private TextBox Publication;
        private TextBox BookStatus;
        private TextBox BookRating;
        private TextBox Spec;
        private Button AddReset;
        private CheckBox TitleCheck;
        private CheckBox AuthorCheck;
        private TextBox PublicationSort;
        private TextBox TitleSort;
        private TextBox AuthorSort;
        private ComboBox StatusSort;
        private ComboBox RatingSort;
        private ComboBox BookTypeSort;
        private TextBox SpecSort;
        private CheckBox PublicationCheck;
        private CheckBox StatusCheck;
        private CheckBox RatingCheck;
        private CheckBox BookTypeCheck;
        private CheckBox SpecCheck;
        private Button SortButton;
        private Button SortReset;
        private Button EditButton;
        private Button RemoveButton;
        private Button CancelButton;
        private ListBox MainListBox;
        private Button button1;
    }
}