namespace WinformChat.FormClass
{
    partial class MessageBoxControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_SendTime = new System.Windows.Forms.Label();
            this.label_NickName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label_SendTime
            // 
            this.label_SendTime.AutoSize = true;
            this.label_SendTime.Location = new System.Drawing.Point(5, 40);
            this.label_SendTime.Name = "label_SendTime";
            this.label_SendTime.Size = new System.Drawing.Size(38, 12);
            this.label_SendTime.TabIndex = 1;
            this.label_SendTime.Text = "label1";
            // 
            // label_NickName
            // 
            this.label_NickName.AutoSize = true;
            this.label_NickName.Location = new System.Drawing.Point(111, 13);
            this.label_NickName.Name = "label_NickName";
            this.label_NickName.Size = new System.Drawing.Size(38, 12);
            this.label_NickName.TabIndex = 2;
            this.label_NickName.Text = "label2";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(194, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MessageBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_NickName);
            this.Controls.Add(this.label_SendTime);
            this.Name = "MessageBoxControl";
            this.Size = new System.Drawing.Size(335, 192);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label_SendTime;
        public System.Windows.Forms.Label label_NickName;
        private System.Windows.Forms.ListView listView1;
    }
}
