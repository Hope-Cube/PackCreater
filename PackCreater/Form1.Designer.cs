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
            pack_create = new Button();
            folder_select = new Button();
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
            pack_type.DropDownStyle = ComboBoxStyle.DropDownList;
            pack_type.FormattingEnabled = true;
            pack_type.Items.AddRange(new object[] { "Data pack", "Resource pack" });
            pack_type.Location = new Point(12, 26);
            pack_type.Name = "pack_type";
            pack_type.Size = new Size(128, 22);
            pack_type.TabIndex = 1;
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
            version_label.Location = new Point(12, 79);
            version_label.Name = "version_label";
            version_label.Size = new Size(56, 14);
            version_label.TabIndex = 7;
            version_label.Text = "Version";
            // 
            // version
            // 
            version.DropDownStyle = ComboBoxStyle.DropDownList;
            version.FormattingEnabled = true;
            version.Items.AddRange(new object[] { "1.13 - 1.14.4", "1.15 - 1.16.2", "1.16.3 - 1.16.5", "1.17 - 1.17.1", "1.18 - 1.18.1", "1.18.2", "1.19 - 1.19.3", "1.19.4", "1.20 - 1.20.1", "1.20.2", "1.20.3 - 1.20.4", "1.20.5 - 1.20.6", "1.21 - 1.21.1", "1.21.2 - 1.21.3", "1.21.5", "1.21.6", "1.21.7 - 1.21.8", "1.21.9 - 1.21.10" });
            version.Location = new Point(12, 96);
            version.Name = "version";
            version.Size = new Size(121, 22);
            version.TabIndex = 8;
            // 
            // description_label
            // 
            description_label.AutoSize = true;
            description_label.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            description_label.Location = new Point(12, 149);
            description_label.Name = "description_label";
            description_label.Size = new Size(84, 14);
            description_label.TabIndex = 9;
            description_label.Text = "Description";
            // 
            // description_check
            // 
            description_check.AutoSize = true;
            description_check.Location = new Point(12, 166);
            description_check.Name = "description_check";
            description_check.Size = new Size(15, 14);
            description_check.TabIndex = 10;
            description_check.UseVisualStyleBackColor = true;
            description_check.Click += description_check_Click;
            // 
            // description
            // 
            description.Enabled = false;
            description.Location = new Point(12, 186);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(262, 66);
            description.TabIndex = 11;
            description.Visible = false;
            // 
            // pack_create
            // 
            pack_create.Location = new Point(135, 351);
            pack_create.Name = "pack_create";
            pack_create.Size = new Size(75, 23);
            pack_create.TabIndex = 12;
            pack_create.Text = "Create";
            pack_create.UseVisualStyleBackColor = true;
            // 
            // folder_select
            // 
            folder_select.Location = new Point(93, 275);
            folder_select.Name = "folder_select";
            folder_select.Size = new Size(104, 50);
            folder_select.TabIndex = 13;
            folder_select.Text = "Select root folder";
            folder_select.UseVisualStyleBackColor = true;
            folder_select.Click += folder_select_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 420);
            Controls.Add(folder_select);
            Controls.Add(pack_create);
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
            Name = "Form1";
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
        private Button pack_create;
        private Button folder_select;
    }
}
