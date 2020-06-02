using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kanlendar {
    public partial class DayView : UserControl {

        GetDay gd = new GetDay();
        public DayView() {
            InitializeComponent();
            gd.Dock = DockStyle.Fill;
            pnl_draw.Controls.Add(gd);
        }

        class GetDay : TableLayoutPanel {
            public int rows = 5;
            public int columns = 7;
            Day[] days = new Day[50];

            public DateTime dtValue = DateTime.Now;
            public GetDay() {
                DoubleBuffered = true;
                SetData();
                SetDay();
                //ClearDay();
                ShowData();
                this.BackColor = Color.White;
                this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            }

            public void SetData() {
                ColumnCount = columns;
                RowCount = rows;
                Day day = null;
                for (int i = 0; i < 50; i++) days[i] = new Day();
                for (int i = 0; i < ColumnCount; i++) ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                for (int i = 0; i < RowCount; i++) RowStyles.Add(new RowStyle(SizeType.Percent, 100F));


                for (int row = 0; row < RowCount; row++) {
                    for (int col = 0; col < ColumnCount; col++) {
                        day = new Day();
                        days[row * 7 + col] = day;                        
                    }
                }               
            }

            public void ShowData() {
                for (int row = 0; row < rows; row++) {
                    for (int col = 0; col < columns; col++) {
                        Controls.Add(days[row * 7 + col], col, row);
                    }
                }
            }

            public void SetDay() {
                ClearDay();
                DateTime Start = new DateTime(dtValue.Year, dtValue.Month, 1);
                int Week = (int)Start.DayOfWeek;
                int End = DateTime.DaysInMonth(dtValue.Year, dtValue.Month);
                int index = 0;
                
                for (int i = 1; i <= End; i++) {
                    index = i + Week - 1;
                    days[index].DATA.GetLabel.Text = i.ToString();
                    days[index].Add();
                }
            }


            public void ClearDay() {
                for (int i = 0; i < 50; i++) {
                    //days[i].Cursor = Cursors.Default;
                    days[i].DATA.GetLabel.Text = string.Empty;
                }
            }

        }
    }
}
