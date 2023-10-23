﻿namespace WinformChat
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
            this.textBox_RecvMsg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Input
            // 
            this.button_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Input.Location = new System.Drawing.Point(691, 17);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(97, 71);
            this.button_Input.TabIndex = 0;
            this.button_Input.Text = "입   력";
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // textBox_SendMsg
            // 
            this.textBox_SendMsg.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox_SendMsg.Location = new System.Drawing.Point(12, 17);
            this.textBox_SendMsg.Multiline = true;
            this.textBox_SendMsg.Name = "textBox_SendMsg";
            this.textBox_SendMsg.Size = new System.Drawing.Size(673, 71);
            this.textBox_SendMsg.TabIndex = 1;
            // 
            // textBox_RecvMsg
            // 
            this.textBox_RecvMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_RecvMsg.Location = new System.Drawing.Point(0, 0);
            this.textBox_RecvMsg.Multiline = true;
            this.textBox_RecvMsg.Name = "textBox_RecvMsg";
            this.textBox_RecvMsg.ReadOnly = true;
            this.textBox_RecvMsg.Size = new System.Drawing.Size(800, 350);
            this.textBox_RecvMsg.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_SendMsg);
            this.panel1.Controls.Add(this.button_Input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 3;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_RecvMsg);
            this.Controls.Add(this.panel1);
            this.Name = "ChatForm";
            this.Text = "1번 채팅";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Input;
        private System.Windows.Forms.TextBox textBox_SendMsg;
        private System.Windows.Forms.TextBox textBox_RecvMsg;
        private System.Windows.Forms.Panel panel1;
    }
}
