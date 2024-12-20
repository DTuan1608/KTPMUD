﻿using DeviceConfig.Views;
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

namespace KTPMUD.Views.CoSoChanNuoi
{
    /// <summary>
    /// Interaction logic for CoSoChanNuoiLayout.xaml
    /// </summary>
    public partial class CoSoChanNuoiLayout : UserControl
    {
        List<string> data;
        public CoSoChanNuoiLayout()
        {
            InitializeComponent();
            data = new List<string>() { "Duong Duc Tuan" , "Mã Sinh Vien"};
            CSCN.ItemsSource = data;
        }
    }
    public class Index : BaseView<CoSoChanNuoiLayout, object> { }

}
