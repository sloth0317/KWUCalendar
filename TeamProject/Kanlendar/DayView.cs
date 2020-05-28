using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanlendar {
    public partial class DayView : UserControl {

        GetDay gd = new GetDay();
        public DayView() {
            InitializeComponent();
            gd.Dock = DockStyle.Fill;
            //gd.SetDay();
            pnl_draw.Controls.Add(gd);
        }

        class GetDay : TableLayoutPanel {
            public int rows = 5;
            public int columns = 7;
            Label[] days = new Label[50];
            public DateTime dtValue = DateTime.Now;
            public GetDay() {
                DoubleBuffered = true;
                SetData();
                this.BackColor = Color.White;
                this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            }

            public void SetData() {                
                ColumnCount = columns;
                RowCount = rows;
                Day day = null;                
                CheckBox cb = null;                
                for (int i = 0; i < ColumnCount; i++) ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                for (int i = 0; i < RowCount; i++) RowStyles.Add(new RowStyle(SizeType.Percent, 100F));


                for(int row = 0; row < RowCount; row++) {
                    for(int col = 0; col < ColumnCount; col++) {
                        day = new Day();
                        cb = new CheckBox();
                        if(row == 0) {                              
                            //day = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.AbbreviatedDayNames[col][0].ToString();
                            //day.Dock = DockStyle.Fill;
                            //day.TextAlign = ContentAlignment.MiddleCenter;                            
                            //day.BackColor = Color.LightGray;                            
                            //day.Margin = new Padding(0);
                            //day.ForeColor = Color.DarkRed;
                        }
                        else if(row % 2 == 1){
                            //day.TextAlign = ContentAlignment.TopLeft;                            
                            //days[(row - 1) * 7 + col] = day;                            
                        }                        
                        day.Font = new Font("Arial", 15, FontStyle.Bold);                                                
                        Controls.Add(day,col,row);
                        
                    }
                }              
            }

            public void SetDay() {                
                Clear();

                DateTime Start = new DateTime(dtValue.Year, dtValue.Month, 1);
                int End = DateTime.DaysInMonth(dtValue.Year, dtValue.Month);
                int Week = (int)Start.DayOfWeek;

                for(int i = 1; i <= End; i++) {
                    int index = i + Week - 1;
                    days[index].Text = string.Format("{0:0}", i);
                }


            } 


            public void Clear() {
                for(int i = 0; i < 50; i++) {
                    days[i].Text = string.Empty;
                }
            }

        }
    }
}
