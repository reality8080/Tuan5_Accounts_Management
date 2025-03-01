namespace Accounts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            layoutPanel = new Panel();
            updateBtn = new Button();
            deleteBtn = new Button();
            insertBtn = new Button();
            loadBtn = new Button();
            infoDGV = new DataGridView();
            lbAccManage = new Label();
            infoGBx = new GroupBox();
            BalanceTxt = new TextBox();
            addressTxt = new TextBox();
            nameTxt = new TextBox();
            serieTxt = new TextBox();
            balaneLb = new Label();
            addressLb = new Label();
            nameLb = new Label();
            idNumberLb = new Label();
            layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoDGV).BeginInit();
            infoGBx.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPanel
            // 
            layoutPanel.Controls.Add(updateBtn);
            layoutPanel.Controls.Add(deleteBtn);
            layoutPanel.Controls.Add(insertBtn);
            layoutPanel.Controls.Add(loadBtn);
            layoutPanel.Controls.Add(infoDGV);
            layoutPanel.Controls.Add(lbAccManage);
            layoutPanel.Controls.Add(infoGBx);
            layoutPanel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            layoutPanel.Location = new Point(12, 12);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.Size = new Size(767, 766);
            layoutPanel.TabIndex = 0;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(613, 297);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 10;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(447, 297);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(242, 297);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(94, 29);
            insertBtn.TabIndex = 8;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(76, 297);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(94, 29);
            loadBtn.TabIndex = 7;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // infoDGV
            // 
            infoDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            infoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoDGV.Location = new Point(0, 369);
            infoDGV.Name = "infoDGV";
            infoDGV.RowHeadersWidth = 51;
            infoDGV.Size = new Size(764, 397);
            infoDGV.TabIndex = 6;
            infoDGV.CellClick += infoDGV_CellClick;
            // 
            // lbAccManage
            // 
            lbAccManage.AutoSize = true;
            lbAccManage.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAccManage.ForeColor = Color.Navy;
            lbAccManage.Location = new Point(280, 10);
            lbAccManage.Name = "lbAccManage";
            lbAccManage.Size = new Size(231, 32);
            lbAccManage.TabIndex = 5;
            lbAccManage.Text = "Quản lý tài khoản";
            // 
            // infoGBx
            // 
            infoGBx.Controls.Add(BalanceTxt);
            infoGBx.Controls.Add(addressTxt);
            infoGBx.Controls.Add(nameTxt);
            infoGBx.Controls.Add(serieTxt);
            infoGBx.Controls.Add(balaneLb);
            infoGBx.Controls.Add(addressLb);
            infoGBx.Controls.Add(nameLb);
            infoGBx.Controls.Add(idNumberLb);
            infoGBx.Location = new Point(6, 54);
            infoGBx.Name = "infoGBx";
            infoGBx.Size = new Size(758, 213);
            infoGBx.TabIndex = 0;
            infoGBx.TabStop = false;
            infoGBx.Text = "Thông tin";
            // 
            // BalanceTxt
            // 
            BalanceTxt.Location = new Point(280, 160);
            BalanceTxt.Name = "BalanceTxt";
            BalanceTxt.Size = new Size(349, 30);
            BalanceTxt.TabIndex = 11;
            BalanceTxt.KeyPress += BalanceTxt_KeyPress;
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(280, 117);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(349, 30);
            addressTxt.TabIndex = 10;
            addressTxt.KeyPress += addressTxt_KeyPress;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(280, 73);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(349, 30);
            nameTxt.TabIndex = 9;
            nameTxt.KeyPress += nameTxt_KeyPress;
            // 
            // serieTxt
            // 
            serieTxt.Location = new Point(280, 34);
            serieTxt.Name = "serieTxt";
            serieTxt.Size = new Size(349, 30);
            serieTxt.TabIndex = 8;
            serieTxt.KeyPress += serieTxt_KeyPress;
            // 
            // balaneLb
            // 
            balaneLb.AutoSize = true;
            balaneLb.Location = new Point(23, 163);
            balaneLb.Name = "balaneLb";
            balaneLb.Size = new Size(57, 22);
            balaneLb.TabIndex = 7;
            balaneLb.Text = "Số dư";
            // 
            // addressLb
            // 
            addressLb.AutoSize = true;
            addressLb.Location = new Point(23, 120);
            addressLb.Name = "addressLb";
            addressLb.Size = new Size(68, 22);
            addressLb.TabIndex = 6;
            addressLb.Text = "Địa chỉ";
            // 
            // nameLb
            // 
            nameLb.AutoSize = true;
            nameLb.Location = new Point(23, 76);
            nameLb.Name = "nameLb";
            nameLb.Size = new Size(131, 22);
            nameLb.TabIndex = 5;
            nameLb.Text = "Tên khách hàng";
            // 
            // idNumberLb
            // 
            idNumberLb.AutoSize = true;
            idNumberLb.Location = new Point(23, 37);
            idNumberLb.Name = "idNumberLb";
            idNumberLb.Size = new Size(107, 22);
            idNumberLb.TabIndex = 4;
            idNumberLb.Text = "Số tài khoản";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 790);
            Controls.Add(layoutPanel);
            Name = "Form1";
            Text = "Form1";
            layoutPanel.ResumeLayout(false);
            layoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoDGV).EndInit();
            infoGBx.ResumeLayout(false);
            infoGBx.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel layoutPanel;
        private GroupBox infoGBx;
        private Label balaneLb;
        private Label addressLb;
        private Label nameLb;
        private Label idNumberLb;
        private Label lbAccManage;
        private TextBox BalanceTxt;
        private TextBox addressTxt;
        private TextBox nameTxt;
        private TextBox serieTxt;
        private DataGridView infoDGV;
        private Button insertBtn;
        private Button loadBtn;
        private Button updateBtn;
        private Button deleteBtn;
    }
}
