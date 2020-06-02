using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.PerformanceData;

namespace Kanlendar {
    public class Data : TableLayoutPanel
    {
        public Label lb_day = new Label();
        public CheckedListBox clb_data = new CheckedListBox();
        public Label lb = new Label();
        public Data()
        {
            this.Dock = DockStyle.Fill;
            this.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            SetCell();
        }

        public void SetLabel()
        {
            lb_day.Font = new Font("Arial", 12, FontStyle.Bold);
            lb_day.Dock = DockStyle.Fill;
            lb_day.Margin = new Padding(0);
            lb_day.Padding = new Padding(0);
        }
        public void SetCLB()
        {
            clb_data.Margin = new Padding(0);
            clb_data.Dock = DockStyle.Bottom;
            clb_data.BorderStyle = BorderStyle.FixedSingle;
        }
        public void SetCell()
        {
            ColumnCount = 1;
            RowCount = 2;
            Margin = new Padding(0);
            Padding = new Padding(0);
            RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            SetLabel();
            SetCLB();

            Controls.Add(lb_day, 0, 0);
            Controls.Add(clb_data, 0, 1);
        }
        public void DataShow()
        {

        }

        public Label GetLabel
        {
            set { lb_day = value; }
            get { return lb_day; }
        }
        public CheckedListBox GetCheckedListBox
        {
            set { clb_data = value; }
            get { return clb_data; }
        }
    }

    public partial class Day : UserControl {
        private Data data;

        public Day() {
            InitializeComponent();
            data = new Data();
            pnl_cell.Padding = new Padding(0);
            pnl_cell.Margin = new Padding(0);            
        }
        public void Add() {
            pnl_cell.Controls.Add(data);
        }

        public Data DATA {
            get { return data;  }
        }                        
    }
}
