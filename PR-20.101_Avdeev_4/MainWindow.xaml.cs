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
using PR_20._101_Avdeev_4.Entity;

namespace PR_20._101_Avdeev_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EntitiesRK m = new EntitiesRK();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_poisk_Click(object sender, RoutedEventArgs e)
        {
            int spec = Convert.ToInt32(tb_Poisk.Text);
            EntitiesRK database = EntitiesRK.GetContext();
            Group group = new Group();
            group = database.Group.FirstOrDefault();

            if (spec == group.IdSpeciality)
            {
                var query = from grp in m.Group select new { grp.IdGroup, grp.Title, grp.CourseNumber, grp.IdSpeciality };
                LoadData.ItemsSource = query.ToList();  
            }
            else
            {
                MessageBox.Show("Результаты поиска остутствуют");
            }
        }
    }
}
