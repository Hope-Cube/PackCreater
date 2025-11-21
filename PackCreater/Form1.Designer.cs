namespace PackCreater
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
            pack_type_label = new Label();
            pack_type = new ComboBox();
            pack_name = new TextBox();
            pack_name_label = new Label();
            version_label = new Label();
            version = new ComboBox();
            description_label = new Label();
            description_check = new CheckBox();
            description = new TextBox();
            fBD = new FolderBrowserDialog();
            folder_select = new Button();
            selected_folder = new Label();
            folder_name_label = new Label();
            folder_name = new TextBox();
            create = new Button();
            SuspendLayout();
            // 
            // pack_type_label
            // 
            pack_type_label.AutoSize = true;
            pack_type_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pack_type_label.Location = new Point(12, 9);
            pack_type_label.Name = "pack_type_label";
            pack_type_label.Size = new Size(70, 14);
            pack_type_label.TabIndex = 0;
            pack_type_label.Text = "Pack Type";
            // 
            // pack_type
            // 
            pack_type.BackColor = SystemColors.Window;
            pack_type.DropDownStyle = ComboBoxStyle.DropDownList;
            pack_type.FormattingEnabled = true;
            pack_type.Items.AddRange(new object[] { "Data pack", "Resource pack" });
            pack_type.Location = new Point(12, 26);
            pack_type.Name = "pack_type";
            pack_type.Size = new Size(128, 22);
            pack_type.TabIndex = 1;
            pack_type.SelectedIndexChanged += pack_type_SelectedIndexChanged;
            // 
            // pack_name
            // 
            pack_name.Location = new Point(146, 26);
            pack_name.Name = "pack_name";
            pack_name.Size = new Size(128, 22);
            pack_name.TabIndex = 2;
            // 
            // pack_name_label
            // 
            pack_name_label.AutoSize = true;
            pack_name_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pack_name_label.Location = new Point(146, 9);
            pack_name_label.Name = "pack_name_label";
            pack_name_label.Size = new Size(70, 14);
            pack_name_label.TabIndex = 3;
            pack_name_label.Text = "Pack name";
            // 
            // version_label
            // 
            version_label.AutoSize = true;
            version_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            version_label.Location = new Point(12, 100);
            version_label.Name = "version_label";
            version_label.Size = new Size(56, 14);
            version_label.TabIndex = 7;
            version_label.Text = "Version";
            // 
            // version
            // 
            version.DropDownStyle = ComboBoxStyle.DropDownList;
            version.FormattingEnabled = true;
            version.ItemHeight = 14;
            version.Location = new Point(12, 117);
            version.Name = "version";
            version.Size = new Size(138, 22);
            version.TabIndex = 4;
            // 
            // description_label
            // 
            description_label.AutoSize = true;
            description_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            description_label.Location = new Point(12, 153);
            description_label.Name = "description_label";
            description_label.Size = new Size(84, 14);
            description_label.TabIndex = 9;
            description_label.Text = "Description";
            // 
            // description_check
            // 
            description_check.AutoSize = true;
            description_check.Location = new Point(12, 170);
            description_check.Name = "description_check";
            description_check.Size = new Size(15, 14);
            description_check.TabIndex = 5;
            description_check.UseVisualStyleBackColor = true;
            description_check.Click += description_check_Click;
            // 
            // description
            // 
            description.Enabled = false;
            description.Location = new Point(12, 190);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(262, 66);
            description.TabIndex = 6;
            description.Visible = false;
            // 
            // folder_select
            // 
            folder_select.Location = new Point(12, 276);
            folder_select.Name = "folder_select";
            folder_select.Size = new Size(81, 23);
            folder_select.TabIndex = 7;
            folder_select.Text = "Select";
            folder_select.UseVisualStyleBackColor = true;
            folder_select.Click += folder_select_Click;
            // 
            // selected_folder
            // 
            selected_folder.AutoSize = true;
            selected_folder.Location = new Point(12, 259);
            selected_folder.Name = "selected_folder";
            selected_folder.Size = new Size(119, 14);
            selected_folder.TabIndex = 14;
            selected_folder.Text = "Select folder...";
            // 
            // folder_name_label
            // 
            folder_name_label.AutoSize = true;
            folder_name_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            folder_name_label.Location = new Point(146, 51);
            folder_name_label.Name = "folder_name_label";
            folder_name_label.Size = new Size(84, 14);
            folder_name_label.TabIndex = 16;
            folder_name_label.Text = "Folder name";
            // 
            // folder_name
            // 
            folder_name.Location = new Point(146, 68);
            folder_name.Name = "folder_name";
            folder_name.Size = new Size(128, 22);
            folder_name.TabIndex = 3;
            // 
            // create
            // 
            create.Location = new Point(12, 305);
            create.Name = "create";
            create.Size = new Size(262, 23);
            create.TabIndex = 8;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(286, 340);
            Controls.Add(create);
            Controls.Add(folder_name_label);
            Controls.Add(folder_name);
            Controls.Add(selected_folder);
            Controls.Add(folder_select);
            Controls.Add(description);
            Controls.Add(description_check);
            Controls.Add(description_label);
            Controls.Add(version);
            Controls.Add(version_label);
            Controls.Add(pack_name_label);
            Controls.Add(pack_name);
            Controls.Add(pack_type);
            Controls.Add(pack_type_label);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximumSize = new Size(302, 379);
            MinimumSize = new Size(302, 379);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PackCreater";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pack_type_label;
        private ComboBox pack_type;
        private TextBox pack_name;
        private Label pack_name_label;
        private Label version_label;
        private ComboBox version;
        private Label description_label;
        private CheckBox description_check;
        private TextBox description;
        private FolderBrowserDialog fBD;
        private Button folder_select;
        private Label selected_folder;
        private Label folder_name_label;
        private TextBox folder_name;
        private Button create;
    }
}
