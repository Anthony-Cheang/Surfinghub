using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfHub
{
    class Memento//备忘录类
    {
        private string signs;

        public Memento(string signs)//导入要保存的数据
        { this.signs = signs; }
        public string Signs//需要保存的数据，本例中为个人的个性签名，后期可适当拓展属性
        {
            get { return signs; }
        }
    }
    class originator//个人信息类
    {
        private string signs;//需要保存的属性
        public string Signs
        {
            get { return signs; }
            set { signs = value; }
        }
        public Memento CreateMemento()
        {
            return (new Memento(signs));
        }
        public void SetMento(Memento memento)
        {
            signs = memento.Signs;
        }
        public string show()
        {
            return signs;
        }
    }
    class Caretaker
    {
        private Memento memento;
        public Memento Memento//设置备忘录属性
        {
            get { return memento; }
            set { memento = value; }
        }
    }

}
