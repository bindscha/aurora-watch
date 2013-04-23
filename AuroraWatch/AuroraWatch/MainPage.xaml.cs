using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace AuroraWatch
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPageLoaded;
            //Pivot.SelectionChanged += PivotChanged;
        }

        private static AuroraArea Europe = new AuroraArea { RegionName = "Europe", ActivityText = "LOW", ForecastText = "Europe..." };
        private static AuroraArea America = new AuroraArea { RegionName = "America", ActivityText = "LOW", ForecastText = "America..." };
        private static AuroraArea Alaska = new AuroraArea { RegionName = "Alaska", ActivityText = "LOW", ForecastText = "Alaska..." };
        private static AuroraArea NorthPole = new AuroraArea { RegionName = "North Pole", ActivityText = "LOW", ForecastText = "NorthPole..." };
        private static AuroraArea SouthPole = new AuroraArea { RegionName = "South Pole", ActivityText = "LOW", ForecastText = "SouthPole..." };

        private AuroraArea[] Areas = new AuroraArea[] { Europe, America, Alaska, NorthPole, SouthPole };

        private void SetDataContext(Grid grid, Info context)
        {
            grid.DataContext = context;
        }

        void MainPageLoaded(object sender, RoutedEventArgs e)
        {
            foreach(AuroraArea area in Areas) {
                Pivot.Items.Add(new PivotItem 
                {
                    Header = area.RegionName,
                    Content = new Grid()
                });
            }
        }

        /*void PivotChanged(object sender, RoutedEventArgs e)
        {
            var _pivotItem = Pivot.SelectedItem;

            var _infoText = new Info
            {
                InfoText = "..."
            };

            if (_pivotItem == Pivot.)
            {
                _infoText.InfoText = "Europe";
                SetDataContext(EuropeRoot, _infoText);
            }
            else if (_pivotItem == AmericaRoot)
            {
                _infoText.InfoText = "America";
                SetDataContext(AmericaRoot, _infoText);
            }
            else if (_pivotItem == AlaskaRoot)
            {
                _infoText.InfoText = "Alaska";
            }
            else if (_pivotItem == NorthPoleRoot)
            {
                _infoText.InfoText = "North Pole";
            }
            else if (_pivotItem == SouthPoleRoot)
            {
                _infoText.InfoText = "South Pole";
            }
            else
            {
                // ignored
                SetDataContext(EuropeRoot, _infoText);
            }

            
        }*/
    }
}