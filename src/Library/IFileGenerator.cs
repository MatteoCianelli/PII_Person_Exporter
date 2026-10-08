//------------------------------------------------------------------------------
// <copyright file="IFileGenerator.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Ucu.Poo.PersonExporter
{
    public interface IFileGenerator
    {
        void GenerateFile(IList<Person> people, string outputPath);
    }
}