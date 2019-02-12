namespace DXSample {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
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
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colParentID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colText = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colDt = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colState = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colDetail = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colText = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Group1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutViewField_colParentID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colInfo = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colDt = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colValue = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colState = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colImage = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colDetail = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colParentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDetail)).BeginInit();
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
            this.gridControl1.DataSource = this.recordBindingSource;
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
            // recordBindingSource
            // 
            this.recordBindingSource.DataSource = typeof(DXSample.Record);
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(298, 62);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colID,
            this.colParentID,
            this.colText,
            this.colInfo,
            this.colValue,
            this.colDt,
            this.colState,
            this.colImage,
            this.colDetail});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colDetail});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsMultiRecordMode.StretchCardToViewWidth = true;
            this.layoutView1.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.CustomCardLayout += new DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventHandler(this.layoutView1_CustomCardLayout);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.LayoutViewField = this.layoutViewField_colID;
            this.colID.Name = "colID";
            // 
            // colParentID
            // 
            this.colParentID.FieldName = "ParentID";
            this.colParentID.LayoutViewField = this.layoutViewField_colParentID;
            this.colParentID.Name = "colParentID";
            // 
            // colText
            // 
            this.colText.FieldName = "Text";
            this.colText.LayoutViewField = this.layoutViewField_colText;
            this.colText.Name = "colText";
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.LayoutViewField = this.layoutViewField_colInfo;
            this.colInfo.Name = "colInfo";
            // 
            // colValue
            // 
            this.colValue.FieldName = "Value";
            this.colValue.LayoutViewField = this.layoutViewField_colValue;
            this.colValue.Name = "colValue";
            // 
            // colDt
            // 
            this.colDt.FieldName = "Dt";
            this.colDt.LayoutViewField = this.layoutViewField_colDt;
            this.colDt.Name = "colDt";
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.LayoutViewField = this.layoutViewField_colState;
            this.colState.Name = "colState";
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.LayoutViewField = this.layoutViewField_colImage;
            this.colImage.Name = "colImage";
            // 
            // colDetail
            // 
            this.colDetail.FieldName = "Detail";
            this.colDetail.LayoutViewField = this.layoutViewField_colDetail;
            this.colDetail.Name = "colDetail";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colID,
            this.layoutViewField_colText,
            this.Group1});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutViewField_colID
            // 
            this.layoutViewField_colID.EditorPreferredWidth = 132;
            this.layoutViewField_colID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colID.Name = "layoutViewField_colID";
            this.layoutViewField_colID.Size = new System.Drawing.Size(167, 24);
            this.layoutViewField_colID.TextSize = new System.Drawing.Size(26, 13);
            // 
            // layoutViewField_colText
            // 
            this.layoutViewField_colText.EditorPreferredWidth = 86;
            this.layoutViewField_colText.Location = new System.Drawing.Point(167, 0);
            this.layoutViewField_colText.Name = "layoutViewField_colText";
            this.layoutViewField_colText.Size = new System.Drawing.Size(121, 24);
            this.layoutViewField_colText.TextSize = new System.Drawing.Size(26, 13);
            // 
            // Group1
            // 
            this.Group1.CustomizationFormText = "Info";
            this.Group1.ExpandButtonVisible = true;
            this.Group1.Expanded = false;
            this.Group1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colParentID,
            this.layoutViewField_colInfo,
            this.layoutViewField_colDt,
            this.layoutViewField_colValue,
            this.layoutViewField_colState,
            this.layoutViewField_colImage});
            this.Group1.Location = new System.Drawing.Point(0, 24);
            this.Group1.Name = "Group1";
            this.Group1.Size = new System.Drawing.Size(288, 28);
            this.Group1.Text = "Info";
            // 
            // layoutViewField_colParentID
            // 
            this.layoutViewField_colParentID.EditorPreferredWidth = 77;
            this.layoutViewField_colParentID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colParentID.Name = "layoutViewField_colParentID";
            this.layoutViewField_colParentID.Size = new System.Drawing.Size(136, 24);
            this.layoutViewField_colParentID.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutViewField_colInfo
            // 
            this.layoutViewField_colInfo.EditorPreferredWidth = 77;
            this.layoutViewField_colInfo.Location = new System.Drawing.Point(136, 0);
            this.layoutViewField_colInfo.Name = "layoutViewField_colInfo";
            this.layoutViewField_colInfo.Size = new System.Drawing.Size(136, 24);
            this.layoutViewField_colInfo.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutViewField_colDt
            // 
            this.layoutViewField_colDt.EditorPreferredWidth = 77;
            this.layoutViewField_colDt.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colDt.Name = "layoutViewField_colDt";
            this.layoutViewField_colDt.Size = new System.Drawing.Size(136, 24);
            this.layoutViewField_colDt.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutViewField_colValue
            // 
            this.layoutViewField_colValue.EditorPreferredWidth = 77;
            this.layoutViewField_colValue.Location = new System.Drawing.Point(136, 24);
            this.layoutViewField_colValue.Name = "layoutViewField_colValue";
            this.layoutViewField_colValue.Size = new System.Drawing.Size(136, 24);
            this.layoutViewField_colValue.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutViewField_colState
            // 
            this.layoutViewField_colState.EditorPreferredWidth = 77;
            this.layoutViewField_colState.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colState.Name = "layoutViewField_colState";
            this.layoutViewField_colState.Size = new System.Drawing.Size(136, 24);
            this.layoutViewField_colState.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutViewField_colImage
            // 
            this.layoutViewField_colImage.EditorPreferredWidth = 77;
            this.layoutViewField_colImage.Location = new System.Drawing.Point(136, 48);
            this.layoutViewField_colImage.Name = "layoutViewField_colImage";
            this.layoutViewField_colImage.Size = new System.Drawing.Size(136, 24);
            this.layoutViewField_colImage.StartNewLine = true;
            this.layoutViewField_colImage.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutViewField_colDetail
            // 
            this.layoutViewField_colDetail.EditorPreferredWidth = 20;
            this.layoutViewField_colDetail.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colDetail.Name = "layoutViewField_colDetail";
            this.layoutViewField_colDetail.Size = new System.Drawing.Size(296, 139);
            this.layoutViewField_colDetail.TextSize = new System.Drawing.Size(50, 13);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(656, 369);
            this.Controls.Add(this.gridControl1);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colParentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colParentID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colText;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colInfo;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colValue;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDt;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colState;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colImage;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDetail;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colParentID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colText;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colInfo;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colValue;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDt;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colState;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colImage;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDetail;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.LayoutControlGroup Group1;
    }
}

