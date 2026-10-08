//------------------------------------------------------------------------------
// <copyright file="CsvGenerator.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace Ucu.Poo.PersonExporter
{
    public class CsvGenerator : IFileGenerator
    {
        public void GenerateFile(IList<Person> people, string outputPath)
        {

            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

            using (StreamWriter writer = new StreamWriter(outputPath, false, Encoding.UTF8))
            {
                using (CsvWriter csv = new CsvWriter(writer, config))
                {
                    csv.WriteHeader<Person>();
                    csv.NextRecord();
                    csv.WriteRecords(people);
                }
            }
        }
    }
}