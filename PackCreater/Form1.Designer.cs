namespace PackCreater
{
    partial class PackCreater
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
            Pack_type_label = new Label();
            Pack_type = new ComboBox();
            Pack_name = new TextBox();
            Pack_name_label = new Label();
            Version_label = new Label();
            Version = new ComboBox();
            Description_label = new Label();
            Description_check = new CheckBox();
            Description = new TextBox();
            fBD = new FolderBrowserDialog();
            Folder_select = new Button();
            Selected_folder = new Label();
            Folder_name_label = new Label();
            Folder_name = new TextBox();
            Create = new Button();
            SuspendLayout();
            // 
            // Pack_type_label
            // 
            Pack_type_label.AutoSize = true;
            Pack_type_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pack_type_label.Location = new Point(12, 9);
            Pack_type_label.Name = "Pack_type_label";
            Pack_type_label.Size = new Size(70, 14);
            Pack_type_label.TabIndex = 0;
            Pack_type_label.Text = "Pack Type";
            // 
            // Pack_type
            // 
            Pack_type.BackColor = SystemColors.Window;
            Pack_type.DropDownStyle = ComboBoxStyle.DropDownList;
            Pack_type.FormattingEnabled = true;
            Pack_type.Items.AddRange(new object[] { "Data pack", "Resource pack" });
            Pack_type.Location = new Point(12, 26);
            Pack_type.Name = "Pack_type";
            Pack_type.Size = new Size(128, 22);
            Pack_type.TabIndex = 1;
            Pack_type.SelectedIndexChanged += Pack_type_SelectedIndexChanged;
            // 
            // Pack_name
            // 
            Pack_name.Location = new Point(146, 26);
            Pack_name.Name = "Pack_name";
            Pack_name.Size = new Size(128, 22);
            Pack_name.TabIndex = 2;
            // 
            // Pack_name_label
            // 
            Pack_name_label.AutoSize = true;
            Pack_name_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pack_name_label.Location = new Point(146, 9);
            Pack_name_label.Name = "Pack_name_label";
            Pack_name_label.Size = new Size(70, 14);
            Pack_name_label.TabIndex = 3;
            Pack_name_label.Text = "Pack name";
            // 
            // Version_label
            // 
            Version_label.AutoSize = true;
            Version_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Version_label.Location = new Point(12, 100);
            Version_label.Name = "Version_label";
            Version_label.Size = new Size(56, 14);
            Version_label.TabIndex = 7;
            Version_label.Text = "Version";
            // 
            // Version
            // 
            Version.DropDownStyle = ComboBoxStyle.DropDownList;
            Version.FormattingEnabled = true;
            Version.ItemHeight = 14;
            Version.Location = new Point(12, 117);
            Version.Name = "Version";
            Version.Size = new Size(138, 22);
            Version.TabIndex = 4;
            // 
            // Description_label
            // 
            Description_label.AutoSize = true;
            Description_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description_label.Location = new Point(12, 153);
            Description_label.Name = "Description_label";
            Description_label.Size = new Size(84, 14);
            Description_label.TabIndex = 9;
            Description_label.Text = "Description";
            // 
            // Description_check
            // 
            Description_check.AutoSize = true;
            Description_check.Location = new Point(12, 170);
            Description_check.Name = "Description_check";
            Description_check.Size = new Size(15, 14);
            Description_check.TabIndex = 5;
            Description_check.UseVisualStyleBackColor = true;
            Description_check.Click += Description_check_Click;
            // 
            // Description
            // 
            Description.Enabled = false;
            Description.Location = new Point(12, 190);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.Size = new Size(262, 66);
            Description.TabIndex = 6;
            Description.Visible = false;
            // 
            // Folder_select
            // 
            Folder_select.Location = new Point(12, 276);
            Folder_select.Name = "Folder_select";
            Folder_select.Size = new Size(81, 23);
            Folder_select.TabIndex = 7;
            Folder_select.Text = "Select";
            Folder_select.UseVisualStyleBackColor = true;
            Folder_select.Click += Folder_select_Click;
            // 
            // Selected_folder
            // 
            Selected_folder.AutoSize = true;
            Selected_folder.Location = new Point(12, 259);
            Selected_folder.Name = "Selected_folder";
            Selected_folder.Size = new Size(119, 14);
            Selected_folder.TabIndex = 14;
            Selected_folder.Text = "Select folder...";
            // 
            // Folder_name_label
            // 
            Folder_name_label.AutoSize = true;
            Folder_name_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Folder_name_label.Location = new Point(146, 51);
            Folder_name_label.Name = "Folder_name_label";
            Folder_name_label.Size = new Size(84, 14);
            Folder_name_label.TabIndex = 16;
            Folder_name_label.Text = "Folder name";
            // 
            // Folder_name
            // 
            Folder_name.Location = new Point(146, 68);
            Folder_name.Name = "Folder_name";
            Folder_name.Size = new Size(128, 22);
            Folder_name.TabIndex = 3;
            // 
            // Create
            // 
            Create.Location = new Point(12, 305);
            Create.Name = "Create";
            Create.Size = new Size(262, 23);
            Create.TabIndex = 8;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // PackCreater
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(286, 340);
            Controls.Add(Create);
            Controls.Add(Folder_name_label);
            Controls.Add(Folder_name);
            Controls.Add(Selected_folder);
            Controls.Add(Folder_select);
            Controls.Add(Description);
            Controls.Add(Description_check);
            Controls.Add(Description_label);
            Controls.Add(Version);
            Controls.Add(Version_label);
            Controls.Add(Pack_name_label);
            Controls.Add(Pack_name);
            Controls.Add(Pack_type);
            Controls.Add(Pack_type_label);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximumSize = new Size(302, 379);
            MinimumSize = new Size(302, 379);
            Name = "PackCreater";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PackCreater";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Pack_type_label;
        private ComboBox Pack_type;
        private TextBox Pack_name;
        private Label Pack_name_label;
        private Label Version_label;
        private ComboBox Version;
        private Label Description_label;
        private CheckBox Description_check;
        private TextBox Description;
        private FolderBrowserDialog fBD;
        private Button Folder_select;
        private Label Selected_folder;
        private Label Folder_name_label;
        private TextBox Folder_name;
        private Button Create;
    }
}
