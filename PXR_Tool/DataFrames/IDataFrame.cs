using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StasaLibrary;

namespace PXR_Tool.DataFrames
{
    public interface IDataFrame
    {
        ParameterGroup paramGroup {get; set; }

        void PackValues(string[] values);
        string[] GetValues();
        void PopulateControl(ParameterGroup pg);
    }
}
