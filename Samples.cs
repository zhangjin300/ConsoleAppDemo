using System.Xml.Linq;

public class Person
{
    // 私有字段，外部无法直接访问
    private string _name;
    private int _age;

    // 公共属性，通过属性访问私有字段
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            // 数据验证：年龄不能为负数
            if (value >= 0)
                _age = value;
            else
                throw new ArgumentException("Age cannot be negative.");
        }
    }

    //// 公共方法：封装行为
    //public void Introduce()
    //{
    //    Console.WriteLine($"Hi, I'm {_name}, and I'm {_age} years old.");
    //}
    // 使用属性来访问私有字段




}
public class Program
{
    public static void Main(string[] args)
    {
        // 创建一个 Person 对象
        Person person = new Person();

        person.Name = "王五";
        person.Age = 30;

        Console.WriteLine($"Hi, I'm {person.Name}, and I'm {person.Age} years old.");
        person.Name = "赵六";
        person.Age = 40;
        Console.WriteLine($"Hi, I'm {person.Name}, and I'm {person.Age} years old.");
    }
}
