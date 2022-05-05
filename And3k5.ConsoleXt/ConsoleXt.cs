using System;
using System.Data;
using System.Linq;
using And3k5.ConsoleExtensions.Chaining;

namespace And3k5.ConsoleExtensions
{
    public static class ConsoleXt
    {
        public static ConsoleChainModelBase Queued() => new QueuedConsoleChainModel();

        public static ConsoleChainModelBase SetForegroundColor(ConsoleColor color) =>
            new ImmediateConsoleChainModel().SetForegroundColor(color);

        public static ConsoleChainModelBase Fg(ConsoleColor color) => new ImmediateConsoleChainModel().Fg(color);

        public static ConsoleChainModelBase SetBackgroundColor(ConsoleColor color) =>
            new ImmediateConsoleChainModel().SetBackgroundColor(color);

        public static ConsoleChainModelBase Bg(ConsoleColor color) => new ImmediateConsoleChainModel().Bg(color);

        public static ConsoleChainModelBase ResetColor() => new ImmediateConsoleChainModel().ResetColor();

        public static ConsoleChainModelBase SetTitle(string title) => new ImmediateConsoleChainModel().SetTitle(title);
        public static ConsoleChainModelBase Beep() => new ImmediateConsoleChainModel().Beep();

        public static ConsoleChainModelBase Beep(int frequency, int duration) =>
            new ImmediateConsoleChainModel().Beep(frequency, duration);

        public static ConsoleChainModelBase Clear() => new ImmediateConsoleChainModel().Clear();
        public static ConsoleChainModelBase WriteLine() => new ImmediateConsoleChainModel().WriteLine();
        public static ConsoleChainModelBase WriteLine(bool value) => new ImmediateConsoleChainModel().WriteLine(value);
        public static ConsoleChainModelBase WriteLine(char value) => new ImmediateConsoleChainModel().WriteLine(value);

        public static ConsoleChainModelBase WriteLine(char[] buffer) =>
            new ImmediateConsoleChainModel().WriteLine(buffer);

        public static ConsoleChainModelBase WriteLine(char[] buffer, int index, int count) =>
            new ImmediateConsoleChainModel().WriteLine(buffer, index, count);

        public static ConsoleChainModelBase WriteLine(decimal value) =>
            new ImmediateConsoleChainModel().WriteLine(value);

        public static ConsoleChainModelBase WriteLine(double value) =>
            new ImmediateConsoleChainModel().WriteLine(value);

        public static ConsoleChainModelBase WriteLine(float value) => new ImmediateConsoleChainModel().WriteLine(value);
        public static ConsoleChainModelBase WriteLine(int value) => new ImmediateConsoleChainModel().WriteLine(value);
        public static ConsoleChainModelBase WriteLine(uint value) => new ImmediateConsoleChainModel().WriteLine(value);
        public static ConsoleChainModelBase WriteLine(long value) => new ImmediateConsoleChainModel().WriteLine(value);
        public static ConsoleChainModelBase WriteLine(ulong value) => new ImmediateConsoleChainModel().WriteLine(value);

        public static ConsoleChainModelBase WriteLine(object value) =>
            new ImmediateConsoleChainModel().WriteLine(value);

        public static ConsoleChainModelBase WriteLine(string value) =>
            new ImmediateConsoleChainModel().WriteLine(value);

        public static ConsoleChainModelBase WriteLine(DataTable value) =>
            new ImmediateConsoleChainModel().WriteLine(value);

        public static ConsoleChainModelBase WriteLine(string format, object arg0) =>
            new ImmediateConsoleChainModel().WriteLine(format, arg0);

        public static ConsoleChainModelBase WriteLine(string format, object arg0, object arg1) =>
            new ImmediateConsoleChainModel().WriteLine(format, arg0, arg1);

        public static ConsoleChainModelBase WriteLine(string format, object arg0, object arg1, object arg2) =>
            new ImmediateConsoleChainModel().WriteLine(format, arg0, arg1, arg2);

        public static ConsoleChainModelBase WriteLine(string format, params object[] arg) =>
            new ImmediateConsoleChainModel().WriteLine(format, arg);

        public static ConsoleChainModelBase Write(string format, object arg0) =>
            new ImmediateConsoleChainModel().Write(format, arg0);

        public static ConsoleChainModelBase Write(string format, object arg0, object arg1) =>
            new ImmediateConsoleChainModel().Write(format, arg0, arg1);

        public static ConsoleChainModelBase Write(string format, object arg0, object arg1, object arg2) =>
            new ImmediateConsoleChainModel().Write(format, arg0, arg1, arg2);

        public static ConsoleChainModelBase Write(string format, params object[] arg) =>
            new ImmediateConsoleChainModel().Write(format, arg);

        public static ConsoleChainModelBase Write(bool value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(char value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(char[] buffer) => new ImmediateConsoleChainModel().Write(buffer);

        public static ConsoleChainModelBase Write(char[] buffer, int index, int count) =>
            new ImmediateConsoleChainModel().Write(buffer, index, count);

        public static ConsoleChainModelBase Write(double value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(decimal value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(float value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(int value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(uint value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(long value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(ulong value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(object value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(string value) => new ImmediateConsoleChainModel().Write(value);
        public static ConsoleChainModelBase Write(DataTable value) => new ImmediateConsoleChainModel().Write(value);

        public static ConsoleColor[] GetAllConsoleColors() =>
            Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();
    }
}