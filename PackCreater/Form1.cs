namespace PackCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            folder_name_label.Visible = false;
            folder_name.Enabled = false;
            folder_name.Visible = false;
            version_label.Location = new(12, 80);
            version.Location = new(12, 97);
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

        private Dictionary<byte, byte> packFormats = [];
        private void create_Click(object sender, EventArgs e)
        {
            string pack = pack_name.Text;
            if (pack_type.SelectedIndex == 0)
            {
                packFormats = new()
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
                string function_folder = Path.Combine(pack, "data", folder_name.Text, "function");
                using (StreamWriter writer = new(Path.Combine(pack, "pack.mcmeta")))
                {
                    writer.WriteLine("{");
                    writer.WriteLine("  \"pack\": {");
                    writer.WriteLine($"    \"pack_format\": {packFormats[(byte)(version.SelectedIndex + 1)]},");
                    writer.WriteLine($"    \"description\": \"{(description_check.Checked ? description.Text : "A Minecraft pack created using PackCreater")}\"");
                    writer.WriteLine("  }");
                    writer.WriteLine("}");
                }
                Directory.CreateDirectory(function_folder);
                using (StreamWriter func_writer = new(Path.Combine(function_folder, "test.mcfunction")))
                {
                    func_writer.WriteLine("tellraw @a \"This is a test function created by PackCreater\"");
                }
                File.Create(Path.Combine(function_folder, "tick.mcfunction"));
                using (StreamWriter load_writer = new(Path.Combine(function_folder, "load.mcfunction")))
                {
                    load_writer.WriteLine($"tellraw @a \"{pack} is loaded!\"");
                }
                string tag_func_folder = Path.Combine(pack, "data", "minecraft", "tags", "function");
                Directory.CreateDirectory(tag_func_folder);
                using (StreamWriter tick_writer = new(Path.Combine(tag_func_folder, "tick.json")))
                {
                    tick_writer.WriteLine("{");
                    tick_writer.WriteLine("  \"values\": [");
                    tick_writer.WriteLine($"    \"{folder_name.Text}:tick\"");
                    tick_writer.WriteLine("  ]");
                    tick_writer.WriteLine("}");
                }
                using (StreamWriter load_writer = new(Path.Combine(tag_func_folder, "load.json")))
                {
                    load_writer.WriteLine("{");
                    load_writer.WriteLine("  \"values\": [");
                    load_writer.WriteLine($"    \"{folder_name.Text}:load\"");
                    load_writer.WriteLine("  ]");
                    load_writer.WriteLine("}");
                }
            }
            if (pack_type.SelectedIndex == 1)
            {
                packFormats = new()
        {
            { 0, 1 },
            { 1, 2 },
            { 2, 3 },
            { 3, 4 },
            { 4, 5 },
            { 5, 6 },
            { 6, 7 },
            { 7, 8 },
            { 8, 9 },
            { 9, 12 },
            { 10, 13 },
            { 11, 15 },
            { 12, 18 },
            { 13, 22 },
            { 14, 32 },
            { 15, 34 },
            { 16, 42 },
            { 17, 46 },
            { 18, 55 },
                    {  19, 63 },
                    { 20, 64 },
                    { 21, 69 }  
        };
                using (StreamWriter writer = new(Path.Combine(pack, "pack.mcmeta")))
                {
                    writer.WriteLine("{");
                    writer.WriteLine("  \"pack\": {");
                    writer.WriteLine($"    \"pack_format\": {packFormats[(byte)(version.SelectedIndex + 1)]},");
                    writer.WriteLine($"    \"description\": \"{(description_check.Checked ? description.Text : "A Minecraft pack created using PackCreater")}\"");
                    writer.WriteLine("  }");
                    writer.WriteLine("}");
                }
                string mc_folder = Path.Combine(pack, "assets", "minecraft");
                string zombie_sound = Path.Combine(mc_folder, "sounds", "mob", "zombie");
                Directory.CreateDirectory(zombie_sound);
                using (StreamWriter sound_writer = new(Path.Combine(mc_folder, "sound.json")))
                {
                    sound_writer.WriteLine("{");
                    sound_writer.WriteLine("  \"mob.zombie.idle\": {");
                    sound_writer.WriteLine("    \"sounds\": [");
                    sound_writer.WriteLine("\"mob/zombie/say1\", \"mob/zombie/say2\"");
                    sound_writer.WriteLine("]");
                    sound_writer.WriteLine("},");
                    sound_writer.WriteLine("  \"mob.zombie.hurt\": {");
                    sound_writer.WriteLine("    \"sounds\": [");
                    sound_writer.WriteLine("\"mob/zombie/hurt1\"");
                    sound_writer.WriteLine("]");
                    sound_writer.WriteLine("}");
                    sound_writer.WriteLine("}");
                }
                File.Create(Path.Combine(zombie_sound, "say1.ogg"));
                File.Create(Path.Combine(zombie_sound, "say2.ogg"));
                File.Create(Path.Combine(zombie_sound, "hurt1.ogg"));
                string texture_folder = Path.Combine(mc_folder, "textures");
                Directory.CreateDirectory(Path.Combine(texture_folder, "block"));
                Directory.CreateDirectory(Path.Combine(texture_folder, "entity", "zombie"));
                using (Bitmap iron_sword = new(Path.Combine(texture_folder, "item", "iron_sword.png")))
                {

                }
            }

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

            bitmap.Save(Path.Combine(pack, "pack.png"));

            MessageBox.Show("Pack created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pack_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pack_type_SelectedIndexChanged == null)
            {
                folder_name_label.Visible = false;
                folder_name.Enabled = false;
                folder_name.Visible = false;
                version_label.Location = new(12, 80);
                version.Location = new(12, 97);
            }
            if (pack_type.SelectedIndex == 0)
            {
                version.Items.Clear();
                version.Items.AddRange(
                    [
                        "1.13 - 1.14.4",
                        "1.15 - 1.16.1",
                        "1.16.2 - 1.16.5",
                        "1.17 - 1.17.1",
                        "1.18 - 1.18.1",
                        "1.18.2",
                        "1.19 - 1.19.3",
                        "1.19.4",
                        "1.20 - 1.20.1",
                        "1.20.2",
                        "1.20.3 - 1.20.4",
                        "1.20.5 - 1.20.6",
                        "1.21 - 1.21.1",
                        "1.21.2 - 1.21.3",
                        "1.21.5",   
                        "1.21.6",   
                        "1.21.7 - 1.21.8",  
                        "1.21.9 - 1.21.10"
                    ]
                );
                pack_name.Text = "My_datapack";
                folder_name_label.Visible = true;
                folder_name.Enabled = true;
                folder_name.Visible = true;
                folder_name.Text = "my_namespace";
                version_label.Location = new(12, 100);
                version.Location = new(12, 117);
                description_label.Location = new(12, 153);
                description_check.Location = new(12, 170);
                description.Location = new(12, 190);
            }
            else if (pack_type.SelectedIndex == 1)
            {
                version.Items.Clear();
                version.Items.AddRange(
                    [
                        "1.6.1 - 1.8.9",
                        "1.9 - 1.10.2",
                        "1.11 - 1.12.2",
                        "1.13 - 1.14.4",
                        "1.15 - 1.16.1",
                        "1.16.2 - 1.16.5",
                        "1.17 - 1.17.1",
                        "1.18 - 1.18.2",
                        "1.19 - 1.19.2",
                        "1.19.3",
                        "1.19.4",
                        "1.20 - 1.20.1",
                        "1.20.2",
                        "1.20.3 - 1.20.4",
                        "1.20.5 - 1.20.6",
                        "1.21 - 1.21.1",
                        "1.21.2 - 1.21.3",
                        "1.21.4",
                        "1.21.5",
                        "1.21.6",
                        "1.21.7 - 1.21.8",
                        "1.21.9 - 1.21.10"
                    ]
                );
                pack_name.Text = "My_resourcepack";
                folder_name_label.Visible = false;
                folder_name.Enabled = false;
                folder_name.Visible = false;
                version_label.Location = new(12, 80);
                version.Location = new(12, 97);
                description_label.Location = new(12, 130);
                description_check.Location = new(12, 147);
                description.Location = new(12, 167);
            }
        }
    }
}