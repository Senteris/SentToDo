﻿using SentToDo.ViewModels;
using System.Windows;

namespace SentToDo.Views
{
    public partial class Tasks : Window
    {
        public Tasks()
        {
            InitializeComponent();
            DataContext = new TasksVM();
        }
    }
}
