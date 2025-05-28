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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AddButton = new Button();
            BookChoose = new ComboBox();
            Author = new TextBox();
            Title = new TextBox();
            Publication = new TextBox();
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
            DeleteButton = new Button();
            ConfirmButton = new Button();
            MainListBox = new ListBox();
            BookStatus = new ComboBox();
            BookRating = new ComboBox();
            SaveButton = new Button();
            LoadButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            VerticalSeparator1 = new Panel();
            VerticalSeparator2 = new Panel();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top;
            AddButton.Location = new Point(3, 257);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 30);
            AddButton.TabIndex = 1;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // BookChoose
            // 
            BookChoose.Anchor = AnchorStyles.Top;
            BookChoose.FormattingEnabled = true;
            BookChoose.Location = new Point(3, 199);
            BookChoose.Name = "BookChoose";
            BookChoose.Size = new Size(229, 23);
            BookChoose.TabIndex = 2;
            BookChoose.Text = "Тип книги";
            // 
            // Author
            // 
            Author.Anchor = AnchorStyles.Top;
            Author.Location = new Point(3, 83);
            Author.Name = "Author";
            Author.Size = new Size(192, 23);
            Author.TabIndex = 3;
            Author.Text = "Автор";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.Location = new Point(3, 54);
            Title.Name = "Title";
            Title.Size = new Size(192, 23);
            Title.TabIndex = 4;
            Title.Text = "Назва";
            // 
            // Publication
            // 
            Publication.Anchor = AnchorStyles.Top;
            Publication.Location = new Point(3, 112);
            Publication.Name = "Publication";
            Publication.Size = new Size(192, 23);
            Publication.TabIndex = 5;
            Publication.Text = "Видавництво";
            // 
            // Spec
            // 
            Spec.Anchor = AnchorStyles.Top;
            Spec.Location = new Point(3, 228);
            Spec.Name = "Spec";
            Spec.Size = new Size(192, 23);
            Spec.TabIndex = 8;
            Spec.Text = "Специфікація";
            // 
            // AddReset
            // 
            AddReset.Anchor = AnchorStyles.Top;
            AddReset.Location = new Point(3, 294);
            AddReset.Name = "AddReset";
            AddReset.Size = new Size(94, 30);
            AddReset.TabIndex = 11;
            AddReset.Text = "Скинути";
            AddReset.UseVisualStyleBackColor = true;
            AddReset.Click += AddReset_Click;
            // 
            // TitleCheck
            // 
            TitleCheck.Anchor = AnchorStyles.Top;
            TitleCheck.AutoSize = true;
            TitleCheck.BackColor = Color.Transparent;
            TitleCheck.Location = new Point(330, 56);
            TitleCheck.Name = "TitleCheck";
            TitleCheck.Size = new Size(58, 19);
            TitleCheck.TabIndex = 12;
            TitleCheck.Text = "Назва";
            TitleCheck.UseVisualStyleBackColor = false;
            // 
            // AuthorCheck
            // 
            AuthorCheck.Anchor = AnchorStyles.Top;
            AuthorCheck.AutoSize = true;
            AuthorCheck.BackColor = Color.Transparent;
            AuthorCheck.Location = new Point(330, 85);
            AuthorCheck.Name = "AuthorCheck";
            AuthorCheck.Size = new Size(59, 19);
            AuthorCheck.TabIndex = 14;
            AuthorCheck.Text = "Автор";
            AuthorCheck.UseVisualStyleBackColor = false;
            // 
            // PublicationSort
            // 
            PublicationSort.Anchor = AnchorStyles.Top;
            PublicationSort.Location = new Point(461, 112);
            PublicationSort.Name = "PublicationSort";
            PublicationSort.Size = new Size(121, 23);
            PublicationSort.TabIndex = 16;
            // 
            // TitleSort
            // 
            TitleSort.Anchor = AnchorStyles.Top;
            TitleSort.Location = new Point(461, 54);
            TitleSort.Name = "TitleSort";
            TitleSort.Size = new Size(121, 23);
            TitleSort.TabIndex = 17;
            // 
            // AuthorSort
            // 
            AuthorSort.Anchor = AnchorStyles.Top;
            AuthorSort.Location = new Point(461, 83);
            AuthorSort.Name = "AuthorSort";
            AuthorSort.Size = new Size(121, 23);
            AuthorSort.TabIndex = 18;
            // 
            // StatusSort
            // 
            StatusSort.Anchor = AnchorStyles.Top;
            StatusSort.FormattingEnabled = true;
            StatusSort.Location = new Point(461, 141);
            StatusSort.Name = "StatusSort";
            StatusSort.Size = new Size(121, 23);
            StatusSort.TabIndex = 19;
            // 
            // RatingSort
            // 
            RatingSort.Anchor = AnchorStyles.Top;
            RatingSort.FormattingEnabled = true;
            RatingSort.Location = new Point(461, 170);
            RatingSort.Name = "RatingSort";
            RatingSort.Size = new Size(121, 23);
            RatingSort.TabIndex = 20;
            // 
            // BookTypeSort
            // 
            BookTypeSort.Anchor = AnchorStyles.Top;
            BookTypeSort.FormattingEnabled = true;
            BookTypeSort.Location = new Point(461, 199);
            BookTypeSort.Name = "BookTypeSort";
            BookTypeSort.Size = new Size(121, 23);
            BookTypeSort.TabIndex = 21;
            // 
            // SpecSort
            // 
            SpecSort.Anchor = AnchorStyles.Top;
            SpecSort.Location = new Point(461, 228);
            SpecSort.Name = "SpecSort";
            SpecSort.Size = new Size(121, 23);
            SpecSort.TabIndex = 22;
            // 
            // PublicationCheck
            // 
            PublicationCheck.Anchor = AnchorStyles.Top;
            PublicationCheck.AutoSize = true;
            PublicationCheck.BackColor = Color.Transparent;
            PublicationCheck.Location = new Point(330, 114);
            PublicationCheck.Name = "PublicationCheck";
            PublicationCheck.Size = new Size(97, 19);
            PublicationCheck.TabIndex = 23;
            PublicationCheck.Text = "Видавництво";
            PublicationCheck.UseVisualStyleBackColor = false;
            // 
            // StatusCheck
            // 
            StatusCheck.Anchor = AnchorStyles.Top;
            StatusCheck.AutoSize = true;
            StatusCheck.BackColor = Color.Transparent;
            StatusCheck.Location = new Point(330, 143);
            StatusCheck.Name = "StatusCheck";
            StatusCheck.Size = new Size(80, 19);
            StatusCheck.TabIndex = 24;
            StatusCheck.Text = "Наявність";
            StatusCheck.UseVisualStyleBackColor = false;
            // 
            // RatingCheck
            // 
            RatingCheck.Anchor = AnchorStyles.Top;
            RatingCheck.AutoSize = true;
            RatingCheck.BackColor = Color.Transparent;
            RatingCheck.Location = new Point(330, 172);
            RatingCheck.Name = "RatingCheck";
            RatingCheck.Size = new Size(64, 19);
            RatingCheck.TabIndex = 25;
            RatingCheck.Text = "Оцінка";
            RatingCheck.UseVisualStyleBackColor = false;
            // 
            // BookTypeCheck
            // 
            BookTypeCheck.Anchor = AnchorStyles.Top;
            BookTypeCheck.AutoSize = true;
            BookTypeCheck.BackColor = Color.Transparent;
            BookTypeCheck.Location = new Point(330, 201);
            BookTypeCheck.Name = "BookTypeCheck";
            BookTypeCheck.Size = new Size(81, 19);
            BookTypeCheck.TabIndex = 26;
            BookTypeCheck.Text = "Тип книги";
            BookTypeCheck.UseVisualStyleBackColor = false;
            // 
            // SpecCheck
            // 
            SpecCheck.Anchor = AnchorStyles.Top;
            SpecCheck.AutoSize = true;
            SpecCheck.BackColor = Color.Transparent;
            SpecCheck.Location = new Point(330, 230);
            SpecCheck.Name = "SpecCheck";
            SpecCheck.Size = new Size(97, 19);
            SpecCheck.TabIndex = 27;
            SpecCheck.Text = "Спеціфікація";
            SpecCheck.UseVisualStyleBackColor = false;
            // 
            // SortButton
            // 
            SortButton.Anchor = AnchorStyles.Top;
            SortButton.Location = new Point(461, 278);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(121, 47);
            SortButton.TabIndex = 28;
            SortButton.Text = "Сортувати";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // SortReset
            // 
            SortReset.Anchor = AnchorStyles.Top;
            SortReset.Location = new Point(330, 278);
            SortReset.Name = "SortReset";
            SortReset.Size = new Size(109, 47);
            SortReset.TabIndex = 29;
            SortReset.Text = "Очистити";
            SortReset.UseVisualStyleBackColor = true;
            SortReset.Click += SortReset_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top;
            EditButton.Location = new Point(103, 258);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(92, 30);
            EditButton.TabIndex = 30;
            EditButton.Text = "Редагувати";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top;
            DeleteButton.BackColor = Color.Transparent;
            DeleteButton.Location = new Point(201, 278);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 30);
            DeleteButton.TabIndex = 31;
            DeleteButton.Text = "Видалити";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Anchor = AnchorStyles.Top;
            ConfirmButton.BackColor = Color.Transparent;
            ConfirmButton.Enabled = false;
            ConfirmButton.Location = new Point(103, 294);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(92, 30);
            ConfirmButton.TabIndex = 32;
            ConfirmButton.Text = "Підтвердити";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // MainListBox
            // 
            MainListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainListBox.BackColor = SystemColors.Control;
            MainListBox.ForeColor = SystemColors.InfoText;
            MainListBox.FormattingEnabled = true;
            MainListBox.ItemHeight = 15;
            MainListBox.Location = new Point(0, 332);
            MainListBox.Name = "MainListBox";
            MainListBox.Size = new Size(753, 319);
            MainListBox.TabIndex = 33;
            // 
            // BookStatus
            // 
            BookStatus.Anchor = AnchorStyles.Top;
            BookStatus.FormattingEnabled = true;
            BookStatus.Location = new Point(3, 141);
            BookStatus.Name = "BookStatus";
            BookStatus.Size = new Size(192, 23);
            BookStatus.TabIndex = 35;
            BookStatus.Text = "Наявність";
            // 
            // BookRating
            // 
            BookRating.Anchor = AnchorStyles.Top;
            BookRating.FormattingEnabled = true;
            BookRating.Location = new Point(3, 170);
            BookRating.Name = "BookRating";
            BookRating.Size = new Size(192, 23);
            BookRating.TabIndex = 36;
            BookRating.Text = "Оцінка від 1 до 5";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top;
            SaveButton.Location = new Point(621, 112);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(116, 64);
            SaveButton.TabIndex = 37;
            SaveButton.Text = "Зберегти";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Anchor = AnchorStyles.Top;
            LoadButton.Location = new Point(621, 177);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(116, 64);
            LoadButton.TabIndex = 38;
            LoadButton.Text = "Завантажити";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(411, 18);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 39;
            label1.Text = "Сортування";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(88, 18);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 40;
            label2.Text = "Менеджмент книг";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(630, 18);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 41;
            label3.Text = "Файл бібліотеки";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VerticalSeparator1
            // 
            VerticalSeparator1.Anchor = AnchorStyles.Top;
            VerticalSeparator1.BackColor = Color.Gray;
            VerticalSeparator1.Location = new Point(315, 30);
            VerticalSeparator1.Name = "VerticalSeparator1";
            VerticalSeparator1.Size = new Size(2, 290);
            VerticalSeparator1.TabIndex = 42;
            // 
            // VerticalSeparator2
            // 
            VerticalSeparator2.Anchor = AnchorStyles.Top;
            VerticalSeparator2.BackColor = Color.Gray;
            VerticalSeparator2.Location = new Point(595, 30);
            VerticalSeparator2.Name = "VerticalSeparator2";
            VerticalSeparator2.Size = new Size(2, 290);
            VerticalSeparator2.TabIndex = 43;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(753, 655);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(BookRating);
            Controls.Add(BookStatus);
            Controls.Add(MainListBox);
            Controls.Add(ConfirmButton);
            Controls.Add(DeleteButton);
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
            Controls.Add(Publication);
            Controls.Add(Title);
            Controls.Add(Author);
            Controls.Add(BookChoose);
            Controls.Add(AddButton);
            Controls.Add(VerticalSeparator1);
            Controls.Add(VerticalSeparator2);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Персональна бібліотека";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddButton;
        private ComboBox BookChoose;
        private TextBox Author;
        private TextBox Title;
        private TextBox Publication;
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
        private Button DeleteButton;
        private Button ConfirmButton;
        private ListBox MainListBox;
        private ComboBox BookStatus;
        private ComboBox BookRating;
        private Button SaveButton;
        private Button LoadButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel VerticalSeparator1;
        private Panel VerticalSeparator2;
    }
}