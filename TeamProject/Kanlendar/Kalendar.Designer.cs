namespace Kanlendar {
    partial class Kalendar {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_big_small = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.dayView1 = new Kanlendar.DayView();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.Maroon;
            this.pnl_top.Controls.Add(this.btn_big_small);
            this.pnl_top.Controls.Add(this.btn_hide);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1069, 50);
            this.pnl_top.TabIndex = 0;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // btn_big_small
            // 
            this.btn_big_small.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_big_small.Location = new System.Drawing.Point(975, 7);
            this.btn_big_small.Name = "btn_big_small";
            this.btn_big_small.Size = new System.Drawing.Size(38, 40);
            this.btn_big_small.TabIndex = 2;
            this.btn_big_small.Text = "ㅁ";
            this.btn_big_small.UseVisualStyleBackColor = true;
            this.btn_big_small.Click += new System.EventHandler(this.btnBigger_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hide.Location = new System.Drawing.Point(931, 7);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(38, 40);
            this.btn_hide.TabIndex = 1;
            this.btn_hide.Text = "_";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btnHidding_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(1019, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(38, 40);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dayView1
            // 
            this.dayView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayView1.Location = new System.Drawing.Point(0, 50);
            this.dayView1.Name = "dayView1";
            this.dayView1.Size = new System.Drawing.Size(1069, 1030);
            this.dayView1.TabIndex = 1;
            // 
            // Kalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 1080);
            this.Controls.Add(this.dayView1);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kalendar";
            this.Text = "Kalendar";
            this.pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_big_small;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_close;
        private DayView dayView1;
    }
}

