using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;

namespace RailroadTicketingApp
{
    public partial class TimetableControl : UserControl
    {
        public TimetableControl()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void TimetableControl_Load(object sender, EventArgs e)
        {
            this.tIMETABLE1TableAdapter.Fill(this.dataSet1.TIMETABLE1);
            this.tIMETABLE2TableAdapter.Fill(this.dataSet1.TIMETABLE2);

            /*this.dataGridView1.Columns.Add("", "    열차");
            this.dataGridView1.Columns.Add("부산    도착", "    도착");
            this.dataGridView1.Columns.Add("부산    출발", "    출발");
            this.dataGridView1.Columns.Add("대구    도착", "    도착");
            this.dataGridView1.Columns.Add("대구    출발", "    출발");
            this.dataGridView1.Columns.Add("대전    도착", "    도착");
            this.dataGridView1.Columns.Add("대전    출발", "    출발");
            this.dataGridView1.Columns.Add("천안    도착", "    도착");
            this.dataGridView1.Columns.Add("천안    출발", "    출발");
            this.dataGridView1.Columns.Add("서울    도착", "    도착");
            this.dataGridView1.Columns.Add("서울    출발", "    출발");

            this.dataGridView3.Columns.Add("", "    열차");
            this.dataGridView3.Columns.Add("서울    도착", "    도착");
            this.dataGridView3.Columns.Add("서울    출발", "    출발");
            this.dataGridView3.Columns.Add("천안    도착", "    도착");
            this.dataGridView3.Columns.Add("천안    출발", "    출발");
            this.dataGridView3.Columns.Add("대전    도착", "    도착");
            this.dataGridView3.Columns.Add("대전    출발", "    출발");
            this.dataGridView3.Columns.Add("대구    도착", "    도착");
            this.dataGridView3.Columns.Add("대구    출발", "    출발");
            this.dataGridView3.Columns.Add("부산    도착", "    도착");
            this.dataGridView3.Columns.Add("부산    출발", "    출발");

            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                this.dataGridView1.Columns[i].Width = 93;
                this.dataGridView2.Columns[i].Width = 93;
                this.dataGridView3.Columns[i].Width = 93;
                this.dataGridView4.Columns[i].Width = 93;
            }

            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersHeight = this.dataGridView1.ColumnHeadersHeight * 2;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            this.dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
            this.dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint);
            this.dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);

            this.dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.ColumnHeadersHeight = this.dataGridView3.ColumnHeadersHeight * 2;
            this.dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            this.dataGridView3.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
            this.dataGridView3.Paint += new PaintEventHandler(dataGridView3_Paint);
            this.dataGridView3.Scroll += new ScrollEventHandler(dataGridView3_Scroll);*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.tIMETABLE1TableAdapter.Fill(this.dataSet1.TIMETABLE1);
                this.tIMETABLE2TableAdapter.Fill(this.dataSet1.TIMETABLE2);
            }
            catch (Exception ex)
            {
            }            
        }

        /*private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView3_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView3.DisplayRectangle;
            rtHeader.Height = this.dataGridView3.ColumnHeadersHeight / 2;
            this.dataGridView3.Invalidate(rtHeader);
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView3_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView3.DisplayRectangle;
            rtHeader.Height = this.dataGridView3.ColumnHeadersHeight / 2;
            this.dataGridView3.Invalidate(rtHeader);
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            string[] monthes = { "부산", "대구", "대전", "천안", "서울" };
            for (int j = 1; j < 10; )
            {
                Rectangle r1 = this.dataGridView1.GetCellDisplayRectangle(j, -1, true);
                int w2 = this.dataGridView1.GetCellDisplayRectangle(j + 1, -1, true).Width;
                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + w2 - 2;
                r1.Height = r1.Height / 2 + 2;
                e.Graphics.FillRectangle(new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r1);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(monthes[j / 2],
                this.dataGridView1.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);
                j += 2;
            }
        }

        private void dataGridView3_Paint(object sender, PaintEventArgs e)
        {
            string[] monthes = { "서울", "천안", "대전", "대구", "부산" };
            for (int j = 1; j < 10; )
            {
                Rectangle r1 = this.dataGridView3.GetCellDisplayRectangle(j, -1, true);
                int w2 = this.dataGridView3.GetCellDisplayRectangle(j + 1, -1, true).Width;
                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + w2 - 2;
                r1.Height = r1.Height / 2 + 2;
                e.Graphics.FillRectangle(new SolidBrush(this.dataGridView3.ColumnHeadersDefaultCellStyle.BackColor), r1);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(monthes[j / 2],
                this.dataGridView1.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(this.dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);
                j += 2;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height / 2;
                r2.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;
            }
        }*/
    }
}
