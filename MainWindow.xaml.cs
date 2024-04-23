using _8PR.Classes;
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

namespace _8PR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WarriorLite WarriorLite = new WarriorLite(100);
        public WarriorHeight WarriorHeght = new WarriorHeight(100);

        public MainWindow()
        {
            InitializeComponent();

            personLiteHP.Content = "Жизненные показатели: " + WarriorLite.HP;
            personHeightHP.Content = "Жизненные показатели: " + WarriorHeght.HP;
        }

        private void AttackLite(object sender, MouseButtonEventArgs e)
        {
            WarriorLite.ShootDamage(50);
            personLiteHP.Content = "Жизненные показатели: " + WarriorLite.HP;
        }

        private void AttackHeight(object sender, MouseButtonEventArgs e)
        {
            WarriorHeght.ShootDamage(50);
            personHeightHP.Content = "Жизненные показатели: " + WarriorHeght.HP;
        }
    }
}
