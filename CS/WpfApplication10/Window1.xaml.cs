using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Carousel;
using System.Windows.Markup;

namespace WpfApplication10 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }

    #region #2
    // The distribution function for positions of items along the path
    public class MySqrFunc : FunctionBase {
        protected override double GetValueOverride(double x) {
            return 1-x*x;
        }
    }
    #endregion #2

    public class DoubleToIntConverter : MarkupExtension, IValueConverter {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (targetType != typeof(int))
                throw new InvalidOperationException();
            return (int)((double)value);
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
        #endregion
    }
}
