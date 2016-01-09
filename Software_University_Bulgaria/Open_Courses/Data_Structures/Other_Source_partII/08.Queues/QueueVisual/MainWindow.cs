using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Interaction logic for MainWindow.xaml

namespace QueueVisual
{
    public partial class MainWindow : Window
    {
        Queue<int> queue = new Queue<int>();
        Random rng = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Create_Click(object sender,RoutedEventArgs e)
        {
            queue.Enqueue(rng.Next(0,200));
            UpdateGrid();
        }

        private void button_Process_Click(object sender,RoutedEventArgs e)
        {
            if (queue.Count > 0 )
            {
                listBox1.Items.Add(queue.Dequeue().ToString());
                UpdateGrid();
            }
        }

        private void UpdateGrid()
        {
            queue_label_1.Content = string.Empty;
            queue_label_2.Content = string.Empty;
            queue_label_3.Content = string.Empty;
            queue_label_4.Content = string.Empty;
            queue_label_5.Content = string.Empty;
            queue_label_6.Content = string.Empty;

            int index = 0;

            foreach (var message in queue)
            {
                switch (index)
                {
                    case 0:
                        queue_label_1.Content = message.ToString();
                        break;
                    case 1:
                        queue_label_2.Content = message.ToString();
                        break;
                    case 2:
                        queue_label_3.Content = message.ToString();
                        break;
                    case 3:
                        queue_label_4.Content = message.ToString();
                        break;
                    case 4:
                        queue_label_5.Content = message.ToString();
                        break;
                    case 5:
                        queue_label_6.Content = message.ToString();
                        break;
                    default:
                        break;
                }

                index++;

                if (index>5)
                {
                    break;
                }
            }

        }


    }
}
