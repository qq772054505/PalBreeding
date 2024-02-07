using System.ComponentModel;

namespace PalBreeding
{
    public enum Gender
    {
        Male = 1,
        Female = 2,
    }
    public class Palu
    {
        public required int No { get; set; }
        public required string Name { get; set; }
    }
    public class PaluBreeding
    {
        [Description("父亲图鉴编号")]
        public required int FatherPaluNo { get; set; }
        [Description("父亲帕鲁名称")]
        public required string FatherPaluName { get; set; }
        [Description("父亲特性")]
        public required string FatherDescription { get; set; }
        [Description("母亲图鉴编号")]
        public required int MotherPaluNo { get; set; }
        [Description("母亲帕鲁名称")]
        public required string MotherPaluName { get; set; }
        [Description("母亲特性")]
        public required string MotherDescription { get; set; }
        [Description("蛋大小")]
        public required EggSize EggSize { get; set; }
        [Description("蛋种类")]
        public required EggType EggType { get; set; }
        [Description("孩子图鉴编号")]
        public int ChildNo { get; set; }
        [Description("孩子帕鲁名称")]
        public string ChildName { get; set; } = string.Empty;
        [Description("孩子帕鲁特性")]
        public string ChildDescription { get; set; } = string.Empty;
        [Description("录入时间")]
        public required DateTime UpdateTime { get; set; }
    }
    public enum EggSize
    {
        [Description("普通")]
        Normal,
        [Description("大")]
        Big,
        [Description("巨大")]
        Huge
    }
    public enum EggType
    {
        [Description("暗黑")]
        Dark,
        [Description("绿")]
        Green,
        [Description("冰")]
        Ice,
        [Description("火热")]
        Hot,
        [Description("平凡")]
        Normal
    }

}
