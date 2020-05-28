namespace Kanlendar {
    partial class Day {
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.pnl_cell = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_cell
            // 
            this.pnl_cell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cell.Location = new System.Drawing.Point(0, 0);
            this.pnl_cell.Name = "pnl_cell";
            this.pnl_cell.Size = new System.Drawing.Size(150, 150);
            this.pnl_cell.TabIndex = 0;
            // 
            // Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_cell);
            this.Name = "Day";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cell;
    }
}
