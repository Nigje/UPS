using System;
using UPS.Framework.Exceptions;

namespace UPS.Framework.Tools
{
    public static class StringExtentions
    {
        public static T ToEnum<T>(this string value)
        {
            try
            {
                return (T)Enum.Parse(typeof(T), value,true);
            }
            catch (Exception ex)
            {
                throw new UPSExceptionInvalidParameter();
            }
        }
        //************************************************************************************************************************************
        /// <summary>
        /// Validate email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(this string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //************************************************************************************************************************************
    }
}
