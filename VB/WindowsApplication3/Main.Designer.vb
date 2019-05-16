Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
			Me.toolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colParentID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colText = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colInfo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colValue = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colDt = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colState = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colImage = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colDetail = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.layoutViewField_colID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colText = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.Group1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutViewField_colParentID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colInfo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colDt = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colValue = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colState = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colImage = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colDetail = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.toolStripContainer1.SuspendLayout()
			Me.toolStripContainer2.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Group1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colParentID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colDt, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colValue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colState, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colImage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colDetail, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' toolStripContainer1
			' 
			' 
			' toolStripContainer1.ContentPanel
			' 
			Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(292, 273)
			Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.toolStripContainer1.LeftToolStripPanelVisible = False
			Me.toolStripContainer1.Location = New System.Drawing.Point(0, 0)
			Me.toolStripContainer1.Name = "toolStripContainer1"
			Me.toolStripContainer1.RightToolStripPanelVisible = False
			Me.toolStripContainer1.Size = New System.Drawing.Size(292, 273)
			Me.toolStripContainer1.TabIndex = 0
			Me.toolStripContainer1.Text = "toolStripContainer1"
			Me.toolStripContainer1.TopToolStripPanelVisible = False
			' 
			' toolStripContainer2
			' 
			' 
			' toolStripContainer2.ContentPanel
			' 
			Me.toolStripContainer2.ContentPanel.Size = New System.Drawing.Size(292, 248)
			Me.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.toolStripContainer2.Location = New System.Drawing.Point(0, 0)
			Me.toolStripContainer2.Name = "toolStripContainer2"
			Me.toolStripContainer2.Size = New System.Drawing.Size(292, 273)
			Me.toolStripContainer2.TabIndex = 1
			Me.toolStripContainer2.Text = "toolStripContainer2"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.recordBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(656, 369)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
			' 
			' recordBindingSource
			' 
			Me.recordBindingSource.DataSource = GetType(DXSample.Record)
			' 
			' layoutView1
			' 
			Me.layoutView1.CardMinSize = New System.Drawing.Size(298, 62)
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colID, Me.colParentID, Me.colText, Me.colInfo, Me.colValue, Me.colDt, Me.colState, Me.colImage, Me.colDetail})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colDetail})
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsMultiRecordMode.StretchCardToViewWidth = True
			Me.layoutView1.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.layoutView1.OptionsView.ShowCardCaption = False
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.layoutView1.CustomCardLayout += new DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventHandler(this.layoutView1_CustomCardLayout);
			' 
			' colID
			' 
			Me.colID.FieldName = "ID"
			Me.colID.LayoutViewField = Me.layoutViewField_colID
			Me.colID.Name = "colID"
			' 
			' colParentID
			' 
			Me.colParentID.FieldName = "ParentID"
			Me.colParentID.LayoutViewField = Me.layoutViewField_colParentID
			Me.colParentID.Name = "colParentID"
			' 
			' colText
			' 
			Me.colText.FieldName = "Text"
			Me.colText.LayoutViewField = Me.layoutViewField_colText
			Me.colText.Name = "colText"
			' 
			' colInfo
			' 
			Me.colInfo.FieldName = "Info"
			Me.colInfo.LayoutViewField = Me.layoutViewField_colInfo
			Me.colInfo.Name = "colInfo"
			' 
			' colValue
			' 
			Me.colValue.FieldName = "Value"
			Me.colValue.LayoutViewField = Me.layoutViewField_colValue
			Me.colValue.Name = "colValue"
			' 
			' colDt
			' 
			Me.colDt.FieldName = "Dt"
			Me.colDt.LayoutViewField = Me.layoutViewField_colDt
			Me.colDt.Name = "colDt"
			' 
			' colState
			' 
			Me.colState.FieldName = "State"
			Me.colState.LayoutViewField = Me.layoutViewField_colState
			Me.colState.Name = "colState"
			' 
			' colImage
			' 
			Me.colImage.FieldName = "Image"
			Me.colImage.LayoutViewField = Me.layoutViewField_colImage
			Me.colImage.Name = "colImage"
			' 
			' colDetail
			' 
			Me.colDetail.FieldName = "Detail"
			Me.colDetail.LayoutViewField = Me.layoutViewField_colDetail
			Me.colDetail.Name = "colDetail"
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
			Me.layoutViewCard1.GroupBordersVisible = False
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colID, Me.layoutViewField_colText, Me.Group1})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
			Me.layoutViewCard1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' layoutViewField_colID
			' 
			Me.layoutViewField_colID.EditorPreferredWidth = 132
			Me.layoutViewField_colID.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colID.Name = "layoutViewField_colID"
			Me.layoutViewField_colID.Size = New System.Drawing.Size(167, 24)
			Me.layoutViewField_colID.TextSize = New System.Drawing.Size(26, 13)
			' 
			' layoutViewField_colText
			' 
			Me.layoutViewField_colText.EditorPreferredWidth = 86
			Me.layoutViewField_colText.Location = New System.Drawing.Point(167, 0)
			Me.layoutViewField_colText.Name = "layoutViewField_colText"
			Me.layoutViewField_colText.Size = New System.Drawing.Size(121, 24)
			Me.layoutViewField_colText.TextSize = New System.Drawing.Size(26, 13)
			' 
			' Group1
			' 
			Me.Group1.CustomizationFormText = "Info"
			Me.Group1.ExpandButtonVisible = True
			Me.Group1.Expanded = False
			Me.Group1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colParentID, Me.layoutViewField_colInfo, Me.layoutViewField_colDt, Me.layoutViewField_colValue, Me.layoutViewField_colState, Me.layoutViewField_colImage})
			Me.Group1.Location = New System.Drawing.Point(0, 24)
			Me.Group1.Name = "Group1"
			Me.Group1.Size = New System.Drawing.Size(288, 28)
			Me.Group1.Text = "Info"
			' 
			' layoutViewField_colParentID
			' 
			Me.layoutViewField_colParentID.EditorPreferredWidth = 77
			Me.layoutViewField_colParentID.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colParentID.Name = "layoutViewField_colParentID"
			Me.layoutViewField_colParentID.Size = New System.Drawing.Size(136, 24)
			Me.layoutViewField_colParentID.TextSize = New System.Drawing.Size(50, 13)
			' 
			' layoutViewField_colInfo
			' 
			Me.layoutViewField_colInfo.EditorPreferredWidth = 77
			Me.layoutViewField_colInfo.Location = New System.Drawing.Point(136, 0)
			Me.layoutViewField_colInfo.Name = "layoutViewField_colInfo"
			Me.layoutViewField_colInfo.Size = New System.Drawing.Size(136, 24)
			Me.layoutViewField_colInfo.TextSize = New System.Drawing.Size(50, 13)
			' 
			' layoutViewField_colDt
			' 
			Me.layoutViewField_colDt.EditorPreferredWidth = 77
			Me.layoutViewField_colDt.Location = New System.Drawing.Point(0, 24)
			Me.layoutViewField_colDt.Name = "layoutViewField_colDt"
			Me.layoutViewField_colDt.Size = New System.Drawing.Size(136, 24)
			Me.layoutViewField_colDt.TextSize = New System.Drawing.Size(50, 13)
			' 
			' layoutViewField_colValue
			' 
			Me.layoutViewField_colValue.EditorPreferredWidth = 77
			Me.layoutViewField_colValue.Location = New System.Drawing.Point(136, 24)
			Me.layoutViewField_colValue.Name = "layoutViewField_colValue"
			Me.layoutViewField_colValue.Size = New System.Drawing.Size(136, 24)
			Me.layoutViewField_colValue.TextSize = New System.Drawing.Size(50, 13)
			' 
			' layoutViewField_colState
			' 
			Me.layoutViewField_colState.EditorPreferredWidth = 77
			Me.layoutViewField_colState.Location = New System.Drawing.Point(0, 48)
			Me.layoutViewField_colState.Name = "layoutViewField_colState"
			Me.layoutViewField_colState.Size = New System.Drawing.Size(136, 24)
			Me.layoutViewField_colState.TextSize = New System.Drawing.Size(50, 13)
			' 
			' layoutViewField_colImage
			' 
			Me.layoutViewField_colImage.EditorPreferredWidth = 77
			Me.layoutViewField_colImage.Location = New System.Drawing.Point(136, 48)
			Me.layoutViewField_colImage.Name = "layoutViewField_colImage"
			Me.layoutViewField_colImage.Size = New System.Drawing.Size(136, 24)
			Me.layoutViewField_colImage.TextSize = New System.Drawing.Size(50, 13)
			' 
			' layoutViewField_colDetail
			' 
			Me.layoutViewField_colDetail.EditorPreferredWidth = 20
			Me.layoutViewField_colDetail.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colDetail.Name = "layoutViewField_colDetail"
			Me.layoutViewField_colDetail.Size = New System.Drawing.Size(296, 139)
			Me.layoutViewField_colDetail.TextSize = New System.Drawing.Size(50, 13)
			' 
			' Main
			' 
			Me.ClientSize = New System.Drawing.Size(656, 369)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Main"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			Me.toolStripContainer1.ResumeLayout(False)
			Me.toolStripContainer1.PerformLayout()
			Me.toolStripContainer2.ResumeLayout(False)
			Me.toolStripContainer2.PerformLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Group1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colParentID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colDt, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colValue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colState, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colImage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colDetail, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private toolStripContainer1 As System.Windows.Forms.ToolStripContainer
		Private toolStripContainer2 As System.Windows.Forms.ToolStripContainer
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private recordBindingSource As System.Windows.Forms.BindingSource
		Private colID As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colParentID As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colText As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colInfo As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colValue As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colDt As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colState As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colImage As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colDetail As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colParentID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colText As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colInfo As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colValue As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colDt As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colState As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colImage As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colDetail As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private Group1 As DevExpress.XtraLayout.LayoutControlGroup
	End Class
End Namespace

