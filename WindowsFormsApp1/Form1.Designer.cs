namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btn_ServerSTOP;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ServerStart = new System.Windows.Forms.Button();
            this.ServerLog = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_GameSTART = new System.Windows.Forms.Button();
            this.btn_GameSTOP = new System.Windows.Forms.Button();
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btn_ServerSTOP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ServerStart
            // 
            this.btn_ServerStart.Location = new System.Drawing.Point(8, 251);
            this.btn_ServerStart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ServerStart.Name = "btn_ServerStart";
            this.btn_ServerStart.Size = new System.Drawing.Size(81, 41);
            this.btn_ServerStart.TabIndex = 0;
            this.btn_ServerStart.Text = "Server START";
            this.btn_ServerStart.UseVisualStyleBackColor = true;
            this.btn_ServerStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServerLog
            // 
            this.ServerLog.FormattingEnabled = true;
            this.ServerLog.ItemHeight = 12;
            this.ServerLog.Location = new System.Drawing.Point(11, 11);
            this.ServerLog.Margin = new System.Windows.Forms.Padding(2);
            this.ServerLog.Name = "ServerLog";
            this.ServerLog.Size = new System.Drawing.Size(260, 232);
            this.ServerLog.TabIndex = 1;
            this.ServerLog.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btn_ServerSTOP
            // 
            btn_ServerSTOP.Location = new System.Drawing.Point(115, 251);
            btn_ServerSTOP.Margin = new System.Windows.Forms.Padding(2);
            btn_ServerSTOP.Name = "btn_ServerSTOP";
            btn_ServerSTOP.Size = new System.Drawing.Size(81, 41);
            btn_ServerSTOP.TabIndex = 4;
            btn_ServerSTOP.Text = "Server \r\nSTOP";
            btn_ServerSTOP.UseVisualStyleBackColor = true;
            btn_ServerSTOP.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_GameSTART
            // 
            this.btn_GameSTART.Location = new System.Drawing.Point(221, 251);
            this.btn_GameSTART.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GameSTART.Name = "btn_GameSTART";
            this.btn_GameSTART.Size = new System.Drawing.Size(81, 41);
            this.btn_GameSTART.TabIndex = 5;
            this.btn_GameSTART.Text = "Game \r\nSTART";
            this.btn_GameSTART.UseVisualStyleBackColor = true;
            // 
            // btn_GameSTOP
            // 
            this.btn_GameSTOP.Location = new System.Drawing.Point(328, 251);
            this.btn_GameSTOP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GameSTOP.Name = "btn_GameSTOP";
            this.btn_GameSTOP.Size = new System.Drawing.Size(81, 41);
            this.btn_GameSTOP.TabIndex = 6;
            this.btn_GameSTOP.Text = "Game \r\nSTOP";
            this.btn_GameSTOP.UseVisualStyleBackColor = true;
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.Location = new System.Drawing.Point(435, 251);
            this.btn_EXIT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(81, 41);
            this.btn_EXIT.TabIndex = 7;
            this.btn_EXIT.Text = "EXIT";
            this.btn_EXIT.UseVisualStyleBackColor = true;
            this.btn_EXIT.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(276, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 231);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.btn_GameSTOP);
            this.Controls.Add(this.btn_GameSTART);
            this.Controls.Add(btn_ServerSTOP);
            this.Controls.Add(this.ServerLog);
            this.Controls.Add(this.btn_ServerStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ServerStart;
        private System.Windows.Forms.ListBox ServerLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_GameSTART;
        private System.Windows.Forms.Button btn_GameSTOP;
        private System.Windows.Forms.Button btn_EXIT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

