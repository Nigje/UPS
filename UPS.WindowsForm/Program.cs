using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPS.WindowsForm.Forms;
using UPS.WindowsForm.Models;
using UPS.WindowsForm.Models.Enums;

namespace UPS.WindowsForm
{
    static class Program
    {
        //************************************************************************************************************************************
        //Variables:
        internal static MainForm MainForm;
        internal static LoadForm LoadForm;


        //************************************************************************************************************************************
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(MyCommonExceptionHandlingMethod);
            LoadForm = new LoadForm();
            Application.Run(LoadForm);
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Handle exceptions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="threadExceptionEventArgs"></param>
        private static void MyCommonExceptionHandlingMethod(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
            Exception exception = threadExceptionEventArgs.Exception;
            MessageForm messageForm;
            if (exception is BusinessException)
            {
                string message = exception.Message;

                var upsException = default(UPSExceptionModel);
                bool isValidObject = exception.Message.TryParseJson<UPSExceptionModel>(out upsException);

                //The exception has been thrown from the server-side. 
                if (isValidObject)
                {
                    message = upsException.Error.Message;
                }
                messageForm = new MessageForm(MessageTypeEnum.Error, message);
            }
            else if (exception is System.Net.Sockets.SocketException)
            {
                messageForm = new MessageForm(MessageTypeEnum.Error, "Api is not available.");
            }
            else
                messageForm = new MessageForm(MessageTypeEnum.Error, "An exception has occurred, please contact support.");
            messageForm.Show();
        }
        //************************************************************************************************************************************
    }
}
