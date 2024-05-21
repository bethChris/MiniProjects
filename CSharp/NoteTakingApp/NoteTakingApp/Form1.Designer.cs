namespace NoteTakingApp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtTitle = new TextBox();
            txtBody = new TextBox();
            newButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            selectButton = new Button();
            noteGrid = new DataGridView();
            saveStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)noteGrid).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(142, 44);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(270, 36);
            txtTitle.TabIndex = 2;
            // 
            // txtBody
            // 
            txtBody.BackColor = Color.FromArgb(255, 224, 192);
            txtBody.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBody.ForeColor = SystemColors.InfoText;
            txtBody.Location = new Point(142, 86);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(270, 254);
            txtBody.TabIndex = 3;
            txtBody.TextChanged += txtBody_TextChanged;
            // 
            // newButton
            // 
            newButton.BackColor = SystemColors.Control;
            newButton.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            newButton.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newButton.Location = new Point(256, 344);
            newButton.Name = "newButton";
            newButton.Size = new Size(75, 23);
            newButton.TabIndex = 4;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(337, 344);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(255, 192, 192);
            deleteButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            deleteButton.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(579, 346);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // selectButton
            // 
            selectButton.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectButton.Location = new Point(498, 346);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(75, 23);
            selectButton.TabIndex = 7;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // noteGrid
            // 
            noteGrid.AllowUserToAddRows = false;
            noteGrid.AllowUserToDeleteRows = false;
            noteGrid.AllowUserToResizeColumns = false;
            noteGrid.AllowUserToResizeRows = false;
            noteGrid.BackgroundColor = Color.LavenderBlush;
            noteGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(150, 129, 205);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            noteGrid.DefaultCellStyle = dataGridViewCellStyle1;
            noteGrid.GridColor = Color.FromArgb(128, 128, 255);
            noteGrid.Location = new Point(439, 86);
            noteGrid.Name = "noteGrid";
            noteGrid.ReadOnly = true;
            noteGrid.RowHeadersVisible = false;
            noteGrid.Size = new Size(215, 254);
            noteGrid.TabIndex = 8;
            noteGrid.CellContentClick += noteGrid_CellContentClick;
            // 
            // saveStatus
            // 
            saveStatus.ForeColor = Color.Brown;
            saveStatus.Location = new Point(262, 370);
            saveStatus.MaximumSize = new Size(150, 15);
            saveStatus.MinimumSize = new Size(150, 15);
            saveStatus.Name = "saveStatus";
            saveStatus.RightToLeft = RightToLeft.No;
            saveStatus.Size = new Size(150, 15);
            saveStatus.TabIndex = 9;
            saveStatus.Text = "Not Saved";
            saveStatus.TextAlign = ContentAlignment.MiddleRight;
            saveStatus.Click += saveStatus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(saveStatus);
            Controls.Add(noteGrid);
            Controls.Add(selectButton);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(txtBody);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)noteGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTitle;
        private TextBox txtBody;
        private Button newButton;
        private Button saveButton;
        private Button deleteButton;
        private Button selectButton;
        private DataGridView noteGrid;
        private Label saveStatus;
    }
}
