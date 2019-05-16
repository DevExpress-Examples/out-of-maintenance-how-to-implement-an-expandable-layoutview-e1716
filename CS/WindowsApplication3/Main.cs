using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Layout.Events;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraEditors;

namespace DXSample {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            recordBindingSource.DataSource = DataHelper.GetData(10);
        }
        private void layoutView1_CustomCardLayout(object sender, LayoutViewCustomCardLayoutEventArgs e) {
            LayoutView view = sender as LayoutView;
            if(e.RowHandle == view.FocusedRowHandle) {
                e.CardDifferences.AddItemDifference("Group1", LayoutItemDifferenceType.GroupExpanded, true);
            }
        }
    }
}