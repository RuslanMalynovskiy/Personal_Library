using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using Personal_Library.Models;
using System.Drawing;

namespace Personal_Library.Forms
{
    public partial class MainForm : Form
    {
        private readonly Library library = new();
        private Book? selectedBook = null;
        private const string LibraryFile = "library.json";

        public MainForm()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(240, 248, 255);
            this.Font = new Font("Segoe UI", 10);
            this.MinimumSize = new Size(800, 600);

            BookChoose.Items.AddRange(["Фікшн", "Хобі", "Господарство", "Спеціальна", "Інше"]);
            BookStatus.Items.AddRange(["Наявна", "Відсутня", "Очікую на прибуття", "Запозичена"]);
            BookRating.Items.AddRange(["1", "2", "3", "4", "5"]);
            BookTypeSort.Items.AddRange(["Фікшн", "Хобі", "Господарство", "Спеціальна", "Інше"]);
            StatusSort.Items.AddRange(["Наявна", "Відсутня", "Очікую на прибуття", "Запозичена"]);
            RatingSort.Items.AddRange(["1", "2", "3", "4", "5"]);

            MainListBox.Font = new Font("Segoe UI", 12);
            MainListBox.DrawMode = DrawMode.OwnerDrawFixed;
            MainListBox.ItemHeight = 40;

            MainListBox.DrawItem += (s, e) =>
            {
                if (e.Index < 0) return;

                var isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                var bg = e.Index % 2 == 0 ? Color.White : Color.FromArgb(235, 245, 255);
                if (isSelected)
                {
                    bg = Color.FromArgb(200, 230, 255);
                    e.Graphics.FillRectangle(new SolidBrush(bg), e.Bounds);
                    var rect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
                    e.Graphics.DrawRectangle(new Pen(Color.RoyalBlue, 2), rect);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(bg), e.Bounds);
                }

                using var brush = new SolidBrush(Color.Black);
                e.Graphics.DrawString(MainListBox.Items[e.Index].ToString(), e.Font, brush, e.Bounds);
                e.DrawFocusRectangle();
            };

            foreach (var cb in Controls.OfType<CheckBox>())
                StyleCheckBox(cb);

            foreach (var btn in Controls.OfType<Button>())
                StyleButton(btn);

            foreach (var tb in Controls.OfType<TextBox>())
                tb.Font = new Font("Segoe UI", 10);

