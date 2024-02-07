using System.ComponentModel;

namespace PalBreeding
{
    public partial class MainForm : Form
    {
        public Dictionary<int, Palu> PaluDic { get; set; } = [];
        public BindingList<PaluBreeding> ViewPaluData { get; set; } = [];
        public readonly string dataFileName = "data.json";
        public readonly string dicFileName = "dic.json";
        public MainForm()
        {
            if (File.Exists(dataFileName))
            {
                var data = File.ReadAllText(dataFileName).ToObject<List<PaluBreeding>>();
                if (data is not null)
                {
                    ViewPaluData = new(data);
                }
            }
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ViewPaluData;
            MotherNoTextBox.KeyPress += new(TextBox_KeyPress);
            FatherNoTextBox.KeyPress += new(TextBox_KeyPress);
            // 获取枚举值并添加到 ComboBox
            foreach (EggSize value in Enum.GetValues(typeof(EggSize)))
            {
                EggSizeComboBox.Items.Add(value.GetDescription());
            }
            foreach (EggType value in Enum.GetValues(typeof(EggType)))
            {
                EggTypeComboBox.Items.Add(value.GetDescription());
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderText = DescriptionExtensions.GetDescription<PaluBreeding>(column.Name);
            }
        }
        private void NoTextBoxAction(TextBox noBox, TextBox nameBox)
        {
            if (!int.TryParse(noBox.Text, out var no))
            {
                return;
            }
            if (PaluDic.TryGetValue(no, out var palu))
            {
                nameBox.Text = palu.Name;
            }
        }
        private void FatherNoTextBox_TextChanged(object sender, EventArgs e)
        {
            NoTextBoxAction(FatherNoTextBox, FatherNameBox);
        }
        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // 如果输入的不是控制字符，也不是数字，那么取消这个输入
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void MotherNoTextBox_TextChanged(object sender, EventArgs e)
        {
            NoTextBoxAction(MotherNoTextBox, MotherNameBox);
        }
        private static void SwapTextBox(TextBox textBox1, TextBox textBox2)
        {
            (textBox1.Text, textBox2.Text) = (textBox2.Text, textBox1.Text);
        }
        private void SwapButton_Click(object sender, EventArgs e)
        {
            SwapTextBox(MotherDescTextBox, FatherDescTextBox);
            SwapTextBox(MotherNoTextBox, FatherNoTextBox);
            SwapTextBox(MotherNameBox, FatherNameBox);
        }
        private void UpdatePaluDic(int no, string name)
        {
            if (PaluDic.TryGetValue(no, out var palu))
            {
                if (palu.Name != name)
                {
                    palu.Name = name;
                }
            }
            else
            {
                PaluDic.Add(no, new()
                {
                    No = no,
                    Name = name
                });
            }
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                ViewPaluData.Add(new()
                {
                    EggSize = (EggSize)Enum.GetValues(typeof(EggSize)).GetValue(EggSizeComboBox.SelectedIndex)!,
                    EggType = (EggType)Enum.GetValues(typeof(EggType)).GetValue(EggSizeComboBox.SelectedIndex)!,
                    FatherDescription = FatherDescTextBox.Text,
                    MotherDescription = MotherDescTextBox.Text,
                    FatherPaluNo = int.Parse(FatherNoTextBox.Text),
                    MotherPaluNo = int.Parse(MotherNoTextBox.Text),
                    FatherPaluName = FatherNameBox.Text,
                    MotherPaluName = MotherNameBox.Text,
                    UpdateTime = DateTime.Now,
                });
            }
            catch
            {
                MessageBox.Show("数据错误");
            }
            File.WriteAllText(dataFileName, ViewPaluData.ToList().ToJson());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].IsNewRow)
                {
                    return;
                }
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}
