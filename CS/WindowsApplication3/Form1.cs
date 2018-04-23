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

namespace WindowsApplication3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
        }
        private void layoutView1_CustomCardLayout(object sender, LayoutViewCustomCardLayoutEventArgs e) {
            if(e.RowHandle == layoutView1.FocusedRowHandle) {
                e.CardDifferences.AddItemDifference("Group1", LayoutItemDifferenceType.GroupExpanded, true);
            }
        }
    }
}