            foreach (var cb in Controls.OfType<ComboBox>())
                cb.Font = new Font("Segoe UI", 10);
        }

        private void StyleCheckBox(CheckBox cb)
        {
            cb.Appearance = Appearance.Button;
            cb.FlatStyle = FlatStyle.Flat;
            cb.FlatAppearance.BorderSize = 0;
            cb.TextAlign = ContentAlignment.MiddleCenter;
            cb.BackColor = Color.IndianRed;
            cb.ForeColor = Color.Black;

            cb.CheckedChanged += (s, e) =>
            {
                cb.BackColor = cb.Checked ? Color.DarkOliveGreen : Color.IndianRed;
            };
        }

        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = btn.Enabled ? Color.LightSeaGreen : Color.IndianRed;
            btn.ForeColor = Color.Black;

            btn.EnabledChanged += (s, e) =>
            {
                btn.BackColor = btn.Enabled ? Color.LightSeaGreen : Color.IndianRed;
            };
        }

        private void UpdateListBox(List<Book> books)
        {
            MainListBox.Items.Clear();
            foreach (var book in books.OrderByDescending(b => b.Id))
                MainListBox.Items.Add(book.About());
        }

        private bool IsOnlyDigits(string input)
        {
            string trimmed = input?.Replace(" ", "") ?? "";
            return trimmed.Length > 0 && trimmed.All(char.IsDigit);
        }

        private void UpdateBookInfo(Book book, string title, string author, string publication, string status, string rating)
        {
            book.Title = title;
            book.Author = author;
            book.Publication = publication;
            book.Availability = status;
            book.Rating = int.TryParse(rating, out int r) ? r : 0;
        }

        private void ClearInputs()
        {
            Title.Text = "Назва";
            Author.Text = "Автор";
            Publication.Text = "Видавництво";
            Spec.Text = "Специфікація";
            BookStatus.SelectedIndex = -1;
            BookStatus.Text = "Наявність";
            BookRating.SelectedIndex = -1;
            BookRating.Text = "Оцінка книги";
            BookChoose.SelectedIndex = -1;
            BookChoose.Text = "Тип книги";
        }

        private int ExtractIdFromText(string text)
        {
            if (text.StartsWith("#"))
            {
                int endIndex = text.IndexOf(' ');
                if (endIndex > 1 && int.TryParse(text[1..endIndex], out int id))
                    return id;
            }
            return -1;
        }

        private string GetSpecValue(Book book) => book switch
        {
            FictionBook fb => fb.Genre,
            HobbyBook hb => hb.HobbyType,
            HouseholdBook hh => hh.HouseholdType,
            SpecialBook sb => sb.Specification,
            OtherBook ob => ob.BookType,
            _ => ""
        };



        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Title.Text) || BookChoose.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Spec.Text))
            {
                MessageBox.Show("Будь ласка, виберіть Тип книги, заповніть Назву та Специфікацію.");
                return;
            }

            if (IsOnlyDigits(Author.Text) || IsOnlyDigits(Publication.Text) || IsOnlyDigits(Spec.Text))
            {
                MessageBox.Show("Не використовуйте лише цифри в цих полях: Автор, Видавництво, Специфікація");
                return;
            }

            string title = Title.Text.Trim();

            string author = string.IsNullOrWhiteSpace(Author.Text) || Author.Text == "Автор" ? "Автор невідомий" : Author.Text.Trim();
            string publication = string.IsNullOrWhiteSpace(Publication.Text) || Publication.Text == "Видавництво" ? "Видавництво невідоме" : Publication.Text.Trim();
            string status = BookStatus.SelectedItem?.ToString() ?? "Наявність невідома";
            string rating = BookRating.SelectedItem?.ToString() ?? "Не впевнений";
            string type = BookChoose.SelectedItem.ToString();
            string spec = Spec.Text.Trim();

            Book newBook = type switch
            {
                "Фікшн" => new FictionBook { Title = title, Author = author, Publication = publication, Genre = spec },
                "Хобі" => new HobbyBook { Title = title, Author = author, Publication = publication, HobbyType = spec },
                "Господарство" => new HouseholdBook { Title = title, Author = author, Publication = publication, HouseholdType = spec },
                "Спеціальна" => new SpecialBook { Title = title, Author = author, Publication = publication, Specification = spec },
                "Інше" => new OtherBook { Title = title, Author = author, Publication = publication, BookType = spec },
                _ => throw new InvalidOperationException("Невідомий тип книги.")
            };

            newBook.Id = library.Count + 1;
            newBook.Availability = status;
            newBook.Rating = int.TryParse(rating, out int r) ? r : 0;
            library.Add(newBook);

            UpdateListBox(library.GetAllBooks());
            ClearInputs();
        }

        private void AddReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
            BookChoose.Visible = true;
            AddButton.Enabled = true;
            ConfirmButton.Enabled = false;
            selectedBook = null;
            UpdateListBox(library.GetAllBooks());
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (MainListBox.SelectedIndex == -1) return;

            int id = ExtractIdFromText(MainListBox.SelectedItem.ToString());
            selectedBook = library.GetById(id);
            if (selectedBook == null) return;

            Title.Text = selectedBook.Title;
            Author.Text = selectedBook.Author;
            Publication.Text = selectedBook.Publication;
            Spec.Text = GetSpecValue(selectedBook);
            BookStatus.SelectedItem = selectedBook.Availability;
            BookRating.SelectedItem = selectedBook.Rating.ToString();
            BookChoose.SelectedItem = selectedBook switch
            {
                FictionBook => "Фікшн",
                HobbyBook => "Хобі",
                HouseholdBook => "Господарство",
                SpecialBook => "Спеціальна",
                OtherBook => "Інше",
                _ => null
            };
            AddButton.Enabled = false;
            ConfirmButton.Enabled = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (selectedBook == null) return;

            if (string.IsNullOrWhiteSpace(Title.Text) ||
                BookChoose.SelectedItem == null ||
                string.IsNullOrWhiteSpace(Spec.Text))
            {
                MessageBox.Show("Заповніть Назву, Тип книги та Специфікацію.");
                return;
            }

            if (IsOnlyDigits(Author.Text) || IsOnlyDigits(Publication.Text) || IsOnlyDigits(Spec.Text))
            {
                MessageBox.Show("Не використовуйте лише цифри в цих полях: Автор, Видавництво, Специфікація.");
                return;
            }

            string title = Title.Text.Trim();
            string author = string.IsNullOrWhiteSpace(Author.Text) || Author.Text == "Автор"
                ? "Автор невідомий"
                : Author.Text.Trim();

            string publication = string.IsNullOrWhiteSpace(Publication.Text) || Publication.Text == "Видавництво"
                ? "Видавництво невідоме"
                : Publication.Text.Trim();

            string status = BookStatus.SelectedItem?.ToString() ?? "Невідомо";
            string rating = BookRating.SelectedItem?.ToString() ?? "0";
            string type = BookChoose.SelectedItem.ToString();
            string spec = Spec.Text.Trim();

            bool typeChanged = true;
            Book updatedBook;

            switch (type)
            {
                case "Фікшн" when selectedBook is FictionBook fb:
                    fb.Genre = spec;
                    updatedBook = fb;
                    typeChanged = false;
                    break;
                case "Хобі" when selectedBook is HobbyBook hb:
                    hb.HobbyType = spec;
                    updatedBook = hb;
                    typeChanged = false;
                    break;
                case "Господарство" when selectedBook is HouseholdBook hhb:
                    hhb.HouseholdType = spec;
                    updatedBook = hhb;
                    typeChanged = false;
                    break;
                case "Спеціальна" when selectedBook is SpecialBook sb:
                    sb.Specification = spec;
                    updatedBook = sb;
                    typeChanged = false;
                    break;
                case "Інше" when selectedBook is OtherBook ob:
                    ob.BookType = spec;
                    updatedBook = ob;
                    typeChanged = false;
                    break;
                default:
                    updatedBook = type switch
                    {
                        "Фікшн" => new FictionBook { Genre = spec },
                        "Хобі" => new HobbyBook { HobbyType = spec },
                        "Господарство" => new HouseholdBook { HouseholdType = spec },
                        "Спеціальна" => new SpecialBook { Specification = spec },
                        "Інше" => new OtherBook { BookType = spec },
                        _ => throw new InvalidOperationException($"Тип книги «{type}» не підтримується.")
                    };
                    break;
            }

            UpdateBookInfo(updatedBook, title, author, publication, status, rating);

            if (typeChanged)
            {
                int originalId = selectedBook.Id;
                library.Remove(originalId);
                updatedBook.Id = originalId;
                library.Add(updatedBook);
            }

            UpdateListBox(library.GetAllBooks());
            ClearInputs();
            AddButton.Enabled = true;
            ConfirmButton.Enabled = false;
            selectedBook = null;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MainListBox.SelectedIndex == -1) return;

            int id = ExtractIdFromText(MainListBox.SelectedItem.ToString());
            if (library.Remove(id))
            {
                UpdateListBox(library.GetAllBooks());
                if (selectedBook?.Id == id)
                {
                    selectedBook = null;
                    ClearInputs();
                    AddButton.Enabled = true;
                    ConfirmButton.Enabled = false;
                }
            }
            else MessageBox.Show("Книгу не знайдено або не вдалося видалити.");
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            var filtered = library.GetAllBooks().Where(book =>
            {
                if (TitleCheck.Checked && !string.IsNullOrWhiteSpace(TitleSort.Text) &&
                    !book.Title.Contains(TitleSort.Text, StringComparison.OrdinalIgnoreCase)) return false;

                if (AuthorCheck.Checked && !string.IsNullOrWhiteSpace(AuthorSort.Text) &&
                    !book.Author.Contains(AuthorSort.Text, StringComparison.OrdinalIgnoreCase)) return false;

                if (PublicationCheck.Checked && !string.IsNullOrWhiteSpace(PublicationSort.Text) &&
                    !book.Publication.Contains(PublicationSort.Text, StringComparison.OrdinalIgnoreCase)) return false;

                if (StatusCheck.Checked && !string.IsNullOrWhiteSpace(StatusSort.Text) &&
                    !book.Availability.Contains(StatusSort.Text, StringComparison.OrdinalIgnoreCase)) return false;

                if (RatingCheck.Checked && !string.IsNullOrWhiteSpace(RatingSort.Text) &&
                    !book.Rating.ToString().Contains(RatingSort.Text)) return false;

                if (BookTypeCheck.Checked && !string.IsNullOrWhiteSpace(BookTypeSort.Text))
                {
                    string actualType = book switch
                    {
                        FictionBook => "Фікшн",
                        HobbyBook => "Хобі",
                        HouseholdBook => "Господарство",
                        SpecialBook => "Спеціальна",
                        OtherBook => "Інше",
                        _ => ""
                    };
                    if (!actualType.Contains(BookTypeSort.Text, StringComparison.OrdinalIgnoreCase)) return false;
                }

                if (SpecCheck.Checked && !string.IsNullOrWhiteSpace(SpecSort.Text) &&
                    !GetSpecValue(book).Contains(SpecSort.Text, StringComparison.OrdinalIgnoreCase)) return false;

                return true;
            }).ToList();
            if (filtered.Count == 0)
            {
                MessageBox.Show("Співпадінь не знайдено!");
            }
            else UpdateListBox(filtered);
        }

        private void SortReset_Click(object sender, EventArgs e)
        {
            TitleSort.Clear(); AuthorSort.Clear(); PublicationSort.Clear(); SpecSort.Clear();
            StatusSort.SelectedIndex = -1; RatingSort.SelectedIndex = -1; BookTypeSort.SelectedIndex = -1;
            TitleCheck.Checked = AuthorCheck.Checked = PublicationCheck.Checked = false;
            StatusCheck.Checked = RatingCheck.Checked = BookTypeCheck.Checked = SpecCheck.Checked = false;
            UpdateListBox(library.GetAllBooks());
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                var loaded = Library.LoadFromFile(LibraryFile);
                if (loaded == null)
                {
                    MessageBox.Show("Файл не знайдено або порожній.");
                    return;
                }

                library.Clear();
                loaded.ForEach(library.Add);
                UpdateListBox(library.GetAllBooks());
                MessageBox.Show("Бібліотека завантажена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Library.SaveToFile(LibraryFile, library.GetAllBooks());
                MessageBox.Show("Бібліотека збережена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

    }
}
