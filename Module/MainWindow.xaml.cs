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
using static Module.Avians;

namespace Module
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

        private void calculate_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DackArea duck_volyer = new DackArea(5, 7, 2 * 4);
                KiwiArea kiwi_volyer = new KiwiArea(5.9, 9.9, 3 * 4);
                PenguinArea penguin_volyer = new PenguinArea(5, 6, 3);
                List<Bird> ducks = new List<Bird>();
                List<Bird> kiwis = new List<Bird>();
                List<Bird> penguins = new List<Bird>();

                if (int.TryParse(duckCountTextBox.Text, out int duckCount))
                {
                    for (int i = 0; i < duckCount; i++)
                    {
                        ducks.Add(new Duck());
                    }
                }

                if (int.TryParse(kiwiCountTextBox.Text, out int kiwiCount))
                {
                    for (int i = 0; i < kiwiCount; i++)
                    {
                        kiwis.Add(new Kiwi());
                    }
                }

                if (int.TryParse(penguinCountTextBox.Text, out int penguinCount))
                {
                    for (int i = 0; i < penguinCount; i++)
                    {
                        penguins.Add(new Penguin());
                    }
                }

                double totalArea = 0;

                totalArea += (kiwi_volyer.area() * kiwiCount) + (penguin_volyer.area() * penguinCount) + (duck_volyer.area() * duckCount);


                textLabelDucks.Content = $"Кількість качок у списку: {ducks.Count}";
                textLabelKiwis.Content = $"Кількість ківі у списку: {kiwis.Count}";
                textLabelPenguins.Content = $"Кількість пінгвінів у списку: {penguins.Count}";
                textLabelTotalArea.Content = $"Сумарна площа вольєрів: {totalArea} м²";
                duckVolyer_area.Content = $"Сумарна площа для качок: {duckCount * duck_volyer.area()}";
                kiwiVolyer_area.Content = $"Сумарна площа для качок: {kiwiCount * kiwi_volyer.area()}";
                penguinVolyer_area.Content = $"Сумарна площа для качок: {penguinCount * penguin_volyer.area()}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка у введенні даних.");
            }

        }
    }
}
