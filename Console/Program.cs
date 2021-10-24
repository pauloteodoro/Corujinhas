using System;
using AppDomain;
using AppDomain.Entities;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {

            EmailSend email = new EmailSend();

            email.EnviarEmail("paulo.teodoro.dev@gmail.com", "teste");

        }
    }
}
