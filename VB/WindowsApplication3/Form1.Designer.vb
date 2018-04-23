Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

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
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsApplication3.nwindDataSet()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.colPicture = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.categoriesTableAdapter = New WindowsApplication3.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.layoutViewField_colCategoryID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colCategoryName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.Group1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutViewField_colPicture = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewField_colDescription = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.toolStripContainer1.SuspendLayout()
			Me.toolStripContainer2.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCategoryID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCategoryName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Group1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPicture, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colDescription, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.gridControl1.DataSource = Me.categoriesBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(656, 369)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' layoutView1
			' 
			Me.layoutView1.CardMinSize = New System.Drawing.Size(285, 29)
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colCategoryID, Me.colCategoryName, Me.colDescription, Me.colPicture})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsMultiRecordMode.StretchCardToViewWidth = True
			Me.layoutView1.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.layoutView1.OptionsView.ShowCardCaption = False
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
'			Me.layoutView1.CustomCardLayout += New DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventHandler(Me.layoutView1_CustomCardLayout);
			' 
			' colCategoryID
			' 
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.LayoutViewField = Me.layoutViewField_colCategoryID
			Me.colCategoryID.Name = "colCategoryID"
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.LayoutViewField = Me.layoutViewField_colCategoryName
			Me.colCategoryName.Name = "colCategoryName"
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.LayoutViewField = Me.layoutViewField_colDescription
			Me.colDescription.Name = "colDescription"
			' 
			' colPicture
			' 
			Me.colPicture.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPicture.FieldName = "Picture"
			Me.colPicture.LayoutViewField = Me.layoutViewField_colPicture
			Me.colPicture.Name = "colPicture"
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.GroupBordersVisible = False
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colCategoryID, Me.layoutViewField_colCategoryName, Me.Group1})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
			Me.layoutViewCard1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' layoutViewField_colCategoryID
			' 
			Me.layoutViewField_colCategoryID.EditorPreferredWidth = 60
			Me.layoutViewField_colCategoryID.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colCategoryID.Name = "layoutViewField_colCategoryID"
			Me.layoutViewField_colCategoryID.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutViewField_colCategoryID.Size = New System.Drawing.Size(70, 26)
			Me.layoutViewField_colCategoryID.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colCategoryID.TextToControlDistance = 0
			Me.layoutViewField_colCategoryID.TextVisible = False
			' 
			' layoutViewField_colCategoryName
			' 
			Me.layoutViewField_colCategoryName.EditorPreferredWidth = 205
			Me.layoutViewField_colCategoryName.Location = New System.Drawing.Point(70, 0)
			Me.layoutViewField_colCategoryName.Name = "layoutViewField_colCategoryName"
			Me.layoutViewField_colCategoryName.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutViewField_colCategoryName.Size = New System.Drawing.Size(215, 26)
			Me.layoutViewField_colCategoryName.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colCategoryName.TextToControlDistance = 0
			Me.layoutViewField_colCategoryName.TextVisible = False
			' 
			' Group1
			' 
			Me.Group1.CustomizationFormText = "Group1"
			Me.Group1.Expanded = False
			Me.Group1.GroupBordersVisible = False
			Me.Group1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colPicture, Me.layoutViewField_colDescription})
			Me.Group1.Location = New System.Drawing.Point(0, 26)
			Me.Group1.Name = "Group1"
			Me.Group1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.Group1.Size = New System.Drawing.Size(285, 3)
			Me.Group1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.Group1.Text = "Group1"
			' 
			' layoutViewField_colPicture
			' 
			Me.layoutViewField_colPicture.EditorPreferredWidth = 220
			Me.layoutViewField_colPicture.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colPicture.MaxSize = New System.Drawing.Size(218, 197)
			Me.layoutViewField_colPicture.MinSize = New System.Drawing.Size(218, 197)
			Me.layoutViewField_colPicture.Name = "layoutViewField_colPicture"
			Me.layoutViewField_colPicture.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutViewField_colPicture.Size = New System.Drawing.Size(230, 197)
			Me.layoutViewField_colPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutViewField_colPicture.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colPicture.TextToControlDistance = 0
			Me.layoutViewField_colPicture.TextVisible = False
			' 
			' layoutViewField_colDescription
			' 
			Me.layoutViewField_colDescription.EditorPreferredWidth = 158
			Me.layoutViewField_colDescription.Location = New System.Drawing.Point(0, 197)
			Me.layoutViewField_colDescription.Name = "layoutViewField_colDescription"
			Me.layoutViewField_colDescription.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutViewField_colDescription.Size = New System.Drawing.Size(230, 58)
			Me.layoutViewField_colDescription.TextSize = New System.Drawing.Size(57, 13)
			Me.layoutViewField_colDescription.TextToControlDistance = 5
			' 
			' Form1
			' 
			Me.ClientSize = New System.Drawing.Size(656, 369)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.toolStripContainer1.ResumeLayout(False)
			Me.toolStripContainer1.PerformLayout()
			Me.toolStripContainer2.ResumeLayout(False)
			Me.toolStripContainer2.PerformLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCategoryID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCategoryName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Group1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPicture, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colDescription, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private toolStripContainer1 As System.Windows.Forms.ToolStripContainer
		Private toolStripContainer2 As System.Windows.Forms.ToolStripContainer
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private nwindDataSet As nwindDataSet
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As WindowsApplication3.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private WithEvents layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private colCategoryID As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colDescription As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colPicture As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private layoutViewField_colCategoryID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colCategoryName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colDescription As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colPicture As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private Group1 As DevExpress.XtraLayout.LayoutControlGroup
	End Class
End Namespace

