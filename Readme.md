<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/WpfApplication10/Window1.xaml) (VB: [Window1.xaml.vb](./VB/WpfApplication10/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/WpfApplication10/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/WpfApplication10/Window1.xaml.vb))
<!-- default file list end -->
# How to specify a distribution function for positions of items along the path


<p>This example demonstrates how to specify distribution functions that affect:<br />
- the positions of items along the path<br />
- the ZIndexes of the items </p><p>If a path is specified by the ItemMovingPath property, the CarouselPanel's items are evenly arranged along the path. To arrange the items at uneven intervals, specify your own distribution function via the OffsetDistributionFunction property. In this example, a quadratic function is assigned to this property. Therefore, the items will be arranged according to a square law.</p><p>The CarouselPanel's elements are displayed above or below other elements along the Z axis. By default, the ZIndexes correlate with the order in which the elements are declared, so that the last declared element always overlaps the preceding elements. To change this behavior, you can control an element's ZIndex property by specifying a distribution function for ZIndexes. In this example, this is accomplished as follows:<br />
1) Creating a custom parameter (ZIndexParameter) in the CarouselPanel.ParameterSet  collection.<br />
2) Specifying a distribution function for this parameter. The function used represents a triangular function, defined in CarouselPanel resources and identified by the Linear3PConvexERIntMax id. According to this function, elements at the middle of the path have higher ZIndexes than the elements at the beginning and end of the path.<br />
3) Binding an element's ZIndex attached property to the custom parameter.</p>

<br/>


