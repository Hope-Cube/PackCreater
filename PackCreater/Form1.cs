namespace PackCreater
{
    public partial class PackCreater : Form
    {
        // Pack format tables by Version combo index
        private static readonly Dictionary<int, int> DataPackFormats = new()
        {
            { 0,  4 },
            { 1,  5 },
            { 2,  6 },
            { 3,  7 },
            { 4,  8 },
            { 5,  9 },
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

        private static readonly Dictionary<int, int> ResourcePackFormats = new()
        {
            { 0,  1 },
            { 1,  2 },
            { 2,  3 },
            { 3,  4 },
            { 4,  5 },
            { 5,  6 },
            { 6,  7 },
            { 7,  8 },
            { 8,  9 },
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
            { 19, 63 },
            { 20, 64 },
            { 21, 69 }
        };

        private static readonly string[] DataPackVersionText =
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
        ];

        private static readonly string[] ResourcePackVersionText =
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
        ];

        public PackCreater()
        {
            InitializeComponent();

            // Initial UI state
            Folder_name_label.Visible = false;
            Folder_name.Enabled = false;
            Folder_name.Visible = false;

            Version_label.Location = new(12, 80);
            Version.Location = new(12, 97);

            Description_check.Checked = false;
            ToggleDescription(false);

            Selected_folder.Location = new(12, 212);
            Folder_select.Location = new(12, 229);
        }

        private void ToggleDescription(bool enabled)
        {
            Description.Visible = enabled;
            Description.Enabled = enabled;

            if (enabled)
            {
                Selected_folder.Location = new(12, 262);
                Folder_select.Location = new(12, 279);
            }
            else
            {
                Selected_folder.Location = new(12, 212);
                Folder_select.Location = new(12, 229);
            }
        }

        private void Description_check_Click(object sender, EventArgs e)
        {
            ToggleDescription(Description_check.Checked);
            if (Description_check.Checked)
                Description.Focus();
        }

        private void Folder_select_Click(object sender, EventArgs e)
        {
            if (fBD.ShowDialog() != DialogResult.OK)
                return;

            var dir = new DirectoryInfo(fBD.SelectedPath);

            string lastTwo = dir.Parent != null
                ? $@"{dir.Parent.Name}\{dir.Name}"
                : dir.Name;

            Selected_folder.Text = @"...\" + lastTwo;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (Version.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Minecraft version.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Pack_type.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a pack type.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string packName = Pack_name.Text.Trim();
            if (string.IsNullOrWhiteSpace(packName))
            {
                MessageBox.Show("Please enter a pack name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Where to create the pack. If you have a base folder, combine it here.
            string packPath = Path.Combine(fBD.SelectedPath, packName);
            Directory.CreateDirectory(packPath);

            int packFormat = Pack_type.SelectedIndex switch
            {
                0 => DataPackFormats[Version.SelectedIndex],
                1 => ResourcePackFormats[Version.SelectedIndex],
                _ => throw new InvalidOperationException("Unknown pack type.")
            };

            string description = !Description_check.Checked || string.IsNullOrWhiteSpace(Description.Text)
                ? "A Minecraft pack created using PackCreater"
                : Description.Text.Replace("\"", "\\\""); // naive escape

            WritePackMcMeta(packPath, packFormat, description);

            if (Pack_type.SelectedIndex == 0)
            {
                if (string.IsNullOrWhiteSpace(Folder_name.Text))
                {
                    MessageBox.Show("Please enter a namespace for the datapack.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CreateDataPackStructure(packPath, Folder_name.Text.Trim());
            }
            else if (Pack_type.SelectedIndex == 1)
            {
                CreateResourcePackStructure(packPath);
            }

            CreatePackIcon(packPath);

            MessageBox.Show("Pack created successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void WritePackMcMeta(string packPath, int packFormat, string description)
        {
            string mcmeta =
$@"{{
  ""pack"": {{
    ""pack_format"": {packFormat},
    ""description"": ""{description}""
  }}
}}";

            File.WriteAllText(Path.Combine(packPath, "pack.mcmeta"), mcmeta);
        }

        private static void CreateEmptyFile(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            using (File.Create(path)) { }
        }

        private static void CreateDataPackStructure(string packPath, string namespaceName)
        {
            string functionFolder = Path.Combine(packPath, "data", namespaceName, "function");
            Directory.CreateDirectory(functionFolder);

            File.WriteAllText(Path.Combine(functionFolder, "test.mcfunction"),
                "tellraw @a \"This is a test function created by PackCreater\"");

            CreateEmptyFile(Path.Combine(functionFolder, "tick.mcfunction"));

            File.WriteAllText(Path.Combine(functionFolder, "load.mcfunction"),
                $"tellraw @a \"{Path.GetFileName(packPath)} is loaded!\"");

            string tagFuncFolder = Path.Combine(packPath, "data", "minecraft", "tags", "function");
            Directory.CreateDirectory(tagFuncFolder);

            File.WriteAllText(Path.Combine(tagFuncFolder, "tick.json"),
$@"{{
  ""values"": [
    ""{namespaceName}:tick""
  ]
}}");

            File.WriteAllText(Path.Combine(tagFuncFolder, "load.json"),
$@"{{
  ""values"": [
    ""{namespaceName}:load""
  ]
}}");
        }

        private static void CreateResourcePackStructure(string packPath)
        {
            string mcFolder = Path.Combine(packPath, "assets", "minecraft");
            string soundsFolder = Path.Combine(mcFolder, "sounds");
            string zombieSound = Path.Combine(soundsFolder, "mob", "zombie");

            Directory.CreateDirectory(zombieSound);

            string soundsJsonPath = Path.Combine(mcFolder, "sounds.json");
            string soundsJson =
@"{
  ""mob.zombie.idle"": {
    ""sounds"": [
      ""mob/zombie/say1"",
      ""mob/zombie/say2""
    ]
  },
  ""mob.zombie.hurt"": {
    ""sounds"": [
      ""mob/zombie/hurt1""
    ]
  }
}";
            File.WriteAllText(soundsJsonPath, soundsJson);

            CreateEmptyFile(Path.Combine(zombieSound, "say1.ogg"));
            CreateEmptyFile(Path.Combine(zombieSound, "say2.ogg"));
            CreateEmptyFile(Path.Combine(zombieSound, "hurt1.ogg"));

            string textureFolder = Path.Combine(mcFolder, "textures");
            Directory.CreateDirectory(Path.Combine(textureFolder, "entity", "zombie"));
            CreateEmptyFile(Path.Combine(textureFolder, "entity", "zombie", "zombie.png"));

            Directory.CreateDirectory(Path.Combine(textureFolder, "block"));
            CreateEmptyFile(Path.Combine(textureFolder, "block", "stone.png"));

            Directory.CreateDirectory(Path.Combine(textureFolder, "item"));
            CreateEmptyFile(Path.Combine(textureFolder, "item", "iron_sword.png"));

            Directory.CreateDirectory(Path.Combine(textureFolder, "gui", "container"));
            CreateEmptyFile(Path.Combine(textureFolder, "gui", "container", "inventory.png"));
            CreateEmptyFile(Path.Combine(textureFolder, "gui", "icons.png"));

            Directory.CreateDirectory(Path.Combine(textureFolder, "painting"));
            CreateEmptyFile(Path.Combine(textureFolder, "painting", "kebab.png"));
        }

        private static void CreatePackIcon(string packPath)
        {
            using var bitmap = new Bitmap(128, 128);
            using var g = Graphics.FromImage(bitmap);
            var rnd = new Random();

            g.Clear(Color.FromArgb(255, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));

            const string text = "PC";

            // Bold black outline
            using (var font = new Font("Consolas", 58, FontStyle.Bold))
            {
                SizeF size = g.MeasureString(text, font);
                float x = (128 - size.Width) / 2f;
                float y = (128 - size.Height) / 2f;
                g.DrawString(text, font, Brushes.Black, new PointF(x, y));
            }

            // White main text
            using (var font = new Font("Consolas", 52, FontStyle.Regular))
            {
                SizeF size = g.MeasureString(text, font);
                float x = (128 - size.Width) / 2f;
                float y = (128 - size.Height) / 2f;
                g.DrawString(text, font, Brushes.White, new PointF(x, y));
            }

            bitmap.Save(Path.Combine(packPath, "pack.png"));
        }

        private void Pack_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pack_type.SelectedIndex == 0) // Datapack
            {
                Version.Items.Clear();
                Version.Items.AddRange(DataPackVersionText);

                Pack_name.Text = "My_datapack";

                Folder_name_label.Visible = true;
                Folder_name.Enabled = true;
                Folder_name.Visible = true;
                Folder_name.Text = "my_namespace";

                Version_label.Location = new(12, 100);
                Version.Location = new(12, 117);

                Description_label.Location = new(12, 153);
                Description_check.Location = new(12, 170);
                Description.Location = new(12, 190);
            }
            else if (Pack_type.SelectedIndex == 1) // Resource pack
            {
                Version.Items.Clear();
                Version.Items.AddRange(ResourcePackVersionText);

                Pack_name.Text = "My_resourcepack";

                Folder_name_label.Visible = false;
                Folder_name.Enabled = false;
                Folder_name.Visible = false;

                Version_label.Location = new(12, 80);
                Version.Location = new(12, 97);

                Description_label.Location = new(12, 130);
                Description_check.Location = new(12, 147);
                Description.Location = new(12, 167);
            }
        }
    }
}