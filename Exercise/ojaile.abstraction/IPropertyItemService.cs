using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ojaile.abstraction
{
    public interface IPropertyItemService
    {
        void SavePropertyItem(object value);
        void DeletePropertyItem();
        void UpdatePropertyItem(string name, object value);
        object GetPropertyItemByName(string name);
        object GetValue(string name, object defaultValue);
        object GetPropertyItemById(int Id);
        object GetPropertyItem();

    }
}
