Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Layout.Events
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraEditors

Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			recordBindingSource.DataSource = DataHelper.GetData(10)
		End Sub
		Private Sub layoutView1_CustomCardLayout(ByVal sender As Object, ByVal e As LayoutViewCustomCardLayoutEventArgs) Handles layoutView1.CustomCardLayout
			Dim view As LayoutView = TryCast(sender, LayoutView)
			If e.RowHandle = view.FocusedRowHandle Then
				e.CardDifferences.AddItemDifference("Group1", LayoutItemDifferenceType.GroupExpanded, True)
			End If
		End Sub
	End Class
End Namespace