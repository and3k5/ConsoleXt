using System;
using System.Data;
using System.Linq;
using System.Text;

namespace And3k5.ConsoleExtensions.Chaining
{
    public abstract class ConsoleChainModelBase
    {
        public ConsoleChainModelBase Fg(ConsoleColor color) => SetForegroundColor(color);

        public ConsoleChainModelBase SetForegroundColor(ConsoleColor color) =>
            Append(() => Console.ForegroundColor = color);

        public ConsoleChainModelBase Bg(ConsoleColor color) => SetBackgroundColor(color);

        public ConsoleChainModelBase SetBackgroundColor(ConsoleColor color) =>
            Append(() => Console.BackgroundColor = color);

        public ConsoleChainModelBase ResetColor() => Append(Console.ResetColor);

        public ConsoleChainModelBase SetTitle(string title) => Append(() => Console.Title = title);
        public ConsoleChainModelBase Beep() => Append(Console.Beep);

        public ConsoleChainModelBase Beep(int frequency, int duration) =>
            Append(() => Console.Beep(frequency, duration));

        public ConsoleChainModelBase Clear() => Append(Console.Clear);
        public ConsoleChainModelBase WriteLine() => Append(Console.WriteLine);
        public ConsoleChainModelBase WriteLine(bool value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(char value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(char[] buffer) => Append(() => Console.WriteLine(buffer));

        public ConsoleChainModelBase WriteLine(char[] buffer, int index, int count) =>
            Append(() => Console.WriteLine(buffer, index, count));

        public ConsoleChainModelBase WriteLine(decimal value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(double value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(float value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(int value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(uint value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(long value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(ulong value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(object value) => Append(() => Console.WriteLine(value));
        public ConsoleChainModelBase WriteLine(string value) => Append(() => Console.WriteLine(value));

        public ConsoleChainModelBase WriteLine(DataTable value)
        {
            var formattedTable = FormatTable(value);
            return Append(() => Console.WriteLine(formattedTable));
        }

        public ConsoleChainModelBase WriteLine(string format, object arg0) =>
            Append(() => Console.WriteLine(format, arg0));

        public ConsoleChainModelBase WriteLine(string format, object arg0, object arg1) =>
            Append(() => Console.WriteLine(format, arg0, arg1));

        public ConsoleChainModelBase WriteLine(string format, object arg0, object arg1, object arg2) =>
            Append(() => Console.WriteLine(format, arg0, arg1, arg2));

        public ConsoleChainModelBase WriteLine(string format, params object[] arg) =>
            Append(() => Console.WriteLine(format, arg));

        public ConsoleChainModelBase Write(string format, object arg0) => Append(() => Console.Write(format, arg0));

        public ConsoleChainModelBase Write(string format, object arg0, object arg1) =>
            Append(() => Console.Write(format, arg0, arg1));

        public ConsoleChainModelBase Write(string format, object arg0, object arg1, object arg2) =>
            Append(() => Console.Write(format, arg0, arg1, arg2));

        public ConsoleChainModelBase Write(string format, params object[] arg) =>
            Append(() => Console.Write(format, arg));

        public ConsoleChainModelBase Write(bool value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(char value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(char[] buffer) => Append(() => Console.Write(buffer));

        public ConsoleChainModelBase Write(char[] buffer, int index, int count) =>
            Append(() => Console.Write(buffer, index, count));

        public ConsoleChainModelBase Write(double value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(decimal value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(float value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(int value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(uint value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(long value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(ulong value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(object value) => Append(() => Console.Write(value));
        public ConsoleChainModelBase Write(string value) => Append(() => Console.Write(value));

        public ConsoleChainModelBase Write(DataTable value)
        {
            var formattedTable = FormatTable(value);
            return Append(() => Console.Write(formattedTable));
        }

        private string FormatTable(DataTable value)
        {
            var stringBuilder = new StringBuilder();

            var columnsAndMaxLength = value.Columns.Cast<DataColumn>().Select(x => new
            {
                column = x,
                maxLength = value.Rows.Cast<DataRow>().Select(y => y[x]?.ToString()).Concat(new[] { x.ColumnName })
                    .Max(y => y?.Length ?? 0)
            }).ToArray();

            var passedFirstColumn = false;

            foreach (var column in columnsAndMaxLength)
            {
                if (passedFirstColumn)
                    stringBuilder.Append(" ");
                var columnName = column.column.ColumnName ?? "";
                stringBuilder.Append(columnName);
                var whitespaces = (column.maxLength - columnName.Length);
                if (whitespaces > 0)
                    stringBuilder.Append(new string(' ', whitespaces));
                passedFirstColumn = true;
            }

            if (value.Rows.Count > 0)
            {
                foreach (DataRow row in value.Rows)
                {
                    stringBuilder.AppendLine();

                    passedFirstColumn = false;

                    foreach (var column in columnsAndMaxLength)
                    {
                        if (passedFirstColumn)
                            stringBuilder.Append(" ");
                        var columnValue = row[column.column]?.ToString() ?? "";
                        stringBuilder.Append(columnValue);
                        var whitespaces = (column.maxLength - columnValue.Length);
                        if (whitespaces > 0)
                            stringBuilder.Append(new string(' ', whitespaces));
                        passedFirstColumn = true;
                    }
                }
            }

            return stringBuilder.ToString();
        }


        private ConsoleChainModelBase Append(Action action)
        {
            AppendAction(action);
            return this;
        }

        public abstract void AppendAction(Action action);

        public virtual void Apply()
        {
        }
    }
}