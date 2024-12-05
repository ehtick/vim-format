using System;
using System.Collections.Generic;
using System.Linq;
using Vim.BFast;

namespace Vim.Format
{
    public class EntityTable_v2
    {
        private readonly Dictionary<string, NamedBuffer<int>> _indexColumnMap = new Dictionary<string, NamedBuffer<int>>();
        private readonly Dictionary<string, NamedBuffer<int>> _stringColumnMap = new Dictionary<string, NamedBuffer<int>>();
        private readonly Dictionary<string, INamedBuffer> _dataColumnMap = new Dictionary<string, INamedBuffer>();
        private readonly string[] _stringBuffer;

        /// <summary>
        /// The entity table name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The buffers which compose the columns.
        /// </summary>
        public INamedBuffer[] Columns { get; }

        /// <summary>
        /// The number of rows in the entity table.
        /// </summary>
        public int RowCount { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public EntityTable_v2(
            SerializableEntityTable et,
            string[] stringBuffer)
        {
            Name = et.Name;
            Columns = et.ValidateColumnRowsAreAligned();
            RowCount = Columns.FirstOrDefault()?.NumElements() ?? 0;

            foreach (var column in et.IndexColumns)
                _indexColumnMap[column.Name] = column;

            foreach (var column in et.StringColumns)
                _stringColumnMap[column.Name] = column;

            foreach (var column in et.DataColumns)
                _dataColumnMap[column.Name] = column;

            _stringBuffer = stringBuffer;
        }

        private static T GetColumnOrDefault<T>(Dictionary<string, T> map, string key, T defaultValue = default)
            => map.TryGetValue(key, out var result) ? result : defaultValue;

        /// <summary>
        /// Returns the index column based on the given column name.
        /// </summary>
        public int[] GetIndexColumnValues(string columnName)
            => GetColumnOrDefault(_indexColumnMap, columnName)?.GetColumnValues<int>();

        /// <summary>
        /// Returns the string column based on the given column name.
        /// </summary>
        public string[] GetStringColumnValues(string columnName)
            => GetColumnOrDefault(_stringColumnMap, columnName)
                ?.GetColumnValues<int>()
                ?.Select(i => _stringBuffer[i])
                .ToArray();

        /// <summary>
        /// Returns the data column based on the given column name.
        /// </summary>
        public T[] GetDataColumnValues<T>(string columnName) where T : unmanaged
        {
            var type = typeof(T);

            if (!ColumnExtensions.DataColumnTypes.Contains(type))
                throw new Exception($"{nameof(GetDataColumnValues)} error - unsupported data column type {type}");

            var namedBuffer = GetColumnOrDefault(_dataColumnMap, columnName);
            if (namedBuffer == null)
                return null;

            if (type == typeof(short))
                return namedBuffer.GetColumnValues<int>().Select(i => (short)i).ToArray() as T[];

            if (type == typeof(bool))
                return namedBuffer.GetColumnValues<byte>().Select(b => b != 0).ToArray() as T[];

            return namedBuffer.GetColumnValues<T>();
        }
    }
}
