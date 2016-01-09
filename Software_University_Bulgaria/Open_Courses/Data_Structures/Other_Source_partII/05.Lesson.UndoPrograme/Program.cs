using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.List;
using System.Windows.Media;

namespace _05.Lesson.UndoPrograme
{
    class Program
    {
        public partial class MainWindow : Window
        {
            //Creating the Stack<> ID undoOps
            Stack<UndoAction> undoOps = new Stack<UndoAction>();
            // Instantiate an Object.
            Random rng = new Random();


            public MainWindow()
            {
                InitializeComponent();
            }
                // Code block that set the color of the buttons
            private Brush GetRandomBrush()
            {
                byte[] rgb =new byte[3];
                rng.NextBytes(rgb);

                return new SolidColorBrush(Color.FromRgb(rgb[0], rgb[1], rgb[2]));
            }
                // Set a button
            private void buttonOne Click(object sender,RoutedEventArgs e)
            {
                undoOps.Push(new UndoAction(buttonOne));
                buttonOne.Background=GetRandomBrush();
                UpdateList();
            }
            
            private void buttonTwo Click(object sender,RoutedEventArgs e)
            {
                undoOps.Push(new UndoAction(buttonOne));
                buttonOne.Background = GetRandomBrush();
                UpdateList();
            }

            private void buttonThree Click(object sender,RoutedEventArgs e)
            {
                undoOps.Push(new UndoAction(buttonOne));
                buttonOne.Background = GetRandomBrush();
                UpdateList();
            }

            private void buttonFour Click(object sender,RoutedEventArgs e)
            {
                undoOps.Push(new UndoAction(buttonOne));
                buttonOne.Background = GetRandomBrush();
                UpdateList();


            }

            private void buttonFive Click(object sender,RoutedEventArgs e)
            {
                if (undoOps.Count > 0)
                	{
		                undoOps.Pop().Execute();
                        UpdateList();
                	}
            }

                // UpDate the List

            private void UpdateList()
            {
                listBoxOne.Items.Clear();

                foreach (UndoAction action  in undoOps)
	                {
		                listBoxOne.Items.Add(action.ToString());
	                }

            }
              
        }
    }
}
