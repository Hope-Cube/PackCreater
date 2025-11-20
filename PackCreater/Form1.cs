namespace PackCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            description_check.Checked = false;
            description.Visible = false;
            description.Enabled = false;
            selected_folder.Location = new(12, 212);
            folder_select.Location = new(12, 229);
        }

        private void description_check_Click(object sender, EventArgs e)
        {
            if (description_check.Checked)
            {
                description.Visible = true;
                description.Enabled = true;
                description.Focus();
                selected_folder.Location = new(12, 262);
                folder_select.Location = new(12, 279);
            }
            else
            {
                description.Visible = false;
                description.Enabled = false;
                selected_folder.Location = new(12, 212);
                folder_select.Location = new(12, 229);
            }
        }

        private void folder_select_Click(object sender, EventArgs e)
        {
            if (fBD.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = new(fBD.SelectedPath);

                // last folder and its parent
                string lastTwo = dir.Parent != null
                    ? $@"{dir.Parent.Name}\{dir.Name}"
                    : dir.Name;

                selected_folder.Text = @"...\" + lastTwo;
            }
        }

        private Dictionary<byte, byte> datapackFormats = new()
        {
            { 0, 4 },
            { 1, 5 },
            { 2, 6 },
            { 3, 7 },
            { 4, 8 },
            { 5, 9 },
            { 6, 10 },
            { 7, 12 },
            { 8, 15 },
            { 9, 18 },
            { 10, 26 },
            { 11, 41 },
            { 12, 48 },
            { 13, 57 },
            { 14, 61 },
            { 15, 71 },
            { 16, 80 },
            { 17, 81 },
            { 18, 88 }
        };
        private void create_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(pack_name.Text, "data", folder_name.Text, "function"));
            File.Create(Path.Combine(pack_name.Text, "data", folder_name.Text, "function", "test.mcfunction")).Close();
            using StreamWriter writer = new(Path.Combine(pack_name.Text, "pack.mcmeta"));
            writer.WriteLine("{");
            writer.WriteLine("  \"pack\": {");
            writer.WriteLine($"    \"pack_format\": {datapackFormats[(byte)(version.SelectedIndex + 1)]},");
            writer.WriteLine($"    \"description\": \"{(description_check.Checked ? description.Text : "A Minecraft pack created using PackCreater")}\"");
            writer.WriteLine("  }");
            writer.WriteLine("}");

            using Bitmap bitmap = new(128, 128);
            using Graphics g = Graphics.FromImage(bitmap);
            Random rnd = new();
            g.Clear(Color.FromArgb(255, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            string text = "PC";

            SizeF size;
            float x, y;
            // measure the text
            using (Font font = new("Consolas", 58, FontStyle.Bold))
            { 
                size = g.MeasureString(text, font);
                x = (128 - size.Width) / 2f;
                y = (128 - size.Height) / 2f;
                g.DrawString(text, font, Brushes.Black, new PointF(x, y));
            }

            using (Font font = new("Consolas", 52))
            {
                size = g.MeasureString(text, font);
                x = (128 - size.Width) / 2f;
                y = (128 - size.Height) / 2f;
                g.DrawString(text, font, Brushes.White, new PointF(x, y));
            }

            bitmap.Save(Path.Combine(pack_name.Text, "pack.png"));

            MessageBox.Show("Pack created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}