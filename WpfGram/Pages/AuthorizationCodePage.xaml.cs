﻿using System;
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

using WpfGram.ViewModels;

namespace WpfGram.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationCodePage.xaml
    /// </summary>
    public partial class AuthorizationCodePage : Page
    {
        public AuthorizationCodePage()
        {
            InitializeComponent();
        }
        public AuthorizationCodePage(AuthorizationCodeViewModel viewModel):this() 
        {
            DataContext = viewModel;
        }
    }
}
