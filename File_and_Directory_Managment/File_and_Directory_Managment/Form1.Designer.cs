namespace File_and_Directory_Managment
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(313, 51);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(108, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreateFile.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F);
            this.btnCreateFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateFile.Location = new System.Drawing.Point(313, 86);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(108, 62);
            this.btnCreateFile.TabIndex = 1;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = false;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F);
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(436, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 62);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreateDirectory.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F);
            this.btnCreateDirectory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateDirectory.Location = new System.Drawing.Point(313, 166);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(108, 62);
            this.btnCreateDirectory.TabIndex = 3;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = false;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(313, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 62);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMove.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F);
            this.btnMove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMove.Location = new System.Drawing.Point(436, 248);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(108, 62);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(12, 51);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(279, 259);
            this.lstFiles.TabIndex = 6;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(436, 51);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(108, 20);
            this.txtDestinationPath.TabIndex = 7;
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOpenDirectory.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F);
            this.btnOpenDirectory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenDirectory.Location = new System.Drawing.Point(436, 166);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(108, 62);
            this.btnOpenDirectory.TabIndex = 8;
            this.btnOpenDirectory.Text = "Open Directory";
            this.btnOpenDirectory.UseVisualStyleBackColor = false;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(310, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(433, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Move to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(559, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.txtFileName);
            this.Name = "Form1";
            this.Text = "File and Directory Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

