namespace Lottery
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
            lblLotSettings = new Label();
            lblMaxValue = new Label();
            lblWantedNumb = new Label();
            txtMaxValue = new TextBox();
            txtWantedNums = new TextBox();
            btnCreateObj = new Button();
            btnDrawNum = new Button();
            btnDrawAllNum = new Button();
            lbObjects = new ListBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblLotSettings
            // 
            lblLotSettings.AutoSize = true;
            lblLotSettings.Location = new Point(36, 9);
            lblLotSettings.Name = "lblLotSettings";
            lblLotSettings.Size = new Size(110, 20);
            lblLotSettings.TabIndex = 0;
            lblLotSettings.Text = "Lottery settings";
            // 
            // lblMaxValue
            // 
            lblMaxValue.AutoSize = true;
            lblMaxValue.Location = new Point(51, 64);
            lblMaxValue.Name = "lblMaxValue";
            lblMaxValue.Size = new Size(77, 20);
            lblMaxValue.TabIndex = 1;
            lblMaxValue.Text = "Max Value";
            // 
            // lblWantedNumb
            // 
            lblWantedNumb.AutoSize = true;
            lblWantedNumb.Location = new Point(51, 114);
            lblWantedNumb.Name = "lblWantedNumb";
            lblWantedNumb.Size = new Size(157, 20);
            lblWantedNumb.TabIndex = 2;
            lblWantedNumb.Text = "Nr of wanted numbers";
            lblWantedNumb.Click += label3_Click;
            // 
            // txtMaxValue
            // 
            txtMaxValue.Location = new Point(224, 64);
            txtMaxValue.Name = "txtMaxValue";
            txtMaxValue.Size = new Size(166, 27);
            txtMaxValue.TabIndex = 3;
            // 
            // txtWantedNums
            // 
            txtWantedNums.Location = new Point(224, 114);
            txtWantedNums.Name = "txtWantedNums";
            txtWantedNums.Size = new Size(166, 27);
            txtWantedNums.TabIndex = 4;
            // 
            // btnCreateObj
            // 
            btnCreateObj.Location = new Point(51, 197);
            btnCreateObj.Name = "btnCreateObj";
            btnCreateObj.Size = new Size(221, 29);
            btnCreateObj.TabIndex = 5;
            btnCreateObj.Text = "Create Lottery Object";
            btnCreateObj.UseVisualStyleBackColor = true;
            btnCreateObj.Click += btnCreateObj_Click;
            // 
            // btnDrawNum
            // 
            btnDrawNum.Location = new Point(51, 255);
            btnDrawNum.Name = "btnDrawNum";
            btnDrawNum.Size = new Size(221, 29);
            btnDrawNum.TabIndex = 6;
            btnDrawNum.Text = "Draw Next Number";
            btnDrawNum.UseVisualStyleBackColor = true;
            btnDrawNum.Click += btnDrawNum_Click;
            // 
            // btnDrawAllNum
            // 
            btnDrawAllNum.Location = new Point(51, 314);
            btnDrawAllNum.Name = "btnDrawAllNum";
            btnDrawAllNum.Size = new Size(221, 29);
            btnDrawAllNum.TabIndex = 7;
            btnDrawAllNum.Text = "Draw All Numbers At Once";
            btnDrawAllNum.UseVisualStyleBackColor = true;
            btnDrawAllNum.Click += btnDrawAllNum_Click;
            // 
            // lbObjects
            // 
            lbObjects.FormattingEnabled = true;
            lbObjects.ItemHeight = 20;
            lbObjects.Location = new Point(500, 30);
            lbObjects.Name = "lbObjects";
            lbObjects.Size = new Size(218, 324);
            lbObjects.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightCoral;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(413, 144);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(767, 402);
            Controls.Add(lbObjects);
            Controls.Add(btnDrawAllNum);
            Controls.Add(btnDrawNum);
            Controls.Add(btnCreateObj);
            Controls.Add(txtWantedNums);
            Controls.Add(txtMaxValue);
            Controls.Add(lblWantedNumb);
            Controls.Add(lblMaxValue);
            Controls.Add(lblLotSettings);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lottery";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLotSettings;
        private Label lblMaxValue;
        private Label lblWantedNumb;
        private TextBox txtMaxValue;
        private TextBox txtWantedNums;
        private Button btnCreateObj;
        private Button btnDrawNum;
        private Button btnDrawAllNum;
        private ListBox lbObjects;
        private DataGridView dataGridView1;
    }
}