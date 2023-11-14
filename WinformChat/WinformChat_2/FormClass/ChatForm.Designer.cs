namespace WinformChat
{
    partial class ChatForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Input = new System.Windows.Forms.Button();
            this.textBox_SendMsg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_RecvMsg = new System.Windows.Forms.Panel();
            this.textBox_RecvMsg = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel_RecvMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Input
            // 
            this.button_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Input.Location = new System.Drawing.Point(605, 14);
            this.button_Input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(85, 57);
            this.button_Input.TabIndex = 0;
            this.button_Input.Text = "입   력";
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // textBox_SendMsg
            // 
            this.textBox_SendMsg.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox_SendMsg.Location = new System.Drawing.Point(10, 14);
            this.textBox_SendMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SendMsg.Multiline = true;
            this.textBox_SendMsg.Name = "textBox_SendMsg";
            this.textBox_SendMsg.Size = new System.Drawing.Size(589, 58);
            this.textBox_SendMsg.TabIndex = 1;
            this.textBox_SendMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SendMsg_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_SendMsg);
            this.panel1.Controls.Add(this.button_Input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 80);
            this.panel1.TabIndex = 3;
            // 
            // panel_RecvMsg
            // 
            this.panel_RecvMsg.Controls.Add(this.textBox_RecvMsg);
            this.panel_RecvMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_RecvMsg.Location = new System.Drawing.Point(0, 0);
            this.panel_RecvMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_RecvMsg.Name = "panel_RecvMsg";
            this.panel_RecvMsg.Size = new System.Drawing.Size(700, 280);
            this.panel_RecvMsg.TabIndex = 4;
            // 
            // textBox_RecvMsg
            // 
            this.textBox_RecvMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_RecvMsg.Location = new System.Drawing.Point(0, 0);
            this.textBox_RecvMsg.Multiline = true;
            this.textBox_RecvMsg.Name = "textBox_RecvMsg";
            this.textBox_RecvMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_RecvMsg.Size = new System.Drawing.Size(700, 280);
            this.textBox_RecvMsg.TabIndex = 1;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.panel_RecvMsg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChatForm";
            this.Text = "2번 채팅";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_RecvMsg.ResumeLayout(false);
            this.panel_RecvMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Input;
        private System.Windows.Forms.TextBox textBox_SendMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_RecvMsg;
        private System.Windows.Forms.TextBox textBox_RecvMsg;
    }
}

