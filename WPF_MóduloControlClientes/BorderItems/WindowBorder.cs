using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace WPF_MóduloControlClientes
{
    public class WindowBorder
    {
        /// <summary>
        /// The element which is acting as the border.
        /// </summary>
        public FrameworkElement Element { get; private set; }

        /// <summary>
        /// The position of the border.
        /// </summary>
        public BorderPosition Position { get; private set; }

        /// <summary>
        /// Creates a new window border using the specified element and position.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="element"></param>
        public WindowBorder(BorderPosition position, FrameworkElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

            Position = position;
            Element = element;
        }
    }
}
