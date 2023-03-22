using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GetCharacterIndexFromPointBugDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_MouseMove(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int charIndex = textBox.GetCharacterIndexFromPoint(Mouse.GetPosition(textBox), false);

            HoveredCharacterTextBlock.Text = charIndex is not -1
                ? textBox.Text[charIndex].ToString()
                : "No character is being hovered?";
        }
    }
}
