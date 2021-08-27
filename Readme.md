<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1716)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication3/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication3/Form1.vb))
<!-- default file list end -->
# How to implement an expandable LayoutView


<p>Starting from version 9.1, the LayoutView provides the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsLayoutLayoutView_CustomCardLayouttopic">CustomCardLayout</a> event, enabling you to modify the layout on the fly. This example demonstrates how to create a view that shows only limited details in one row, and expand other details only for a row being currently edited.</p>


<h3>Description</h3>

<p>Within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsLayoutLayoutView_CustomCardLayouttopic">LayoutView.CustomCardLayout</a> event handler, you can provide a different layout based on the row state.</p>

<br/>


