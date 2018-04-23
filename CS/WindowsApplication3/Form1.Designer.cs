namespace WindowsApplication3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsApplication3.nwindDataSet();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.categoriesTableAdapter = new WindowsApplication3.nwindDataSetTableAdapters.CategoriesTableAdapter();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colCategoryID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colCategoryName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Group1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutViewField_colPicture = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colDescription = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(292, 273);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(292, 273);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(292, 248);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(292, 273);
            this.toolStripContainer2.TabIndex = 1;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.categoriesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl1.Size = new System.Drawing.Size(656, 369);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(285, 29);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colCategoryID,
            this.colCategoryName,
            this.colDescription,
            this.colPicture});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsMultiRecordMode.StretchCardToViewWidth = true;
            this.layoutView1.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.CustomCardLayout += new DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventHandler(this.layoutView1_CustomCardLayout);
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.LayoutViewField = this.layoutViewField_colCategoryID;
            this.colCategoryID.Name = "colCategoryID";
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.LayoutViewField = this.layoutViewField_colCategoryName;
            this.colCategoryName.Name = "colCategoryName";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.LayoutViewField = this.layoutViewField_colDescription;
            this.colDescription.Name = "colDescription";
            // 
            // colPicture
            // 
            this.colPicture.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPicture.FieldName = "Picture";
            this.colPicture.LayoutViewField = this.layoutViewField_colPicture;
            this.colPicture.Name = "colPicture";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colCategoryID,
            this.layoutViewField_colCategoryName,
            this.Group1});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutViewField_colCategoryID
            // 
            this.layoutViewField_colCategoryID.EditorPreferredWidth = 60;
            this.layoutViewField_colCategoryID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colCategoryID.Name = "layoutViewField_colCategoryID";
            this.layoutViewField_colCategoryID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colCategoryID.Size = new System.Drawing.Size(70, 26);
            this.layoutViewField_colCategoryID.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colCategoryID.TextToControlDistance = 0;
            this.layoutViewField_colCategoryID.TextVisible = false;
            // 
            // layoutViewField_colCategoryName
            // 
            this.layoutViewField_colCategoryName.EditorPreferredWidth = 205;
            this.layoutViewField_colCategoryName.Location = new System.Drawing.Point(70, 0);
            this.layoutViewField_colCategoryName.Name = "layoutViewField_colCategoryName";
            this.layoutViewField_colCategoryName.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colCategoryName.Size = new System.Drawing.Size(215, 26);
            this.layoutViewField_colCategoryName.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colCategoryName.TextToControlDistance = 0;
            this.layoutViewField_colCategoryName.TextVisible = false;
            // 
            // Group1
            // 
            this.Group1.CustomizationFormText = "Group1";
            this.Group1.Expanded = false;
            this.Group1.GroupBordersVisible = false;
            this.Group1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colPicture,
            this.layoutViewField_colDescription});
            this.Group1.Location = new System.Drawing.Point(0, 26);
            this.Group1.Name = "Group1";
            this.Group1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Group1.Size = new System.Drawing.Size(285, 3);
            this.Group1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Group1.Text = "Group1";
            // 
            // layoutViewField_colPicture
            // 
            this.layoutViewField_colPicture.EditorPreferredWidth = 220;
            this.layoutViewField_colPicture.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colPicture.MaxSize = new System.Drawing.Size(218, 197);
            this.layoutViewField_colPicture.MinSize = new System.Drawing.Size(218, 197);
            this.layoutViewField_colPicture.Name = "layoutViewField_colPicture";
            this.layoutViewField_colPicture.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colPicture.Size = new System.Drawing.Size(230, 197);
            this.layoutViewField_colPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_colPicture.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPicture.TextToControlDistance = 0;
            this.layoutViewField_colPicture.TextVisible = false;
            // 
            // layoutViewField_colDescription
            // 
            this.layoutViewField_colDescription.EditorPreferredWidth = 158;
            this.layoutViewField_colDescription.Location = new System.Drawing.Point(0, 197);
            this.layoutViewField_colDescription.Name = "layoutViewField_colDescription";
            this.layoutViewField_colDescription.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colDescription.Size = new System.Drawing.Size(230, 58);
            this.layoutViewField_colDescription.TextSize = new System.Drawing.Size(57, 13);
            this.layoutViewField_colDescription.TextToControlDistance = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(656, 369);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private WindowsApplication3.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDescription;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPicture;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCategoryID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCategoryName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDescription;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPicture;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.LayoutControlGroup Group1;
    }
}

