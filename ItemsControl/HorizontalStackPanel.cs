using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ItemsControl
{
   public class HorizontalsStackPanel:Panel
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            var size = new Size();
            foreach (UIElement childElement in this.InternalChildren)
            {
                childElement.Measure(availableSize);
                  size.Width += childElement.DesiredSize.Width;
                size.Height += size.Height > childElement.DesiredSize.Height? size.Height:childElement.DesiredSize.Height;
            }
            return size;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            var location = new Point();
            foreach (UIElement childElement in this.InternalChildren)
            {
                childElement.Arrange(new Rect(location,childElement.DesiredSize));
                location.X += childElement.DesiredSize.Width;
               
            }
            return finalSize;
        }
    }
}
