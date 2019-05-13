﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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
using ModuleB.ViewModel;

namespace ModuleB.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    /// 
    [Export(typeof(MessageList))]
    public partial class MessageList : UserControl
    {


        [ImportingConstructor]
        public MessageList()
        {
            InitializeComponent();
        }
    }
}
