Imports Microsoft.VisualBasic
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

Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
		End Sub
		Private Sub layoutView1_CustomCardLayout(ByVal sender As Object, ByVal e As LayoutViewCustomCardLayoutEventArgs) Handles layoutView1.CustomCardLayout
			If e.RowHandle = layoutView1.FocusedRowHandle Then
				e.CardDifferences.AddItemDifference("Group1", LayoutItemDifferenceType.GroupExpanded, True)
			End If
		End Sub
	End Class
End Namespace