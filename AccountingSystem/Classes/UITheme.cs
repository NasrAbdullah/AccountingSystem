using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AccountingSystem.Classes
{

    public static class UITheme
    {
        // =========================================================
        // COLORS
        // =========================================================

        // خلفية البرنامج
        public static Color Background =
            Color.FromArgb(12, 15, 25);

        // Sidebar
        public static Color Sidebar =
            Color.FromArgb(17, 21, 35);

        // محتوى الصفحات
        public static Color Content =
            Color.FromArgb(21, 26, 42);

        // Header
        public static Color Header =
            Color.FromArgb(25, 30, 49);

        // Footer
        public static Color Footer =
            Color.FromArgb(17, 21, 35);

        // Cards
        public static Color Card =
            Color.FromArgb(27, 33, 53);

        // الحدود
        public static Color Border =
            Color.FromArgb(48, 57, 84);


        // =========================================================
        // PRIMARY COLORS
        // =========================================================

        // اللون الأساسي
        public static Color Primary =
            Color.FromArgb(124, 92, 255);

        // Hover
        public static Color PrimaryHover =
            Color.FromArgb(145, 118, 255);

        // اللون الأزرق
        public static Color Blue =
            Color.FromArgb(72, 133, 237);

        // الأزرق عند Hover
        public static Color BlueHover =
            Color.FromArgb(91, 151, 255);


        // =========================================================
        // STATUS COLORS
        // =========================================================

        public static Color Success =
            Color.FromArgb(46, 204, 153);

        public static Color Warning =
            Color.FromArgb(255, 184, 77);

        public static Color Danger =
            Color.FromArgb(239, 91, 91);

        public static Color Info =
            Color.FromArgb(72, 133, 237);


        // =========================================================
        // TEXT COLORS
        // =========================================================

        // النص الأساسي
        public static Color Text =
            Color.FromArgb(245, 247, 255);

        // النص الثانوي
        public static Color SecondaryText =
            Color.FromArgb(166, 174, 198);

        // النص الخافت
        public static Color MutedText =
            Color.FromArgb(115, 124, 151);


        // =========================================================
        // FORM
        // =========================================================

        public static void ApplyForm(Form form)
        {
            form.BackColor = Background;
            form.ForeColor = Text;
        }


        // =========================================================
        // PANELS
        // =========================================================

        public static void ApplySidebar(Panel panel)
        {
            panel.BackColor = Sidebar;
        }

        public static void ApplyContent(Panel panel)
        {
            panel.BackColor = Content;
        }

        public static void ApplyHeader(Panel panel)
        {
            panel.BackColor = Header;
        }

        public static void ApplyFooter(Panel panel)
        {
            panel.BackColor = Footer;
        }

        public static void ApplyCard(Panel panel)
        {
            panel.BackColor = Card;
        }

        public static void ApplyPanel(Panel panel)
        {
            panel.BackColor = Content;
        }


        // =========================================================
        // LABEL
        // =========================================================

        public static void ApplyLabel(Label label)
        {
            label.ForeColor = Text;
            label.BackColor = Color.Transparent;
        }

        public static void ApplySecondaryLabel(Label label)
        {
            label.ForeColor = SecondaryText;
            label.BackColor = Color.Transparent;
        }

        public static void ApplyMutedLabel(Label label)
        {
            label.ForeColor = MutedText;
            label.BackColor = Color.Transparent;
        }

        public static void ApplyTitle(Label label)
        {
            label.ForeColor = Text;
            label.BackColor = Color.Transparent;
            label.Font = new Font(
                label.Font.FontFamily,
                18,
                FontStyle.Bold
            );
        }


        // =========================================================
        // BUTTON
        // =========================================================

        public static void ApplyButton(Button button)
        {
            button.BackColor = Primary;
            button.ForeColor = Color.White;

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            button.Cursor = Cursors.Hand;

            button.Font = new Font(
                button.Font.FontFamily,
                button.Font.Size,
                FontStyle.Bold
            );
        }

        public static void ApplySecondaryButton(Button button)
        {
            button.BackColor = Card;
            button.ForeColor = Text;

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Border;

            button.Cursor = Cursors.Hand;
        }

        public static void ApplySuccessButton(Button button)
        {
            button.BackColor = Success;
            button.ForeColor = Color.White;

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            button.Cursor = Cursors.Hand;
        }

        public static void ApplyDangerButton(Button button)
        {
            button.BackColor = Danger;
            button.ForeColor = Color.White;

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            button.Cursor = Cursors.Hand;
        }


        // =========================================================
        // TEXTBOX
        // =========================================================

        public static void ApplyTextBox(TextBox textBox)
        {
            textBox.BackColor = Card;
            textBox.ForeColor = Text;

            textBox.BorderStyle = BorderStyle.FixedSingle;

            textBox.Font = new Font(
                textBox.Font.FontFamily,
                textBox.Font.Size
            );
        }


        // =========================================================
        // COMBOBOX
        // =========================================================

        public static void ApplyComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = Card;
            comboBox.ForeColor = Text;

            comboBox.FlatStyle = FlatStyle.Flat;

            comboBox.Cursor = Cursors.Hand;
        }


        // =========================================================
        // NUMERIC UP DOWN
        // =========================================================

        public static void ApplyNumericUpDown(NumericUpDown numeric)
        {
            numeric.BackColor = Card;
            numeric.ForeColor = Text;

            numeric.BorderStyle = BorderStyle.FixedSingle;
        }


        // =========================================================
        // CHECKBOX
        // =========================================================

        public static void ApplyCheckBox(CheckBox checkBox)
        {
            checkBox.BackColor = Color.Transparent;
            checkBox.ForeColor = Text;

            checkBox.Cursor = Cursors.Hand;
        }


        // =========================================================
        // RADIO BUTTON
        // =========================================================

        public static void ApplyRadioButton(RadioButton radioButton)
        {
            radioButton.BackColor = Color.Transparent;
            radioButton.ForeColor = Text;

            radioButton.Cursor = Cursors.Hand;
        }


        // =========================================================
        // DATA GRID VIEW
        // =========================================================

        public static void ApplyDataGridView(DataGridView grid)
        {
            // الخلفية
            grid.BackgroundColor = Content;

            // لون النص
            grid.ForeColor = Text;

            // إزالة الحدود
            grid.BorderStyle = BorderStyle.None;

            // طريقة تحديد الصف
            grid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            grid.MultiSelect = false;

            // منع إضافة صف فارغ
            grid.AllowUserToAddRows = false;

            // منع حذف الصفوف من المستخدم
            grid.AllowUserToDeleteRows = false;

            // منع تغيير حجم الأعمدة
            grid.AllowUserToResizeColumns = false;

            // منع تغيير حجم الصفوف
            grid.AllowUserToResizeRows = false;


            // =====================================================
            // HEADER
            // =====================================================

            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor =
                Header;

            grid.ColumnHeadersDefaultCellStyle.ForeColor =
                Text;

            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Header;

            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Text;

            grid.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            grid.ColumnHeadersHeight = 45;


            // =====================================================
            // ROWS
            // =====================================================

            grid.DefaultCellStyle.BackColor =
                Card;

            grid.DefaultCellStyle.ForeColor =
                Text;

            grid.DefaultCellStyle.SelectionBackColor =
                Primary;

            grid.DefaultCellStyle.SelectionForeColor =
                Color.White;

            grid.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            grid.RowTemplate.Height = 40;


            // =====================================================
            // ALTERNATE ROW
            // =====================================================

            grid.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(24, 30, 48);


            // =====================================================
            // GRID LINES
            // =====================================================

            grid.GridColor = Border;

            grid.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;


            // =====================================================
            // ALIGNMENT
            // =====================================================

            grid.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            grid.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            // =====================================================
            // ROW HEADERS
            // =====================================================

            grid.RowHeadersVisible = false;
        }


        // =========================================================
        // GROUP BOX
        // =========================================================

        public static void ApplyGroupBox(GroupBox groupBox)
        {
            groupBox.BackColor = Color.Transparent;
            groupBox.ForeColor = SecondaryText;
        }


        // =========================================================
        // CHECKED LIST BOX
        // =========================================================

        public static void ApplyCheckedListBox(
            CheckedListBox listBox)
        {
            listBox.BackColor = Card;
            listBox.ForeColor = Text;

            listBox.BorderStyle =
                BorderStyle.FixedSingle;
        }


        // =========================================================
        // LIST BOX
        // =========================================================

        public static void ApplyListBox(ListBox listBox)
        {
            listBox.BackColor = Card;
            listBox.ForeColor = Text;

            listBox.BorderStyle =
                BorderStyle.FixedSingle;
        }


        // =========================================================
        // PROGRESS BAR
        // =========================================================

        public static void ApplyProgressBar(
            ProgressBar progressBar)
        {
            progressBar.BackColor = Card;
        }


        // =========================================================
        // DATE TIME PICKER
        // =========================================================

        public static void ApplyDateTimePicker(
            DateTimePicker datePicker)
        {
            datePicker.BackColor = Card;
            datePicker.ForeColor = Text;
        }


        // =========================================================
        // RICH TEXT BOX
        // =========================================================

        public static void ApplyRichTextBox(
            RichTextBox richTextBox)
        {
            richTextBox.BackColor = Card;
            richTextBox.ForeColor = Text;

            richTextBox.BorderStyle =
                BorderStyle.FixedSingle;
        }
    };

}