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

        int Count { get; }

        void UpdateValues(string[] values);
        string[] GetValues();
        System.Drawing.Size PopulateControl(ParameterGroup pg);
    }
}
