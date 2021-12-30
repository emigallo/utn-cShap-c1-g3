using Business.Operations;
using GUI.ViewModels;
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
using System.Windows.Shapes;

namespace GUI.Views
{
    public partial class CalculatorView : Window
    {
        private CalculatorViewModel _vm;
        private Dictionary<string, OperationBase> _operations;


        public CalculatorView()
        {
            InitializeComponent();
            this._vm = new CalculatorViewModel();
            DataContext = this._vm;

            display.Content = "";

        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double result = this._vm.CalculateResult();
            display.Content = result;
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;


            int value = int.Parse(display.Content.ToString());
            display.Content += button.Content.ToString();

            this._vm.AddValue(value);
        }
            
        
        private void AddOperationButton_Click(object sender, RoutedEventArgs e)
        {



            Button button = sender as Button;
            string key = button.Content.ToString();


            OperationBase op = new AddOperation();
            display.Content += key;

            this._vm.AddOperation(op);
            //+
        }

        private void DivideOperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string key = button.Content.ToString();

            OperationBase op = new DivideOperation();
            display.Content += key;

            this._vm.AddOperation(op);
            //+
        }

        private void SubtractOperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string key = button.Content.ToString();

            OperationBase op = new SubtractOperation();
            display.Content += key;

            this._vm.AddOperation(op);
            //+
        }

        private void MultiplyOperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string key = button.Content.ToString();

            OperationBase op = new MultiplyOperation();
            display.Content += key;

            this._vm.AddOperation(op);
            //+
        }

        private void AC_ButtonClick (object sender, RoutedEventArgs e)
        {

            this._vm.Clear();
            display.Content ="";

        }
    }
}