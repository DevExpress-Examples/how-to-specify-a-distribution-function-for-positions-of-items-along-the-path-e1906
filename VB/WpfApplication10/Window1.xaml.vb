Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Carousel
Imports System.Windows.Markup

Namespace WpfApplication10
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	#Region "#2"
	' The distribution function for positions of items along the path
	Public Class MySqrFunc
		Inherits FunctionBase
		Protected Overrides Function GetValueOverride(ByVal x As Double) As Double
			Return 1-x*x
		End Function
	End Class
	#End Region ' #2

	Public Class DoubleToIntConverter
		Inherits MarkupExtension
		Implements IValueConverter
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
		#Region "IValueConverter Members"
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			If targetType IsNot GetType(Integer) Then
				Throw New InvalidOperationException()
			End If
			Return CInt(Fix(CDbl(value)))
		End Function
		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
		#End Region
	End Class
End Namespace
