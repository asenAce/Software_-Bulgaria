using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace _05.Lesson.UndoPrograme
{
    class UndoAction
    {
        public UndoAction(Button button)
        {
            button = button;
            brush = button.Background.CloneCurrentValue();

        }

        public void Execute()
        {
            button.Background = brush;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}",button.Content,brush.ToString());
        }

        Button button;
        Brush brush;


    }
}
