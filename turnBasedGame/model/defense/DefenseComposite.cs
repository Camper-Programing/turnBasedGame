using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedGame.model.Defense
{
    public class DefenseComposite : IDefenseItem
    {
        private readonly List<IDefenseItem> _items = new();
        public DefenseComposite()
        {
        }
        public void Add(IDefenseItem item) => _items.Add(item);
        public string Name => "Composite Defense";
        public int Protection => _items.Sum(item => item.Protection);

        string IDefenseItem.Name { get => Name; set => throw new NotImplementedException(); }
    }
}
