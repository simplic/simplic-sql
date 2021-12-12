using System;
using System.Collections.Generic;

namespace Simplic.Sql
{
    public interface ISqlColumnService
    {
        /// <summary>
        /// Retrieves the columns from the database table and compares them with the model.
        /// Returns only the fields which are found in the model!
        /// </summary>
        /// <param name="documentColumns">Dictionary with different column names</param>
        /// <param name="tableName">Table to read the columns from</param>
        IDictionary<string, string> GetModelDBColumnNames(string tableName, Type modelType, IDictionary<string, string> differentColumnName);

        /// <summary>
        /// Retrieves the columns from the database table and compares them with the model.
        /// Returns only the fields which are found in the model!
        /// </summary>
        /// <param name="documentColumns">Dictionary with different column names</param>
        /// <param name="tableName">Table to read the columns from</param>
        IDictionary<string, string> GetModelDBColumnNames(string tableName, Type modelType, IDictionary<string, string> differentColumnName, string databaseName);

        /// <summary>
        /// Retrieves the columns from the database table.
        /// </summary>
        /// <param name="tableName">Table to read the columns from</param>
        /// <param name="databaseName">Database to read the information from</param>
        IDictionary<string, Type> GetColumns(string tableName, string databaseName);
    }
}
