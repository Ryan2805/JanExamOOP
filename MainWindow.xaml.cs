/********************************
 * Program Purpose: January Exam Object Oriented Programming
 * Author: Ryan Daly (S00237889)
 * Date Created: 06/01/2024
 * Link to GitHub Repository: https://github.com/Ryan2805/JanExamOOP
 * 
 * 
 * 
 */






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

namespace JanExamOOP
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
        //Display Income List Box
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Income 
            // Why is BudgetItem saying theres no response to the Boolean recurring if theres true & false 
            BudgetItem item1 = new BudgetItem("Grant", "5th of Month", 300, true);
            BudgetItem item2 = new BudgetItem("Bonus", "15th of Month", 300, false);
            BudgetItem item3 = new BudgetItem("Wages", "25th of Month", 100, true);

            
            //Display
            lbx.Items.Add(item1);
        }





    }
}
