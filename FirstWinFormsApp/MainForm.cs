using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = "Текст из конструктора";
            string hexValue = "#FF0000";
            Color color = ColorTranslator.FromHtml(hexValue);
            this.BackColor = color;
        }

        private bool stringIsSpaces(string str)
        {
            for(int i = 0; i < str.Length; i++) 
            {
                char symbol = str[i];
                if(symbol != ' ')
                {
                    return false;
                }
            }

            return true;
        }

        private void AddPeople_Click(object sender, System.EventArgs e)
        {
            if (SelectedImageFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            string fullPathToFile = SelectedImageFileDialog.FileName;
            Peoples.Items.Add(Path.GetFileName(fullPathToFile));
        }

        private void Peoples_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selectedIndex = Peoples.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    Peoples.Items.RemoveAt(selectedIndex);
                }
            }
        }

        private void Peoples_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            /// ДЗ: загружать связанную с выбранным элементом картинку в область PictureArea
            MessageBox.Show(Peoples.SelectedItem.ToString());

            PictureArea.Load()
        }
    }
}
