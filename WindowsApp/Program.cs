namespace WindowsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]//єтим атрибутом мі говорим как бі что мейн главная и управляет всем остальнім и никакие больше компоненті не будут перехватівать инициативу
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();//инициализаия самого приложения,єлементов управления окна 
            Application.Run(new Form1());//создание формі и запуск цикла обработки сообщения 
        }
    }
}